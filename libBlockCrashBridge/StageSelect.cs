using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace libBlockCrashBridge
{
    class StageSelect
    {
        private bool endflag;
        private int[] bargh;
        private int ballgh;
        private int[] stagegh;
        private int[] sdetailgh;
        private bool[] clear;
        private int sselectgh;
        private int cleargh;
        private bool selectflag;
        private bool decisionflag;
        private int sh;
        private int dh;
        private int keycount;
        private int entercount;
        private int autocount;

        private Input input;

        private void Draw()
        {
            DX.DrawGraph(0, 0, sselectgh, 1); // ステージタイトル表示
            DX.DrawGraph(400, 320, sdetailgh[mstage - 1], 1); // ステージタイトル表示

            switch (mstage)
            { // ステージ詳細表示
                case 1: DX.DrawString(40, 340, "オナジミサン", Color.RGB(255, 120, 0));
                    break;
                case 2: DX.DrawString(40, 340, "４つの塔", Color.RGB(255, 120, 0));
                    break;
                case 3: DX.DrawString(40, 340, "クロスクロス", Color.RGB(255, 120, 0));
                    break;
                case 4: DX.DrawString(40, 340, "円環の理", Color.RGB(255, 120, 0));
                    break;
                case 5: DX.DrawString(40, 340, "製作は私達です。", Color.RGB(255, 120, 0));
                    break;
                // 追加ステージ：時間あったら追加しよう
                /*case 6: DrawString( 40, 340, TEXT("プレイありがとうございます。"), RGB(255,120,0));
                        break;*/
            }
            for (int i = 0; i < 5; ++i)
            {
                DX.DrawGraph(60 + i * 120, 200, stagegh[i], 1); // ステージタイトル表示
            }
            if (clear[mstage - 1])
            {
                DX.DrawGraph(700, 320, cleargh, 1); // ステージタイトル表示
            }

            DX.DrawBox(60 + (mstage - 1) * 120, 200, 160 + (mstage - 1) * 120, 270, Color.RGB(255, 20, 30), 0); // 選択枠表示

            DX.DrawBox(400, 320, 750, 578, Color.RGB(255, 20, 30), 0); // 詳細枠表示

            DX.DrawGraph(40, 460, bargh[mbar - 1], 1); // 選択バー表示

            DX.DrawString(40, 500, string.Format("SCORE: %d", mscore), Color.RGB(255, 120, 0));
            DX.DrawString(40, 540, string.Format("STOCK: %d", mstock), Color.RGB(255, 120, 0));
        }

        private void KeyGet()
        {
            if (input.rB)
            { // 右ボタン
                if (input.AT)
                { // オートモードの場合
                    ++autocount;
                }
                ++mstage;
                if (mstage > 5)
                {
                    mstage = 1;
                }
                input.rB = false;
            }
            if (input.lB)
            { // 左ボタン
                if (input.AT)
                { // オートモードの場合
                    ++autocount;
                }
                --mstage;
                if (mstage < 1)
                {
                    mstage = 5;
                }
                input.lB = false;
            }
            if (input.AT)
            { // オートモードの場合
                if (input.eB && autocount > 10)
                { // 決定ボタン
                    endflag = true;
                    input.eB = false;
                    autocount = 0;
                }
            }
            else if (input.eB)
            { // 決定ボタン
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

        public StageSelect(Input input)
        {
            this.input = input;
            mstage = 1;
            keycount = 8;

            bargh = new int[3];
            bargh[0] = DX.LoadGraph("bar.bmp"); // バー１
            bargh[1] = DX.LoadGraph("barsecond.bmp"); // バー２
            bargh[2] = DX.LoadGraph("barthird.bmp"); // バー３

            ballgh = DX.LoadGraph("ball_b.png"); // 残機表示

            stagegh = new int[6];
            stagegh[0] = DX.LoadGraph("stage1mini.png"); // ステージ１
            stagegh[1] = DX.LoadGraph("stage2mini.png"); // ステージ２
            stagegh[2] = DX.LoadGraph("stage3mini.png"); // ステージ３
            stagegh[3] = DX.LoadGraph("stage4mini.png"); // ステージ４
            stagegh[4] = DX.LoadGraph("stage5mini.png"); // ステージ５
            stagegh[5] = DX.LoadGraph("ball_a.png"); // ステージ５

            sdetailgh = new int[6];
            sdetailgh[0] = DX.LoadGraph("stage1.png"); // ステージ１詳細
            sdetailgh[1] = DX.LoadGraph("stage2.png"); // ステージ２詳細
            sdetailgh[2] = DX.LoadGraph("stage3.png"); // ステージ３詳細
            sdetailgh[3] = DX.LoadGraph("stage4.png"); // ステージ４詳細
            sdetailgh[4] = DX.LoadGraph("stage5.png"); // ステージ５詳細
            sdetailgh[5] = DX.LoadGraph("ball_a.png"); // ステージ６詳細

            sselectgh = DX.LoadGraph("stageselect.png"); // ステージセレクトタイトル
            cleargh = DX.LoadGraph("clearstar.png"); // クリア表示

            selectflag = false;
            decisionflag = false;

            endflag = false;

            //音声ファイル読み込み。
            sh = DX.LoadSoundMem("bound.wav");
            dh = DX.LoadSoundMem("demolish.wav");

            clear = new bool[6];
            for (int i = 0; i < 6; ++i)
            {
                clear[i] = false;
            }
            mscore = 0;
            mstock = 2;
            mbar = 1;

            entercount = 0;
            // オート入力の遊び
            autocount = 0;
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
            for (int i = 0; i < 5; ++i)
            {
                clear[i] = false;
            }
            mscore = 0;
            mstock = 2;
        }

        public void SetValue(int bar, int stage, int score, int stock)
        {
            mbar = bar;
            clear[stage - 1] = true;
            mscore = score;
            mstock = stock;
        }

        public int mscore;
        public int mstock;
        public int mstage;
        public int mbar;
    }
}
