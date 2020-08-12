namespace ATM
{
    partial class UCGreeting
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
            this.startPanel = new System.Windows.Forms.Panel();
            this.enterCard = new System.Windows.Forms.Button();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startPanel.Controls.Add(this.enterCard);
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(563, 401);
            this.startPanel.TabIndex = 8;
            // 
            // enterCard
            // 
            this.enterCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.enterCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterCard.Location = new System.Drawing.Point(167, 180);
            this.enterCard.Name = "enterCard";
            this.enterCard.Size = new System.Drawing.Size(213, 64);
            this.enterCard.TabIndex = 1;
            this.enterCard.Text = "Вставьте карту";
            this.enterCard.UseVisualStyleBackColor = false;
            this.enterCard.Click += new System.EventHandler(this.enterCard_Click);
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startPanel);
            this.Name = "Greeting";
            this.Size = new System.Drawing.Size(563, 401);
            this.startPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button enterCard;
    }
}
