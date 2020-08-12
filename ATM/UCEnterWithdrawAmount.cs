using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class UCEnterWithdrawAmount : UserControl
    {
        public UCEnterWithdrawAmount()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Parent.Controls.RemoveAt(0);
        }

        private void pressDigital(int value)
        {
            if (value == 0 && withdrawText.Text.Length == 0)
            {
                return;
            }
            if (withdrawText.Text.Length <= 5)
            {
                withdrawText.Text += value.ToString();
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            pressDigital(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            pressDigital(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            pressDigital(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            pressDigital(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            pressDigital(5);
        }

        private void six_Click(object sender, EventArgs e)
        {
            pressDigital(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            pressDigital(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            pressDigital(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            pressDigital(9);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            pressDigital(0);
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            int stringLength = withdrawText.Text.Length;
            if (stringLength > 0)
            {
                withdrawText.Text = withdrawText.Text.Remove(stringLength - 1);
            }
        }

        private void enterWithdraw_Click(object sender, EventArgs e)
        {
            if (withdrawText.Text != "")
            {
                UCChooseFaceValue cw = new UCChooseFaceValue(int.Parse(withdrawText.Text));
                Parent.Controls.Add(cw);
                cw.CreateBanknoteControls();
                Parent.Controls.SetChildIndex(cw, 0);
            }
        }
    }
}