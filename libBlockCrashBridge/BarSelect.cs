using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace libBlockCrashBridge
{
	class BarSelect
	{
		private bool endflag;
		private int[] bargh;
		private int bselectgh;
		private bool selectflag;
		private bool decisionflag;
		private int sh;
		private int dh;
		private int keycount;
		private int autocount;
		private Input input;

		private void Draw()
		{
			DX.DrawGraph(30, 0, bselectgh, 1); //バータイトル表示

			switch (mbar) //バー詳細表示
			{
				case 1:
					DX.DrawString(440, 240, "BAR NAME：", Color.RGB(255,180,0));
					DX.DrawString(560, 240, "ノーマルバー", Color.RGB(255, 255, 128));
					DX.DrawString(440, 300, "BALL SPEED：", Color.RGB(255, 180, 0));
					DX.DrawString(570, 300, "★", Color.RGB(255, 180, 128));
					DX.DrawString(440, 360, "TECHNICAL：", Color.RGB(255, 180, 0));
					DX.DrawString(570, 360, "★", Color.RGB(255, 180, 128));
					DX.DrawString(440, 420, "DIFFICULTY：", Color.RGB(255, 180, 0));
					DX.DrawString(570, 420, "★", Color.RGB(255, 180, 128));
					break;
				case 2:
					DX.DrawString(440, 240, "BAR NAME：", Color.RGB(255,180,0));
					DX.DrawString(560, 240, "２号機", Color.RGB(255, 255, 128));
					DX.DrawString(440, 300, "BALL SPEED：", Color.RGB(255, 180, 0));
					DX.DrawString(570, 300, "★　★　★", Color.RGB(255, 180, 128));
					DX.DrawString(440, 360, "TECHNICAL：", Color.RGB(255, 180, 0));
					DX.DrawString(570, 360, "★　★", Color.RGB(255, 180, 128));
					DX.DrawString(440, 420, "DIFFICULTY：", Color.RGB(255, 180, 0));
					DX.DrawString(570, 420, "★　★", Color.RGB(255, 180, 128));
					break;
				case 3:
					DX.DrawString( 440, 240, "BAR NAME：", Color.RGB(255,180,0));
					DX.DrawString( 560, 240, "３つめ", Color.RGB(255,255,128));
					DX.DrawString( 440, 300, "BALL SPEED：", Color.RGB(255,180,0));
					DX.DrawString( 570, 300, "★　★　★　★　★", Color.RGB(255,0,128));
					DX.DrawString( 440, 360, "TECHNICAL：", Color.RGB(255,180,0));
					DX.DrawString( 570, 360, "★　★　★", Color.RGB(255,0,128));
					DX.DrawString( 440, 420, "DIFFICULTY：", Color.RGB(255,180,0));
					DX.DrawString( 570, 420, "★　★　★　★　★", Color.RGB(255,0,128));
					break;
			}

			for (int i = 0; i < 3; ++i)
			{
				if (i == 2)
					DX.DrawGraph(125, 200 + i * 120, bargh[i], 1); //ミニバー種類表示
				else
					DX.DrawGraph(100, 200 + i * 120, bargh[i], 1); //バー種類表示
			}

			DX.DrawBox(80, 190 + (mbar - 1) * 120, 220, 224 + (mbar - 1) * 120, Color.RGB(255, 20, 30), 0); //選択枠表示
			DX.DrawBox(400, 220, 750, 478, Color.RGB(255, 20, 30), 0); //詳細枠表示
		}

		private void KeyGet()
		{
			if (input.rB) //右ボタン
			{
				if (input.AT) //オートモード
				{
					++autocount;
				}
				++mbar;
				if (mbar > 3)
				{
					mbar = 1;
				}
				input.rB = false;
			}

			if (input.lB) //左ボタン
			{
				if (input.AT)
				{
					++autocount;
				}
				--mbar;
				if (mbar < 1)
				{
					mbar = 3;
				}
				input.lB = false;
			}

			if (input.AT) //オートモードの場合
			{
				if (input.eB && autocount > 10) //決定ボタン
				{
					endflag = true;
					input.eB = false;
					autocount = 0;
				}
			}
			else if (input.eB) //決定ボタン
			{
				endflag = true;
				input.eB = false;
			}
		}

		public bool All()
		{
			//キー処理
			KeyGet();

			//描画処理
			Draw();

			return endflag;
		}

		public BarSelect(Input input)
		{
            this.input = input;
			mbar = 1;
			keycount = 8; //キーボード入力の場合に必要

            bargh = new int[3];
			bargh[0] = DX.LoadGraph("bar.bmp"); //バー１
			bargh[1] = DX.LoadGraph("barsecond.bmp"); //バー２
			bargh[2] = DX.LoadGraph("barthird.bmp"); //バー３

			bselectgh = DX.LoadGraph("barselect.png");

			selectflag = false;
			decisionflag = false;

			endflag = false;

			autocount = 0;

			//音声ファイル読み込み
			sh = DX.LoadSoundMem("bound.wav");
			dh = DX.LoadSoundMem("demolish.wav");
		}

		public void SetFlag(bool flag)
		{
			endflag = flag;
		}

		public bool GetFlag()
		{
			return endflag;
		}

		public void Reset()
		{
			mbar = 1;
		}

		public void SetValue(int bar, int stage, int score, int stock)
		{
			throw new NotImplementedException();
		}

		public int mbar;
	}
}
