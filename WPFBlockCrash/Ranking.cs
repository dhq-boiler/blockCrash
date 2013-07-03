using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace WPFBlockCrash
{
    class Ranking : IInputable
    {
        private DisplayInfo dInfo;
        private Image[] gh;
        private Image newgh;
        public SaveGameData[] saved = new SaveGameData[20];
        private Image rankGh;
        public bool IsDead { get; set; }
        public bool selectSoundFlag { get; private set; }
        public bool decisionSoundFlag { get; private set; }
        public bool end { get; private set; }
        private bool scroll;
        private int scrollspeed { get; set; }
        private int scorey;
        private int index { get; set; } // 新しい記録の場所を示すインデックス
        private SoundPlayer sh;
        private SoundPlayer dh;

        private IOperator Operator;
        private readonly Font font = new Font("Consolas", 20);

        public Ranking(int score, EBarType barnum, DisplayInfo dInfo, IOperator Operator)
        {
            this.dInfo = dInfo;
            this.Operator = Operator;

            try
            {
                rankGh = new Bitmap(Main.ResourceDirectory + "ranking.png");
                gh = new Image[3];
                gh[0] = new Bitmap(Main.ResourceDirectory + "bar.bmp");
                gh[1] = new Bitmap(Main.ResourceDirectory + "barsecond.bmp");
                gh[2] = new Bitmap(Main.ResourceDirectory + "barthird.bmp");
                newgh = new Bitmap(Main.ResourceDirectory + "new.bmp");
            }
            catch (Exception e)
            {

            }
            selectSoundFlag = false;
            decisionSoundFlag = false;
            IsDead = false;
            scrollspeed = 1;
            end = false;
            scorey = 0;
            scroll = true;
            index = -1; // 配列の一番最初は添え字が0なため

            Save(score, barnum);

            sh = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
            dh = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");
        }

        // セーブデータ作成
        public void Save(int xscore, EBarType xbarnum)
        {

            // 日付取得
            // 数値を入れる。日付は作成日
            // 必要な変数を宣言する
            DateTime dtNow = DateTime.Now;
            // 年 (Year) を取得する
            int iYear = dtNow.Year;
            // 月 (Month) を取得する
            int iMonth = dtNow.Month;
            // 日 (Day) を取得する
            int iDay = dtNow.Day;

            // Saveファイルを開く
            //保存した内容を復元する
            XmlSerializer serializer = new XmlSerializer(typeof(SaveGameData[]));
            System.IO.FileStream fs1 = null;

            try
            {
                try
                {
                    System.IO.FileStream fs2 = null;
                    try
                    {
                        // あれば開く　場所はC:\Users\大輔\Desktop\TSBBC\blockcrash\BlockCrashGUI\bin\Debug
                        fs2 = new System.IO.FileStream("savedata.xml", System.IO.FileMode.Open); // 読み込み
                        saved = (SaveGameData[])serializer.Deserialize(fs2);
                    }
                    finally
                    {
                        if (fs2 != null)
                            fs2.Close();
                    }
                    fs1 = new System.IO.FileStream("savedata.xml", System.IO.FileMode.Create); // 再作成
                }
                catch (Exception e)
                {
                    // 開けなかったらCreate
                    fs1 = new System.IO.FileStream("savedata.xml", System.IO.FileMode.Create); //作成
                    for (int i = 0; i < 20; ++i) // 配列20
                    {
                        saved[i] = new SaveGameData();
                        if (i == 19) // デバック用に最下位は0を入力
                        {
                            saved[i].Score = 0;
                        }
                        else // 数値は最上位が30000,
                            saved[i].Score = 30000 - (i + 1) * 1500;

                        // BarNumはランダムで
                        EBarType bt = (EBarType)(Main.rand.Next() % 3 + 1);
                        saved[i].BarNum = bt;
                        saved[i].Year = iYear;
                        saved[i].Month = iMonth;
                        saved[i].Date = iDay;
                    }
                }

                SaveGameData oldscore = new SaveGameData();
                SaveGameData newsave = new SaveGameData();
                // 新しいデータを登録 //コンストラクタ作るのめんどかった
                newsave.Score = xscore;
                //newsave.BarNum = xbarnum -1;
                newsave.BarNum = xbarnum;
                newsave.Year = iYear;
                newsave.Month = iMonth;
                newsave.Date = iDay;

                List<SaveGameData> saveGames = new List<SaveGameData>(saved);
                saveGames.Add(newsave);
                var DescendingOrder = saveGames.OrderByDescending(a => a.Score).Take(20);
                index = new List<SaveGameData>(DescendingOrder).FindIndex(a => Object.ReferenceEquals(newsave, a));
                saved = DescendingOrder.ToArray();

                //for (int i = 0; i < 20; ++i)// index0から検索して,xScoreより小さいところまで来たらその番号を保存
                //{ 
                //    if (saved[i].Score < xscore) 
                //    {
                //        for (int j = i; j < 20; ++j)
                //        {
                //            if (j == i)// 番号のところに今回の記録を記入
                //            { 
                //                index = j;
                //                oldscore = saved[j];
                //                saved[j] = newsave;
                //            }
                //            else // それ以降のindexは一つずつずらす
                //            { 
                //                newsave = oldscore;
                //                oldscore = saved[j];
                //                saved[j] = newsave;
                //            }
                //        }
                //        break; // 代入したら終了
                //    }            
                //}
                //XMLファイルに保存する
                //serializer.Serialize(fs1, saved);
                serializer.Serialize(fs1, saved);
            }
            finally
            {
                if (fs1 != null)
                    fs1.Close();
            }
        }

        public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(g);

            if (IsDead)
                return new ProcessResult() { IsDead = IsDead, NextState = new Title(dInfo, Operator) };
            else
                return new ProcessResult() { IsDead = IsDead, NextState = this };
        }

        private void KeyGet(Input input)
        {
            if (input.eB)
            {
                if (end || !scroll)
                {
                    IsDead = true;
                }
                else
                    scrollspeed = 2;
            }
            else
                scrollspeed = 1;

            if (!input.AT)
            {
                Operator.ScrollRanking(input, ref scorey, ref scroll);

                //if (input.lB)
                //{
                //    if (scorey > 0)
                //    {
                //        scorey -= 20;
                //        scroll = false;
                //    }
                //}

                //if (input.rB)
                //{
                //    if (scorey < 900)
                //    {
                //        scorey += 20;
                //        scroll = false;
                //    }
                //}
            }
        }

        private void Draw(Graphics g)
        {
            // ランキング表示
            // 時間経過でスクロール
            for (int i = 0; i < 20; ++i)
            {
                if (i == index)
                { // 今回の記録
                    g.DrawLine(new System.Drawing.Pen(DrawUtil.BrushRGB(255, 0, 0)), 25, -635 + i * 40 + scorey, 650, -635 + i * 40 + scorey);

                    g.DrawString(string.Format("{0}：", i + 1), font, DrawUtil.BrushRGB(255, 255, 100), 40, -670 + i * 40 + scorey);
                    g.DrawString(string.Format("{0}", saved[i].Score), font, DrawUtil.BrushRGB(255, 255, 100), 150, -670 + i * 40 + scorey);
                    g.DrawImage(gh[(int)saved[i].BarNum - 1], 300, -665 + i * 40 + scorey);
                    g.DrawString(string.Format("{0}/{1}/{2}", saved[i].Year, saved[i].Month, saved[i].Date), font, DrawUtil.BrushRGB(255, 255, 100), 450, -670 + i * 40 + scorey);
                    g.DrawImage(newgh, 650, -680 + i * 40 + scorey);
                }
                else {
                    g.DrawLine(new System.Drawing.Pen(DrawUtil.BrushRGB(230, 230, 230)), 25, -635 + i * 40 + scorey, 650, -635 + i * 40 + scorey);
                    g.DrawString(string.Format("{0} :", i + 1), font, DrawUtil.BrushRGB(255, 120, 0), 40, -670 + i * 40 + scorey);
                    g.DrawString(string.Format("{0}", saved[i].Score), font, DrawUtil.BrushRGB(255, 120, 0), 150, -670 + i * 40 + scorey);
                    g.DrawImage(gh[(int)saved[i].BarNum - 1], 300, -665 + i * 40 + scorey);
                    g.DrawString(string.Format("{0}/{1}/{2}", saved[i].Year, saved[i].Month, saved[i].Date), font, DrawUtil.BrushRGB(255, 120, 0), 450, -670 + i * 40 + scorey);
                }
                
            }

            g.DrawImage(rankGh, 0, 0);
            g.DrawString("RANK", font, DrawUtil.BrushRGB(255, 255, 255), 40, 180);
            g.DrawString("SCORE", font, DrawUtil.BrushRGB(255, 255, 255), 150, 180);
            g.DrawString("BARTYPE", font, DrawUtil.BrushRGB(255, 255, 255), 300, 180);
            g.DrawString("DATE", font, DrawUtil.BrushRGB(255, 255, 255), 480, 180);

            if (scorey < 900 && scroll)
                scorey += 4 * scrollspeed;
            if (scorey >= 900)
                end = true;
        }
    }

    public class SaveGameData
    {
        //    public string PlayerName; // 名前入力用
        public int Score;
        public EBarType BarNum;
        public int Year;
        public int Month; // 日付用
        public int Date;
    }
}