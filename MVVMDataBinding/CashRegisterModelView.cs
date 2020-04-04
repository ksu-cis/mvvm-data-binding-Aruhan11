using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// The CashDrawer this class uses
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InokePropertyChanged("Pennies");

            }
        }

        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InokePropertyChanged("Nickels");
            }
        }


        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InokePropertyChanged("Dimes");
            }
        }

        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InokePropertyChanged("Quarters");
            }
        }

        public int HalfDollars
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InokePropertyChanged("HalfDollars");
            }
        }

        public int Dollars
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InokePropertyChanged("Dollars");
            }
        }

        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0) return;
                int quantity = drawer.Ones - value;
                if (quantity > 0) drawer.RemoveBill(Bills.One, quantity);
                else drawer.RemoveBill(Bills.One, -quantity);
                InokePropertyChanged("Ones");
            }
        }

        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                int quantity = drawer.Twos - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Two, quantity);
                else drawer.RemoveBill(Bills.Two, -quantity);
                InokePropertyChanged("Twos");
            }
        }

        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                int quantity = drawer.Fives - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Five, quantity);
                else drawer.RemoveBill(Bills.Five, -quantity);
                InokePropertyChanged("Fives");
            }
        }

        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                int quantity = drawer.Tens - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Ten, quantity);
                else drawer.RemoveBill(Bills.Ten, -quantity);
                InokePropertyChanged("Tens");
            }
        }

        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                int quantity = drawer.Twenties - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                InokePropertyChanged("Twenties");
            }
        }

        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                int quantity = drawer.Fifties - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Fifty, quantity);
                else drawer.RemoveBill(Bills.Fifty, -quantity);
                InokePropertyChanged("Fifties");
            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                int quantity = drawer.Hundreds - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Hundred, quantity);
                else drawer.RemoveBill(Bills.Hundred, -quantity);
                InokePropertyChanged("Hundreds");
            }
        }

      

        /// <summary>
        /// Helper method for triggering PropertyChanged events
        /// </summary>
        /// <param name="denomination">The denomination prroperty that is changing</param>
        void InokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
