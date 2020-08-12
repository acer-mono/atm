using System;

namespace ATM
{
    public class WithdrawCassette : Cassette
    {
        public readonly BanknoteFaceValue faceValue;

        public WithdrawCassette(BanknoteFaceValue faceValue, int capacity, int banknotesQuantity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Ёмкость кассеты не может быть пустой");
            }

            if (banknotesQuantity <= 0)
            {
                throw new ArgumentException("Кассета не может быть пустой");
            }

            if (banknotesQuantity > capacity)
            {
                throw new ArgumentException($"Число банкнот в кассете не может превышать {capacity}");
            }

            this.faceValue = faceValue;
            this.capacity = capacity;
            BanknotesQuantity = banknotesQuantity;
        }
        public int AmountOfMoney => BanknotesQuantity * (int) faceValue;

        public void Withdraw(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("Число банкнот не может быть отрицательным");
            }

            BanknotesQuantity -= quantity;
        }
    }

}
