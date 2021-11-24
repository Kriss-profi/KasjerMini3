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
using KasjerMini3.ViewModel;

namespace KasjerMini3.View
{
    /// <summary>
    /// Interaction logic for SystemValuePage.xaml
    /// </summary>
    public partial class SystemValuePage : Page
    {
        public SystemValuePage()
        {
            InitializeComponent();
            DataContext = new Wallet();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //Window1.Close();
        }
    }
}
