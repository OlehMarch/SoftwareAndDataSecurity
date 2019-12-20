namespace lr_3_sopad
{
    partial class TrialForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.B_Accept = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert password to reset trial:";
            // 
            // B_Accept
            // 
            this.B_Accept.Location = new System.Drawing.Point(63, 74);
            this.B_Accept.Name = "B_Accept";
            this.B_Accept.Size = new System.Drawing.Size(75, 27);
            this.B_Accept.TabIndex = 1;
            this.B_Accept.Text = "Accept";
            this.B_Accept.UseVisualStyleBackColor = true;
            this.B_Accept.Click += new System.EventHandler(this.B_Accept_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(194, 74);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 27);
            this.B_Cancel.TabIndex = 2;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(13, 32);
            this.TB_Password.MaxLength = 29;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(304, 26);
            this.TB_Password.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_Password);
            this.panel1.Controls.Add(this.B_Accept);
            this.panel1.Controls.Add(this.B_Cancel);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 115);
            this.panel1.TabIndex = 4;
            // 
            // TrialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 138);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trial";
            this.Load += new System.EventHandler(this.TrialForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Accept;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Panel panel1;
    }
}

