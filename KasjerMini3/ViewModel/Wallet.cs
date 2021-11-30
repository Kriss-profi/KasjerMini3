using KasjerMini3.Help;
using KasjerMini3.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace KasjerMini3.ViewModel
{
    public class Wallet : INotifyPropertyChanged
    {
        public Wallet()
        {
            walletStorage = new WalletStorage();
            ZerujCommand = new RelayCommand(a => Zeruj());
            walletStorage.Load(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private decimal _systemValue;
        private decimal _walletValue;
        private decimal _valueDifference;
        private string _differenceColor;
        private readonly WalletStorage walletStorage;
        public List<int> WalletList = new();
        

        public void ListaIlosci()
        {
            WalletList.Add(QuantityNom50000);
            WalletList.Add(QuantityNom5000);
            WalletList.Add(QuantityNom500);
            WalletList.Add(QuantityNom50);
            WalletList.Add(QuantityNom5);
            WalletList.Add(QuantityNom20000);
            WalletList.Add(QuantityNom2000);
            WalletList.Add(QuantityNom200);
            WalletList.Add(QuantityNom20);
            WalletList.Add(QuantityNom2);
            WalletList.Add(QuantityNom10000);
            WalletList.Add(QuantityNom1000);
            WalletList.Add(QuantityNom100);
            WalletList.Add(QuantityNom10);
            WalletList.Add(QuantityNom1);
        }
        public ICommand ZerujCommand { get; private set; }

        private void Zeruj()
        {
            //Double a = 1.0;
            //double b = 1.2;


            QuantityNom1 = 0;
            QuantityNom10 = 0;
            QuantityNom100 = 0;
            QuantityNom1000 = 0;
            QuantityNom10000 = 0;
            QuantityNom2 = 0;
            QuantityNom20 = 0;
            QuantityNom200 = 0;
            QuantityNom2000 = 0;
            QuantityNom20000 = 0;
            QuantityNom5 = 0;
            QuantityNom50 = 0;
            QuantityNom500 = 0;
            QuantityNom5000 = 0;
            QuantityNom50000 = 0;
        }

        public decimal SystemValue
        {
            get { return _systemValue; }
            set
            {
                //var temp = Convert.ToDecimal(Convert.ToString(value).Replace(",","."));
                _systemValue = value;
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal WalletValue
        {
            get { return _walletValue; }
            set
            {
                _walletValue = value;
                OnPropertyChanged();
            }
        }

        public decimal ValueDifference
        {
            get { return _valueDifference; }
            set
            {
                _valueDifference = value;
                DifferenceColor = DFColor(value);
                OnPropertyChanged();
            }
        }

        private string DFColor(decimal value)
        {
            if(value < 0)
            {
                return "Brushes.Red";
            }
            else
            {
                return "Brushes.Navy";
            }
        }

        public string DifferenceColor
        {
            get { return _differenceColor; }
            set
            {
                _differenceColor = value;
                OnPropertyChanged();
            }
        }

        MyWallet wallet = new MyWallet();

        public List<FaceValue> MyWallet = new List<FaceValue>();


        #region Nom50000
        public string NameNom50000
        {
            get
            {
                return wallet.Nom50000.Name;
            }
        }

        public int QuantityNom50000 
        { 
            get
            {
                return wallet.Nom50000.Quantity;
            }
            set
            {
               
                wallet.Nom50000.Quantity = value;
                ValueForMoneyNom50000 = Calculate(wallet.Nom50000);
                CalculateWalletValue();
                OnPropertyChanged();
                
            }
        }

        public decimal ValueForMoneyNom50000
        {
            get
            {
                return wallet.Nom50000.ValueForMoney;
            }
            set
            {
                wallet.Nom50000.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Nom20000
        public string NameNom20000
        {
            get
            {
                return wallet.Nom20000.Name;
            }
        }

        public int QuantityNom20000
        {
            get
            {
                return wallet.Nom20000.Quantity;
            }
            set
            {
                wallet.Nom20000.Quantity = value;
                ValueForMoneyNom20000 = Calculate(wallet.Nom20000);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom20000
        {
            get
            {
                return wallet.Nom20000.ValueForMoney;
            }
            set
            {
                wallet.Nom20000.ValueForMoney = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region Nom10000
        public string NameNom10000
        {
            get
            {
                return wallet.Nom10000.Name;
            }
        }

        public int QuantityNom10000
        {
            get
            {
                return wallet.Nom10000.Quantity;
            }
            set
            {
                wallet.Nom10000.Quantity = value;
                ValueForMoneyNom10000 = Calculate(wallet.Nom10000);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom10000
        {
            get
            {
                return wallet.Nom10000.ValueForMoney;
            }
            set
            {
                wallet.Nom10000.ValueForMoney = value;
                OnPropertyChanged();
            }
        }


        #endregion


        #region Nom5000
        public string NameNom5000
        {
            get
            {
                return wallet.Nom5000.Name;
            }
        }

        public int QuantityNom5000
        {
            get
            {
                return wallet.Nom5000.Quantity;
            }
            set
            {
                wallet.Nom5000.Quantity = value;
                ValueForMoneyNom5000 = Calculate(wallet.Nom5000);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom5000
        {
            get
            {
                return wallet.Nom5000.ValueForMoney;
            }
            set
            {
                wallet.Nom5000.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Nom2000
        public string NameNom2000
        {
            get
            {
                return wallet.Nom2000.Name;
            }
        }

        public int QuantityNom2000
        {
            get
            {
                return wallet.Nom2000.Quantity;
            }
            set
            {
                wallet.Nom2000.Quantity = value;
                ValueForMoneyNom2000 = Calculate(wallet.Nom2000);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom2000
        {
            get
            {
                return wallet.Nom2000.ValueForMoney;
            }
            set
            {
                wallet.Nom2000.ValueForMoney = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region Nom1000
        public string NameNom1000
        {
            get
            {
                return wallet.Nom1000.Name;
            }
        }

        public int QuantityNom1000
        {
            get
            {
                return wallet.Nom1000.Quantity;
            }
            set
            {
                wallet.Nom1000.Quantity = value;
                ValueForMoneyNom1000 = Calculate(wallet.Nom1000);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom1000
        {
            get
            {
                return wallet.Nom1000.ValueForMoney;
            }
            set
            {
                wallet.Nom1000.ValueForMoney = value;
                OnPropertyChanged();
            }
        }


        #endregion


        #region Nom500
        public string NameNom500
        {
            get
            {
                return wallet.Nom500.Name;
            }
        }

        public int QuantityNom500
        {
            get
            {
                return wallet.Nom500.Quantity;
            }
            set
            {
                wallet.Nom500.Quantity = value;
                ValueForMoneyNom500 = Calculate(wallet.Nom500);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom500
        {
            get
            {
                return wallet.Nom500.ValueForMoney;
            }
            set
            {
                wallet.Nom500.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Nom200
        public string NameNom200
        {
            get
            {
                return wallet.Nom200.Name;
            }
        }

        public int QuantityNom200
        {
            get
            {
                return wallet.Nom200.Quantity;
            }
            set
            {
                wallet.Nom200.Quantity = value;
                ValueForMoneyNom200 = Calculate(wallet.Nom200);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom200
        {
            get
            {
                return wallet.Nom200.ValueForMoney;
            }
            set
            {
                wallet.Nom200.ValueForMoney = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region Nom100
        public string NameNom100
        {
            get
            {
                return wallet.Nom100.Name;
            }
        }

        public int QuantityNom100
        {
            get
            {
                return wallet.Nom100.Quantity;
            }
            set
            {
                wallet.Nom100.Quantity = value;
                ValueForMoneyNom100 = Calculate(wallet.Nom100);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom100
        {
            get
            {
                return wallet.Nom100.ValueForMoney;
            }
            set
            {
                wallet.Nom100.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion


        #region Nom50
        public string NameNom50
        {
            get
            {
                return wallet.Nom50.Name;
            }
        }

        public int QuantityNom50
        {
            get
            {
                return wallet.Nom50.Quantity;
            }
            set
            {
                wallet.Nom50.Quantity = value;
                ValueForMoneyNom50 = Calculate(wallet.Nom50);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom50
        {
            get
            {
                return wallet.Nom50.ValueForMoney;
            }
            set
            {
                wallet.Nom50.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Nom20
        public string NameNom20
        {
            get
            {
                return wallet.Nom20.Name;
            }
        }

        public int QuantityNom20
        {
            get
            {
                return wallet.Nom20.Quantity;
            }
            set
            {
                wallet.Nom20.Quantity = value;
                ValueForMoneyNom20 = Calculate(wallet.Nom20);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom20
        {
            get
            {
                return wallet.Nom20.ValueForMoney;
            }
            set
            {
                wallet.Nom20.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Nom10
        public string NameNom10
        {
            get
            {
                return wallet.Nom10.Name;
            }
        }

        public int QuantityNom10
        {
            get
            {
                return wallet.Nom10.Quantity;
            }
            set
            {
                wallet.Nom10.Quantity = value;
                ValueForMoneyNom10 = Calculate(wallet.Nom10);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom10
        {
            get
            {
                return wallet.Nom10.ValueForMoney;
            }
            set
            {
                wallet.Nom10.ValueForMoney = value;
                OnPropertyChanged();
            }
        }


        #endregion


        #region Nom5
        public string NameNom5
        {
            get
            {
                return wallet.Nom5.Name;
            }
        }

        public int QuantityNom5
        {
            get
            {
                return wallet.Nom5.Quantity;
            }
            set
            {
                wallet.Nom5.Quantity = value;
                ValueForMoneyNom5 = Calculate(wallet.Nom5);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom5
        {
            get
            {
                return wallet.Nom5.ValueForMoney;
            }
            set
            {
                wallet.Nom5.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Nom2
        public string NameNom2
        {
            get
            {
                return wallet.Nom2.Name;
            }
        }

        public int QuantityNom2
        {
            get
            {
                return wallet.Nom2.Quantity;
            }
            set
            {
                wallet.Nom2.Quantity = value;
                ValueForMoneyNom2 = Calculate(wallet.Nom2);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom2
        {
            get
            {
                return wallet.Nom2.ValueForMoney;
            }
            set
            {
                wallet.Nom2.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Nom1
        public string NameNom1
        {
            get
            {
                return wallet.Nom1.Name;
            }
        }

        public int QuantityNom1
        {
            get
            {
                return wallet.Nom1.Quantity;
            }
            set
            {
                wallet.Nom1.Quantity = value;
                ValueForMoneyNom1 = Calculate(wallet.Nom1);
                CalculateWalletValue();
                OnPropertyChanged();
            }
        }

        public decimal ValueForMoneyNom1
        {
            get
            {
                return wallet.Nom1.ValueForMoney;
            }
            set
            {
                wallet.Nom1.ValueForMoney = value;
                OnPropertyChanged();
            }
        }

        #endregion


        private static decimal Calculate(FaceValue nom)
        {
            return nom.Quantity * nom.FValue;
        }

        private void CalculateWalletValue()
        {
            WalletValue = ValueForMoneyNom50000 
                + ValueForMoneyNom20000 
                + ValueForMoneyNom10000 
                + ValueForMoneyNom5000 
                + ValueForMoneyNom2000 
                + ValueForMoneyNom1000 
                + ValueForMoneyNom500 
                + ValueForMoneyNom200 
                + ValueForMoneyNom100 
                + ValueForMoneyNom50 
                + ValueForMoneyNom20 
                + ValueForMoneyNom10
                + ValueForMoneyNom5
                + ValueForMoneyNom2
                + ValueForMoneyNom1;
            CalculateValueDifference();
            SaveMyWallet();

        }

        private void CalculateValueDifference()
        {
            ValueDifference = WalletValue - SystemValue;
        }

        internal void SaveMyWallet()
        {
            walletStorage.SaveWallet(this);
        }
    }
}
