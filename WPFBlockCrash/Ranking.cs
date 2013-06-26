using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace WPFBlockCrash
{
    class Ranking
    {
        private DisplayInfo dInfo;
        private ImageSource[] gh;
        private ImageSource newgh;
        public SaveGameData[] saved = new SaveGameData[20];

        public Ranking(int score, int barnum, DisplayInfo dInfo)
        {
            this.dInfo = dInfo;

            try
            {
                rankGh = new BitmapImage(new Uri(Main.ResourceDirectory, "ranking.png"));
                gh = new ImageSource[3];
                gh[0] = new BitmapImage(new Uri(Main.ResourceDirectory, "bar.bmp"));
                gh[1] = new BitmapImage(new Uri(Main.ResourceDirectory, "barsecond.bmp"));
                gh[2] = new BitmapImage(new Uri(Main.ResourceDirectory, "barthird.bmp"));
                newgh = new BitmapImage(new Uri(Main.ResourceDirectory, "new.bmp"));
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
        public void Save(int xscore, int xbarnum)
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
            System.IO.FileStream fs1;
            try { // あれば開く　場所はC:\Users\大輔\Desktop\TSBBC\blockcrash\BlockCrashGUI\bin\Debug
                System.IO.FileStream fs2;
                fs2 = new System.IO.FileStream("savedata.xml", System.IO.FileMode.Open); // 読み込み
                saved = (SaveGameData[])serializer.Deserialize(fs2);
                fs2.Close();
                fs1 = new System.IO.FileStream("savedata.xml", System.IO.FileMode.Create); // 再作成
            }
            catch (Exception e)
            { // 開けなかったらCreate
                fs1 = new System.IO.FileStream("savedata.xml", System.IO.FileMode.Create); //作成
                for (int i = 0; i < 20; ++i)
                { // 配列20
                    saved[i] = new SaveGameData();
                    if (i == 19)
                    { // デバック用に最下位は0を入力
                        saved[i].Score = 0;
                    }
                    else // 数値は最上位が300000,/iでどうです
                        saved[i].Score = 30000 - (i + 1)*1500;
                    // BarNumはランダムで
                    saved[i].BarNum = Main.rand.Next() % 3;
                    saved[i].Year = iYear;
                    saved[i].Month = iMonth;
                    saved[i].Date = iDay;
                }
            }

            SaveGameData oldscore = new SaveGameData();
            SaveGameData newsave = new SaveGameData();
            // 新しいデータを登録 //コンストラクタ作るのめんどかった
            newsave.Score = xscore;
            newsave.BarNum = xbarnum -1;
            newsave.Year = iYear;
            newsave.Month = iMonth;
            newsave.Date = iDay;

            for (int i = 0; i < 20; ++i){ // index0から検索して,xScoreより小さいところまで来たらその番号を保存
                if (saved[i].Score < xscore) {
                    for (int j = i; j < 20; ++j) {
                        if (j == i) { // 番号のところに今回の記録を記入
                            index = j;
                            oldscore = saved[j];
                            saved[j] = newsave;
                        }
                        else { // それ以降のindexは一つずつずらす
                            newsave = oldscore;
                            oldscore = saved[j];
                            saved[j] = newsave;
                            
                        }
                    }
                    break; // 代入したら終了
                }            
            }
            //XMLファイルに保存する
            serializer.Serialize(fs1, saved);
            fs1.Close();
        }

        public bool Process(Input input, DrawingContext dc)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(dc);

            return IsDead;
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
                if (input.lB)
                {
                    if (scorey > 0)
                    {
                        scorey -= 20;
                        scroll = false;
                    }
                }
                if (input.rB)
                {
                    if (scorey < 900)
                    {
                        scorey += 20;
                        scroll = false;
                    }
                }
            }
        }

        private void Draw(DrawingContext dc)
        {
            // ランキング表示
            // 時間経過でスクロール
            for (int i = 0; i < 20; ++i)
            {
                if (i == index) { // 今回の記録
                    DrawUtil.DrawLine(dc, 25, -595 + i * 40 + scorey, 650, -600 + i * 40 + scorey, Color.FromRgb(255, 0, 0));

                    DrawUtil.DrawString(dc, 40, -630 + i * 40 + scorey, string.Format("{0} :", i + 1), Color.FromRgb(255, 255, 100), 32);
                    DrawUtil.DrawString(dc, 150, -630 + i * 40 + scorey, string.Format("{0}", saved[i].Score), Color.FromRgb(255, 255, 100), 32);
                    DrawUtil.DrawGraph(dc, 300, -625 + i * 40 + scorey, gh[saved[i].BarNum]);
                    DrawUtil.DrawString(dc, 450, -630 + i * 40 + scorey, string.Format("{0}/{1}/{2}", saved[i].Year, saved[i].Month, saved[i].Date), Color.FromRgb(255, 255, 100), 32);
                    DrawUtil.DrawGraph(dc, 650, -640 + i * 40 + scorey, newgh);
                }
                else {
                    DrawUtil.DrawLine(dc, 25, -595 + i * 40 + scorey, 650, -600 + i * 40 + scorey, Color.FromRgb(230, 230, 230));

                    DrawUtil.DrawString(dc, 40, -630 + i * 40 + scorey, string.Format("{0} :", i + 1), Color.FromRgb(255, 120, 0), 32);
                    DrawUtil.DrawString(dc, 150, -630 + i * 40 + scorey, string.Format("{0}", saved[i].Score), Color.FromRgb(255, 120, 0), 32);
                    DrawUtil.DrawGraph(dc, 300, -625 + i * 40 + scorey, gh[saved[i].BarNum]);
                    DrawUtil.DrawString(dc, 450, -630 + i * 40 + scorey, string.Format("{0}/{1}/{2}", saved[i].Year, saved[i].Month, saved[i].Date), Color.FromRgb(255, 120, 0), 32);
                }
                
            }
            DrawUtil.DrawGraph(dc, 0, 0, rankGh);
            DrawUtil.DrawString(dc, 40, 220, string.Format("RANK"), Color.FromRgb(255, 255, 255), 32);
            DrawUtil.DrawString(dc, 150, 220, string.Format("SCORE"), Color.FromRgb(255, 255, 255), 32);
            DrawUtil.DrawString(dc, 300, 220, string.Format("BARTYPE"), Color.FromRgb(255, 255, 255), 32);
            DrawUtil.DrawString(dc, 480, 220, string.Format("DATE"), Color.FromRgb(255, 255, 255), 32);

            if (scorey < 900 && scroll)
                scorey += 4 * scrollspeed;
            if (scorey >= 900)
                end = true;
        }

        private ImageSource rankGh;
        public bool IsDead { get; set; }
        public bool selectSoundFlag { get; private set; }
        public bool decisionSoundFlag { get; private set; }
        public bool end { get; private set; }
        public bool scroll { get; private set; }
        private int scrollspeed { get; set; }
        private int scorey { get; set; }
        private int index { get; set; } // 新しい記録の場所を示すインデックス
        private SoundPlayer sh;
        private SoundPlayer dh;

    }
    public class SaveGameData
    {
        //    public string PlayerName; // 名前入力用
        public int Score;
        public int BarNum;
        public int Year;
        public int Month; // 日付用
        public int Date;
    }
}