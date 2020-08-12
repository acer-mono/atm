using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATM
{
    public partial class UCEnterDepositFaceValues : UserControl
    {
        private int totalFaceValueQuantity = 0;
        private int[] banknotes = (int[])Enum.GetValues(typeof(BanknoteFaceValue));
        public int RemainingBanknotesQuantity { get; set; }
        public UCEnterDepositFaceValues()
        {
            InitializeComponent();
            CreateBanknoteControls();
        }

        private void ToggleControls(bool enabled)
        {
            foreach (int banknote in banknotes)
            {
                back.Controls[$"banknote{banknote}Control"].Controls[$"inc{banknote}Button"].Enabled = enabled;
            }
        }

        private void BlockControls()
        {
            ToggleControls(false);
        }

        private void UnblockControls()
        {
            ToggleControls(true);
        }

        private void Increment(TextBox tb)
        {
            if (totalFaceValueQuantity >= RemainingBanknotesQuantity)
            {
                BlockControls();
            }
            else
            {
                totalFaceValueQuantity++;
                tb.Text = (Int32.Parse(tb.Text) + 1).ToString();
            }
        }

        private void Decrement(TextBox tb)
        {
            if (Int32.Parse(tb.Text) > 0)
            {
                totalFaceValueQuantity--;
                if (totalFaceValueQuantity < RemainingBanknotesQuantity)
                {
                    UnblockControls();
                }
                tb.Text = (Int32.Parse(tb.Text) - 1).ToString();
            }
        }

        public void CreateBanknoteControls()
        {
            int banknotesLength = banknotes.Length;

            for (int iter = 0; iter < banknotesLength; iter++)
            {
                int i = iter % 2;
                int j = iter / 2;

                //Панель для контрола банкноты
                Panel pl = new Panel
                {
                    Name = $"banknote{banknotes[iter]}Control",
                    Height = 50,
                    Width = 250
                };

                //Название банкноты
                Label banknoteLabel = new Label
                {
                    Name = $"banknote{banknotes[iter]}Label",
                    Text = banknotes[iter].ToString(),
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 20.0f),
                    Height = 50,
                    Width = 80,
                    TextAlign = System.Drawing.ContentAlignment.TopRight
                };
                pl.Controls.Add(banknoteLabel);
                banknoteLabel.Location = new System.Drawing.Point(10, 0);

                //Кнопка для уменьшения на единицу
                Button decButton = new Button
                {
                    Name = $"dec{banknotes[iter]}Button",
                    Text = "-",
                    Tag = banknotes[iter].ToString(),
                    BackColor = System.Drawing.Color.FromArgb(255, 192, 255),
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0f),
                    Height = 40,
                    Width = 40
                };
                pl.Controls.Add(decButton);
                decButton.Click += decrement_Click;
                decButton.Location = new System.Drawing.Point(90, 0);

                //Поле для значений
                TextBox bf = new TextBox
                {
                    Name = $"banknote{banknotes[iter]}Value",
                    Text = "0",
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 18.0f),
                    Enabled = false,
                    Height = 40,
                    Width = 44,
                    TextAlign = HorizontalAlignment.Center
                };
                pl.Controls.Add(bf);
                bf.Location = new System.Drawing.Point(140, 3);

                //Кнопка для увеличения на единицу
                Button incButton = new Button
                {
                    Name = $"inc{banknotes[iter]}Button",
                    Text = "+",
                    Tag = banknotes[iter].ToString(),
                    BackColor = System.Drawing.Color.FromArgb(255, 192, 255),
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0f),
                    Height = 40,
                    Width = 40
                };
                pl.Controls.Add(incButton);
                incButton.Click += increment_Click;
                incButton.Location = new System.Drawing.Point(194, 0);

                back.Controls.Add(pl);
                pl.Location = new System.Drawing.Point(260 * i, 100 + 50 * j);
            }
        }

        private TextBox GetTextBoxByFaceValue(string faceValue)
        {
            return (TextBox)back.Controls[$"banknote{faceValue}Control"].Controls[$"banknote{faceValue}Value"];
        }

        private void increment_Click(object sender, EventArgs e)
        {
            string faceValue = ((Button)sender).Tag.ToString();
            Increment(GetTextBoxByFaceValue(faceValue));
        }

        private void decrement_Click(object sender, EventArgs e)
        {
            string faceValue = ((Button)sender).Tag.ToString();
            Decrement(GetTextBoxByFaceValue(faceValue));
        }

        private void back_Click(object sender, EventArgs e)
        {
            Parent.Controls.RemoveAt(0);
        }

        private void next_Click(object sender, EventArgs e)
        {
            Dictionary<BanknoteFaceValue, int> faceValueQuantity = new Dictionary<BanknoteFaceValue, int>();

            foreach (int current in banknotes)
            {
                faceValueQuantity[(BanknoteFaceValue) current] = int.Parse(GetTextBoxByFaceValue(current.ToString()).Text);
            }

            if (totalFaceValueQuantity != 0)
            {
                UCConfirmOperation co = new UCConfirmOperation(faceValueQuantity, OperationType.Deposit);
                Parent.Controls.Add(co);
                Parent.Controls.SetChildIndex(co, 0);
            }
        }
    }
}
