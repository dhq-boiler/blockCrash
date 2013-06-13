using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFBlockCrash
{
	class Control
	{
		private Input input;
		private Bar bar;
		private Ball ball;
		private Ball[] sBall;
		private Block[] block;

		private int bdx, bdy, blx, bly, bkx, bky;

		private int bdwidth, bdheight, blwidth, blheight, bkwidth, bkheight;

		private int exwidth;
		private bool boundFlag, demolishFlag;

		private int bh, dh;
		private SoundPlayer playerBH;
		private SoundPlayer playerDH;
		
		private int sballCount;
		private int mLevel, mScore, mStock;

		//private int gh;
		private Image gh;

		private int act;
		private int sumblock;
		private int mStage;
		private int accel;
		private int barnum;
		private int ballspup;
		private int vspeed;
		public bool clear;

		public int Stock { get; set; }

		public Control(Input input, int mbar, int stage, int score, int stock)
		{
			this.input = input;

			barnum = mbar;
	
			//バーとボールのインスタンスを生成
			bar = new Bar(input, barnum);
			ball = new Ball(input);
			ballspup = 0;

			boundFlag=false;
			demolishFlag=false;
			sballCount = 0;
			clear = false;
			mScore = score;
			mStock = stock;
			act = 0;
			mStage = stage;
			vspeed = 0;

			Random rand = new Random(Environment.TickCount);
	
			//バーの幅と高さ
			bdwidth = bar.GetWidth();
			bdheight = bar.GetHeight();

			// バーが拡大する長さ
			exwidth = (int)bdwidth/2;

			//ボールの幅と高さ
			blwidth = ball.GetWidth();
			blheight = ball.GetHeight();

			//音声ファイル読み込み。
			playerBH = new SoundPlayer("bound.wav");
			playerDH = new SoundPlayer("demolish.wav");

			// 残機表示の読み込み
			//gh = LoadGraph(TEXT("ball_b.png")); // 通常弾
			gh = new Image() { Source = new BitmapImage(new Uri("ball_b.png")) };

	
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

		internal bool All()
		{
			bool back, sballdrop;
			int itemhandle;
			int count = 0;

			for (int i = 0; i < sumblock; ++i)
			{
				if (block[i].EndFlag)
					++count;
				if (block[i].ItemFlag)
					itemhandle = 4;
				else
					itemhandle = 0;
				switch (mStage)
				{
					case 1: if (i < 7)
							block[i].All(0 + itemhandle);
						else if (i > 6 && i < 14)
							block[i].All(1 + itemhandle);
						else if (i > 13 && i < 21)
							block[i].All(2 + itemhandle);
						else
							block[i].All(3 + itemhandle);
						break;
					default: if (i % 4 == 0)
							block[i].All(0 + itemhandle);
						else if (i % 4 == 1)
							block[i].All(1 + itemhandle);
						else if (i % 4 == 2)
							block[i].All(2 + itemhandle);
						else
							block[i].All(3 + itemhandle);
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
			bar.All();

			if (ball.m_actcount == 0)
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

			back = ball.All();

			//ボールとバーの当たり判定
			HitCheckBallAndBar(ball);

			//ボールとブロックの当たり判定
			HitCheckBallAndBlock(ball);


			// 小玉があれば表示　// 謎の挙動
			for (int i = 0; i < sballcount; ++i)
			{
				if (sball[i] == null)
					continue;
				sballdrop = sball[i].All();
				//ボールとバーの当たり判定
				HitCheckBallAndBar(sball[i]);
				//ボールとブロックの当たり判定
				HitCheckBallAndBlock(sball[i]);
				if (sballdrop)
					sball[i] = null;
			}

			accel = bar.GetAcceleration(); // デバック用
			// 得点、レベル、残機枠の表示
			DrawBox(0, 0, 800, 30, RGB(230, 230, 230), true);
			DrawFormatString(20, 10, RGB(255, 120, 0), TEXT("SCORE: %d"), mscore);
			DrawFormatString(220, 10, RGB(10, 120, 120), TEXT("LEVEL: %d"), ball.level);
			for (int i = 0; i < mstock; ++i)
				DrawGraph(540 + 18 * i, 7, gh, TRUE);

			///音再生
			SoundPlay();

			if (back)
			{
				//bar.SetFlag(true);
				bar.Flag = true;
				ball.DX = 0;
			}
			if (clear)
			{
				ball.DX = 0;
				ball.DY = 0;
				// 小玉があれば表示
				for (int i = 0; i < sballcount; ++i)
				{
					if (sball[i] == null)
						continue;
					sball[i].DX = 0;
					sball[i].DY = 0;
				}
				vspeed = 0;
				bar.Flag = true;
			}

			return back;
		}

		private void SoundPlay()
		{
			throw new NotImplementedException();
		}

		private void HitCheckBallAndBlock(Ball ball)
		{
			throw new NotImplementedException();
		}

		private void HitCheckBallAndBar(Ball ball)
		{
			throw new NotImplementedException();
		}

		internal void Reset()
		{
			throw new NotImplementedException();
		}

		public int Bar { get; set; }

		public int Stage { get; set; }

		public int Score { get; set; }

		public int sballcount { get; set; }
	}
}
