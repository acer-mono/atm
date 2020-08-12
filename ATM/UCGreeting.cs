using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class UCGreeting : UserControl
    {
        public UCGreeting()
        {
            InitializeComponent();
        }

        private void enterCard_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new UCChooseCardAction());
            Parent.Controls.RemoveAt(0);
        }
    }
}
