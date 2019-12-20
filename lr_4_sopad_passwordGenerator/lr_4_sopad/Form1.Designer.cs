namespace lr_4_sopad
{
    partial class PasswordGeneratorForm
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
            this.CB_Letters = new System.Windows.Forms.CheckBox();
            this.CB_Numbers = new System.Windows.Forms.CheckBox();
            this.CB_Special_Symbols = new System.Windows.Forms.CheckBox();
            this.TB_Pass_Generated = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RB_Both = new System.Windows.Forms.RadioButton();
            this.RB_Uppercase = new System.Windows.Forms.RadioButton();
            this.RB_Lowercase = new System.Windows.Forms.RadioButton();
            this.TB_Pass_Length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Generate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.B_Copy_To_Clipboard = new System.Windows.Forms.Button();
            this.B_Choose_Special_Simbols = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Letters
            // 
            this.CB_Letters.AutoSize = true;
            this.CB_Letters.Location = new System.Drawing.Point(19, 5);
            this.CB_Letters.Name = "CB_Letters";
            this.CB_Letters.Size = new System.Drawing.Size(78, 24);
            this.CB_Letters.TabIndex = 1;
            this.CB_Letters.Text = "Letters";
            this.CB_Letters.UseVisualStyleBackColor = true;
            this.CB_Letters.CheckStateChanged += new System.EventHandler(this.CB_Letters_CheckStateChanged);
            // 
            // CB_Numbers
            // 
            this.CB_Numbers.AutoSize = true;
            this.CB_Numbers.Checked = true;
            this.CB_Numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Numbers.Location = new System.Drawing.Point(19, 125);
            this.CB_Numbers.Name = "CB_Numbers";
            this.CB_Numbers.Size = new System.Drawing.Size(92, 24);
            this.CB_Numbers.TabIndex = 2;
            this.CB_Numbers.Text = "Numbers";
            this.CB_Numbers.UseVisualStyleBackColor = true;
            // 
            // CB_Special_Symbols
            // 
            this.CB_Special_Symbols.AutoSize = true;
            this.CB_Special_Symbols.Location = new System.Drawing.Point(19, 155);
            this.CB_Special_Symbols.Name = "CB_Special_Symbols";
            this.CB_Special_Symbols.Size = new System.Drawing.Size(144, 24);
            this.CB_Special_Symbols.TabIndex = 3;
            this.CB_Special_Symbols.Text = "Special Symbols";
            this.CB_Special_Symbols.UseVisualStyleBackColor = true;
            // 
            // TB_Pass_Generated
            // 
            this.TB_Pass_Generated.Location = new System.Drawing.Point(12, 97);
            this.TB_Pass_Generated.MaxLength = 99;
            this.TB_Pass_Generated.Multiline = true;
            this.TB_Pass_Generated.Name = "TB_Pass_Generated";
            this.TB_Pass_Generated.ReadOnly = true;
            this.TB_Pass_Generated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Pass_Generated.Size = new System.Drawing.Size(247, 107);
            this.TB_Pass_Generated.TabIndex = 5;
            this.TB_Pass_Generated.TextChanged += new System.EventHandler(this.TB_Pass_Generated_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RB_Both);
            this.panel1.Controls.Add(this.RB_Uppercase);
            this.panel1.Controls.Add(this.RB_Lowercase);
            this.panel1.Controls.Add(this.CB_Letters);
            this.panel1.Controls.Add(this.CB_Numbers);
            this.panel1.Controls.Add(this.CB_Special_Symbols);
            this.panel1.Location = new System.Drawing.Point(297, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 184);
            this.panel1.TabIndex = 7;
            // 
            // RB_Both
            // 
            this.RB_Both.AutoSize = true;
            this.RB_Both.Checked = true;
            this.RB_Both.Enabled = false;
            this.RB_Both.Location = new System.Drawing.Point(39, 95);
            this.RB_Both.Name = "RB_Both";
            this.RB_Both.Size = new System.Drawing.Size(61, 24);
            this.RB_Both.TabIndex = 4;
            this.RB_Both.TabStop = true;
            this.RB_Both.Text = "Both";
            this.RB_Both.UseVisualStyleBackColor = true;
            // 
            // RB_Uppercase
            // 
            this.RB_Uppercase.AutoSize = true;
            this.RB_Uppercase.Enabled = false;
            this.RB_Uppercase.Location = new System.Drawing.Point(39, 65);
            this.RB_Uppercase.Name = "RB_Uppercase";
            this.RB_Uppercase.Size = new System.Drawing.Size(105, 24);
            this.RB_Uppercase.TabIndex = 3;
            this.RB_Uppercase.Text = "Uppercase";
            this.RB_Uppercase.UseVisualStyleBackColor = true;
            // 
            // RB_Lowercase
            // 
            this.RB_Lowercase.AutoSize = true;
            this.RB_Lowercase.Enabled = false;
            this.RB_Lowercase.Location = new System.Drawing.Point(39, 35);
            this.RB_Lowercase.Name = "RB_Lowercase";
            this.RB_Lowercase.Size = new System.Drawing.Size(104, 24);
            this.RB_Lowercase.TabIndex = 2;
            this.RB_Lowercase.Text = "Lowercase";
            this.RB_Lowercase.UseVisualStyleBackColor = true;
            // 
            // TB_Pass_Length
            // 
            this.TB_Pass_Length.Location = new System.Drawing.Point(210, 25);
            this.TB_Pass_Length.MaxLength = 4;
            this.TB_Pass_Length.Name = "TB_Pass_Length";
            this.TB_Pass_Length.Size = new System.Drawing.Size(49, 26);
            this.TB_Pass_Length.TabIndex = 4;
            this.TB_Pass_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Pass_Length.TextChanged += new System.EventHandler(this.TB_Pass_Length_TextChanged);
            this.TB_Pass_Length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Pass_Length_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insert length of password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generated password:";
            // 
            // B_Generate
            // 
            this.B_Generate.Enabled = false;
            this.B_Generate.Location = new System.Drawing.Point(189, 232);
            this.B_Generate.Name = "B_Generate";
            this.B_Generate.Size = new System.Drawing.Size(107, 31);
            this.B_Generate.TabIndex = 6;
            this.B_Generate.Text = "Generate";
            this.B_Generate.UseVisualStyleBackColor = true;
            this.B_Generate.Click += new System.EventHandler(this.B_Generate_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(6, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 196);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.B_Copy_To_Clipboard);
            this.panel3.Controls.Add(this.B_Choose_Special_Simbols);
            this.panel3.Location = new System.Drawing.Point(-1, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 64);
            this.panel3.TabIndex = 10;
            // 
            // B_Copy_To_Clipboard
            // 
            this.B_Copy_To_Clipboard.Enabled = false;
            this.B_Copy_To_Clipboard.Location = new System.Drawing.Point(21, 8);
            this.B_Copy_To_Clipboard.Name = "B_Copy_To_Clipboard";
            this.B_Copy_To_Clipboard.Size = new System.Drawing.Size(127, 48);
            this.B_Copy_To_Clipboard.TabIndex = 1;
            this.B_Copy_To_Clipboard.Text = "Copy to clipboard";
            this.B_Copy_To_Clipboard.UseVisualStyleBackColor = true;
            this.B_Copy_To_Clipboard.Click += new System.EventHandler(this.B_Copy_To_Clipboard_Click);
            // 
            // B_Choose_Special_Simbols
            // 
            this.B_Choose_Special_Simbols.Location = new System.Drawing.Point(337, 8);
            this.B_Choose_Special_Simbols.Name = "B_Choose_Special_Simbols";
            this.B_Choose_Special_Simbols.Size = new System.Drawing.Size(127, 48);
            this.B_Choose_Special_Simbols.TabIndex = 0;
            this.B_Choose_Special_Simbols.Text = "Choose special symbols";
            this.B_Choose_Special_Simbols.UseVisualStyleBackColor = true;
            this.B_Choose_Special_Simbols.Click += new System.EventHandler(this.B_Choose_Special_Simbols_Click);
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 292);
            this.Controls.Add(this.B_Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Pass_Length);
            this.Controls.Add(this.TB_Pass_Generated);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PasswordGeneratorForm";
            this.Text = "Password Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordGeneratorForm_FormClosing);
            this.Load += new System.EventHandler(this.PasswordGeneratorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Letters;
        private System.Windows.Forms.CheckBox CB_Numbers;
        private System.Windows.Forms.CheckBox CB_Special_Symbols;
        private System.Windows.Forms.TextBox TB_Pass_Generated;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_Pass_Length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Generate;
        private System.Windows.Forms.RadioButton RB_Both;
        private System.Windows.Forms.RadioButton RB_Uppercase;
        private System.Windows.Forms.RadioButton RB_Lowercase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button B_Choose_Special_Simbols;
        private System.Windows.Forms.Button B_Copy_To_Clipboard;

    }
}

