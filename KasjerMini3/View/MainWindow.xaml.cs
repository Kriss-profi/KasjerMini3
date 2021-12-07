using KasjerMini3.View;
using KasjerMini3.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Printing;

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

        public ICommand ZerujCommand { get; private set; }

        private Wallet MyDataContext => DataContext as Wallet;

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Dispatcher.BeginInvoke(new Action(() => tb.SelectAll()));
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            new Window1(MyDataContext).ShowDialog();
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox s = e.Source as TextBox;
                if (s != null)
                {
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                }

                e.Handled = true;
            }
        }

        private void bt5_ToolTipOpening(object sender, ToolTipEventArgs e)
        {

        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            // Configure message box
            string message = "Siema To ja z pozdrowionkami \n Wpadnij na stronę:\n  www.polprofi.de/Kasjer ";
            string caption = "Info o twórcy";
            MessageBoxButton buttons = MessageBoxButton.OK;
            //MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult defaultResult = MessageBoxResult.OK;
            MessageBoxOptions options = MessageBoxOptions.RightAlign;
            // Show message box
            MessageBox.Show(message, caption, buttons, icon, defaultResult, options);
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            new PrintPage(MyDataContext).ShowDialog();
        }
    }
}
