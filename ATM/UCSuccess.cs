using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class UCSuccess : UserControl
    {
        public UCSuccess()
        {
            InitializeComponent();
        }

        private void takeCard_Click(object sender, EventArgs e)
        {
            Control parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new UCGreeting());
        }
    }
}
