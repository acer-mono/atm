namespace ATM
{
    public class DepositCassette : Cassette
    {
        public int AmountOfMoney { get; set; }

        public DepositCassette(int capacity)
        {
            this.capacity = capacity;
        }

        public void Deposit(int banknotesQuantity, int amountOfMoney)
        {
            BanknotesQuantity += banknotesQuantity;
            AmountOfMoney += amountOfMoney;
        }

        public bool IsFull => BanknotesQuantity == capacity;
    }
}
