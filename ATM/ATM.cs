using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    public class ATM
    {
        private const int CassetteCapacity = 10;
        private const int DepositCassetteCapacity = 10;
        private DepositCassette depositCassette;
        private WithdrawCassette[] withdrawCassettes = new WithdrawCassette[] { };

        public ATM()
        {
            Refresh();
        }

        public int RemainingDepositBanknotesQuantity => DepositCassetteCapacity - DepositBanknotesQuantity;

        public bool IsDepositAvailable => !depositCassette.IsFull;

        public int DepositAmount => depositCassette.AmountOfMoney;

        public int DepositBanknotesQuantity => depositCassette.BanknotesQuantity;

        public int WithdrawBanknotesQuantity => withdrawCassettes.Select(c => c.BanknotesQuantity).Sum();

        public bool IsWithdrawAvailable => WithdrawBanknotesQuantity > 0;

        public int GetWithdrawBanknotesQuantityByFaceValue(BanknoteFaceValue faceValue)
        {
            return withdrawCassettes.Where(c => c.faceValue.Equals(faceValue)).Select(c => c.BanknotesQuantity).First();
        }

        private WithdrawCassette GetWithdrawCassetteByFaceValue(BanknoteFaceValue faceValue)
        {
            return withdrawCassettes.Where(c => c.faceValue.Equals(faceValue)).First();
        }

        public Dictionary<BanknoteFaceValue, int> GetAvailableBanknotes(int withdrawalAmount, BanknoteFaceValue desiredFaceValue)
        {
            Dictionary<BanknoteFaceValue, int> banknotes = new Dictionary<BanknoteFaceValue, int>();
            BanknoteFaceValue[] faceValues = (BanknoteFaceValue[]) Enum.GetValues(typeof(BanknoteFaceValue));
            Array.Reverse(faceValues);

            int desiredFaceValueIndex = Array.IndexOf(faceValues, desiredFaceValue);

            for (int i = desiredFaceValueIndex; i < faceValues.Length; i++)
            {
                banknotes.Clear();
                int currentWithdrawalAmount = withdrawalAmount;

                for (int j = i; j < faceValues.Length; j++)
                {
                    int banknotesQuantity = currentWithdrawalAmount / (int) faceValues[j];
                    int faceValueBanknotesQuantity = GetWithdrawBanknotesQuantityByFaceValue(faceValues[j]);

                    if (banknotesQuantity > faceValueBanknotesQuantity)
                    {
                        banknotesQuantity = faceValueBanknotesQuantity;
                    }

                    currentWithdrawalAmount -= (int) faceValues[j] * banknotesQuantity;
                    banknotes[faceValues[j]] = banknotesQuantity;
                }

                if (currentWithdrawalAmount == 0)
                {
                    return banknotes;
                }
            }

            banknotes.Clear();
            return banknotes;
        }

        public void Withdraw(Dictionary<BanknoteFaceValue, int> banknotes)
        {
            foreach (var keyValue in banknotes)
            {
                GetWithdrawCassetteByFaceValue(keyValue.Key).Withdraw(keyValue.Value);
            }
        }

        public void Deposit(int depositAmount, int banknoteQuantity)
        {
            depositCassette.Deposit(banknoteQuantity, depositAmount);
        }

        public void Refresh()
        {
            depositCassette = new DepositCassette(DepositCassetteCapacity);
            withdrawCassettes = Enum.GetValues(typeof(BanknoteFaceValue))
                                    .Cast<BanknoteFaceValue>()
                                    .Select(value => new WithdrawCassette(value, CassetteCapacity, CassetteCapacity))
                                    .ToArray();
        }
    }
}