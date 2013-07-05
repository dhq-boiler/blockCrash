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
		
		private int barWidth, barHeight, ballWidth, ballHeight, blockWidth, blockHeight;

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
		private StageBuilder builder;

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
		private bool ReflectVEnable;
		private bool ReflectHEnable;
        private bool ReflectEnable;
        private bool ReflectEnableByBar;

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
			barWidth = bar.Width;
			barHeight = bar.Height;

			// バーが拡大する長さ
			exwidth = (int)barWidth/2;

			//ボールの幅と高さ
			ballWidth = ball.Width;
			ballHeight = ball.Height;

			//音声ファイル読み込み。
			playerBH = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
			playerDH = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");

			// 残機表示の読み込み
			gh = new Bitmap(Main.ResourceDirectory + "ball_b.png");

			builder = StageBuilder.CreateStageBuilder(Stage);

			builder.CreateStage(out block, ref sumblock, extendon);

			blockWidth = block[0].Width;
			blockHeight = block[0].Height;
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

			//ブロックの描画処理
			builder.BlockProcess(input, g, uc, takeOver, block, ref count, sumblock);

			if (count == sumblock)
				clear = true;

			if (input.AT)
			{
				//ボールの座標取得
				bar.CenterX = ball.CenterX;
			}

			//バーの処理
			bar.Process(input, g, uc, takeOver);

			//発射前のメインボールのX座標
			if (ball.ActCount == 0)
			{
				ball.CenterX = bar.MX;
			}

			//吸着時のメインボールのX座標
			if (ball.ballstop)
			{
				ball.CenterX = bar.MX + ball.xoffset;
			}

			//吸着時のスモールボールのX座標
			foreach (Ball smallBall in SmallBalls)
			{
				if (smallBall.ballstop)// ボールが止まっていれば
				{ 
					smallBall.CenterX = bar.MX + smallBall.xoffset;
					smallBall.CenterY = 527;
				}
			}

			// ボールの動き
			if (!ball.ballstop)
			{
				++ballspup; // 速度上昇カウント

				switch (Bar) // バーによりの速度上昇の早さが違う
				{

					case EBarType.LONG:
						g.DrawString(string.Format("{0} ballspup", ballspup % 1500), font, DrawUtil.BrushRGB(255, 120, 0), 20, 440);
						if (ballspup % 1500 == 0)// やさしい
						{ 
							ball.LvUp(1);
						}
						break;
					case EBarType.MEDIUM:
						g.DrawString(string.Format("{0} ballspup", ballspup % 1000), font, DrawUtil.BrushRGB(255, 120, 0), 20, 440);
						if (ballspup % 1000 == 0)// ふつう
						{ 
							ball.LvUp(1);
						}
						break;
					case EBarType.SHORT:
						g.DrawString(string.Format("{0} ballspup", ballspup % 800), font, DrawUtil.BrushRGB(255, 120, 0), 20, 440);
						if (ballspup % 800 == 0)// 難しい
						{ 
							ball.LvUp(1);
						}
						break;
				}
			}

			//++vspeed; // 進まなくなったとき用カウントの増加

			if (++vspeed == 1000)
			{
				vspeed = 0;
				ball.spchange();
			}

			accel = bar.Accel; 

			BallIsDead = UpdateBall(input, accel, g);

			// 小玉があれば表示
			UpdateSmallBalls(input, accel, g, uc, takeOver);
			
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

		private bool UpdateBall(Input input, int barAccel, Graphics g)
		{
			bool BallIsDead = ball.Process(input, g, null, null).IsDead;

			// ボールとバーの当たり判定
			HitCheckBallAndBar(ball, barAccel, g);

			// ボールとブロックの当たり判定
			HitCheckBallAndBlock(ball);

			// ボールとボールの衝突判定
			HitCheckBallAndBall(ball);

			return BallIsDead;
		}

		private void UpdateSmallBalls(Input input, int barAccel, Graphics g, UserChoice uc, TakeOver takeOver)
		{
			List<Ball> willBeRemovedSmallBalls = new List<Ball>();

			foreach (Ball smallBall in SmallBalls)
			{
				bool SmallBallDroped = smallBall.Process(input, g, uc, takeOver).IsDead;

				HitCheckBallAndBar(smallBall, barAccel, g);

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

			int ballX = ball.CenterX;
			int ballY = ball.CenterY;

			for (int i = 0; i < sumblock; ++i)
			{
                if (!block[i].IsDead)
                {
                    if (CheckCrashingBlock(ball, block[i]))
                        break;
                }
                else if (block[i].ItemFlag)
                {
                    if (block[i].matchlesscount > 0 && ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        continue;
                    CheckGettingItem(ballX, ballY, i);
                }
			}
		}

		private void CheckGettingItem(int ballX, int ballY, int i)
		{
			int blockendX = 0;
			int blockX = block[i].CenterX;
			int blockY = block[i].CenterY;

			if (blockX - blockWidth / 2 < 0)
				blockendX = blockX - blockWidth / 2 + 800;
			if (blockX + blockWidth / 2 >= 800)
				blockendX = blockX + blockWidth / 2 - 800;

			for (int j = 0; j < 1; ++j)
			{
				if (ballX < blockX + blockWidth / 2
					&& ballX > blockX - blockWidth / 2
					&& ballY + ballHeight / 2 > blockY - blockHeight / 2
					&& ballY + ballHeight / 2 < blockY + blockHeight / 2)
				{
					vspeed = 0;

					block[i].ItemFlag = false;

					ItemEffect(block[i].ItemType, ballX, ballY);

					demolishFlag = true;
				}
				else if (ballX < blockX + blockWidth / 2
					&& ballX > blockX - blockWidth / 2
					&& ballY - ballHeight / 2 > blockY - blockHeight / 2
					&& ballY - ballHeight / 2 < blockY + blockHeight / 2)
				{
					vspeed = 0;

					block[i].ItemFlag = false;

					ItemEffect(block[i].ItemType, ballX, ballY);

					demolishFlag = true;
				}
				else if (ballX + ballWidth / 2 < blockX - blockWidth / 2 + ballWidth
					&& ballX + ballWidth / 2 > blockX - blockWidth / 2
					&& ballY > blockY - blockHeight / 2
					&& ballY < blockY + blockHeight / 2)
				{
					vspeed = 0;

					block[i].ItemFlag = false;

					ItemEffect(block[i].ItemType, ballX, ballY);

					demolishFlag = true;
				}
				else if (ballX - ballWidth / 2 < blockX + blockWidth / 2
					&& ballX - ballWidth / 2 > blockX + blockWidth / 2 - ballWidth
					&& ballY > blockY - blockHeight / 2
					&& ballY < blockY + blockHeight / 2)
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

		private bool CheckCrashingBlock(Ball ball, Block block)
		{
			int blockendX = 0;
			int ballCX = ball.CenterX;
			int ballCY = ball.CenterY;
			int blockCX = block.CenterX;
			int blockCY = block.CenterY;

			if (blockCX - blockWidth / 2 < 0)
				blockendX = blockCX - blockWidth / 2 + 800;
			if (blockCX + blockWidth / 2 >= 800)
				blockendX = blockCX + blockWidth / 2 - 800;

			bool IsOverlappedVertical = Math.Abs(blockCY - ballCY) < ballHeight / 2 + blockHeight / 2;
			bool IsOverlappedHorizontal = Math.Abs(blockCX - ballCX) < ballWidth / 2 + blockWidth / 2;

			if (IsOverlappedHorizontal && IsOverlappedVertical)
			{
				double OverlapDistanceX = double.MaxValue;
				double OverlapDistanceY = double.MaxValue;

				if (blockCY < ballCY)
					OverlapDistanceY = (ball.Top - block.Bottom) / (double)block.Height;
				else if (blockCY > ballCY)
                    OverlapDistanceY = (block.Top - ball.Bottom) / (double)block.Height;

				if (blockCX < ballCX)
                    OverlapDistanceX = (ball.Left - block.Right) / (double)block.Width;
				else
                    OverlapDistanceX = (block.Left - ball.Right) / (double)block.Width;
                    
                if (ReflectEnable && OverlapDistanceX < 0d && OverlapDistanceY < 0d && OverlapDistanceY < OverlapDistanceX)
				{
                    ReflectHorizontal(ball);
                    ReflectEnable = false;
				}
                else if (ReflectEnable && OverlapDistanceX < 0d && OverlapDistanceY < 0d && OverlapDistanceY >= OverlapDistanceX)
				{
                    ReflectVertical(ball);
                    ReflectEnable = false;
				}

                block.IsDead = true;
			}
            else
            {
                ReflectEnable = true;
            }

			if (block.IsDead)
			{
				int NonMoveBonus = 0;
				if (!bar.IsMove)
					NonMoveBonus = 500;
				++combocount;
				Score += 100 + 50 * ball.Level + combocount * 100 + NonMoveBonus;
				ball.Radius = 0;
			}

            return block.IsDead;
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
						barWidth += exwidth;
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

		private void HitCheckBallAndBar(Ball ball, int barAccel, Graphics g)
		{
			boundFlag = false;

			boundFlag = ball.PlaySound;

			int barCX = bar.CenterX;
			int barCY = bar.CenterY;
			int ballCX = ball.CenterX;
			int ballCY = ball.CenterY;

			bool IsOverlappedVertical = Math.Abs(barCY - ballCY) < ballHeight / 2 + barHeight / 2;
			bool IsOverlappedHorizontal = Math.Abs(barCX - ballCX) < ballWidth / 2 + barWidth / 2;

			if (IsOverlappedVertical && IsOverlappedHorizontal)
			{
				double OverlapDistanceX = double.MaxValue;
				double OverlapDistanceY = double.MaxValue;

				if (barCY < ballCY) //下辺反射
					OverlapDistanceY = (ball.Top - bar.Bottom) / (double)bar.Height;
                else  //上辺反射
					OverlapDistanceY = (bar.Top - ball.Bottom) / (double)bar.Height;

                if (barCX < ballCX) //右辺反射
					OverlapDistanceX = (ball.Left - bar.Right) / (double)bar.Width;
                else //左辺反射
					OverlapDistanceX = (bar.Left - ball.Right) / (double)bar.Width;

				g.DrawString(string.Format("ODX:{0}", OverlapDistanceX), font, DrawUtil.BrushRGB(255, 120, 0), 20, 480);
				g.DrawString(string.Format("ODY:{0}", OverlapDistanceY), font, DrawUtil.BrushRGB(255, 120, 0), 20, 520);

				if (ReflectEnableByBar && OverlapDistanceX < 0d && OverlapDistanceY < 0d && Math.Abs(OverlapDistanceX - OverlapDistanceY) < 0.1)
				{
					ReflectVerticalIfOverlapped(ball, bar);
					ReflectHorizontalIfOverlapped(ball, bar, barAccel);
				}
                else if (ReflectEnableByBar && OverlapDistanceY < 0d && OverlapDistanceX < 0d && OverlapDistanceY < OverlapDistanceX)
				{
					ReflectHorizontalIfOverlapped(ball, bar, barAccel);
				}
                else if (ReflectEnableByBar && OverlapDistanceY < 0d && OverlapDistanceX < 0d && OverlapDistanceY >= OverlapDistanceX)
				{
					ReflectVerticalIfOverlapped(ball, bar);
				}
			}
			else if (!IsOverlappedHorizontal && !IsOverlappedVertical)
			{
				ReflectEnableByBar = true;
			}
		}

		private void ReflectHorizontalIfOverlapped(Ball ball, Bar bar, int barAccel)
		{
            //if (bar.CenterY + barHeight / 2 > ball.CenterY
            //    && bar.CenterY - barHeight / 2 < ball.CenterY)
            //{
            if (ball.Left < bar.Left || ball.Right > bar.Right)
				ReflectHorizontal(ball, bar, barAccel);
			ReflectEnableByBar = false;
            //}
		}

		private void ReflectHorizontalIfOverlapped(Ball ball, Block block)
		{
            //if (block.Bottom > ball.CenterY && block.Top < ball.CenterY)
            //{
				ReflectHorizontal(ball);
				ReflectHEnable = false;
            //}
		}

		private void ReflectVerticalIfOverlapped(Ball ball, Bar bar)
		{
            //if (bar.Right > ball.CenterX && bar.Left < ball.CenterX)
            //{
				ReflectVertical(ball, bar);
				ReflectEnableByBar = false;
            //}
		}

		private void ReflectVerticalIfOverlapped(Ball ball, Block block)
		{
            //if (block.Right > ball.CenterX && block.Left < ball.CenterX)
            //{
				ReflectVertical(ball);
				ReflectVEnable = false;
            //}
		}

		private void ReflectHorizontal(Ball ball)
		{
			ball.DX = -ball.DX;
			ball.CenterX += ball.DX;

			boundFlag = true;
		}

		private void ReflectHorizontal(Ball ball, Bar bar, int BarAccel)
		{
			ReflectHorizontal(ball);
			ball.CenterX += ball.DX * BarAccel;
		}

		private void ReflectVertical(Ball ball)
		{
			ball.Radius = 20;

			if (Main.CatchBallEnables && ballcatch)// ボールがバーにくっつく状態
			{
				ball.DX = ball.DY = 0;
				ball.ballstop = true;
				if (ball.ballstop) // ＋なら右に，ーなら左にずれてる
					ball.xoffset = ball.CenterX - bar.MX;
				combocount = 0;
				bar.IsMove = false;
			}
			else
			{
				combocount = 0;
				bar.IsMove = false;
				ball.DY = -ball.DY;
				ball.CenterY = ball.CenterY - 5;
				boundFlag = true;
			}
		}

		private void ReflectVertical(Ball ball, Bar bar)
		{
			ball.Radius = 20;

			if (Main.CatchBallEnables && ballcatch)// ボールがバーにくっつく状態
			{
				ball.DX = ball.DY = 0;
				ball.ballstop = true;
				if (ball.ballstop) // ＋なら右に，ーなら左にずれてる
					ball.xoffset = ball.CenterX - bar.MX;
				combocount = 0;
				bar.IsMove = false;
			}
			else if (ball.CenterX < bar.CenterX - barWidth / 2 * 2 / 3 
                && ball.CenterX > bar.CenterX + barWidth / 2 * 2 / 3)
			{
				combocount = 0;
				bar.IsMove = false;
				if (Bar == EBarType.SHORT)
					ball.LvUp(1);

				ball.DX = -ball.DX;
				ball.DY = -ball.DY;
				ball.CenterY = ball.CenterY - 5;

				boundFlag = true;
			}
			else
			{
				if (ball.CenterX < bar.CenterX + 10 && ball.CenterX > bar.CenterX - 10)
				{
					ball.Penetration();
					ball.LvUp(1); // 速度が上がって短時間貫通化
				}

				combocount = 0;
				bar.IsMove = false;
				if (Bar == EBarType.SHORT)
					ball.LvUp(1);
				ball.DY = -ball.DY;
				ball.CenterY = ball.CenterY - 5;
				boundFlag = true;
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

			int ballX = ball.CenterX;
			int ballY = ball.CenterY;

			foreach (Ball smallBall in SmallBalls)
			{
				if (smallBall == ball) // 捜査対象が同じならコンティニュー
					continue;
				if (smallBall.IsNewCount > 0) // 増えたばかりならコンティニュー
					continue;

				if ((ballX - smallBall.CenterX) * (ballX - smallBall.CenterX) + (ballY - smallBall.CenterY) * (ballY - smallBall.CenterY) <= 20 * 20) // 衝突判定
				{
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
			vspeed = 0;
			barWidth = bar.Width;
			combocount = 0;
			bar.Reset();
			ball.Reset();
			for (int i = 0; i < sumblock; ++i)
				block[i].scrollStop = false;
			bar.IsDead = false;
		}
	}
}
