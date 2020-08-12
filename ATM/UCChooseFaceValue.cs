using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATM
{
    public partial class UCChooseFaceValue : UserControl
    {
        private int withdrawAmount = 0;
        private Dictionary<BanknoteFaceValue, int>[] banknotesInfo;
        private int[] banknotes = (int[])Enum.GetValues(typeof(BanknoteFaceValue));

        public UCChooseFaceValue(int withdrawAmount)
        {
            this.withdrawAmount = withdrawAmount;
            InitializeComponent();
        }

        public void SetAvailableBanknotes(Func<int, BanknoteFaceValue, Dictionary<BanknoteFaceValue, int>> supplier)
        {
            banknotesInfo = new Dictionary<BanknoteFaceValue, int>[banknotes.Length];

            for (int i = 0; i < banknotes.Length; i++)
            {
                banknotesInfo[i] = supplier(withdrawAmount, (BanknoteFaceValue)banknotes[i]);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Parent.Controls.RemoveAt(0);
        }

        private void CreateConfirmWithdrawInfo(int faceValue)
        {
            int index = Array.IndexOf(banknotes, faceValue);

            UCConfirmOperation cwi = new UCConfirmOperation(banknotesInfo[index], OperationType.Withdraw);
            Parent.Controls.Add(cwi);
            Parent.Controls.SetChildIndex(cwi, 0);
        }

        private void banknoteButton_Click(object sender, EventArgs e)
        {
            CreateConfirmWithdrawInfo(int.Parse(((Button)sender).Text));
        }

        private void CreateBanknoteButton(int faceValueIndex)
        {
            int offsetX = 167;
            int offsetY = 79;

            int i = faceValueIndex % 3;
            int j = faceValueIndex / 3;
            Button bt = new Button();
            bt.Name = $"banknote{banknotes[faceValueIndex]}Button";
            bt.Text = banknotes[faceValueIndex].ToString();
            bt.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            bt.Location = new System.Drawing.Point(69 + offsetX * i, 169 + offsetY * j);
            bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0f);
            bt.Height = 43;
            bt.Width = 98;

            panel2.Controls.Add(bt);

            bt.Click += banknoteButton_Click;

            if (banknotesInfo[faceValueIndex].Count == 0 || banknotesInfo[faceValueIndex][(BanknoteFaceValue)banknotes[faceValueIndex]] == 0)
            {
                bt.Enabled = false;
            }

        }

        public void CreateBanknoteControls()
        {
            int banknotesLength = banknotes.Length;

            for (int iter = 0; iter < banknotesLength; iter++)
            {
                CreateBanknoteButton(iter);
            }
        }
    }
}