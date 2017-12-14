namespace SimpleATM
{
    public class BankCard
    {

        public string Name { get; set; }
        public string AccountNumber { get; set; }
        private int PinCode { get; set; }

        public BankCard(string name, string acNo, int pin)
        {
            this.Name = name;
            this.AccountNumber = acNo;
            this.PinCode = pin;
        }

        public bool CheckCode(int pincode)
        {
            return pincode.Equals(PinCode);
        }
    }
}