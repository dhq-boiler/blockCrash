using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFBlockCrash
{
	class Control : IInputable
	{
		private const int MAX_SBALLCOUNT = 20;
		private const int MAX_BLOCKCOUNT = 100;

		private Bar bar;
		private Ball ball;
		private LinkedList<Ball> SmallBalls;
		private List<Ball> willBeAddedSmallBalls;
		private Block[] block;
		
		private int bdwidth, bdheight, blwidth, blheight, bkwidth, bkheight;

		private int exwidth;
		private bool boundFlag;
		private bool demolishFlag;

		private SoundPlayer playerBH;
		private SoundPlayer playerDH;
		
		private System.Drawing.Image gh;

		private int sumblock;
		private int accel;
		private int ballspup;
		private int vspeed;
		private DisplayInfo dInfo;
		private IOperator Operator;

		private readonly Font font = new Font("Consolas", 16);

		public EBarType Bar { get; set; }
		public EStageType Stage { get; set; }
		public int Score { get; set; }
		public int Stock { get; set; }
		public int sballcount { get; set; }
		public bool ballcatch { get; set; }
		public bool clear;
		private int alphacombo { get; set; }
		private int combocount { get; set; }
		private bool comboon { get; set; }
		private int combooncount { get; set; }

		public bool IsDead { get; set; }
		public bool IsPlaying { get; set; }

		private IInputable message { get; set; }

		public Control(UserChoice userChoice, TakeOver takeOver, DisplayInfo dInfo, Input input, IOperator Operator)
		{
			this.dInfo = dInfo;
			this.Operator = Operator;

			Bar = userChoice.BarType;

			bool extendon = true;
			if (Bar == EBarType.SHORT)
				extendon = false;
	
			//バーとボールのインスタンスを生成
			bar = new Bar(Bar, dInfo, Operator);
			ball = new Ball(dInfo);
			ballspup = 0;

			SmallBalls = new LinkedList<Ball>();
			willBeAddedSmallBalls = new List<Ball>();

			boundFlag=false;
			demolishFlag=false;
			clear = false;
			Score = takeOver.Score;
			Stock = takeOver.Stock;
			Stage = userChoice.StageType;
			vspeed = 0;
			ballcatch = false;
			combocount = 0;
			comboon = false;
			combooncount = 0;
			alphacombo = 0;

			//バーの幅と高さ
			bdwidth = bar.Width;
			bdheight = bar.Height;

			// バーが拡大する長さ
			exwidth = (int)bdwidth/2;

			//ボールの幅と高さ
			blwidth = ball.Width;
			blheight = ball.Height;

			//音声ファイル読み込み。
			playerBH = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
			playerDH = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");

			// 残機表示の読み込み
			gh = new Bitmap(Main.ResourceDirectory + "ball_b.png");

			StageBuilder builder = StageBuilder.CreateStageBuilder(Stage);

			builder.CreateStage(out block, ref sumblock, extendon);

			bkwidth = block[0].Width;
			bkheight = block[0].Height;
		}

		public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
		{
			if (CalculateAndDraw(input, g, uc, takeOver))
			{
				if (Stock > 1)
				{
					if (IsPlaying)
					{
						message = new Message(EMessageType.FAILED, 50, dInfo);
						IsPlaying = false;
					}

					if (message.Process(input, g, uc, takeOver).IsDead)
					{
						Reset();
						--Stock;
						IsPlaying = true;
						message = null;
					}
				}
				else // Stock == 0
				{
					if (IsPlaying)
					{
						message = new Message(EMessageType.GAMEOVER, 120, dInfo);
						IsPlaying = false;
					}

					if (message.Process(input, g, uc, takeOver).IsDead)
					{
						return new ProcessResult()
						{
							IsDead = true,
							NextState = new Ranking(Score, Bar, dInfo, Operator),
							TakeOver = takeOver
						};
					}
				}
			}
			else if (clear)
			{
				if (IsPlaying)
				{
					message = new Message(EMessageType.CLEAR, 200, dInfo);
					IsPlaying = false;
				}

				if (message.Process(input, g, uc, takeOver).IsDead)
				{
					if (input.AT)
						return new ProcessResult()
						{
							IsDead = true,
							NextState = new Title(Main.MainInstance, dInfo, Operator),
							TakeOver = takeOver
						};
					else
						return new ProcessResult()
						{
							IsDead = true,
							NextState = new Ranking(Score, Bar, dInfo, Operator),
							TakeOver = takeOver
						};
				}
			}

			return new ProcessResult()
			{
				IsDead = false,
				NextState = this,
				TakeOver = takeOver,
				UserChoice = uc
			};
		}

		private bool CalculateAndDraw(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
		{
			bool BallIsDead;
			int count = 0;

			for (int i = 0; i < sumblock; ++i)
			{
				if (block[i].IsDead)
					++count;

				switch (Stage)
				{
					case EStageType.ONAJIMISAN:
						if (i < 7)
							block[i].Process(input, g, uc, takeOver);
						else if (i > 6 && i < 14)
							block[i].Process(input, g, uc, takeOver);
						else if (i > 13 && i < 21)
							block[i].Process(input, g, uc, takeOver);
						else
							block[i].Process(input, g, uc, takeOver);
						break;
					default:
						if (i % 4 == 0)
							block[i].Process(input, g, uc, takeOver);
						else if (i % 4 == 1)
							block[i].Process(input, g, uc, takeOver);
						else if (i % 4 == 2)
							block[i].Process(input, g, uc, takeOver);
						else
							block[i].Process(input, g, uc, takeOver);
						break;
				}
			}

			if (count == sumblock)
				clear = true;

			if (input.AT)
			{
				//ボールの座標取得
				bar.X = ball.X;
			}

			//バーの処理
			bar.Process(input, g, uc, takeOver);

			if (ball.ActCount == 0)
			{
				ball.X = bar.MX;
			}

			if (ball.ballstop)
			{
				ball.X = bar.MX + ball.xoffset;
			}

			foreach (Ball smallBall in SmallBalls)
			{
				if (smallBall.ballstop)// ボールが止まっていれば
				{ 
					smallBall.X = bar.MX + smallBall.xoffset;
					smallBall.Y = 527;
				}
			}

			// ボールの動き
			if (!ball.ballstop)
			{
				++ballspup; // 速度上昇カウント

				switch (Bar) // バーによりの速度上昇の早さが違う
				{ 

					case EBarType.LONG:
						if (ballspup % 1500 == 0)// やさしい
						{ 
							ball.LvUp(1);
						}
						break;
					case EBarType.MEDIUM:
						if (ballspup % 1000 == 0)// ふつう
						{ 
							ball.LvUp(1);
						}
						break;
					case EBarType.SHORT:
						if (ballspup % 800 == 0)// 難しい
						{ 
							ball.LvUp(1);
						}
						break;
				}
			}

			++vspeed; // 進まなくなったとき用カウントの増加

			if (vspeed == 1000)
			{
				vspeed = 0;
				ball.spchange();
			}

			BallIsDead = UpdateBall(input, g);

			// 小玉があれば表示
			UpdateSmallBalls(input, g, uc, takeOver);

			accel = bar.Accel; 
			
			// 得点、レベル、残機枠の表示
			g.DrawRectangle(new System.Drawing.Pen(DrawUtil.BrushRGB(230, 230, 230), 3), 0, 0, 800, 30);
			g.DrawString(string.Format("SCORE: {0}", Score), font, DrawUtil.BrushRGB(255, 120, 0), 20, 5);
			g.DrawString(string.Format("LEVEL: {0}", ball.Level), font, DrawUtil.BrushRGB(255, 120, 0), 220, 5);

			//デバック用

			// コンボ表示　邪魔にならないよう透明化処理する  
			if (combocount > 1)
			{
				g.DrawString(string.Format("{0} COMBO!", combocount), font, DrawUtil.BrushRGB(255, 120, 0), 20, 400);
				combooncount = 0;
				comboon = true;
				alphacombo = combocount;
			}

			if(combocount == 0 && comboon)
			{
				if (combooncount < 20)
				{
					g.DrawString(string.Format("{0} COMBO!", alphacombo), font, DrawUtil.BrushRGB((int)((255f / 40) * (20 - combooncount)), 255, 120, 0), 20, 400);
					++combooncount;
				}
				else
				{
					comboon = false;
					alphacombo = 0;
				}
			}

			//ストック数の表示
			for (int i = 0; i < (BallIsDead ? Stock - 2 : Stock - 1); ++i)
			{
				g.DrawImage(gh, 540 + 18 * i, 7, (float)gh.Width, (float)gh.Height);
			}

			ball.BarAccel(accel);

			// 小玉があれば表示
			foreach (Ball smallBall in SmallBalls)
			{
				smallBall.BarAccel(accel);
			}

			///音再生
			SoundPlay();

			if (BallIsDead)
			{
				for(int i = 0; i < sumblock; ++i)
					block[i].scrollStop = true;
				bar.IsDead = true;
				ball.DX = 0;
			}

			if (clear)
			{
				ball.DX = 0;
				ball.DY = 0;

				for (int i = 0; i < sumblock; ++i)
					block[i].scrollStop = true;

				// 小玉があれば表示
				foreach (Ball smallBall in SmallBalls)
				{
					smallBall.DX = 0;
					smallBall.DY = 0;
				}

				vspeed = 0;
				Score += ball.Level * Stock; 
				bar.IsDead = true;
			}

			return BallIsDead;
		}

		private bool UpdateBall(Input input, Graphics g)
		{
			bool BallIsDead = ball.Process(input, g, null, null).IsDead;

			// ボールとバーの当たり判定
			HitCheckBallAndBar(ball);

			// ボールとブロックの当たり判定
			HitCheckBallAndBlock(ball);

			// ボールとボールの衝突判定
			HitCheckBallAndBall(ball);

			return BallIsDead;
		}

		private void UpdateSmallBalls(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
		{
			List<Ball> willBeRemovedSmallBalls = new List<Ball>();

			foreach (Ball smallBall in SmallBalls)
			{
				bool SmallBallDroped = smallBall.Process(input, g, uc, takeOver).IsDead;

				HitCheckBallAndBar(smallBall);

				HitCheckBallAndBlock(smallBall);

				// ボールとボールの衝突判定
				HitCheckBallAndBall(smallBall);

				if (SmallBallDroped)
				{
					willBeRemovedSmallBalls.Add(smallBall);
					--sballcount;
				}
			}

			foreach (Ball Adding in willBeAddedSmallBalls)
			{
				SmallBalls.AddLast(Adding);
			}

			foreach (Ball removing in willBeRemovedSmallBalls)
			{
				SmallBalls.Remove(removing);
			}

			willBeAddedSmallBalls.Clear();
			willBeRemovedSmallBalls.Clear();
		}

		private void SoundPlay()
		{
			if (boundFlag)
				playerBH.Play(); //非同期

			if (demolishFlag)
				playerDH.Play(); //非同期
		}


		private void HitCheckBallAndBlock(Ball ball)
		{
			demolishFlag = false;

			int ballX = ball.X;
			int ballY = ball.Y;

			for (int i = 0; i < sumblock; ++i)
			{
				if (!block[i].IsDead)
				{
					int blockendX = 0;
					int blockX = block[i].X;
					int blockY = block[i].Y;

					if (blockX - bkwidth / 2 < 0)
						blockendX = blockX - bkwidth / 2 + 800;
					if (blockX + bkwidth / 2 >= 800)
						blockendX = blockX + bkwidth / 2 - 800;

					for (int j = 0; j < 2; ++j)
					{
						if (ballX < blockX + bkwidth / 2
							&& ballX > blockX - bkwidth / 2
							&& ballY + blheight / 2 > blockY - bkheight / 2
							&& ballY + blheight / 2 < blockY + bkheight / 2)
						{
							vspeed = 0;

							block[i].IsDead = true;
							demolishFlag = true;

							if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
								ball.DY = -ball.DY;
						}
						else if (ballX < blockX + bkwidth / 2
							&& ballX > blockX - bkwidth / 2
							&& ballY - blheight / 2 > blockY - bkheight / 2
							&& ballY - blheight / 2 < blockY + bkheight / 2)
						{
							vspeed = 0;

							block[i].IsDead = true;
							demolishFlag = true;
							if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
								ball.DY = -ball.DY;
						}
						else if (ballX + blwidth / 2 < blockX - bkwidth / 2 + blwidth
							&& ballX + blwidth / 2 > blockX - bkwidth / 2
							&& ballY > blockY - bkheight / 2
							&& ballY < blockY + bkheight / 2)
						{
							vspeed = 0;

							block[i].IsDead = true;
							demolishFlag = true;
							if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
								ball.DX = -ball.DX;
						}
						else if (ballX - blwidth / 2 < blockX + bkwidth / 2
							&& ballX - blwidth / 2 > blockX + bkwidth / 2 - blwidth
							&& ballY > blockY - bkheight / 2
							&& ballY < blockY + bkheight / 2)
						{
							vspeed = 0;

							block[i].IsDead = true;
							demolishFlag = true;
							if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
								ball.DX = -ball.DX;
						}
						if (blockendX != 0)
							blockX = blockendX;
						else
							break;
					}

					if (block[i].IsDead)
					{
						int nonmovebonus = 0;
						if (!bar.IsMove)
							nonmovebonus = 500;
						++combocount; 
						Score += 100 + 50 * ball.Level + combocount * 100 + nonmovebonus;
						ball.Radius = 0;
					}
				}
				else if (block[i].ItemFlag)
				{
					if (block[i].matchlesscount > 0 && ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
						continue;
					int blockendX = 0;
					int blockX = block[i].X;
					int blockY = block[i].Y;

					if (blockX - bkwidth / 2 < 0)
						blockendX = blockX - bkwidth / 2 + 800;
					if (blockX + bkwidth / 2 >= 800)
						blockendX = blockX + bkwidth / 2 - 800;

					for (int j = 0; j < 2; ++j)
					{
						if (ballX < blockX + bkwidth / 2
							&& ballX > blockX - bkwidth / 2
							&& ballY + blheight / 2 > blockY - bkheight / 2
							&& ballY + blheight / 2 < blockY + bkheight / 2)
						{
							vspeed = 0;

							block[i].ItemFlag = false;

							ItemEffect(block[i].ItemType, ballX, ballY);

							demolishFlag = true;
						}
						else if (ballX < blockX + bkwidth / 2
							&& ballX > blockX - bkwidth / 2
							&& ballY - blheight / 2 > blockY - bkheight / 2
							&& ballY - blheight / 2 < blockY + bkheight / 2)
						{
							vspeed = 0;

							block[i].ItemFlag = false;

							ItemEffect(block[i].ItemType, ballX, ballY);

							demolishFlag = true;
						}
						else if (ballX + blwidth / 2 < blockX - bkwidth / 2 + blwidth
							&& ballX + blwidth / 2 > blockX - bkwidth / 2
							&& ballY > blockY - bkheight / 2
							&& ballY < blockY + bkheight / 2)
						{
							vspeed = 0;

							block[i].ItemFlag = false;

							ItemEffect(block[i].ItemType, ballX, ballY);

							demolishFlag = true;
						}
						else if (ballX - blwidth / 2 < blockX + bkwidth / 2
							&& ballX - blwidth / 2 > blockX + bkwidth / 2 - blwidth
							&& ballY > blockY - bkheight / 2
							&& ballY < blockY + bkheight / 2)
						{
							vspeed = 0;

							block[i].ItemFlag = false;

							ItemEffect(block[i].ItemType, ballX, ballY);

							demolishFlag = true;
						}
						if (blockendX != 0)
							blockX = blockendX;
						else
							break;
					}

					if (!block[i].ItemFlag)
						Score += 300;
				}
			}
		}

		private void ItemEffect(EItemType eItemType, int ballX, int ballY)
		{
			int ct = 0;
			switch (eItemType)
			{
				case EItemType.ITEMTYPE_LONG:
					if (Bar != EBarType.SHORT)
					{
						bar.ExtendWidth();
						bdwidth += exwidth;
					}
					break;
				case EItemType.ITEMTYPE_POWERUP:
					ball.PowerUp();
					break;
				case EItemType.ITEMTYPE_INCRESE:
					while (true)
					{
						if (sballcount >= MAX_SBALLCOUNT)
							break;

						Ball newSmallBall = new Ball(dInfo);
						newSmallBall.ballstop = false;
						newSmallBall.Increse(ballX, ballY);
						willBeAddedSmallBalls.Add(newSmallBall);
						++sballcount;
						++ct;
						if (ct == 3) break;
					}
					break;
				case EItemType.ITEMTYPE_1UP:
					++Stock;
					break;
				case EItemType.ITEMTYPE_SCOREUP:
					Score += 5000;
					break;
				case EItemType.ITEMTYPE_BALLCATCHER:
					bar.BallCatch( true );
					ballcatch = true;
					break;
			}
		}

		private void HitCheckBallAndBar(Ball ball)
		{
			boundFlag = false;

			boundFlag = ball.PlaySound;

			int barX = bar.X;
			int barY = bar.Y;
			int ballX = ball.X;
			int ballY = ball.Y;


			if (Math.Abs(barY - ballY) < blheight / 2 + bdheight / 2)
			{
				if (barX + bdwidth / 2 > ballX
					&& barX - bdwidth / 2 < ballX)
				{
					ball.Radius = 20;

					if (ballcatch)// ボールがバーにくっつく状態
					{ 
						ball.DX = ball.DY = 0;
						ball.ballstop = true;
						if (ball.ballstop) // ＋なら右に，ーなら左にずれてる
							ball.xoffset = ball.X - bar.MX;
						combocount = 0;
						bar.IsMove = false;
					}
					else if (ballX < barX - bdwidth / 2 * 2 / 3)
					{
						combocount = 0;
						bar.IsMove = false;
						if (Bar == EBarType.SHORT)
							ball.LvUp(1);

						ball.DX = -ball.DX;
						ball.DY = -ball.DY;
						ball.Y = ball.Y - 5;

						boundFlag = true;
					}
					else if (ballX > barX + bdwidth / 2 * 2 / 3)
					{
						combocount = 0;
						bar.IsMove = false;
						if (Bar == EBarType.SHORT)
							ball.LvUp(1);
						ball.DX = -ball.DX;
						ball.DY = -ball.DY;
						ball.Y = ball.Y - 5;

						boundFlag = true;
					}
					else
					{
						if (ballX < barX + 10 && ballX > barX - 10)
						{
							ball.Penetration();
							ball.LvUp(1); // 速度が上がって短時間貫通化
						}

						combocount = 0;
						bar.IsMove = false;
						if (Bar == EBarType.SHORT)
							ball.LvUp(1);
						ball.DY = -ball.DY;
						ball.Y = ball.Y - 5;
						boundFlag = true;
					}
				}
			}
		}

		/// <summary>
		/// ボールとボールの衝突判定
		/// </summary>
		/// <param name="ball"></param>
		private void HitCheckBallAndBall(Ball ball)
		{
			boundFlag = false;

			boundFlag = ball.PlaySound;

			int ballX = ball.X;
			int ballY = ball.Y;

			foreach (Ball smallBall in SmallBalls)
			{
				if (smallBall == ball) // 捜査対象が同じならコンティニュー
					continue;
				if (smallBall.IsNewCount > 0) // 増えたばかりならコンティニュー
					continue;

				if ((ballX - smallBall.X) * (ballX - smallBall.X) + (ballY - smallBall.Y) * (ballY - smallBall.Y) <= 20 * 20)
				{// 衝突判定

					ball.DX = -ball.DX;
					ball.DY = ball.DY;
					smallBall.DX = -smallBall.DX;
					smallBall.DY = smallBall.DY;

					boundFlag = true;
				}
			}
		}
		

		internal void Reset()
		{

			SmallBalls = new LinkedList<Ball>();
			ballcatch = false;
			bar.BallCatch(false);
			sballcount = 0;
			--Stock;
			vspeed = 0;
			bdwidth = bar.Width;
			combocount = 0;
			bar.Reset();
			ball.Reset();
			for (int i = 0; i < sumblock; ++i)
				block[i].scrollStop = false;
			bar.IsDead = false;
		}
	}
}
