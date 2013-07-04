using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class DesktopKeyboard : IOperator
    {
        public void SelectBar(BarSelect barSelect, ref int BarType, Input input, ref int autoCount)
        {
            SelectBarByInputKey(ref BarType, input, ref autoCount);
        }

        public static void SelectBarByInputKey(ref int BarType, Input input, ref int autoCount)
        {
            if (input.rB)
            {
                if (input.AT)
                    ++autoCount;

                ++BarType;

                if (BarType > 3)
                    BarType = 1;

                input.rB = false;
            }

            if (input.lB)
            {
                if (input.AT)
                    ++autoCount;

                --BarType;

                if (BarType < 1)
                    BarType = 3;

                input.lB = false;
            }
        }


        public void SelectStage(StageSelect stageSelect, ref int Stage, Input input, ref int autoCount)
        {
            SelectStageByInputKey(ref Stage, input, ref autoCount);
        }

        public static void SelectStageByInputKey(ref int Stage, Input input, ref int autoCount)
        {
            if (input.rB)
            {
                if (input.AT)
                    ++autoCount;

                ++Stage;

                if (Stage > 5)
                    Stage = 1;

                input.rB = false;
            }

            if (input.lB)
            {
                if (input.AT)
                    ++autoCount;

                --Stage;

                if (Stage < 1)
                    Stage = 5;

                input.lB = false;
            }
        }


        public bool MoveBar(Bar bar, ref int AcceleratingCount, Input input)
        {
            bool IsPushedAnyKey = false;

            if (input.key256[Input.KEY_INPUT_LEFT] == 1)
            {
                bar.IsMove = true;
                bar.CenterX -= bar.SPEED;
                ++AcceleratingCount;

                if (AcceleratingCount < 25)
                    bar.Accel = -1;
                else if (AcceleratingCount < 50)
                    bar.Accel = -2;
                else
                    bar.Accel = -3;

                IsPushedAnyKey = true;
            }
            else if (input.key256[Input.KEY_INPUT_RIGHT] == 1)
            {
                bar.IsMove = true;
                bar.CenterX += bar.SPEED;
                ++AcceleratingCount;

                if (AcceleratingCount < 25)
                    bar.Accel = 1;
                else if (AcceleratingCount < 50)
                    bar.Accel = 2;
                else
                    bar.Accel = 3;

                IsPushedAnyKey = true;
            }
            else if (input.key256[Input.KEY_INPUT_ESCAPE] == 1)
            {
                bar.IsDead = true;
            }

            return IsPushedAnyKey;
        }


        public void ScrollRanking(Input input, ref int scoreY, ref bool scroll)
        {
            if (input.lB)
            {
                if (scoreY > 0)
                {
                    scoreY -= 20;
                    scroll = false;
                }
            }

            if (input.rB)
            {
                if (scoreY < 900)
                {
                    scoreY += 20;
                    scroll = false;
                }
            }
        }
    }
}
