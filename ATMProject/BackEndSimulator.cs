using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATM
{
    public class BackEndSimulator : IDataProvider
    {

        List<Account> Accounts = new List<Account>();

        public BackEndSimulator()
        {
            Account testAccountOne = new Account("Max Mustermann", "1234", 2000);
            Account testAccountTwo = new Account("Maxime Musterfrau", "5678", 1000);
            //Add Demo Accounts
            Accounts.Add(testAccountOne);
            Accounts.Add(testAccountTwo);
        }

        public Account QueryAccount(string accountNumber)
        {
            foreach (var item in Accounts)
            {
                if (item.AccountNumber.Equals(accountNumber))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
