using KasjerMini3.ViewModel;
using KasjerMini3.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using KasjerMini3.View;

namespace KasjerMini3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Wallet();
        }

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Dispatcher.BeginInvoke(new Action(() => tb.SelectAll()));
        }

        private void KasaSystem_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            //SystemValue
            Wallet wallet = new();
            //wallet.SystemValue = Convert.ToDecimal(textBox.Text.Replace(",", "."));
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            Wallet wallet = new Wallet();
            _ = MessageBox.Show(messageBoxText: wallet.SystemValue.ToString());
        }
    }
}
