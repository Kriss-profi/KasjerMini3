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
using System.Printing;
using System.Windows.Xps;
using KasjerMini3.ViewModel;

namespace KasjerMini3.View
{
    /// <summary>
    /// Interaction logic for PrintPage.xaml
    /// </summary>
    public partial class PrintPage : Window
    {
        //private FixedDocumentSequence _document;
        public PrintPage(Wallet dc)
        //public PrintPage(FixedDocumentSequence document)
        {
            InitializeComponent();
            DataContext = dc;   

            //_document = document;

            //PreviewD.Document = document;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //StackPanel stackPanel = e.Source as StackPanel;
            //stackPanel = sender(WalletView);

            //PrintDialog printD = new PrintDialog();

            //printD = stackPanel.Name.WalletView;
            //Nullable<Boolean> print = printD.ShowDialog(); 

            //new PrintPage(MyDataContext).ShowDialog();

            //if (printD != null)
            //{

            //}
            PrintDocument();
        }

        public void PrintDocument()
        {
            PrintDialog printDialog = new PrintDialog();   
            printDialog.PrintQueue = LocalPrintServer.GetDefaultPrintQueue();
            printDialog.PrintTicket = printDialog.PrintQueue.DefaultPrintTicket;
            
            printDialog.PrintTicket.PageOrientation = PageOrientation.Portrait; 
            printDialog.PrintTicket.PageScalingFactor = 1;
            printDialog.PrintTicket.PageMediaSize = new PageMediaSize(PageMediaSizeName.ISOA4);
            

            
            if (printDialog.ShowDialog() == true)
            {
                //_document.PrintTicket = printDialog.PrintTicket;

                //XpsDocumentWriter writer = PrintQueue.CreateXpsDocumentWriter(printDialog.PrintQueue);

                //writer.WriteAsync(_document, printDialog.PrintTicket);
                
                printDialog.PrintVisual(WalletView, "KasjerMini3 Portwel.");
            }
            this.Close();
        }
    }
}
