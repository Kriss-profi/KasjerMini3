using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasjerMini3.Model
{
    public class FaceValue
    {
        public FaceValue( int nominal)
        {
            Quantity = 0;
            FValue = Convert.ToDecimal(nominal) / 100;
            if(FValue >= 1)
            {
                Name = Convert.ToString(FValue) + " zł.";
            }
            else
            {
                Name = Convert.ToString(FValue) + " gr.";
            }
        }

        private string _name;
        private decimal _fvalue;
        private decimal _valueForMoney;
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public decimal ValueForMoney
        {
            get { return _valueForMoney; }
            set { _valueForMoney = value; }
        }

        public decimal FValue
        {
            get { return _fvalue; }
            set { _fvalue = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
