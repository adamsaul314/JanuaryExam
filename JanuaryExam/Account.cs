using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    public abstract class Account
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Balance { get; set; }

        public DateTime IntrestDate { get; set; }


        public abstract double CalculateIntrest(); //Abstract method

        public override string ToString() //used to display information in listbox
        {
            return $" {LastName},{FirstName}";
        }
    }
    public class CurrentAccount : Account
    {
        public double IntrestRate { get; set; }


        public override double CalculateIntrest()
        {
            Acc
            IntrestRate;
        }
    }

    public class SavingsAccount : Account 
    {
        public double IntrestRate { get; set; }

        public override double CalculateIntrest()
        {
            return IntrestRate;
        }
    }
}
