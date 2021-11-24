using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using KasjerMini3.Model;

namespace KasjerMini3.ViewModel
{
    public class Wallet : INotifyPropertyChanged
    {

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


        public decimal SystemValue
        {
            get { return _systemValue; }
            set
            {
                //var temp = Convert.ToDecimal(Convert.ToString(value).Replace(",","."));
                _systemValue = value;
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
                OnPropertyChanged();
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
                if (value > 0)
                {
                    wallet.Nom50000.Quantity = value;
                    Calculate50000();
                    OnPropertyChanged();
                }
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

        private void Calculate50000()
        {
            ValueForMoneyNom50000 = wallet.Nom50000.Quantity * wallet.Nom50000.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom20000.Quantity = value;
                    Calculate20000();
                    OnPropertyChanged();
                }
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

        private void Calculate20000()
        {
            ValueForMoneyNom20000 = wallet.Nom20000.Quantity * wallet.Nom20000.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom10000.Quantity = value;
                    Calculate10000();
                    OnPropertyChanged();
                }
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

        private void Calculate10000()
        {
            ValueForMoneyNom10000 = wallet.Nom10000.Quantity * wallet.Nom10000.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom5000.Quantity = value;
                    Calculate5000();
                    OnPropertyChanged();
                }
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

        private void Calculate5000()
        {
            ValueForMoneyNom5000 = wallet.Nom5000.Quantity * wallet.Nom5000.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom2000.Quantity = value;
                    Calculate2000();
                    OnPropertyChanged();
                }
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

        private void Calculate2000()
        {
            ValueForMoneyNom2000 = wallet.Nom2000.Quantity * wallet.Nom2000.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom1000.Quantity = value;
                    Calculate1000();
                    OnPropertyChanged();
                }
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

        private void Calculate1000()
        {
            ValueForMoneyNom1000 = wallet.Nom1000.Quantity * wallet.Nom1000.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom500.Quantity = value;
                    Calculate500();
                    OnPropertyChanged();
                }
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

        private void Calculate500()
        {
            ValueForMoneyNom500 = wallet.Nom500.Quantity * wallet.Nom500.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom200.Quantity = value;
                    Calculate200();
                    OnPropertyChanged();
                }
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

        private void Calculate200()
        {
            ValueForMoneyNom200 = wallet.Nom200.Quantity * wallet.Nom200.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom100.Quantity = value;
                    Calculate100();
                    OnPropertyChanged();
                }
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

        private void Calculate100()
        {
            ValueForMoneyNom100 = wallet.Nom100.Quantity * wallet.Nom100.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom50.Quantity = value;
                    Calculate50();
                    OnPropertyChanged();
                }
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

        private void Calculate50()
        {
            ValueForMoneyNom50 = wallet.Nom50.Quantity * wallet.Nom50.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom20.Quantity = value;
                    Calculate20();
                    OnPropertyChanged();
                }
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

        private void Calculate20()
        {
            ValueForMoneyNom20 = wallet.Nom20.Quantity * wallet.Nom20.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom10.Quantity = value;
                    Calculate10();
                    OnPropertyChanged();
                }
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

        private void Calculate10()
        {
            ValueForMoneyNom10 = wallet.Nom10.Quantity * wallet.Nom10.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom5.Quantity = value;
                    Calculate5();
                    OnPropertyChanged();
                }
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

        private void Calculate5()
        {
            ValueForMoneyNom5 = wallet.Nom5.Quantity * wallet.Nom5.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom2.Quantity = value;
                    Calculate2();
                    OnPropertyChanged();
                }
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

        private void Calculate2()
        {
            ValueForMoneyNom2 = wallet.Nom2.Quantity * wallet.Nom2.FValue;
            CalculateWalletValue();
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
                if (value > 0)
                {
                    wallet.Nom1.Quantity = value;
                    Calculate1();
                    OnPropertyChanged();
                }
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

        private void Calculate1()
        {
            ValueForMoneyNom1 = wallet.Nom1.Quantity * wallet.Nom1.FValue;
            CalculateWalletValue();
        }

        #endregion




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
            //SaveMyWallet();

        }

        private void CalculateValueDifference()
        {
            ValueDifference = WalletValue - SystemValue;
        }

        internal void SaveMyWallet()
        {
            //walletStorage.SaveWallet(this);
        }
    }
}
