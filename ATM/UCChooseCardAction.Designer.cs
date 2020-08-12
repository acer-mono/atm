namespace ATM
{
    partial class UCChooseCardAction
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.back = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.back.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.back.Controls.Add(this.button4);
            this.back.Controls.Add(this.depositButton);
            this.back.Controls.Add(this.withdrawButton);
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(563, 401);
            this.back.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(36, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 64);
            this.button4.TabIndex = 10;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button3
            // 
            this.depositButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositButton.Location = new System.Drawing.Point(311, 196);
            this.depositButton.Name = "button3";
            this.depositButton.Size = new System.Drawing.Size(213, 64);
            this.depositButton.TabIndex = 9;
            this.depositButton.Text = "Внести наличные";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withrowButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdrawButton.Location = new System.Drawing.Point(311, 108);
            this.withdrawButton.Name = "withrowButton";
            this.withdrawButton.Size = new System.Drawing.Size(213, 64);
            this.withdrawButton.TabIndex = 8;
            this.withdrawButton.Text = "Снять наличные";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // ChooseCardAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back);
            this.Name = "ChooseCardAction";
            this.Size = new System.Drawing.Size(563, 401);
            this.back.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button button4;
    }
}
