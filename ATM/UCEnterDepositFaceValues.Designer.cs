namespace ATM
{
    partial class UCEnterDepositFaceValues
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
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.back.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.back.Controls.Add(this.withdrawLabel);
            this.back.Controls.Add(this.next);
            this.back.Controls.Add(this.prev);
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(563, 401);
            this.back.TabIndex = 10;
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdrawLabel.Location = new System.Drawing.Point(44, 26);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(484, 31);
            this.withdrawLabel.TabIndex = 45;
            this.withdrawLabel.Text = "Вставьте купюры в купюроприемник:";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.Location = new System.Drawing.Point(395, 341);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(97, 38);
            this.next.TabIndex = 11;
            this.next.Text = "Вперед";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prev.Location = new System.Drawing.Point(118, 341);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(97, 38);
            this.prev.TabIndex = 10;
            this.prev.Text = "Назад";
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.back_Click);
            // 
            // EnterDepositeFaceValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back);
            this.Name = "EnterDepositeFaceValues";
            this.Size = new System.Drawing.Size(563, 401);
            this.back.ResumeLayout(false);
            this.back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Label withdrawLabel;
    }
}
