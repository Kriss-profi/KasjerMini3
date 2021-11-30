using KasjerMini3.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace KasjerMini3.Model
{
    public class WalletStorage
    {
        private const string fileName = "KasjerMini3.txt";

        public List<int> WalletList = new();
        

        public void SaveWallet(Wallet wallet)
        {
            FileStream stream = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new(stream);

            SaveList(writer, wallet);
            writer.Dispose();
        }

        public void Load(Wallet wallet)
        {
            try
            {
                if(File.Exists(fileName))
                {
                    string[] table = File.ReadAllLines(fileName);
                    wallet.QuantityNom50000 = int.Parse(table[0]);
                    wallet.QuantityNom5000 = int.Parse(table[1]);
                    wallet.QuantityNom500 = int.Parse(table[2]);
                    wallet.QuantityNom50 = int.Parse(table[3]);
                    wallet.QuantityNom5 = int.Parse(table[4]);
                    wallet.QuantityNom20000 = int.Parse(table[5]);
                    wallet.QuantityNom2000 = int.Parse(table[6]);
                    wallet.QuantityNom200 = int.Parse(table[7]);
                    wallet.QuantityNom20 = int.Parse(table[8]);
                    wallet.QuantityNom2 = int.Parse(table[9]);
                    wallet.QuantityNom10000 = int.Parse(table[10]);
                    wallet.QuantityNom1000 = int.Parse(table[11]);
                    wallet.QuantityNom100 = int.Parse(table[12]);
                    wallet.QuantityNom10 = int.Parse(table[13]);
                    wallet.QuantityNom1 = int.Parse(table[14]);
                    wallet.SystemValue = decimal.Parse(table[15]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Błąd: {e.Message}");
            }
        }
        private static void SaveList(StreamWriter writer, Wallet wallet)
        {
            
            writer.WriteLine(Convert.ToString(wallet.QuantityNom50000));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom5000));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom500));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom50));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom5));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom20000));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom2000));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom200));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom20));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom2));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom10000));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom1000));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom100));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom10));
            writer.WriteLine(Convert.ToString(wallet.QuantityNom1));
            writer.WriteLine(Convert.ToString(wallet.SystemValue));
        }

        private static void ReadList3(Wallet wallet)
        {

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamReader reader = new(stream);

            wallet.QuantityNom50000 = int.Parse(reader.ReadLine());
            wallet.QuantityNom5000 = int.Parse(reader.ReadLine());
            wallet.QuantityNom500 = int.Parse(reader.ReadLine());
            wallet.QuantityNom50 = int.Parse(reader.ReadLine());
            wallet.QuantityNom5 = int.Parse(reader.ReadLine());
            wallet.QuantityNom20000 = int.Parse(reader.ReadLine());
            wallet.QuantityNom2000 = int.Parse(reader.ReadLine());
            wallet.QuantityNom200 = int.Parse(reader.ReadLine());
            wallet.QuantityNom20 = int.Parse(reader.ReadLine());
            wallet.QuantityNom2 = int.Parse(reader.ReadLine());
            wallet.QuantityNom10000 = int.Parse(reader.ReadLine());
            wallet.QuantityNom1000 = int.Parse(reader.ReadLine());
            wallet.QuantityNom100 = int.Parse(reader.ReadLine());
            wallet.QuantityNom10 = int.Parse(reader.ReadLine());
            wallet.QuantityNom1 = int.Parse(reader.ReadLine());

            reader.Dispose();
        }

    }
}
