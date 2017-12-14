using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATM
{
    public class Account
    {
        //Test 123
        private float Balance {  get; set; }
        public string AccountName { get; private set; }
        public string AccountNumber { get; private set; }
        public int Limit { get; set; }
        public Account(string accountName, string accountNumber, int limit)
        {
            Balance = 0;
            AccountName = accountName;
            AccountNumber = accountNumber;
            Limit = limit;
        }

        public float QueryBalance()
        {
            return Balance;
        }
        public bool BookCharge(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            else if (amount < 0)
            {
                if((Balance-amount)> Limit)
                {
                    Balance -= amount;
                    return true;
                }
            }
            return false;
        }
    }
}
