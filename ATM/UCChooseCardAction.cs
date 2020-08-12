using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class UCChooseCardAction : UserControl
    {
        public UCChooseCardAction()
        {
            InitializeComponent();
        }

        public void ToggleDeposit(bool isDepositAvailable)
        {
            depositButton.Enabled = isDepositAvailable;
        }

        public void ToggleWithdraw(bool isWithdrawAvailable)
        {
            withdrawButton.Enabled = isWithdrawAvailable;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new UCGreeting());
            Parent.Controls.RemoveAt(0);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            UCEnterWithdrawAmount ewa = new UCEnterWithdrawAmount();
            Parent.Controls.Add(ewa);
            Parent.Controls.SetChildIndex(ewa, 0);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            UCEnterDepositFaceValues edfv = new UCEnterDepositFaceValues();
            Parent.Controls.Add(edfv);
            Parent.Controls.SetChildIndex(edfv, 0);
        }
    }
}
