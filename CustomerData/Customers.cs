using System;

namespace CustomerData
{
    public class Customers
    {
        //class-level const
        private static int AUTO_NO = 100;
        private static decimal ADMIN_CHARGE = 12;
        private static decimal UNIT_CHARGE = 0.07m;

        //private properties 
        private int accountNo;
        private string fName;
        private string lName;
        private decimal kW;
        private decimal billAmount; 


        //constructor
        public Customers(string fName="Unknown",string lName="Unknown", decimal kW=0)
        {
            accountNo = AUTO_NO;
            AUTO_NO++;
            this.fName = fName;
            this.lName = lName;
            if (kW > 0) this.kW = kW;
            else this.kW = 0;
            billAmount = 0;
        }

        //public properties 
        public int AccountNo { get { return accountNo; } }
        
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }

        public decimal KW
        {
            get { return kW; }
            set { if (value < 0) value = 0;
                kW = value;
            }
        }

        public decimal Bill { get { return billAmount; } } //read-only property 


        //public methods 
        public decimal CalculateCharges() //update the billAmount value based on calculatd charge 
        {
            billAmount=ADMIN_CHARGE + kW*UNIT_CHARGE ;
            return billAmount;
        }

        public override string ToString() => $"Account #: {accountNo}, Name: {fName} {lName}, " +
                                             $"Usage: {kW} kW, Bill: {billAmount} $ ";
                                       

    }
}
