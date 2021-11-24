using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KasjerMini3.ViewModel;

namespace KasjerMini3.Model
{
    public class WalletStorage
    {
        //private static Wallet Wallet1 = new Wallet();
        private static List<int> MyWallet = new();
        private const string fileName = "KasjerMini.txt";

        private static void AddAll(Wallet Wallet1)
        {
            MyWallet.Add(Wallet1.QuantityNom50000);
            MyWallet.Add(Wallet1.QuantityNom20000);
            MyWallet.Add(Wallet1.QuantityNom10000);
            MyWallet.Add(Wallet1.QuantityNom5000);
            MyWallet.Add(Wallet1.QuantityNom2000);
            MyWallet.Add(Wallet1.QuantityNom1000);
            MyWallet.Add(Wallet1.QuantityNom500);
            MyWallet.Add(Wallet1.QuantityNom200);
            MyWallet.Add(Wallet1.QuantityNom100);
            MyWallet.Add(Wallet1.QuantityNom50);
            MyWallet.Add(Wallet1.QuantityNom20);
            MyWallet.Add(Wallet1.QuantityNom10);
            MyWallet.Add(Wallet1.QuantityNom5);
            MyWallet.Add(Wallet1.QuantityNom2);
            MyWallet.Add(Wallet1.QuantityNom1);
        }
        public void SaveWallet(Wallet wallet)
        {
            AddAll(wallet);
            FileStream stream = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new(stream);
            SaveList(writer);
            writer.Dispose();
        }

        private static void SaveList(StreamWriter writer)
        {
            
            foreach (int item in MyWallet)
            {
                writer.WriteLine(Convert.ToString(item));
            }
        }
    }
}
