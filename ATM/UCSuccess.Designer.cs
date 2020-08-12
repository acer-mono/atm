namespace ATM
{
    partial class UCSuccess
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
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.takeCard = new System.Windows.Forms.Button();
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.withdrawPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.withdrawPanel.Controls.Add(this.takeCard);
            this.withdrawPanel.Controls.Add(this.withdrawLabel);
            this.withdrawPanel.Location = new System.Drawing.Point(0, 0);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(563, 401);
            this.withdrawPanel.TabIndex = 12;
            // 
            // takeCard
            // 
            this.takeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.takeCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.takeCard.Location = new System.Drawing.Point(167, 180);
            this.takeCard.Name = "takeCard";
            this.takeCard.Size = new System.Drawing.Size(213, 64);
            this.takeCard.TabIndex = 2;
            this.takeCard.Text = "Заберите карту";
            this.takeCard.UseVisualStyleBackColor = false;
            this.takeCard.Click += new System.EventHandler(this.takeCard_Click);
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdrawLabel.Location = new System.Drawing.Point(143, 64);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(282, 31);
            this.withdrawLabel.TabIndex = 0;
            this.withdrawLabel.Text = "Успешно завершено!";
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.withdrawPanel);
            this.Name = "Success";
            this.Size = new System.Drawing.Size(563, 401);
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Label withdrawLabel;
        private System.Windows.Forms.Button takeCard;
    }
}
