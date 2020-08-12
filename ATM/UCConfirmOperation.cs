using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ATM
{
    public partial class UCConfirmOperation : UserControl
    {
        private OperationType operation = OperationType.Withdraw;
        private Dictionary<BanknoteFaceValue, int> banknoteQuantities = new Dictionary<BanknoteFaceValue, int>();

        public Action<int, int> OnDeposit { get; set; }
        public Action<Dictionary<BanknoteFaceValue, int>> OnWithdraw { get; set; }

        public UCConfirmOperation(Dictionary<BanknoteFaceValue, int> banknoteQuantities, OperationType operation)
        {
            this.banknoteQuantities = banknoteQuantities;
            this.operation = operation;
            InitializeComponent();
            CreateBanknoteControls(banknoteQuantities);
        }

        private void CreateBanknoteControls(Dictionary<BanknoteFaceValue, int> banknotes)
        {
            int labelOffset = 25;
            int iter = 0;
            foreach (var keyvalue in banknotes)
            {
                if (keyvalue.Value != 0)
                {
                    string key = $"value{(int)keyvalue.Key}";
                    Label tb = new Label();
                    tb.Name = $"value{(int)keyvalue.Key}";
                    tb.Text = $"{(int)keyvalue.Key}    X    {keyvalue.Value}";
                    tb.Width = 200;
                    tb.TextAlign = ContentAlignment.BottomRight;
                    tb.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Italic);
                    tb.Location = new Point(130, 110 + iter * labelOffset);
                    panel2.Controls.Add(tb);

                    iter++;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Parent.Controls.RemoveAt(0);
        }

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                if (operation == OperationType.Deposit)
                {
                    int totalBanknotesQuantity = banknoteQuantities.Sum(el => el.Value);
                    int totalSum = banknoteQuantities.Sum(el => el.Value * (int)el.Key);

                    OnDeposit?.Invoke(totalSum, totalBanknotesQuantity);
                }
                else
                {
                    OnWithdraw?.Invoke(banknoteQuantities);
                }

                UCSuccess sc = new UCSuccess();
                Parent.Controls.Add(sc);
                Parent.Controls.SetChildIndex(sc, 0);
            } 
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
