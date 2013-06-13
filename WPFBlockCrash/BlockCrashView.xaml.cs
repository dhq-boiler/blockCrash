using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBlockCrash
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class BlockCrashView : UserControl
    {

        public BlockCrashView()
        {
            InitializeComponent();

            main = new Main(input);
        }

        public void BeginGame() //GameStart()
        {
            th = new Thread(() => main.All());
        }

        public void PushRButton()
        {
            input.RB = true;
            input.IsPushedKeys = true;
        }

        public void PushLButton()
        {
            input.LB = true;
            input.IsPushedKeys = true;
        }

        public void MoveBarTo(int vx)
        {
            input.barx = vx;
        }

        public void PushEnterButton()
        {
            input.EB = true;
            input.IsPushedKeys = true;
        }

        public bool IsAuto
        {
            get { return input.AT; }
            set { input.AT = value; }
        }

        public void KeyEnd()
        {
            input.IsPushedKeys = false;
        }

        public void Finish()
        {
            input.IsFinished = true;
        }

        private Thread th;
        private Main main;
        private Input input;
    }
}
