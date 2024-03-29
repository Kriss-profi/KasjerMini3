﻿using KasjerMini3.ViewModel;
using System;
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
using System.Windows.Shapes;

namespace KasjerMini3.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(Wallet dc)
        {
            InitializeComponent();
            DataContext = dc;
        }

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Dispatcher.BeginInvoke(new Action(() => tb.SelectAll()));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(KasaWSystemie.Text.ToString());
            Close();
        }

        private void KasaWSystemie_PreviewKeyUp(object sender, KeyEventArgs e)
        {

            
            if (e.Key == Key.Enter)
            {
                Close();
            }
        }
    }
}
