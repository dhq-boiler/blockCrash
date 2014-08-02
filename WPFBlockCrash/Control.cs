using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using PV2E.Agent;
using PV2E.Stream;
using PV2IO.Async;
using PV2IO.Parameter;
using PV2SS;
using PV2SS.exception;

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

		SoundDevice device;
		IStream bound_wav;
		IStream demolish_wav;
		
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
			mainBall = new Ball(dInfo, bar);
			ballspup = 0;

			SmallBalls = new LinkedList<Ball>();
			willBeAddedSmallBalls = new List<Ball>();

			clear = false;
			Score = takeOver.Score;
			Stock = takeOver.Stock;
			Stage = userChoice.StageType;
			vspeed = 0;
			ComboCount = 0;
			comboon = false;
			combooncount = 0;
			alphacombo = 0;
			
			PrepareSound();

			// 残機表示の読み込み
			gh = new Bitmap(Main.ResourceDirectory + "ball_b.png");

			builder = StageBuilder.CreateStageBuilder(Stage);

			builder.CreateStage(out block, ref sumblock, extendon);
		}

		private void PrepareSound()
		{
			try
			{
				//オーディオ初期化
				using (DeviceManager manager = new DeviceManager())
				{
					manager.ReadyRenderDeviceCollection();
					device = manager.GetDefaultDevice(DeviceManager.Render, DeviceManager.Console);
				}

				//音声ファイル読み込み
				using (Client client = device.GetAudioClient())
				{
					client.SharedMode(false, false);
					client.EventDriven();

					ReadWavFile(client, "bound_mix.wav", ref bound_wav);
					ReadWavFile(client, "demolish_44100_STREAM_SAMPLETYPE_FLOAT32.wav", ref demolish_wav);
				}
			}
			catch (Exception e)
			{
				Trace.WriteLine(string.Format("オーディオが正しく初期化されませんでした．例外情報：{0}", e.ToString()));
			}
		}

		private void ReadWavFile(Client client, string WavFileName, ref IStream stream)
		{
			try
			{
				using (DirectWave wav = new DirectWave(Main.ResourceDirectory + WavFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					PCMParam pcmp = wav.readParameter();
					client.IsFormatSupported(pcmp);
					stream = StreamGenerator.GenerateStream(pcmp, wav.readSamplesData());
				}
			}
			catch (Exception e)
			{
				Trace.WriteLine(string.Format("{0} のロードに失敗しました．例外情報：{1}", WavFileName, e.ToString()));
			}
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
				if (smallBall.IsCatching)// ボールが止まっていれば
				{ 
					smallBall.CenterX = bar.MX + smallBall.xoffset;
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

			if (++vspeed == 1000)// 進まなくなったとき用カウントの増加
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
			bool bound = mainBall.PlaySound;

			if (!bound)
			{
				foreach (var small in SmallBalls)
				{
					bound |= small.PlaySound;
				}
			}

			if (bound_wav != null && bound)
			{
				PlayBoundSoundAsync();
			}

			bool demolish = mainBall.NowCrashingBlockOrGettingItem;

			if (!demolish)
			{
				foreach (var small in SmallBalls)
				{
					demolish |= small.NowCrashingBlockOrGettingItem;
				}
			}

			if (demolish_wav != null && demolish)
			{
				PlayDemolishSoundAsync();
			}
		}

		private void PlayDemolishSoundAsync()
		{
			new Thread(() => PlaySync(demolish_wav, "demolish_44100_STREAM_SAMPLETYPE_FLOAT32.wav")).Start();
		}

		private void PlayBoundSoundAsync()
		{
			new Thread(() => PlaySync(bound_wav, "bound_mix.wav")).Start();
		}

		private void PlaySync(IStream stream, string soundName)
		{
			using (Client client = device.GetAudioClient())
			{
				client.SharedMode(false, false);
				client.EventDriven();
				client.Initialize(stream.PCMParam, 0, false);

				using (Driver render = client.StartUpRenderer(stream))
				{
					client.GetReady();
					client.Start();
					try
					{
						client.Drive();
						Trace.WriteLine(soundName + " stopped.");
					}
					catch (RenderingException)
					{
						Trace.WriteLine(soundName + " stopped in midstream.");
					}
				}
			}
		}

		private void HitCheckBallAndBlock(Ball ball)
		{
			int ballX = ball.CenterX;
			int ballY = ball.CenterY;

			for (int i = 0; i < sumblock; ++i)
			{
				if (!block[i].IsDead)
				{
					if (CheckCrashingBlock(ball, block[i]))
					{
						ball.NowCrashingBlockOrGettingItem = true;
						break;
					}
				}
				else if (block[i].ItemFlag)
				{
					if (block[i].matchlessCount > 0 && ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
						continue;
					CheckGettingItem(ball, block[i]);
				}
			}
		}

		private void CheckGettingItem(Ball ball, Block block)
		{
			int blockendX = 0;
			int blockX = block.CenterX;
			int blockY = block.CenterY;

			if (blockX - block.Width / 2 < 0)
				blockendX = blockX - block.Width / 2 + 800;
			if (blockX + block.Width / 2 >= 800)
				blockendX = blockX + block.Width / 2 - 800;

			for (int j = 0; j < 1; ++j)
			{
				if (ball.CenterX < blockX + block.Width / 2
					&& ball.CenterX > blockX - block.Width / 2
					&& ball.CenterY + ball.Height / 2 > blockY - block.Height / 2
					&& ball.CenterY + ball.Height / 2 < blockY + block.Height / 2)
				{
					GetItem(ball, block);
				}
				else if (ball.CenterX < blockX + block.Width / 2
					&& ball.CenterX > blockX - block.Width / 2
					&& ball.CenterY - ball.Height / 2 > blockY - block.Height / 2
					&& ball.CenterY - ball.Height / 2 < blockY + block.Height / 2)
				{
					GetItem(ball, block);
				}
				else if (ball.CenterX + ball.Width / 2 < blockX - block.Width / 2 + ball.Width
					&& ball.CenterX + ball.Width / 2 > blockX - block.Width / 2
					&& ball.CenterY > blockY - block.Height / 2
					&& ball.CenterY < blockY + block.Height / 2)
				{
					GetItem(ball, block);
				}
				else if (ball.CenterX - ball.Width / 2 < blockX + block.Width / 2
					&& ball.CenterX - ball.Width / 2 > blockX + block.Width / 2 - ball.Width
					&& ball.CenterY > blockY - block.Height / 2
					&& ball.CenterY < blockY + block.Height / 2)
				{
					GetItem(ball, block);
				}
				if (blockendX != 0)
					blockX = blockendX;
				else
					break;
			}

			if (!block.ItemFlag)
				Score += 300;
		}

		private void GetItem(Ball ball, Block block)
		{
			vspeed = 0;
			block.ItemFlag = false;
			ItemEffect(block.ItemType, ball.CenterX, ball.CenterY);
			ball.NowCrashingBlockOrGettingItem = true;
		}

		private bool CheckCrashingBlock(Ball ball, Block block)
		{
			bool IsNotOverlapping = false;

			IsNotOverlapping |= DetectCollision(ball, block);
			if (block.IsMirroring)
				IsNotOverlapping |= DetectCollisionMirror(ball, block);

			if (block.IsDead)
			{
				int NonMoveBonus = 0;
				if (!bar.IsMove)
					NonMoveBonus = 500;
				++ComboCount;
				Score += 100 + 50 * ball.Level + ComboCount * 100 + NonMoveBonus;
			}

			return block.IsDead;
		}

		private bool DetectCollision(Ball ball, Block block)
		{
			bool IsOverlappedVertical = Math.Abs(block.CenterY - ball.CenterY) < ball.Height / 2 + block.Height / 2;
			bool IsOverlappedHorizontal = Math.Abs(block.CenterX - ball.CenterX) < ball.Width / 2 + block.Width / 2;

			if (IsOverlappedVertical && IsOverlappedHorizontal)
			{
				double OverlapDistanceX = double.MaxValue;
				double OverlapDistanceY = double.MaxValue;

				if (block.CenterY < ball.CenterY) //下辺反射
					OverlapDistanceY = (ball.Top - block.Bottom) / (double)block.Height;
				else  //上辺反射
					OverlapDistanceY = (block.Top - ball.Bottom) / (double)block.Height;

				if (block.CenterX < ball.CenterX) //右辺反射
					OverlapDistanceX = (ball.Left - block.Right) / (double)block.Width;
				else //左辺反射
					OverlapDistanceX = (block.Left - ball.Right) / (double)block.Width;

				if (OverlapDistanceX >= 0d || OverlapDistanceY >= 0d)
					return false;

				if (ball.Penetrability == Ball.EPenetrability.PENETRATING)
				{
					block.IsDead = true;
				}
				else if (Math.Abs(OverlapDistanceX - OverlapDistanceY) < 0.10)
				{
					Debug.WriteLine("RHV ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
					Collision.ReflectVerticalIfOverlapped(ball, block, ref combocount);
					Collision.ReflectHorizontalIfOverlapped(ball, block);
					block.IsDead = true;
				}
				else if (OverlapDistanceY < OverlapDistanceX)
				{
					Debug.WriteLine("RH ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
					Collision.ReflectHorizontalIfOverlapped(ball, block);
					block.IsDead = true;
				}
				else if (OverlapDistanceX < OverlapDistanceY)
				{
					Debug.WriteLine("RV ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
					Collision.ReflectVerticalIfOverlapped(ball, block, ref combocount);
					block.IsDead = true;
				}

				return true;
			}

			return false;
		}

		private bool DetectCollisionMirror(Ball ball, Block block)
		{
			bool IsOverlappedVertical = Math.Abs(block.MirrorCenterY - ball.CenterY) < ball.Height / 2 + block.Height / 2;
			bool IsOverlappedHorizontal = Math.Abs(block.MirrorCenterX - ball.CenterX) < ball.Width / 2 + block.Width / 2;

			if (IsOverlappedVertical && IsOverlappedHorizontal)
			{
				double OverlapDistanceX = double.MaxValue;
				double OverlapDistanceY = double.MaxValue;

				if (block.MirrorCenterY < ball.CenterY) //下辺反射
					OverlapDistanceY = (ball.Top - block.Bottom) / (double)block.Height;
				else  //上辺反射
					OverlapDistanceY = (block.Top - ball.Bottom) / (double)block.Height;

				if (block.MirrorCenterX < ball.CenterX) //右辺反射
					OverlapDistanceX = (ball.Left - block.Right) / (double)block.Width;
				else //左辺反射
					OverlapDistanceX = (block.Left - ball.Right) / (double)block.Width;

				if (OverlapDistanceX >= 0d || OverlapDistanceY >= 0d)
					return false;

				if (ball.Penetrability == Ball.EPenetrability.PENETRATING)
				{
					block.IsDead = true;
				}
				else if (Math.Abs(OverlapDistanceX - OverlapDistanceY) < 0.10)
				{
					Debug.WriteLine("RHV ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
					Collision.ReflectVerticalIfOverlapped(ball, block, ref combocount);
					block.IsDead = true;
				}
				else if (OverlapDistanceY < OverlapDistanceX)
				{
					Debug.WriteLine("RH ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
					Collision.ReflectHorizontalIfOverlapped(ball, block);
					block.IsDead = true;
				}
				else if (OverlapDistanceX < OverlapDistanceY)
				{
					Debug.WriteLine("RV ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
					Collision.ReflectVerticalIfOverlapped(ball, block, ref combocount);
					block.IsDead = true;
				}
				else
				{
					Debug.WriteLine("N ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
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

						Ball newSmallBall = new Ball(dInfo, bar);
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
					bar.IsBallCatch = true;
					break;
			}
		}

		private void HitCheckBallAndBar(Ball ball, int barAccel, Graphics g)
		{
			bool IsOverlappedVertical = Math.Abs(bar.CenterY - ball.CenterY) < ball.Height / 2 + bar.Height / 2;
			bool IsOverlappedHorizontal = Math.Abs(bar.CenterX - ball.CenterX) < ball.Width / 2 + bar.EnlargedWidth / 2;

			if (!ball.IsBounding && IsOverlappedVertical && IsOverlappedHorizontal)
			{
				ball.IsBounding = true;
				double OverlapDistanceX = double.MaxValue;
				double OverlapDistanceY = double.MaxValue;
				if (ball.CenterX < bar.CenterX)
				{
					OverlapDistanceX = (ball.Right - bar.Left);
				}
				else
				{
					OverlapDistanceX = (bar.Right - ball.Left);
				}

				if (ball.CenterY < bar.CenterY)
				{
					OverlapDistanceY = (ball.Bottom - bar.Top);
				}
				else
				{
					OverlapDistanceY = (bar.Bottom - ball.Top);
				}

				DrawDebugString_ODX_ODY(g, OverlapDistanceX, OverlapDistanceY);

				if (Math.Abs(OverlapDistanceX - OverlapDistanceY) < 0.10)
				{
					Console.WriteLine("RHV ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
					Collision.ReflectHorizontal(ball);
					Collision.ReflectVertical(ball, bar, BarType, ref combocount);
					if (!ball.IsCatching) ball.PlaySound = true;
				}
				else if (OverlapDistanceY > OverlapDistanceX)
				{
					Console.WriteLine("RH ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
					Collision.ReflectHorizontal(ball);
					if (!ball.IsCatching) ball.PlaySound = true;
				}
				else if (OverlapDistanceX > OverlapDistanceY)
				{
					Console.WriteLine("RV ODX: " + OverlapDistanceX.ToString("0.00") + " ODY: " + OverlapDistanceY.ToString("0.00"));
					Collision.ReflectVertical(ball, bar, BarType, ref combocount);
					if (!ball.IsCatching) ball.PlaySound = true;
				}
				else
				{
					Console.WriteLine("N ODX: " + OverlapDistanceX + " ODY: " + OverlapDistanceY);
				}
			}
			else
			{
				ball.IsBounding = false;
			}
		}

		[Conditional("DEBUG")]
		private void DrawDebugString_ODX_ODY(Graphics g, double OverlapDistanceX, double OverlapDistanceY)
		{
			g.DrawString(string.Format("ODX:{0}", OverlapDistanceX.ToString("0.00")), font, DrawUtil.BrushRGB(255, 120, 0), 20, 480);
			g.DrawString(string.Format("ODY:{0}", OverlapDistanceY.ToString("0.00")), font, DrawUtil.BrushRGB(255, 120, 0), 20, 520);
		}

		/// <summary>
		/// ボールとボールの衝突判定
		/// </summary>
		/// <param name="ball"></param>
		private void HitCheckBallAndBall(Ball ball)
		{
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

			ball1.PlaySound = ball2.PlaySound = true;
		}

		internal void Reset()
		{
			SmallBalls = new LinkedList<Ball>();
			bar.IsBallCatch = false;
			sballcount = 0;
			vspeed = 0;
			ComboCount = 0;
			bar.Reset();
			mainBall.Reset();
			for (int i = 0; i < sumblock; ++i)
				block[i].scrollStop = false;
			bar.IsDead = false;
		}
	}
}
