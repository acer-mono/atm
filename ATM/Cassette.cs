using System;

namespace ATM
{
    abstract public class Cassette
    {
        protected int capacity;
        private int backnotesQuantity;

        public int BanknotesQuantity 
        { 
            get => backnotesQuantity;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Число купюр не может быть отрицательным");
                }

                if (value > capacity)
                {
                    throw new ArgumentException($"Число купюр не может быть больше {capacity} купюр");
                }

                backnotesQuantity = value;
            }
        }

        public bool IsEmpty => backnotesQuantity == 0;
    }
}
