using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class KeyInput
    {
        private bool ispushed;
        public bool Output
        {
            get
            {
                if (!ispushed)
                    return false;

                if (IsFirstFrameSinceKeyPushed)
                {
                    IsFirstFrameSinceKeyPushed = false;
                    return true;
                }

                if (TimeToContinuousInput != null)
                {
                    if ((DateTime.Now - TimeSincePushed) >= TimeToContinuousInput)
                    {
                        if (!TimeSinceBeforeOutput.HasValue)
                        {
                            TimeSinceBeforeOutput = DateTime.Now;
                            return true;
                        }
                        else
                        {
                            if ((DateTime.Now - TimeSinceBeforeOutput) >= TimeSpan.FromMilliseconds(100))
                            {
                                TimeSinceBeforeOutput = DateTime.Now;
                                return true;
                            }
                            else
                                return false;
                        }
                    }
                    else
                        return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private DateTime? TimeSincePushed { get; set; }
        private DateTime? TimeSinceBeforeOutput { get; set; }
        public TimeSpan TimeToContinuousInput { get; set; }

        private bool IsFirstFrameSinceKeyPushed { get; set; }

        public void KeyDown()
        {
            ispushed = true;
            TimeSincePushed = DateTime.Now;
            IsFirstFrameSinceKeyPushed = true;
        }

        public void KeyUp()
        {
            ispushed = false;
            TimeSincePushed = null;
        }
    }
}
