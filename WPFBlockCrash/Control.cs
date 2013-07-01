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


		public Control(UserChoice userChoice, TakeOver takeOver, DisplayInfo dInfo, Input input)
		{
			this.dInfo = dInfo;
			Bar = userChoice.BarType;


			bool extendon = true;
			if (Bar == EBarType.SHORT)
				extendon = false;
	
			//バーとボールのインスタンスを生成
			bar = new Bar(Bar, dInfo);
			ball = new Ball(dInfo);
			ballspup = 0;

			block = new Block[MAX_BLOCKCOUNT];
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
	
			switch( Stage ){
			case EStageType.ONAJIMISAN:
				sumblock = 28;
					//ブロックの間を5ピクセルあけて、横7列、縦4行で配置
					for(int i=0;i<sumblock;++i){
						if(i<7)
							block[i] = new Block(80 + (5 + 100) * i, 50 * 1 + 10, extendon, EBlockColor.RED);
						else if(i>6 && i<14)
							block[i] = new Block(80 + (5 + 100) * (i - 7), 50 * 2 + 10, extendon, EBlockColor.BLUE);
						else if(i>13 && i<21)
							block[i] = new Block(80 + (5 + 100) * (i - 14), 50 * 3 + 10, extendon, EBlockColor.PURPLE);
						else
							block[i] = new Block(80 + (5 + 100) * (i - 21), 50 * 4 + 10, extendon, EBlockColor.CYAN);
					}
					break;
			case EStageType.FOURTOWER:
				sumblock = 48;
					//ブロックの上下間を30ピクセルあけて、横4列、縦12行で配置
					for(int i=0;i<sumblock;++i){
						if(i<4)
							block[i] = new Block(50 + (8 + 225) * i, 30 * 1 + 15, extendon, EBlockColor.RED);
						else if(i>3 && i<8)
							block[i] = new Block(50 + (8 + 225) * (i - 4), 30 * 2 + 15, extendon, EBlockColor.BLUE);
						else if(i>7 && i<12)
							block[i] = new Block(50 + (8 + 225) * (i - 8), 30 * 3 + 15, extendon, EBlockColor.PURPLE);
						else if(i>11 && i<16)
							block[i] = new Block(50 + (8 + 225) * (i - 12), 30 * 4 + 15, extendon, EBlockColor.CYAN);
						else if(i>15 && i<20)
							block[i] = new Block(50 + (8 + 225) * (i - 16), 30 * 5 + 15, extendon, EBlockColor.RED);
						else if(i>19 && i<24)
							block[i] = new Block(50 + (8 + 225) * (i - 20), 30 * 6 + 15, extendon, EBlockColor.BLUE);
						else if(i>23 && i<28)
							block[i] = new Block(50 + (8 + 225) * (i - 24), 30 * 7 + 15, extendon, EBlockColor.PURPLE);
						else if(i>27 && i<32)
							block[i] = new Block(50 + (8 + 225) * (i - 28), 30 * 8 + 15, extendon, EBlockColor.CYAN);
						else if(i>31 && i<36)
							block[i] = new Block(50 + (8 + 225) * (i - 32), 30 * 9 + 15, extendon, EBlockColor.RED);
						else if(i>35 && i<40)
							block[i] = new Block(50 + (8 + 225) * (i - 36), 30 * 10 + 15, extendon, EBlockColor.BLUE);
						else if(i>39 && i<44)
							block[i] = new Block(50 + (8 + 225) * (i - 40), 30 * 11 + 15, extendon, EBlockColor.PURPLE);
						else
							block[i] = new Block(50 + (8 + 225) * (i - 44), 30 * 12 + 15, extendon, EBlockColor.CYAN);
					}
					break;
			case EStageType.CROSSCROSS:
				sumblock = 48;
					//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
					for(int i=0;i<sumblock;++i){
						if(i<4)
							block[i] = new Block(55 + (8 + 180) * i, 30 * 1 + 15, extendon, EBlockColor.RED);
						else if(i>3 && i<8)
							block[i] = new Block(145 + (8 + 180) * (i - 4), 30 * 2 + 15, extendon, EBlockColor.BLUE);
						else if(i>7 && i<12)
							block[i] = new Block(55 + (8 + 180) * (i - 8), 30 * 3 + 15, extendon, EBlockColor.PURPLE);
						else if(i>11 && i<16)
							block[i] = new Block(145 + (8 + 180) * (i - 12), 30 * 4 + 15, extendon, EBlockColor.CYAN);
						else if(i>15 && i<20)
							block[i] = new Block(55 + (8 + 180) * (i - 16), 30 * 5 + 15, extendon, EBlockColor.RED);
						else if(i>19 && i<24)
							block[i] = new Block(145 + (8 + 180) * (i - 20), 30 * 6 + 15, extendon, EBlockColor.BLUE);
						else if(i>23 && i<28)
							block[i] = new Block(55 + (8 + 180) * (i - 24), 30 * 7 + 15, extendon, EBlockColor.PURPLE);
						else if(i>27 && i<32)
							block[i] = new Block(145 + (8 + 180) * (i - 28), 30 * 8 + 15, extendon, EBlockColor.CYAN);
						else if(i>31 && i<36)
							block[i] = new Block(55 + (8 + 180) * (i - 32), 30 * 9 + 15, extendon, EBlockColor.RED);
						else if(i>35 && i<40)
							block[i] = new Block(145 + (8 + 180) * (i - 36), 30 * 10 + 15, extendon, EBlockColor.BLUE);
						else if(i>39 && i<44)
							block[i] = new Block(55 + (8 + 180) * (i - 40), 30 * 11 + 15, extendon, EBlockColor.PURPLE);
						else
							block[i] = new Block(145 + (8 + 180) * (i - 44), 30 * 12 + 15, extendon, EBlockColor.CYAN);
						if (i % 2 == 0)
							block[i].ScrollFlag = 1;
						else
							block[i].ScrollFlag = -1;
					}
					break;
			case EStageType.LAWOFCYCLES:
				sumblock = 44;
					//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
					for(int i=0;i<sumblock;++i){
						if(i<1)
							block[i] = new Block(400, 28 * 1 + 15, extendon, EBlockColor.RED);
						else if(i>0 && i<3)
							block[i] = new Block(350 + 100 * (i - 1), 28 * 2 + 15, extendon, EBlockColor.BLUE);
						else if(i>2 && i<5)
							block[i] = new Block(300 + 200 * (i - 3), 28 * 3 + 15, extendon, EBlockColor.PURPLE);
						else if(i>4 && i<7)
							block[i] = new Block(250 + 300 * (i - 5), 28 * 4 + 15, extendon, EBlockColor.CYAN);
						else if(i>6 && i<9)
							block[i] = new Block(200 + 400 * (i - 7), 28 * 5 + 15, extendon, EBlockColor.RED);
						else if(i>8 && i<11)
							block[i] = new Block(150 + 500 * (i - 9), 28 * 6 + 15, extendon, EBlockColor.BLUE);
						else if(i>10 && i<13)
							block[i] = new Block(100 + 600 * (i - 11), 28 * 7 + 15, extendon, EBlockColor.PURPLE);
						else if(i>12 && i<15)
							block[i] = new Block(50 + 700 * (i - 13), 28 * 8 + 15, extendon, EBlockColor.CYAN);
						else if(i>14 && i<17)
							block[i] = new Block(100 + 600 * (i - 15), 28 * 9 + 15, extendon, EBlockColor.RED);
						else if(i>16 && i<19)
							block[i] = new Block(150 + 500 * (i - 17), 28 * 10 + 15, extendon, EBlockColor.BLUE);
						else if(i>18 && i<21)
							block[i] = new Block(200 + 400 * (i - 19), 28 * 11 + 15, extendon, EBlockColor.PURPLE);
						else if(i>20 && i<23)
							block[i] = new Block(250 + 300 * (i - 21), 28 * 12 + 15, extendon, EBlockColor.CYAN);
						else if(i>22 && i<25)
							block[i] = new Block(300 + 200 * (i - 23), 28 * 13 + 15, extendon, EBlockColor.RED);
						else if(i>24 && i<27)
							block[i] = new Block(350 + 100 * (i - 25), 28 * 14 + 15, extendon, EBlockColor.BLUE);
						else if(i>26 && i<28)
							block[i] = new Block(400, 28 * 15 + 15, extendon, EBlockColor.PURPLE);
						else if(i>27 && i<29)
							block[i] = new Block(400, 28 * 4 + 15, extendon, EBlockColor.CYAN);
						else if(i>28 && i<31)
							block[i] = new Block(350 + 100 * (i - 29), 28 * 5 + 15, extendon, EBlockColor.RED);
						else if(i>30 && i<33)
							block[i] = new Block(300 + 200 * (i - 31), 28 * 6 + 15, extendon, EBlockColor.BLUE);
						else if(i>32 && i<35)
							block[i] = new Block(250 + 300 * (i - 33), 28 * 7 + 15, extendon, EBlockColor.PURPLE);
						else if(i>34 && i<37)
							block[i] = new Block(200 + 400 * (i - 35), 28 * 8 + 15, extendon, EBlockColor.CYAN);
						else if(i>36 && i<39)
							block[i] = new Block(250 + 300 * (i - 37), 28 * 9 + 15, extendon, EBlockColor.RED);
						else if(i>38 && i<41)
							block[i] = new Block(300 + 200 * (i - 39), 28 * 10 + 15, extendon, EBlockColor.BLUE);
						else if(i>40 && i<43)
							block[i] = new Block(350 + 100 * (i - 41), 28 * 11 + 15, extendon, EBlockColor.PURPLE);
						else
							block[i] = new Block(400, 28 * 12 + 15, extendon, EBlockColor.CYAN);
					}
					break;
				case EStageType.PRODUCTORISUS:
					sumblock = 64;
					//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
					for(int i=0;i<sumblock;++i){
						if (i < 4)
							block[i] = new Block(50 + 50 * i, 50, extendon, EBlockColor.RED);
						else if (i > 3 && i < 16)
							block[i] = new Block(125, 50 + 28 * (i - 3), extendon, EBlockColor.BLUE);
						else if (i > 15 && i < 20)
							block[i] = new Block(50 + 50 * (i - 16), 50 + 28 * 13, extendon, EBlockColor.PURPLE);

						else if (i > 19 && i < 21)
							block[i] = new Block(375, 50, extendon, EBlockColor.CYAN);
						else if (i > 20 && i < 23)
							block[i] = new Block(325 + 100 * (i - 21), 50 + 28 * 1, extendon, EBlockColor.RED);
						else if (i > 22 && i < 25)
							block[i] = new Block(275 + 200 * (i - 23), 50 + 28 * 2, extendon, EBlockColor.BLUE);
						else if (i > 24 && i < 27)
							block[i] = new Block(250 + 250 * (i - 25), 50 + 28 * 3, extendon, EBlockColor.PURPLE);
						else if (i > 26 && i < 29)
							block[i] = new Block(250 + 250 * (i - 27), 50 + 28 * 4, extendon, EBlockColor.CYAN);
						else if (i > 28 && i < 33)
							block[i] = new Block(250, 50 + 28 * (i - 24), extendon, EBlockColor.RED);
						else if (i > 32 && i < 35)
							block[i] = new Block(250 + 250 * (i - 33), 50 + 28 * 9, extendon, EBlockColor.BLUE);
						else if (i > 34 && i < 37)
							block[i] = new Block(250 + 250 * (i - 35), 50 + 28 * 10, extendon, EBlockColor.PURPLE);
						else if (i > 36 && i < 39)
							block[i] = new Block(275 + 200 * (i - 37), 50 + 28 * 11, extendon, EBlockColor.CYAN);
						else if (i > 38 && i < 41)
							block[i] = new Block(325 + 100 * (i - 39), 50 + 28 * 12, extendon, EBlockColor.RED);
						else if (i > 40 && i < 42)
							block[i] = new Block(375, 50 + 28 * 13, extendon, EBlockColor.BLUE);

						else if (i > 41 && i < 44)
							block[i] = new Block(550 + 50 * (i - 42), 50, extendon, EBlockColor.PURPLE);
						else if (i > 43 && i < 55)
							block[i] = new Block(575, 50 + 28 * (i - 43), extendon, EBlockColor.CYAN);
						else if (i > 54 && i < 57)
							block[i] = new Block(575 + 175 * (i - 55), 50 + 28 * 11, extendon, EBlockColor.RED);
						else if (i > 56 && i < 59)
							block[i] = new Block(575 + 175 * (i - 57), 50 + 28 * 12, extendon, EBlockColor.BLUE);
						else if (i > 58 && i < 64)
							block[i] = new Block(550 + 50 * (i - 59), 50 + 28 * 13, extendon, EBlockColor.PURPLE);

						block[i].HalfFlag = true;
						block[i].ScrollFlag = 1;
					}
					break;

			}

			bkwidth = block[0].Width;
			bkheight = block[0].Height;
		}

		public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
		{
			if (BallIsDroped(input, g, uc, takeOver))
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
				else
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
							NextState = new Ranking(Score, Bar, dInfo),
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
					return new ProcessResult()
					{
						IsDead = true,
						NextState = new Ranking(Score, Bar, dInfo),
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

		private bool BallIsDroped(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
		{
			bool BallIsDead;
			//int itemhandle;
			int count = 0;

			for (int i = 0; i < sumblock; ++i)
			{
				if (block[i].IsDead)
					++count;
				//if (block[i].ItemFlag)
				//    itemhandle = 4;
				//else
				//    itemhandle = 0;

				switch (Stage)
				{
					case EStageType.ONAJIMISAN: if (i < 7)
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
			if (ball.ballstop) {
				ball.X = bar.MX + ball.xoffset;
			}
			foreach (Ball smallBall in SmallBalls)
			{
				if (smallBall.ballstop){ // ボールが止まっていれば
					smallBall.X = bar.MX + smallBall.xoffset;
					smallBall.Y = 527;
				}
			}


			// ボールの動き
			if (!ball.ballstop)
			{
				++ballspup; // 速度上昇カウント

				switch (Bar)
				{ // バーによりの速度上昇の早さが違う

					case EBarType.LONG:
						if (ballspup % 1500 == 0)
						{ // やさしい
							ball.LvUp(1);
						}
						break;
					case EBarType.MEDIUM:
						if (ballspup % 1000 == 0)
						{ // ふつう
							ball.LvUp(1);
						}
						break;
					case EBarType.SHORT:
						if (ballspup % 800 == 0)
						{ // 難しい
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

			for (int i = 0; i < Stock; ++i)
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

					if (ballcatch)
					{ // ボールがバーにくっつく状態
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
						if (ballX < barX + 10 && ballX > barX - 10) {
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

		private void HitCheckBallAndBall(Ball ball) // ボールとボールの衝突判定
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
			//for (int i = 0; i < sballcount; ++i)
			//    SmallBalls[i] = null;

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
