﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace BlockCrashGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                string[] args = Environment.CommandLine.Split(' ');
                WPFBlockCrash.BlockCrashView.EOperatingType selectOperationMode = (WPFBlockCrash.BlockCrashView.EOperatingType)int.Parse(args[0]);
                view.Initialize(selectOperationMode);
            }
            catch (NullReferenceException)
            {
                SetKeyboardMode();
            }
            catch (ArgumentNullException)
            {
                SetKeyboardMode();
            }
            catch (FormatException)
            {
                SetKeyboardMode();
            }
            catch (InvalidCastException)
            {
                SetKeyboardMode();
            }

            view.RunGame();
        }

        private void SetKeyboardMode()
        {
            view.Initialize(WPFBlockCrash.BlockCrashView.EOperatingType.DESKTOP_KEYBOARD);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Space:
                    //view.KeyDownSpaceButton();
                    view.KeyDownEnterButton();
                    break;
                case Key.Left:
                    view.KeyDownLButton();
                    break;
                case Key.Right:
                    view.KeyDownRButton();
                    break;
                case Key.Enter:
                    view.KeyDownEnterButton();
                    break;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Space:
                    //view.KeyUpSpaceButton();
                    view.KeyUpEnterButton();
                    break;
                case Key.Left:
                    view.KeyUpLButton();
                    break;
                case Key.Right:
                    view.KeyUpRButton();
                    break;
                case Key.Enter:
                    view.KeyUpEnterButton();
                    break;
            }
        }
    }
}
