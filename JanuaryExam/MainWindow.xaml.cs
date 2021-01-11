using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace JanuaryExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Account> accounts;
        public List<Account> filteredaccounts;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Initialise the collections
            accounts = new List<Account>();
            filteredaccounts = new List<Account>();

            //created account objects
            CurrentAccount ca1 = new CurrentAccount() { AccountNumber = 111, LastName = "Saul", FirstName = "Adam", Balance = 500, IntrestRate = 0.3 };
            CurrentAccount ca2 = new CurrentAccount() { AccountNumber = 222, LastName = "Kirby", FirstName = "Chantelle", Balance = 200, IntrestRate = 0.3 };
            SavingsAccount sa1 = new SavingsAccount() { AccountNumber = 333, LastName = "Dunne", FirstName = "John", Balance = 9000, IntrestRate = 0.6 };
            SavingsAccount sa2 = new SavingsAccount() { AccountNumber = 444, LastName = "Dunne", FirstName = "Cathy", Balance = 51000,IntrestRate= 0.6 };

            //Add all account to main colelction of accounts
            accounts.Add(ca1);
            accounts.Add(ca2);
            accounts.Add(sa1);
            accounts.Add(sa2);

            lbxNames.ItemsSource = accounts;


            //Set initial values on checkboxes
            chbxCurrentAccount.IsChecked = true;
            chbxSavingsAccount.IsChecked = true;
        }

        //Updates fields when an employee is selected from the list
        private void lbxNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Account selected = lbxNames.SelectedItem as Account;

            if(selected != null)
            {
                tblkFirstName.Text = selected.FirstName;
                tblkLastname.Text = selected.LastName;

                tblkBalance.Text = selected.CalculateIntrest().ToString("C");
            }
        }


        private void chbx_Click(object sender, RoutedEventArgs e) //filtering accounts
        {
            //if all employees are selected
            if((chbxCurrentAccount.IsChecked==true) && (chbxSavingsAccount.IsChecked == true))
            {
                lbxNames.ItemsSource = accounts;
            }
            //if no emplyees are selected
            else if ((chbxCurrentAccount.IsChecked == false) && (chbxSavingsAccount.IsChecked == false))
            {
                lbxNames.ItemsSource = null;
            }
            //if Current account is selected
            else if ((chbxCurrentAccount.IsChecked == true) && (chbxSavingsAccount.IsChecked == false))
            {
                filteredaccounts.Clear();

                foreach(Account account in accounts)
                {
                    if(account is CurrentAccount)
                    {
                        filteredaccounts.Add(account);
                    }
                    lbxNames.ItemsSource = filteredaccounts;
                }
            }
            //if savings account is selected
            else if ((chbxCurrentAccount.IsChecked == false) && (chbxSavingsAccount.IsChecked == true))
            {
                filteredaccounts.Clear();

                foreach (Account account in accounts)
                {
                    if (account is SavingsAccount)
                    {
                        filteredaccounts.Add(account);
                    }
                    lbxNames.ItemsSource = filteredaccounts;
                }
            }

        }
    }
}
