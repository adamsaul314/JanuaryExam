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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JanuaryExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Account> currentaccount;
        public List<Account> savingsaccount;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            currentaccount = new List<Account>();
            savingsaccount = new List<Account>();

            CurrentAccount ca1 = new CurrentAccount() { AccountNumber = 001, LastName = "Saul", FirstName = "Adam" };
            CurrentAccount ca2 = new CurrentAccount() { AccountNumber = 002, LastName = "Kirby", FirstName = "Chantelle" };
            SavingsAccount sa1 = new SavingsAccount() { AccountNumber = 003, LastName = "Dunne", FirstName = "John" };
            SavingsAccount sa2 = new SavingsAccount() { AccountNumber = 004, LastName = "Dunne", FirstName = "Cathy" };

        }
    }
}
