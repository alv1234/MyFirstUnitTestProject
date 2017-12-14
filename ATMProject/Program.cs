using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple ATM");
            BackEndSimulator sim = new BackEndSimulator();
            ATMController controller = new ATMController(sim);

            Console.WriteLine("Please enter your card and pin");
            //generate demo bankcard
            BankCard c = new BankCard("Dummy", "1234", 1234);
            int pin = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Pin " + controller.Authenticate(c, pin));

            Console.WriteLine("Please enter your options: 1) withdraw, 2) query balance");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                   //query for amount
                    break;
                case 2:
                    //output balance
                    break;
                default:
                    break;
            }
        }
    }
}
