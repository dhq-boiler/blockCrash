using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    static class CollisionDetection
    {
        public static void HitCheckBallAndBlock(Ball ball, Bar bar, Block[] block, ref bool demolishFlag, int sumblock, ref int vspeed, ref int combocount, ref int Score, Action<EItemType, int, int> ItemEffect)
        {
            demolishFlag = false;

            int ballX = ball.CenterX;
            int ballY = ball.CenterY;
            int ballHeight = ball.Height;
            int ballWidth = ball.Width;

            for (int i = 0; i < sumblock; ++i)
            {
                if (!block[i].IsDead)
                {
                    int blockendX = 0;
                    int blockX = block[i].CenterX;
                    int blockY = block[i].CenterY;
                    int blockWidth = block[i].Width;
                    int blockHeight = block[i].Height;

                    if (blockX - blockWidth / 2 < 0)
                        blockendX = blockX - blockWidth / 2 + 800;
                    if (blockX + blockWidth / 2 >= 800)
                        blockendX = blockX + blockWidth / 2 - 800;

                    for (int j = 0; j < 2; ++j)
                    {
                        if (ballX < blockX + blockWidth / 2
                            && ballX > blockX - blockWidth / 2
                            && ballY + ballHeight / 2 > blockY - blockHeight / 2
                            && ballY + ballHeight / 2 < blockY + blockHeight / 2)
                        {
                            vspeed = 0;

                            block[i].IsDead = true;
                            demolishFlag = true;

                            if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                                ball.DY = -ball.DY;
                        }
                        else if (ballX < blockX + blockWidth / 2
                            && ballX > blockX - blockWidth / 2
                            && ballY - ballHeight / 2 > blockY - blockHeight / 2
                            && ballY - ballHeight / 2 < blockY + blockHeight / 2)
                        {
                            vspeed = 0;

                            block[i].IsDead = true;
                            demolishFlag = true;
                            if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                                ball.DY = -ball.DY;
                        }
                        else if (ballX + ballWidth / 2 < blockX - blockWidth / 2 + ballWidth
                            && ballX + ballWidth / 2 > blockX - blockWidth / 2
                            && ballY > blockY - blockHeight / 2
                            && ballY < blockY + blockHeight / 2)
                        {
                            vspeed = 0;

                            block[i].IsDead = true;
                            demolishFlag = true;
                            if (ball.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                                ball.DX = -ball.DX;
                        }
                        else if (ballX - ballWidth / 2 < blockX + blockWidth / 2
                            && ballX - ballWidth / 2 > blockX + blockWidth / 2 - ballWidth
                            && ballY > blockY - blockHeight / 2
                            && ballY < blockY + blockHeight / 2)
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
                    int blockX = block[i].CenterX;
                    int blockY = block[i].CenterY;
                    int blockWidth = block[i].Width;
                    int blockHeight = block[i].Height;

                    if (blockX - blockWidth / 2 < 0)
                        blockendX = blockX - blockWidth / 2 + 800;
                    if (blockX + blockWidth / 2 >= 800)
                        blockendX = blockX + blockWidth / 2 - 800;

                    for (int j = 0; j < 2; ++j)
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
            }
        }

        public static void HitCheckBallAndBar(Ball ball, Bar bar, Graphics g, EBarType BarType, bool ballcatch, ref bool boundFlag, ref int combocount, Font font)
        {
            boundFlag = false;

            boundFlag = ball.PlaySound;

            int barCX = bar.CenterX;
            int barCY = bar.CenterY;
            int ballCX = ball.CenterX;
            int ballCY = ball.CenterY;
            int ballHeight = ball.Height;
            int ballWidth = ball.Width;
            int barHeight = bar.Height;
            int barWidth = bar.Width;

            bool IsOverlappedVertical = Math.Abs(barCY - ballCY) < ballHeight / 2 + barHeight / 2;
            bool IsOverlappedHorizontal = Math.Abs(barCX - ballCX) < ballWidth / 2 + barWidth / 2;

            if (IsOverlappedVertical && IsOverlappedHorizontal)
            {
                double OverlapDistanceX = double.MaxValue;
                double OverlapDistanceY = double.MaxValue;

                if (barCY < ballCY)
                    OverlapDistanceY = (ball.Top - bar.Bottom) / (double)bar.Height;
                else if (barCY > ballCY)
                    OverlapDistanceY = (bar.Top - ball.Bottom) / (double)bar.Height;

                if (barCX < ballCX)
                    OverlapDistanceX = (ball.Left - bar.Right) / (double)bar.Width;
                else
                    OverlapDistanceX = (bar.Left - ball.Right) / (double)bar.Width;

                g.DrawString(string.Format("ODX:{0}", OverlapDistanceX), font, DrawUtil.BrushRGB(255, 120, 0), 20, 480);
                g.DrawString(string.Format("ODY:{0}", OverlapDistanceY), font, DrawUtil.BrushRGB(255, 120, 0), 20, 520);

                if (OverlapDistanceY < 0d && OverlapDistanceY < OverlapDistanceX)
                    ReflectVerticalIfOverlapped(ball, bar, BarType, ballcatch, ref combocount, ref boundFlag);
                else if (OverlapDistanceX < 0d && OverlapDistanceY >= OverlapDistanceX)
                    ReflectHorizontalIfOverlapped(ball, bar, ref boundFlag);
            }
        }

        private static void ReflectHorizontalIfOverlapped(Ball ball, Bar bar, ref bool boundFlag)
        {
            if (bar.CenterY + bar.Height / 2 > ball.CenterY
                && bar.CenterY - bar.Height / 2 < ball.CenterY)
            {
                ReflectHorizontal(ball, ref boundFlag);
            }
        }

        private static void ReflectVerticalIfOverlapped(Ball ball, Bar bar, EBarType BarType, bool ballcatch, ref int combocount, ref bool boundFlag)
        {
            if (bar.Right > ball.CenterX && bar.Left < ball.CenterX)
            {
                ReflectVertical(ball, bar, BarType, ballcatch, ref combocount, ref boundFlag);
            }
        }

        private static void ReflectHorizontal(Ball ball, ref bool boundFlag)
        {
            ball.DX = -ball.DX;
            ball.CenterX += ball.DX;

            boundFlag = true;
        }

        private static void ReflectVertical(Ball ball, Bar bar, EBarType BarType, bool ballcatch, ref int combocount, ref bool boundFlag)
        {
            ball.Radius = 20;

            if (ballcatch)// ボールがバーにくっつく状態
            {
                ball.DX = ball.DY = 0;
                ball.IsStop = true;
                if (ball.IsStop) // ＋なら右に，ーなら左にずれてる
                    ball.xoffset = ball.CenterX - bar.MX;
                combocount = 0;
                bar.IsMove = false;
            }
            else if (ball.CenterX < bar.CenterX - bar.Width / 2 * 2 / 3 && ball.CenterX > bar.CenterX + bar.Width / 2 * 2 / 3)
            {
                combocount = 0;
                bar.IsMove = false;
                if (BarType == EBarType.SHORT)
                    ball.LvUp(1);

                ball.DX = -ball.DX;
                ball.DY = -ball.DY;
                ball.CenterY = ball.CenterY - 5;

                boundFlag = true;
            }
            else
            {
                if (ball.CenterX < bar.CenterX + 10 && ball.CenterX > bar.CenterX - 10)
                {
                    ball.Penetration();
                    ball.LvUp(1); // 速度が上がって短時間貫通化
                }

                combocount = 0;
                bar.IsMove = false;
                if (BarType == EBarType.SHORT)
                    ball.LvUp(1);
                ball.DY = -ball.DY;
                ball.CenterY = ball.CenterY - 5;
                boundFlag = true;
            }
        }
    }
}
