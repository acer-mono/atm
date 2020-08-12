using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class MainForm : Form
    {
        private ATM atm;
        private int[] banknotes = (int[])Enum.GetValues(typeof(BanknoteFaceValue));

        public MainForm()
        {
            atm = new ATM();
            InitializeComponent();
            CreateBanknoteControls();
            startPanel.Controls.Add(new UCGreeting());
        }

        private void CreateBanknoteControls()
        {
            //кассета для выдачи купюр
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            tableLayoutPanel1.Controls.Add(new Label { Text = "Номинал", AutoSize = true }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label { Text = "Доступно для выдачи", AutoSize = true }, 1, 0);

            for (int iter = 0; iter < banknotes.Length; iter++)
            {
                tableLayoutPanel1.Controls.Add(new Label { Name = $"l{banknotes[iter]}", Text = $"{banknotes[iter]}",  AutoSize = true }, 0, iter + 1);
                tableLayoutPanel1.Controls.Add(new Label { Name = $"q{banknotes[iter]}", Text = $"{atm.GetWithdrawBanknotesQuantityByFaceValue((BanknoteFaceValue)banknotes[iter])}", AutoSize = true }, 1, iter + 1);
            }

            //кассета для внесения купюр
            tableLayoutPanel2.Controls.Add(new Label { Text = "Сумма для инкассации", AutoSize = true }, 0, 0);
            tableLayoutPanel2.Controls.Add(new Label { Text = "Доступно для внесения", AutoSize = true }, 1, 0);
            tableLayoutPanel2.Controls.Add(new Label { Name = "totalDepositAmount", Text = $"{atm.DepositAmount}", AutoSize = true }, 0, 1);
            tableLayoutPanel2.Controls.Add(new Label { Name = "depositAvailableBanknotes", Text = $"{atm.RemainingDepositBanknotesQuantity}", AutoSize = true }, 1, 1);
        }

        private void UpdateATMInfo()
        {
            foreach (int banknote in banknotes)
            {
                string quantity = atm.GetWithdrawBanknotesQuantityByFaceValue((BanknoteFaceValue)banknote).ToString();

                tableLayoutPanel1.Controls[$"q{banknote}"].Text = quantity;
            }

            tableLayoutPanel2.Controls["depositAvailableBanknotes"].Text = atm.RemainingDepositBanknotesQuantity.ToString();
            tableLayoutPanel2.Controls["totalDepositAmount"].Text = atm.DepositAmount.ToString();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            atm.Refresh();
            UpdateATMInfo();
        }

        private void startPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdateATMInfo();
        }

        private void startPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            switch (e.Control)
            {
                case UCChooseCardAction form:
                    form.ToggleDeposit(atm.IsDepositAvailable);
                    form.ToggleWithdraw(atm.IsWithdrawAvailable);
                    break;

                case UCChooseFaceValue form:
                    form.SetAvailableBanknotes((amount, banknote) => atm.GetAvailableBanknotes(amount, banknote));
                    break;

                case UCEnterDepositFaceValues form:
                    form.RemainingBanknotesQuantity = atm.RemainingDepositBanknotesQuantity;
                    break;

                case UCConfirmOperation form:
                    form.OnDeposit = (totalSum, banknotesQuantity) => atm.Deposit(totalSum, banknotesQuantity);
                    form.OnWithdraw = (banknotes) => atm.Withdraw(banknotes);
                    break;
            }
        }
    }
}
