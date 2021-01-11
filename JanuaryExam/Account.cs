using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    public abstract class Account
    {
        //properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Balance { get; set; }

        public DateTime IntrestDate { get; set; }

        public int AccountNumber { get; set; }

        public abstract double CalculateIntrest(); //Abstract method

        public override string ToString() //used to display information in listbox
        {
            return $" {AccountNumber},{LastName},{FirstName}";
        }
    }
    public class CurrentAccount : Account //inherit class from account
    {
        public double IntrestRate { get; set; }


        public override double CalculateIntrest()// impelement abstract method
        {
            
            return Balance*IntrestRate; //method formula
        }
    }

    public class SavingsAccount : Account 
    {
        //Properties
        public double IntrestRate { get; set; }

        public override double CalculateIntrest()//Implementation of abstract method
        {
            return Balance * IntrestRate;
        }
    }
}
