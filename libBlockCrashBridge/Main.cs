using DxLibDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBlockCrashBridge
{
    class Main
    {
        private StageSelect stageselect;
        private Control control;
        private Message message;
        private BarSelect barselect;
        private Title title;
        private int m_actcount;
        private int act;
        private int stock;
        private bool keycheck;
        private bool automode;
        private Input input;

        const int WIDTH = 800;
        const int HEIGHT = 600;
        const int REFRESHRATE = 16;
        
        private void ReStart()
        {
            input.Clear();

            title = new Title();
            barselect = new BarSelect();
            stageselect = new StageSelect();
            act = 0;
            stock = 0;
            keycheck = true;
            automode = false;

            switch (m_actcount)
            {
                case 0:
                    break;
                case 1:
                    barselect.SetFlag(false);
                    break;
                case 2:
                    barselect.SetFlag(false);
                    stageselect.SetFlag(false);
                    control = null;
                    break;
            }
            m_actcount = 0;
        }

        private void ATMode()
        {
            if (input.AT)
            {
                if (c < 15)
                    ++c;
                else
                {
                    c = 0;

                    /* 乱数系列の変更 */
                    Random rand = new Random(Environment.TickCount);

                    int r = rand.Next() % 3;

                    if (r == 0)
                        input.RB = true;
                    if (r == 1)
                        input.LB = true;
                    if (r == 2)
                        input.EB = true;
                }
            }
        }

        private int c;
        private bool dxlib;

        public bool All()
        {
            while (DX.ScreenFlip() == 0
                && DX.ProcessMessage() == 0
                && DX.ClearDrawScreen() == 0
                && dxlib == true)
            {
                if (input.AT)
                {
                    //自動化状態
                    ATMode();
                    automode = true;
                    input.Key = true;
                }

                if (automode && input.AT == false)
                {
                    //自動化解除
                    ReStart();
                }

                if (input.Key == true)
                {
                    if (keycheck)
                    {
                        input.rB = input.RB;
                        input.lB = input.LB;
                        input.eB = input.EB;
                        input.RB = input.LB = input.EB = false;
                        keycheck = false;
                    }
                }

                if (m_actcount == 0)
                {
                    if (title.All()) //title.All() は選択終了でtrueを返す
                    {
                        m_actcount = 1;
                    }
                    input.rB = input.lB = input.eB = false;
                }

                if (m_actcount == 1)
                {
                    if (barselect.All()) //barselect.All() は選択終了でtrueを返す
                    {
                        stageselect.SetValue(barselect.mbar, 0, 0, 2);
                        m_actcount = 2;
                    }
                    input.rB = input.lB = input.eB = false;
                }

                if (m_actcount == 2)
                {
                    if (stageselect.All())
                    {
                        m_actcount = 3;
                        stock = stageselect.mstock;
                        control = new Control(stageselect.mbar, stageselect.mstage, stageselect.mscore, stock);
                    }
                    input.rB = input.lB = input.eB = false;
                }

                if (m_actcount == 3)
                {
                    if (control.All()) //control.All() は残機がなくなるとtrueを返す
                    {
                        stock = control.GetStock();

                        if (stock > 1)
                        {
                            if (act == 0)
                            {
                                message = new Message(1, 50);
                                ++act;
                            }

                            if (message.All()) //ミス
                            {
                                control.Reset();
                                --stock;
                                act = 0;
                                message = null;
                            }
                        }
                        else
                        {
                            if (act == 0)
                            {
                                message = new Message(3, 200);
                                ++act;
                            }

                            if (message.All()) //ゲームオーバー
                            {
                                m_actcount = 0;
                                act = 0;
                                stageselect.Reset();
                                stageselect.SetFlag(false);
                                message = null;
                                control = null;
                            }
                        }
                    }
                    else if (control.clear)
                    {
                        if (act == 0)
                        {
                            message = new Message(2, 200);
                            ++act;
                        }

                        if (message.All()) //クリア
                        {
                            if (input.AT)
                            {
                                m_actcount = 1;
                                barselect.SetFlag(false);
                            }
                            else
                            {
                                m_actcount = 2;
                                stageselect.SetValue(control.GetBar(), control.GetStage(), control.GetScore(), control.GetStock());
                            }
                            act = 0;
                            stageselect.SetFlag(false);
                            message = null;
                            control = null;
                        }
                    }
                }
                keycheck = true;
                input.rB = input.lB = input.eB = false;
            }

            //Dxライブラリ終了
            DX.DxLib_End();

            stageselect = null;
            barselect = null;

            return false;
        }

        public Main(Input input)
        {
            this.input = input;

            DX.ChangeWindowMode(1);

            dxlib = true;

            //DXライブラリ初期化
            if (DX.DxLib_Init() == -1)
                dxlib = false;

            //画面の大きさを変更
            DX.SetGraphMode(WIDTH, HEIGHT, REFRESHRATE);

            //裏画面に描画
            DX.SetDrawScreen(DX.DX_SCREEN_BACK);

            //キーボードの状態を取得
            title = new Title();
            barselect = new BarSelect();
            stageselect = new StageSelect();
            m_actcount = 0;
            act = 0;
            stock = 0;
            keycheck = true;
            automode = false;
            c = 0;
        }

        public void KeyCheck()
        {
            throw new NotImplementedException();
        }
    }
}
