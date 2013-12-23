using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		private Ball mainBall;
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

		public EBarType BarType { get; set; }
		public EStageType Stage { get; set; }
		public int Score { get; set; }
		public int Stock { get; set; }
		public int sballcount { get; set; }
		private bool isballcatch;
		public bool IsBallCatch { get { return isballcatch; } set { isballcatch = value; } }
		public bool clear;
		private int alphacombo { get; set; }
		private int combocount;
		private int ComboCount { get { return combocount; } set { combocount = value; } }
		private bool comboon { get; set; }
		private int combooncount { get; set; }
		private bool reflectEnableByBar;
		private bool ReflectEnableByBar
		{
			get { return reflectEnableByBar; }
			set
			{
				reflectEnableByBar = value;
				Debug.WriteLine("Update ReflectEnableByBar to " + reflectEnableByBar);
			}
		}
		private bool reflectEnableByBlock;
		private bool ReflectEnableByBlock
		{
			get { return reflectEnableByBlock; }
			set
			{
				reflectEnableByBlock = value;
				Debug.WriteLine("Update ReflectEnableByBlock to " + reflectEnableByBlock);
			}
		}

		public bool IsDead { get; set; }
		public bool IsPlaying { get; set; }

		private IInputable message { get; set; }

		public Control(UserChoice userChoice, TakeOver takeOver, DisplayInfo dInfo, Input input, IOperator Operator)
		{
			this.dInfo = dInfo;
			this.Operator = Operator;

			BarType = userChoice.BarType;

			bool extendon = true;
			if (BarType == EBarType.SHORT)
				extendon = false;
	
			//バーとボールのインスタンスを生成
			bar = new Bar(BarType, dInfo, Operator);
			mainBall = new Ball(dInfo);
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
			IsBallCatch = false;
			ComboCount = 0;
			comboon = false;
			combooncount = 0;
			alphacombo = 0;

			//バーの幅と高さ
			barWidth = bar.Width;
			barHeight = bar.Height;

			// バーが拡大する長さ
			exwidth = (int)barWidth/2;

			//ボールの幅と高さ
			ballWidth = mainBall.Width;
			ballHeight = mainBall.Height;

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
						mainBall.IsStop = true;
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
						mainBall.IsStop = true;
					}

					if (message.Process(input, g, uc, takeOver).IsDead)
					{
						return new ProcessResult()
						{
							IsDead = true,
							NextState = new Ranking(Score, BarType, dInfo, Operator),
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
					mainBall.IsStop = true;
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
							NextState = new Ranking(Score, BarType, dInfo, Operator),
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

			//クリア判定
			if (count == sumblock)
			{
				clear = true;
			}

			if (input.AT)
			{
				//ボールの座標取得
				bar.CenterX = mainBall.CenterX;
			}

			//バーの処理
			bar.Process(input, g, uc, takeOver);

			//発射前のメインボールのX座標
			if (mainBall.ActCount == 0)
			{
				mainBall.CenterX = bar.MX;
				if (!ReflectEnableByBar)
					ReflectEnableByBar = true;
			}

			//吸着時のメインボールのX座標
			if (mainBall.IsCatching)
			{
				mainBall.CenterX = bar.MX + mainBall.xoffset;
			}

			//吸着時のスモールボールのX座標
			foreach (Ball smallBall in SmallBalls)
			{
				if (smallBall.IsStop)// ボールが止まっていれば
				{ 
					smallBall.CenterX = bar.MX + smallBall.xoffset;
					smallBall.CenterY = 527;
				}
			}

			// ボールの動き
			if (!mainBall.IsStop && !mainBall.IsCatching)
			{
				++ballspup; // 速度上昇カウント

				switch (BarType) // バーによりの速度上昇の早さが違う
				{

					case EBarType.LONG:
						g.DrawString(string.Format("{0} ballspup", ballspup % 1500), font, DrawUtil.BrushRGB(255, 120, 0), 20, 440);
						if (ballspup % 1500 == 0)// やさしい
						{ 
							mainBall.LvUp(1);
						}
						break;
					case EBarType.MEDIUM:
						g.DrawString(string.Format("{0} ballspup", ballspup % 1000), font, DrawUtil.BrushRGB(255, 120, 0), 20, 440);
						if (ballspup % 1000 == 0)// ふつう
						{ 
							mainBall.LvUp(1);
						}
						break;
					case EBarType.SHORT:
						g.DrawString(string.Format("{0} ballspup", ballspup % 800), font, DrawUtil.BrushRGB(255, 120, 0), 20, 440);
						if (ballspup % 800 == 0)// 難しい
						{ 
							mainBall.LvUp(1);
						}
						break;
				}
			}

			//++vspeed; // 進まなくなったとき用カウントの増加

			if (++vspeed == 1000)
			{
				vspeed = 0;
				mainBall.spchange();
			}

			accel = bar.Accel; 

			BallIsDead = UpdateBall(input, accel, g);

			// 小玉があれば表示
			UpdateSmallBalls(input, accel, g, uc, takeOver);
			
			// 得点、レベル、残機枠の表示
			g.DrawRectangle(new System.Drawing.Pen(DrawUtil.BrushRGB(230, 230, 230), 3), 0, 0, 800, 30);
			g.DrawString(string.Format("SCORE: {0}", Score), font, DrawUtil.BrushRGB(255, 120, 0), 20, 5);
			g.DrawString(string.Format("LEVEL: {0}", mainBall.Level), font, DrawUtil.BrushRGB(255, 120, 0), 220, 5);

			//デバック用

			// コンボ表示　邪魔にならないよう透明化処理する  
			if (ComboCount > 1)
			{
				g.DrawString(string.Format("{0} COMBO!", ComboCount), font, DrawUtil.BrushRGB(255, 120, 0), 20, 400);
				combooncount = 0;
				comboon = true;
				alphacombo = ComboCount;
			}

			if(ComboCount == 0 && comboon)
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

			mainBall.BarAccel(accel);

			// 小玉があれば加速させる？
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
				mainBall.DX = 0;
			}

			if (clear)
			{
				mainBall.DX = 0;
				mainBall.DY = 0;

				for (int i = 0; i < sumblock; ++i)
					block[i].scrollStop = true;

				// 小玉があれば表示
				foreach (Ball smallBall in SmallBalls)
				{
					smallBall.DX = 0;
					smallBall.DY = 0;
				}

				vspeed = 0;
				Score += mainBall.Level * Stock; 
				bar.IsDead = true;
			}

			return BallIsDead;
		}

		private bool UpdateBall(Input input, int barAccel, Graphics g)
		{
			bool BallIsDead = mainBall.Process(input, g, null, null).IsDead;

			// ボールとバーの当たり判定
			HitCheckBallAndBar(mainBall, barAccel, g);

			// ボールとブロックの当たり判定
			HitCheckBallAndBlock(mainBall);

			// ボールとボールの衝突判定
			HitCheckBallAndBall(mainBall);

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
					if (block[i].matchlessCount > 0 && ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
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
			bool IsNotOverlapping = false;

			IsNotOverlapping |= DetectOneCollision(ref block.isdead, ball.CenterX, ball.CenterY, ball.Top, ball.Bottom, ball.Left, ball.Right, ref ball.dx, ref ball.dy,
								   block.CenterX, block.CenterY, block.Top, block.Bottom, block.Left, block.Right, block.Width, block.Height, ref block.dx, ref block.dy, ball.Penetrability);
			if (block.IsMirroring)
				IsNotOverlapping |= DetectOneCollision(ref block.isdead, ball.CenterX, ball.CenterY, ball.Top, ball.Bottom, ball.Left, ball.Right, ref ball.dx, ref ball.dy,
										block.MirrorCenterX, block.MirrorCenterY, block.MirrorTop, block.MirrorBottom, block.MirrorLeft, block.MirrorRight, block.Width, block.Height, ref block.dx, ref block.dy, ball.Penetrability);

			if (block.IsDead)
			{
				int NonMoveBonus = 0;
				if (!bar.IsMove)
					NonMoveBonus = 500;
				++ComboCount;
				Score += 100 + 50 * ball.Level + ComboCount * 100 + NonMoveBonus;
				ball.Radius = 0;
			}

			return block.IsDead;
		}

		private bool DetectOneCollision(ref bool BlockIsDead,
			int ballCX, int ballCY, int ballTop, int ballBottom, int ballLeft, int ballRight, ref int ballDX, ref int ballDY,
			int blockCX, int blockCY, int blockTop, int blockBottom, int blockLeft, int blockRight, int blockWidth, int blockHeight, ref int blockDX, ref int blockDY,
			Ball.EPenetrability Penetrability)
		{
			bool IsOverlappedVertical = Math.Abs(blockCY - ballCY) < ballHeight / 2 + blockHeight / 2;
			bool IsOverlappedHorizontal = Math.Abs(blockCX - ballCX) < ballWidth / 2 + blockWidth / 2;

			if (IsOverlappedVertical && IsOverlappedHorizontal)
			{
				double OverlapDistanceX = double.MaxValue;
				double OverlapDistanceY = double.MaxValue;

				if (blockCY < ballCY) //下辺反射
					OverlapDistanceY = (ballTop - blockBottom) / (double)blockHeight;
				else  //上辺反射
					OverlapDistanceY = (blockTop - ballBottom) / (double)blockHeight;

				if (blockCX < ballCX) //右辺反射
					OverlapDistanceX = (ballLeft - blockRight) / (double)blockWidth;
				else //左辺反射
					OverlapDistanceX = (blockLeft - ballRight) / (double)blockWidth;

				if (OverlapDistanceX >= 0d || OverlapDistanceY >= 0d)
					return false;

				if (Penetrability == Ball.EPenetrability.PENETRATING)
				{
					BlockIsDead = true;
				}
				else if (Math.Abs(OverlapDistanceX - OverlapDistanceY) < 0.10)
				{
					Debug.WriteLine("RHV ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
					Collision.ReflectVerticalIfOverlapped(ballTop, ballBottom, ballLeft, ballRight, ref ballDX, ref ballDY,
						blockTop, blockBottom, blockLeft, blockRight, ref blockDX, ref blockDY, ref isballcatch, ref combocount, ref boundFlag);
					Collision.ReflectHorizontalIfOverlapped(ballTop, ballBottom, ballLeft, ballRight, ref ballDX, ref ballDY, ref ballCX,
						blockTop, blockBottom, blockLeft, blockRight, ref blockDX, ref boundFlag);
					BlockIsDead = true;
				}
				else if (OverlapDistanceY < OverlapDistanceX)
				{
					Debug.WriteLine("RH ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
					Collision.ReflectHorizontalIfOverlapped(ballTop, ballBottom, ballLeft, ballRight, ref ballDX, ref ballDY, ref ballCX,
						blockTop, blockBottom, blockLeft, blockRight, ref blockDX, ref boundFlag);
					BlockIsDead = true;
				}
				else if (OverlapDistanceX < OverlapDistanceY)
				{
					Debug.WriteLine("RV ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
					Collision.ReflectVerticalIfOverlapped(ballTop, ballBottom, ballLeft, ballRight, ref ballDX, ref ballDY, blockTop, blockBottom, blockLeft, blockRight, ref blockDX, ref blockDY, ref isballcatch, ref combocount, ref boundFlag);
					BlockIsDead = true;
				}
				else
				{
					Debug.WriteLine("N ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
				}

				return true;
			}

			return false;
		}

		private void ItemEffect(EItemType eItemType, int ballX, int ballY)
		{
			int ct = 0;
			switch (eItemType)
			{
				case EItemType.ITEMTYPE_LONG:
					if (BarType != EBarType.SHORT)
					{
						bar.ExtendWidth();
						barWidth += exwidth;
					}
					break;
				case EItemType.ITEMTYPE_POWERUP:
					mainBall.PowerUp();
					break;
				case EItemType.ITEMTYPE_INCRESE:
					while (true)
					{
						if (sballcount >= MAX_SBALLCOUNT)
							break;

						Ball newSmallBall = new Ball(dInfo);
						newSmallBall.IsStop = false;
						newSmallBall.Increse(mainBall, ballX, ballY);
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
					IsBallCatch = true;
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

#if DEBUG
				g.DrawString(string.Format("ODX:{0}", OverlapDistanceX), font, DrawUtil.BrushRGB(255, 120, 0), 20, 480);
				g.DrawString(string.Format("ODY:{0}", OverlapDistanceY), font, DrawUtil.BrushRGB(255, 120, 0), 20, 520);
#endif

				if (Math.Abs(OverlapDistanceX - OverlapDistanceY) < 0.25)
				{
					Debug.WriteLine("RHV ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
					Collision.ReflectVerticalIfOverlapped(ball, bar, BarType, ref isballcatch, ref combocount, ref boundFlag, ref reflectEnableByBar);
					Collision.ReflectHorizontalIfOverlapped(ball, bar, barAccel, ref boundFlag, ref reflectEnableByBar);
				}
				else if (OverlapDistanceY < OverlapDistanceX)
				{
					Debug.WriteLine("RH ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
					Collision.ReflectHorizontalIfOverlapped(ball, bar, barAccel, ref boundFlag, ref reflectEnableByBar);
				}
				else if (OverlapDistanceX < OverlapDistanceY)
				{
					Debug.WriteLine("RV ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
					Collision.ReflectVerticalIfOverlapped(ball, bar, BarType, ref isballcatch, ref combocount, ref boundFlag, ref reflectEnableByBar);
				}
				else
				{
					Debug.WriteLine("N ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
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

			int ballX = ball.CenterX;
			int ballY = ball.CenterY;

			foreach (Ball smallBall in SmallBalls)
			{
				if (smallBall == ball) // 捜査対象が同じならコンティニュー
					continue;
				if (smallBall.IsNewCount > 0) // 増えたばかりならコンティニュー
					continue;

				// 衝突判定
				if (!ball.IsOverlapping(smallBall)
					&& !smallBall.IsOverlapping(ball) //省略可
					&& Collision.BallsIsOverlapping(ball, smallBall)) 
				{
					Bounce(ball, smallBall);
					ball.BeginOverlapping(smallBall);
					smallBall.BeginOverlapping(ball);
				}
			}
		}

		private void Bounce(Ball ball1, Ball ball2)
		{
			double OverlapDistanceX = 0d;
			double OverlapDistanceY = 0d;

			if (ball2.CenterY < ball1.CenterY) //下辺反射
				OverlapDistanceY = (ball1.Top - ball2.Bottom) / (double)ball2.Height;
			else  //上辺反射
				OverlapDistanceY = (ball2.Top - ball1.Bottom) / (double)ball2.Height;

			if (ball2.CenterX < ball1.CenterX) //右辺反射
				OverlapDistanceX = (ball1.Left - ball2.Right) / (double)ball2.Width;
			else //左辺反射
				OverlapDistanceX = (ball2.Left - ball1.Right) / (double)ball2.Width;

			//重複領域が生じない場合，バウンドしない
			if (OverlapDistanceX > 0d || OverlapDistanceY > 0d)
			{
				return;
			}

			if (Math.Abs(OverlapDistanceX - OverlapDistanceY) < 0.25)
			{
				Collision.ReflectVerticalIfOverlapped(ball1, ball2);
				Collision.ReflectHorizontalIfOverlapped(ball1, ball2);
			}
			else if (OverlapDistanceY < OverlapDistanceX)
			{
				Collision.ReflectHorizontalIfOverlapped(ball1, ball2);
			}
			else if (OverlapDistanceX < OverlapDistanceY)
			{
				Collision.ReflectVerticalIfOverlapped(ball2, ball2);
			}

			boundFlag = true;
		}

		internal void Reset()
		{
			SmallBalls = new LinkedList<Ball>();
			IsBallCatch = false;
			bar.BallCatch(false);
			sballcount = 0;
			vspeed = 0;
			barWidth = bar.Width;
			ComboCount = 0;
			bar.Reset();
			mainBall.Reset();
			for (int i = 0; i < sumblock; ++i)
				block[i].scrollStop = false;
			bar.IsDead = false;
		}
	}
}
