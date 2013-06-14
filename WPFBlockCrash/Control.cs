using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFBlockCrash
{
	class Control
	{
		private const int MAX_SBALLCOUNT = 20;
		private const int MAX_BLOCKCOUNT = 100;

		private Bar bar;
		private Ball ball;
		private Ball[] sBall;
		private Block[] block;

		private int bdx, bdy, blx, bly, bkx, bky;

		private int bdwidth, bdheight, blwidth, blheight, bkwidth, bkheight;

		private int exwidth;
		private bool boundFlag;
		private bool demolishFlag;

		//private int bh, dh;
		private SoundPlayer playerBH;
		private SoundPlayer playerDH;
		
		private int sballCount;
		private int mLevel, mScore, mStock;

		//private int gh;
		private ImageSource gh;

		private int act;
		private int sumblock;
		private int mStage;
		private int accel;
		private int barnum;
		private int ballspup;
		private int vspeed;
		private DisplayInfo dInfo;

		public bool clear;

		public int Stock { get; set; }

		public Control(int mbar, int stage, int score, int stock, DisplayInfo dInfo)
		{
			this.dInfo = dInfo;
			barnum = mbar;
	
			//バーとボールのインスタンスを生成
			bar = new Bar(barnum, dInfo);
			ball = new Ball(dInfo);
			ballspup = 0;

			block = new Block[MAX_BLOCKCOUNT];
			sBall = new Ball[MAX_SBALLCOUNT];

			boundFlag=false;
			demolishFlag=false;
			sballCount = 0;
			clear = false;
			mScore = score;
			mStock = stock;
			act = 0;
			mStage = stage;
			vspeed = 0;

			//Random rand = new Random(Environment.TickCount);
	
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
			gh = new BitmapImage(new Uri(Main.ResourceDirectory, "ball_b.png"));

	
			switch( mStage ){
			case 1: sumblock = 28;
					//ブロックの間を5ピクセルあけて、横7列、縦4行で配置
					for(int i=0;i<sumblock;++i){
						if(i<7)
							block[i]= new Block(80+(5+100)*i,50*1+10);
						else if(i>6 && i<14)
							block[i]= new Block(80+(5+100)*(i-7),50*2+10);
						else if(i>13 && i<21)
							block[i]= new Block(80+(5+100)*(i-14),50*3+10);
						else
							block[i]= new Block(80+(5+100)*(i-21),50*4+10);
					}
					break;
			case 2: sumblock = 48;
					//ブロックの上下間を30ピクセルあけて、横4列、縦12行で配置
					for(int i=0;i<sumblock;++i){
						if(i<4)
							block[i]= new Block(50+(8+225)*i,30*1+15);
						else if(i>3 && i<8)
							block[i]= new Block(50+(8+225)*(i-4),30*2+15);
						else if(i>7 && i<12)
							block[i]= new Block(50+(8+225)*(i-8),30*3+15);
						else if(i>11 && i<16)
							block[i]= new Block(50+(8+225)*(i-12),30*4+15);
						else if(i>15 && i<20)
							block[i]= new Block(50+(8+225)*(i-16),30*5+15);
						else if(i>19 && i<24)
							block[i]= new Block(50+(8+225)*(i-20),30*6+15);
						else if(i>23 && i<28)
							block[i]= new Block(50+(8+225)*(i-24),30*7+15);
						else if(i>27 && i<32)
							block[i]= new Block(50+(8+225)*(i-28),30*8+15);
						else if(i>31 && i<36)
							block[i]= new Block(50+(8+225)*(i-32),30*9+15);
						else if(i>35 && i<40)
							block[i]= new Block(50+(8+225)*(i-36),30*10+15);
						else if(i>39 && i<44)
							block[i]= new Block(50+(8+225)*(i-40),30*11+15);
						else
							block[i]= new Block(50+(8+225)*(i-44),30*12+15);
					}
					break;
			case 3: sumblock = 48;
					//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
					for(int i=0;i<sumblock;++i){
						if(i<4)
							block[i]= new Block(55+(8+180)*i,30*1+15);
						else if(i>3 && i<8)
							block[i]= new Block(145+(8+180)*(i-4),30*2+15);
						else if(i>7 && i<12)
							block[i]= new Block(55+(8+180)*(i-8),30*3+15);
						else if(i>11 && i<16)
							block[i]= new Block(145+(8+180)*(i-12),30*4+15);
						else if(i>15 && i<20)
							block[i]= new Block(55+(8+180)*(i-16),30*5+15);
						else if(i>19 && i<24)
							block[i]= new Block(145+(8+180)*(i-20),30*6+15);
						else if(i>23 && i<28)
							block[i]= new Block(55+(8+180)*(i-24),30*7+15);
						else if(i>27 && i<32)
							block[i]= new Block(145+(8+180)*(i-28),30*8+15);
						else if(i>31 && i<36)
							block[i]= new Block(55+(8+180)*(i-32),30*9+15);
						else if(i>35 && i<40)
							block[i]= new Block(145+(8+180)*(i-36),30*10+15);
						else if(i>39 && i<44)
							block[i]= new Block(55+(8+180)*(i-40),30*11+15);
						else
							block[i]= new Block(145+(8+180)*(i-44),30*12+15);
					}
					break;
			case 4: sumblock = 44;
					//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
					for(int i=0;i<sumblock;++i){
						if(i<1)
							block[i]= new Block(400,28*1+15);
						else if(i>0 && i<3)
							block[i]= new Block(350+100*(i-1),28*2+15);
						else if(i>2 && i<5)
							block[i]= new Block(300+200*(i-3),28*3+15);
						else if(i>4 && i<7)
							block[i]= new Block(250+300*(i-5),28*4+15);
						else if(i>6 && i<9)
							block[i]= new Block(200+400*(i-7),28*5+15);
						else if(i>8 && i<11)
							block[i]= new Block(150+500*(i-9),28*6+15);
						else if(i>10 && i<13)
							block[i]= new Block(100+600*(i-11),28*7+15);
						else if(i>12 && i<15)
							block[i]= new Block(50+700*(i-13),28*8+15);
						else if(i>14 && i<17)
							block[i]= new Block(100+600*(i-15),28*9+15);
						else if(i>16 && i<19)
							block[i]= new Block(150+500*(i-17),28*10+15);
						else if(i>18 && i<21)
							block[i]= new Block(200+400*(i-19),28*11+15);
						else if(i>20 && i<23)
							block[i]= new Block(250+300*(i-21),28*12+15);
						else if(i>22 && i<25)
							block[i]= new Block(300+200*(i-23),28*13+15);
						else if(i>24 && i<27)
							block[i]= new Block(350+100*(i-25),28*14+15);
						else if(i>26 && i<28)
							block[i]= new Block(400,28*15+15);
						else if(i>27 && i<29)
							block[i]= new Block(400,28*4+15);
						else if(i>28 && i<31)
							block[i]= new Block(350+100*(i-29),28*5+15);
						else if(i>30 && i<33)
							block[i]= new Block(300+200*(i-31),28*6+15);
						else if(i>32 && i<35)
							block[i]= new Block(250+300*(i-33),28*7+15);
						else if(i>34 && i<37)
							block[i]= new Block(200+400*(i-35),28*8+15);
						else if(i>36 && i<39)
							block[i]= new Block(250+300*(i-37),28*9+15);
						else if(i>38 && i<41)
							block[i]= new Block(300+200*(i-39),28*10+15);
						else if(i>40 && i<43)
							block[i]= new Block(350+100*(i-41),28*11+15);
						else
							block[i]= new Block(400,28*12+15);
					}
					break;
				case 5: sumblock = 64;
					//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
					for(int i=0;i<sumblock;++i){
						if(i<4)
							block[i]= new Block(50+50*i, 50);
						else if(i>3 && i<16)
							block[i]= new Block(125, 50+28*(i-3));
						else if(i>15 && i<20)
							block[i]= new Block(50+50*(i-16),50+28*13 );

						else if(i>19 && i<21)
							block[i]= new Block(375,50);
						else if(i>20 && i<23)
							block[i]= new Block(325+100*(i-21),50+28*1);
						else if(i>22 && i<25)
							block[i]= new Block(275+200*(i-23),50+28*2);
						else if(i>24 && i<27)
							block[i]= new Block(250+250*(i-25),50+28*3);
						else if(i>26 && i<29)
							block[i]= new Block(250+250*(i-27),50+28*4);
						else if(i>28 && i<33)
							block[i]= new Block(250,50+28*(i-24));
						else if(i>32 && i<35)
							block[i]= new Block(250+250*(i-33),50+28*9);
						else if(i>34 && i<37)
							block[i]= new Block(250+250*(i-35),50+28*10);
						else if(i>36 && i<39)
							block[i]= new Block(275+200*(i-37),50+28*11);
						else if(i>38 && i<41)
							block[i]= new Block(325+100*(i-39),50+28*12);
						else if(i>40 && i<42)
							block[i]= new Block(375,50+28*13);

						else if(i>41 && i<44)
							block[i]= new Block(550+50*(i-42),50);
						else if(i>43 && i<55)
							block[i]= new Block(575,50+28*(i-43));
						else if(i>54 && i<57)
							block[i]= new Block(575+175*(i-55),50+28*11);
						else if(i>56 && i<59)
							block[i]= new Block(575+175*(i-57),50+28*12);
						else if(i>58 && i<64)
							block[i]= new Block(550+50*(i-59),50+28*13);

						//block[i].SetHalfFlag(true);
						block[i].HalfFlag = true;
					}
					break;
			}

			bkwidth = block[0].Width;
			bkheight = block[0].Height;
		}

		internal bool Process(Input input, DrawingContext dc)
		{
			bool back, sballdrop;
			int itemhandle;
			int count = 0;

			for (int i = 0; i < sumblock; ++i)
			{
				if (block[i].IsDead)
					++count;
				if (block[i].ItemFlag)
					itemhandle = 4;
				else
					itemhandle = 0;

				switch (mStage)
				{
					case 1: if (i < 7)
							block[i].Process(dc, 0 + itemhandle);
						else if (i > 6 && i < 14)
							block[i].Process(dc, 1 + itemhandle);
						else if (i > 13 && i < 21)
							block[i].Process(dc, 2 + itemhandle);
						else
							block[i].Process(dc, 3 + itemhandle);
						break;
					default: if (i % 4 == 0)
							block[i].Process(dc, 0 + itemhandle);
						else if (i % 4 == 1)
							block[i].Process(dc, 1 + itemhandle);
						else if (i % 4 == 2)
							block[i].Process(dc, 2 + itemhandle);
						else
							block[i].Process(dc, 3 + itemhandle);
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
			bar.Process(input, dc);

			if (ball.ActCount == 0)
			{
				ball.X = bar.MX;
			}

			// ボールの動き
			++ballspup; // 速度上昇カウント

			switch (barnum)
			{ // バーによりの速度上昇の早さが違う
				case 1: if (ballspup % 1500 == 0)
					{ // やさしい
						ball.LvUp(1);
					}
					break;
				case 2: if (ballspup % 1000 == 0)
					{ // ふつう
						ball.LvUp(1);
					}
					break;
				case 3: if (ballspup % 800 == 0)
					{ // 難しい
						ball.LvUp(1);
					}
					break;
			}

			++vspeed; // 進まなくなったとき用カウントの増加

			if (vspeed == 1000)
			{
				vspeed = 0;
				ball.spchange();
			}

			back = ball.Process(input, dc);

			//ボールとバーの当たり判定
			HitCheckBallAndBar(ball);

			//ボールとブロックの当たり判定
			HitCheckBallAndBlock(ball);

			// 小玉があれば表示　// 謎の挙動
			for (int i = 0; i < sballcount; ++i)
			{
				if (sBall[i] == null)
					continue;

				sballdrop = sBall[i].Process(input, dc);

				//ボールとバーの当たり判定
				HitCheckBallAndBar(sBall[i]);
				//ボールとブロックの当たり判定

				HitCheckBallAndBlock(sBall[i]);
				if (sballdrop)
				{
					sBall[i] = null;
					--sballcount;
				}
			}

			accel = bar.Accel; // デバック用
			
			// 得点、レベル、残機枠の表示
			DrawUtil.DrawBox(dc, 0, 0, 800, 30, Color.FromRgb(230, 230, 230), 3, null);
			DrawUtil.DrawString(dc, 20, 10, string.Format("SCORE: {0}", mScore), Color.FromRgb(255, 120, 0));
			DrawUtil.DrawString(dc, 220, 10, string.Format("LEVEL: {0}", ball.Level), Color.FromRgb(255, 120, 0));

			for (int i = 0; i < mStock; ++i)
			{
				dc.DrawImage(gh, new Rect(540 + 18 * i, 7, gh.Width, gh.Height));
			}

			///音再生
			SoundPlay();

			if (back)
			{
				bar.IsDead = true;
				ball.DX = 0;
			}
			if (clear)
			{
				ball.DX = 0;
				ball.DY = 0;

				// 小玉があれば表示
				for (int i = 0; i < sballcount; ++i)
				{
					if (sBall[i] == null)
						continue;
					sBall[i].DX = 0;
					sBall[i].DY = 0;
				}
				vspeed = 0;
				bar.IsDead = true;
			}

			return back;
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

			blx = ball.X;
			bly = ball.Y;

			for (int i = 0; i < sumblock; ++i)
			{
				if (!block[i].IsDead)
				{
					bkx = block[i].X;
					bky = block[i].Y;

					if (blx < bkx + bkwidth / 2
						&& blx > bkx - bkwidth / 2
						&& bly + blheight / 2 > bky - bkheight / 2
						&& bly + blheight / 2 < bky + bkheight / 2)
					{
						vspeed = 0;

						block[i].IsDead = true;
						demolishFlag = true;

						if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
							ball.DY = -ball.DY;
					}
					else if (blx < bkx + bkwidth / 2
						&& blx > bkx - bkwidth / 2
						&& bly - blheight / 2 > bky - bkheight / 2
						&& bly - blheight / 2 < bky + bkheight / 2)
					{
						vspeed = 0;

						block[i].IsDead = true;
						demolishFlag = true;
						if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
							ball.DY = -ball.DY;
					}
					else if (blx + blwidth / 2 < bkx - bkwidth / 2 + blwidth
						&& blx + blwidth / 2 > bkx - bkwidth / 2
						&& bly > bky - bkheight / 2
						&& bly < bky + bkheight / 2)
					{
						vspeed = 0;

						block[i].IsDead = true;
						demolishFlag = true;
						if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
							ball.DX = -ball.DX;
					}
					else if (blx - blwidth / 2 < bkx + bkwidth / 2
						&& blx - blwidth / 2 > bkx + bkwidth / 2 - blwidth
						&& bly > bky - bkheight / 2
						&& bly < bky + bkheight / 2)
					{
						vspeed = 0;

						block[i].IsDead = true;
						demolishFlag = true;
						if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
							ball.DX = -ball.DX;
					}

					if (block[i].IsDead)
					{
						mScore += 100 + 50 * ball.Level;
						ball.Radius = 0;
					}
				}
				else if (block[i].ItemFlag)
				{
					bkx = block[i].X;
					bky = block[i].Y;

					if (blx < bkx + bkwidth / 2
						&& blx > bkx - bkwidth / 2
						&& bly + blheight / 2 > bky - bkheight / 2
						&& bly + blheight / 2 < bky + bkheight / 2)
					{
						vspeed = 0;

						block[i].ItemFlag = false;

						ItemEffect(block[i].ItemType, blx, bly);

						demolishFlag = true;
					}
					else if (blx < bkx + bkwidth / 2
						&& blx > bkx - bkwidth / 2
						&& bly - blheight / 2 > bky - bkheight / 2
						&& bly - blheight / 2 < bky + bkheight / 2)
					{
						vspeed = 0;

						block[i].ItemFlag = false;

						ItemEffect(block[i].ItemType, blx, bly);

						demolishFlag = true;
					}
					else if (blx + blwidth / 2 < bkx - bkwidth / 2 + blwidth
						&& blx + blwidth / 2 > bkx - bkwidth / 2
						&& bly > bky - bkheight / 2
						&& bly < bky + bkheight / 2)
					{
						vspeed = 0;

						block[i].ItemFlag = false;

						ItemEffect(block[i].ItemType, blx, bly);

						demolishFlag = true;
					}
					else if (blx - blwidth / 2 < bkx + bkwidth / 2
						&& blx - blwidth / 2 > bkx + bkwidth / 2 - blwidth
						&& bly > bky - bkheight / 2
						&& bly < bky + bkheight / 2)
					{
						vspeed = 0;

						block[i].ItemFlag = false;

						ItemEffect(block[i].ItemType, blx, bly);

						demolishFlag = true;
					}

					if (!block[i].ItemFlag)
						mScore += 300;
				}
			}
		}

		private void ItemEffect(EItemType eItemType, int blx, int bly)
		{
			int ct = 0;
			int index = 0;
			switch (eItemType)
			{
				case EItemType.ITEMTYPE_LONG:
					if (barnum != 3)
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
						if (sBall[sballcount + index] != null)
						{
							++index;
							continue;
						}
						if (sballcount + index >= MAX_SBALLCOUNT)
						{
							break;
						}
						sBall[sballcount + index] = new Ball(dInfo);
						sBall[sballcount + index].Increse(blx, bly);
						++sballcount;
						++ct;
						if (ct == 3) break;
					}
					break;
				case EItemType.ITEMTYPE_1UP:
					++mStock;
					break;
				case EItemType.ITEMTYPE_SCOREUP:
					mScore += 2000;
					break;
			}
		}

		private void HitCheckBallAndBar(Ball ball)
		{
			boundFlag = false;

			boundFlag = ball.PlaySound;

			bdx = bar.X;
			bdy = bar.Y;

			blx = ball.X;
			bly = ball.Y;

			if (Math.Abs(bdy - bly) < blheight / 2 + bdheight / 2)
			{
				if (bdx + bdwidth / 2 > blx
					&& bdx - bdwidth / 2 < blx)
				{
					ball.Radius = 20;

					if (blx < bdx - bdwidth / 2 * 2 / 3)
					{
						if (barnum == 3)
							ball.LvUp(1);

						ball.DX = -ball.DX;
						ball.DY = -ball.DY;
						ball.Y = ball.Y - 5;

						boundFlag = true;
					}
					else if (blx > bdx + bdwidth / 2 * 2 / 3)
					{
						if (barnum == 3)
							ball.LvUp(1);

						ball.DX = -ball.DX;
						ball.DY = -ball.DY;
						ball.Y = ball.Y - 5;

						boundFlag = true;
					}
					else
					{
						if (barnum == 3)
							ball.LvUp(1);

						ball.DY = -ball.DY;
						ball.Y = ball.Y - 5;
						boundFlag = true;
					}
				}
			}
		}

		internal void Reset()
		{
			for (int i = 0; i < sballcount; ++i)
				sBall[i] = null;

			sballcount = 0;
			--mStock;
			bdwidth = bar.Width;
			bar.Reset();
			ball.Reset();
			bar.IsDead = false;
		}

		public int Bar { get; set; }

		public int Stage { get; set; }

		public int Score { get; set; }

		public int sballcount { get; set; }
	}
}
