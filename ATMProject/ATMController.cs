using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATM
{
   public class ATMController
    {
        IDataProvider dataprovider;
        bool authenticated = false;
        BankCard card;
        Account account;

        public ATMController(IDataProvider dataprovider)
        {
            this.dataprovider = dataprovider;
        }
        public bool Authenticate(BankCard card, int pin)
        {
            authenticated =(card.CheckCode(pin));
            this.card = card;
            return authenticated;
        }

        public void RemoveAuthentication()
        {
            authenticated = false;
            card = null;
        }

        public bool WithdrawCash(int amount)
        {
            if (authenticated)
            {
                account = dataprovider.QueryAccount(card.AccountNumber);
            }
            return account.BookCharge(amount);
        }

        public float QueryBalance(int amount)
        {
            if (authenticated)
            {
                account = dataprovider.QueryAccount(card.AccountNumber);
            }
            return account.QueryBalance();
        }
    }
}
