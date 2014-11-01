using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    static class Collision
    {
        public static bool IsOverlapping(Bar bar, Ball ball)
        {
            bool IsOverlappedVertical = Math.Abs(bar.CenterY - ball.CenterY) < (bar.Height + ball.Height) / 2;
            if (!IsOverlappedVertical) return IsOverlappedVertical;
            bool IsOverlappedHorizontal = Math.Abs(bar.CenterX - ball.CenterX) < (bar.EnlargedWidth + ball.Width) / 2;
            return IsOverlappedHorizontal;
        }

        public static bool BallsIsOverlapping(Ball ball1, Ball ball2)
        {
            return Math.Pow(ball1.CenterX - ball2.CenterX, 2) + Math.Pow(ball1.CenterY - ball2.CenterY, 2) <= Math.Pow(20, 2);
        }

        public static Tuple<double, double> BounceCalculate(double mass_ball1, double mass_ball2, double v1, double v2)
        {
            double newV1 = (-v1 + v2) * (1 + Main.ElasticCoefficient) / (mass_ball1 / mass_ball2 + 1) + v1;
            double newV2 = (-v2 + v1) * (1 + Main.ElasticCoefficient) / (mass_ball2 / mass_ball1 + 1) + v2;
            return new Tuple<double, double>(newV1, newV2);
        }

        public static void ReflectVertical(Ball ball, Bar bar, EBarType BarType)
        {
            if (Main.CatchBallEnables && bar.IsBallCatch)// ボールがバーにくっつく状態
            {
                ball.IsCatching = true;
                ball.DX = ball.DY = 0;
                ball.IsStop = true;
                if (ball.IsStop) // ＋なら右に，ーなら左にずれてる
                    ball.CatchXOffset = ball.CenterX - bar.CenterX;
                bar.IsMove = false;
            }
            else if (ball.CenterX < bar.CenterX - bar.EnlargedWidth / 2 * 2 / 3
                && ball.CenterX > bar.CenterX + bar.EnlargedWidth / 2 * 2 / 3)
            {
                bar.IsMove = false;
                if (BarType == EBarType.SHORT)
                    ball.LvUp(1);

                ball.DY = -ball.DY;
                ball.CenterY = ball.CenterY - 5;

                Console.WriteLine("Reflect Vertical " + (ball.DY > 0 ? "↓" : "↑"));
            }
            else
            {
                if (ball.CenterX < bar.CenterX + 10 && ball.CenterX > bar.CenterX - 10)
                {
                    ball.Penetration();
                    ball.LvUp(1); // 速度が上がって短時間貫通化
                }

                bar.IsMove = false;
                if (BarType == EBarType.SHORT)
                    ball.LvUp(1);
                ball.DY = -ball.DY;
                ball.CenterY = ball.CenterY - 5;

                Console.WriteLine("Reflect Vertical " + (ball.DY > 0 ? "↓" : "↑"));
            }
        }

        public static void ReflectHorizontal(ref int ballDX, ref int ballDY, ref int ballCX, ref bool boundFlag)
        {
            ballDX = -ballDX;
            ballCX += ballDX;

            boundFlag = true;
            Debug.WriteLine("ReflectHorizontal " + (ballDX > 0 ? "→" : "←"));
        }

        public static void ReflectHorizontal(Ball ball)
        {
            ball.DX = -ball.DX;
            ball.CenterX += ball.DX;
            Console.WriteLine("ReflectHorizontal " + (ball.DX > 0 ? "→" : "←"));
        }

        private static void ReflectHorizontal(Ball ball, Bar bar, int barAccel)
        {
            ball.DX = -(ball.DX + barAccel);
            ball.CenterX += ball.DX;
            Debug.WriteLine("ReflectHorizontal " + (ball.DX > 0 ? "→" : "←"));
        }

        public static void ReflectHorizontalIfOverlapped(Ball ball, Block block)
        {
            if (ball.Right > block.Left && ball.Left < block.Left) //ブロックの左辺で重なり反射
            {
                if (ball.DX < 0)
                {
                    Debug.Write("Accelerate " + ball.DX);
                    ball.DX = (int)(ball.DX + block.DX * 2);
                    Debug.WriteLine(" → " + ball.DX);
                }
                else
                {
                    ReflectHorizontal(ball);
                }
            }
            else if (ball.Left < block.Right && ball.Right > block.Right) //ブロックの右辺で重なり反射
            {
                if (ball.DX > 0)
                {
                    Debug.Write("Accelerate " + ball.DX);
                    ball.DX = (int)(ball.DX + block.DX * 2);
                    Debug.WriteLine(" → " + ball.DX);
                }
                else
                {
                    ReflectHorizontal(ball);
                }
            }
        }

        public static void ReflectHorizontalIfOverlapped(int ballTop, int ballBottom, int ballLeft, int ballRight, ref int ballDX, ref int ballDY, ref int ballCX,
            int blockTop, int blockBottom, int blockLeft, int blockRight, ref int blockDX,
            ref bool boundFlag)
        {
            if (ballRight > blockLeft && ballLeft < blockLeft) //ブロックの左辺で重なり反射
            {
                if (ballDX < 0)
                {
                    Debug.Write("Accelerate " + ballDX);
                    ballDX = (int)(ballDX + blockDX * 2);
                    Debug.WriteLine(" → " + ballDX);
                }
                else
                {
                    ReflectHorizontal(ref ballDX, ref ballDY, ref ballCX, ref boundFlag);
                }
            }
            else if (ballLeft < blockRight && ballRight > blockRight) //ブロックの右辺で重なり反射
            {
                if (ballDX > 0)
                {
                    Debug.Write("Accelerate " + ballDX);
                    ballDX = (int)(ballDX + blockDX * 2);
                    Debug.WriteLine(" → " + ballDX);
                }
                else
                {
                    ReflectHorizontal(ref ballDX, ref ballDY, ref ballCX, ref boundFlag);
                }
            }
        }


        public static void ReflectVerticalIfOverlapped(Ball ball, Block block)
        {
            if (ball.Bottom > block.Top && ball.Top < block.Top) //ブロックの上辺で反射
            {
                if (ball.DY < 0)
                {
                    Debug.WriteLine("Accelerate " + ball.DY);
                    ball.DY = (int)(ball.DY * 1.2);
                    Debug.WriteLine(" → " + ball.DY);
                }
                else
                {
                    ReflectVertical(ball);
                }
            }
            else if (ball.Top < block.Bottom && block.Bottom < ball.Bottom) //ブロックの下辺で反射
            {
                if (ball.DY > 0)
                {
                    Debug.WriteLine("Accelerate " + ball.DY);
                    ball.DY = (int)(ball.DY * 1.2);
                    Debug.WriteLine(" → " + ball.DY);
                }
                else
                {
                    ReflectVertical(ball);
                }
            }
        }

        private static void ReflectVertical(Ball ball)
        {
            ball.DY = -ball.DY;
        }

        private static void ReflectVertical(ref int ballDY, ref bool boundFlag)
        {
            ballDY = -ballDY;
            boundFlag = true;
        }

        public static void ReflectHorizontalIfOverlapped(Ball ball, Bar bar, int barAccel, ref bool ReflectEnableByBar)
        {
            if (ball.Right > bar.Left && ball.Left < bar.Left) //バーの左辺で重なり反射
            {
                if (ball.DX < 0 && barAccel < 0)
                {
                    Debug.Write("Accelerate " + ball.DX);
                    ball.DX = (int)(ball.DX + barAccel * 2);
                    Debug.WriteLine(" → " + ball.DX);
                }
                else
                {
                    ReflectHorizontal(ball, bar, barAccel);
                }
                ReflectEnableByBar = false;
            }
            else if (ball.Left < bar.Right && ball.Right > bar.Right) //バーの右辺で重なり反射
            {
                if (ball.DX > 0 && barAccel > 0)
                {
                    Debug.Write("Accelerate " + ball.DX);
                    ball.DX = (int)(ball.DX + barAccel * 2);
                    Debug.WriteLine(" → " + ball.DX);
                }
                else
                {
                    ReflectHorizontal(ball, bar, barAccel);
                }
                ReflectEnableByBar = false;
            }
        }

        public static void ReflectHorizontalIfOverlapped(Ball ball1, Ball ball2)
        {
            if (ball1.Right > ball2.Left && ball1.Left < ball2.Left)
            {
                if (ball1.DX > 0 && ball2.DX > 0)
                {
                    if (ball1.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball1.DX = (int)(ball1.DX * 1.1);
                    if (ball2.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball2.DX = (int)(ball2.DX * 1.1);
                }
                else
                {
                    if (ball1.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball1.DX = -ball1.DX;
                    if (ball2.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                    ball2.DX = -ball2.DX;
                }
            }
            else if (ball1.Left < ball2.Right && ball1.Right > ball2.Right)
            {
                if (ball1.DX < 0 && ball2.DX < 0)
                {
                    if (ball1.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball1.DX = (int)(ball1.DX * 1.1);
                    if (ball2.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball2.DX = (int)(ball2.DX * 1.1);
                }
                else
                {
                    if (ball1.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball1.DX = -ball1.DX;
                    if (ball2.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball2.DX = -ball2.DX;
                }
            }
        }

        public static void ReflectVerticalIfOverlapped(Ball ball1, Ball ball2)
        {
            ball1.DY = -ball1.DY;
            ball2.DY = -ball2.DY;

            if (ball1.Bottom > ball2.Top && ball1.Top < ball2.Top)
            {
                if (ball1.DY > 0 && ball2.DY > 0)
                {
                    if (ball1.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball1.DY = (int)(ball1.DY * 1.1);
                    if (ball2.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball2.DY = (int)(ball2.DY * 1.1);
                }
                else
                {
                    if (ball1.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball1.DY = -ball1.DY;
                    if (ball2.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball2.DY = -ball2.DY;
                }
            }
            else if (ball1.Top < ball2.Bottom && ball1.Bottom > ball2.Bottom)
            {
                if (ball1.DY < 0 && ball2.DY < 0)
                {
                    if (ball1.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball1.DY = (int)(ball1.DY * 1.1);
                    if (ball2.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball2.DY = (int)(ball2.DY * 1.1);
                }
                else
                {
                    if (ball1.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball1.DY = -ball1.DY;
                    if (ball2.Penetrability == Ball.EPenetrability.NON_PENETRATING)
                        ball2.DY = -ball2.DY;
                }
            }
        }
    }
}
