using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lr_4_sopad
{
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }

        private int Length;
        private string symbols;

        private void TB_Pass_Length_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((!Char.IsDigit(symbol)) && (symbol != 8))
            {
                e.Handled = true;
            }
        }

        private void TB_Pass_Length_TextChanged(object sender, EventArgs e)
        {
            if (TB_Pass_Length.TextLength != 0)
            {
                B_Generate.Enabled = true;
            }
            else
            {
                B_Generate.Enabled = false;
            }
        }

        private void B_Generate_Click(object sender, EventArgs e)
        {
            Length = stoi(TB_Pass_Length.Text);
            if (Length < 6)
            {
                MessageBox.Show(this, "Length of password must be more than 5 symbols");
            }
            else
            {
                TB_Pass_Generated.Text = passGenerator();
            }
        }

        private int stoi(string value)
        {
            int intValue = 0;
            for (int i = value.Length - 1, counter = 1; i >= 0; i--, counter *= 10)
            {
                if (counter == 1)
                {
                    intValue = (char)value[i] - 48;
                }
                else
                {
                    intValue += counter * ((char)value[i] - 48);
                }
            }
            return intValue;
        }

        private string atos(char[] symbolArray)
        {
            string pass = "";
            for (int i = 0; i < symbolArray.Length; i++)
            {
                pass += symbolArray[i];
            }
            return pass;
        }

        private string passGenerator()
        {
            string pass = "";

            if (CB_Numbers.Checked && !CB_Letters.Checked && !CB_Special_Symbols.Checked)
            {
            // only numbers
                Random rnd = new Random();
                for (int i = 0; i < Length; i++)
                {
                    pass += rnd.Next(0, 10);
                }
                return pass;
            }
            else if (!CB_Numbers.Checked && CB_Letters.Checked && !CB_Special_Symbols.Checked)
            {
            // only letters
                pass = letterRanomization(pass);
                return pass;
            }
            else if (!CB_Numbers.Checked && !CB_Letters.Checked && CB_Special_Symbols.Checked)
            {
            // only special symbols
                MessageBox.Show(this, "Special symbols mustn't be used\nwithout Letters or Numbers!");
                return "Special symbols mustn't be used without Letters or Numbers!";
            }
            else if (CB_Numbers.Checked && CB_Letters.Checked && !CB_Special_Symbols.Checked)
            {
            // letters and numbers
                pass = letterRanomization(pass);
                char[] symbolArray = pass.ToCharArray(); 
                Random rnd = new Random();
                for (int i = 0; i < Length * 3 / 4; i++)
                {
                    symbolArray[rnd.Next(Length - 1)] = (char)(rnd.Next(0, 10) + 48);
                }
                return atos(symbolArray);
            }
            else if (CB_Numbers.Checked && !CB_Letters.Checked && CB_Special_Symbols.Checked)
            {
            // numbers and special symbols
                symbolsLoader();
                Random rnd = new Random();
                for (int i = 0; i < Length; i++)
                {
                    pass += rnd.Next(0, 10);
                }
                char[] symbolArray = pass.ToCharArray();
                for (int i = 0; i < Length / 4; i++)
                {
                    symbolArray[rnd.Next(Length - 1)] = @symbols[rnd.Next(0, symbols.Length)];
                }
                return atos(symbolArray);
            }
            else if (!CB_Numbers.Checked && CB_Letters.Checked && CB_Special_Symbols.Checked)
            {
            // letters and special symbols
                symbolsLoader();
                pass = letterRanomization(pass);
                char[] symbolArray = pass.ToCharArray();
                Random rnd = new Random();
                for (int i = 0; i < Length / 4; i++)
                {
                    symbolArray[rnd.Next(Length - 1)] = @symbols[rnd.Next(0, symbols.Length)];
                }
                return atos(symbolArray);
            }
            else if (CB_Numbers.Checked && CB_Letters.Checked && CB_Special_Symbols.Checked)
            {
            // numbers, letters and special symbols
                symbolsLoader();
                pass = letterRanomization(pass);
                char[] symbolArray = pass.ToCharArray();
                Random rnd = new Random();
                for (int i = 0; i < Length * 3 / 4; i++)
                {
                    symbolArray[rnd.Next(Length - 1)] = (char)(rnd.Next(0, 10) + 48);
                }
                for (int i = 0; i < Length / 4; i++)
                {
                    symbolArray[rnd.Next(Length - 1)] = @symbols[rnd.Next(0, symbols.Length)];
                }
                return atos(symbolArray);
            }
            else
            {
            // nothing have been chosen
                MessageBox.Show(this, "Unknown Error!");
                return "Unknown Error!";
            }
        }

        private string letterRanomization(string pass)
        {
            Random rnd = new Random();
            int symbol;
            if (RB_Lowercase.Checked)
            {
                for (int i = 0; i < Length; i++)
                {
                    symbol = rnd.Next(97, 123);
                    pass += (char)symbol;
                }
            }
            else if (RB_Uppercase.Checked)
            {
                for (int i = 0; i < Length; i++)
                {
                    symbol = rnd.Next(65, 91);
                    pass += (char)symbol;
                }
            }
            else if (RB_Both.Checked)
            {
                for (int i = 0; i < Length / 2; i++)
                {
                    if (rnd.Next(2) == 1)
                    {
                        symbol = rnd.Next(65, 91);
                        pass += (char)symbol;
                        symbol = rnd.Next(97, 123);
                        pass += (char)symbol;
                    }
                    else
                    {
                        symbol = rnd.Next(97, 123);
                        pass += (char)symbol;
                        symbol = rnd.Next(65, 91);
                        pass += (char)symbol;
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Unknown Error!");
                return "Unknown Error!";
            }
            return pass;
        }

        private void CB_Letters_CheckStateChanged(object sender, EventArgs e)
        {
            if (CB_Letters.Checked)
            {
                RB_Both.Enabled = true;
                RB_Lowercase.Enabled = true;
                RB_Uppercase.Enabled = true;
            }
            else
            {
                RB_Both.Enabled = false;
                RB_Lowercase.Enabled = false;
                RB_Uppercase.Enabled = false;
            }
        }

        private void B_Choose_Special_Simbols_Click(object sender, EventArgs e)
        {
            SpecialSymbol spSimbol = new SpecialSymbol();
            spSimbol.ShowDialog();
        }

        private void symbolsLoader()
        {
            try
            {
                StreamReader sR = new StreamReader("symbols.txt");
                symbols = sR.ReadToEnd();
                sR.Close();
            }
            catch
            {
                symbols = "*_";
            }
        }

        private void PasswordGeneratorForm_Load(object sender, EventArgs e)
        {
            symbolsLoader();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.CB_Special_Symbols, "By default, special \nsymbols are: \'*\' and \'_\'");
            toolTip1.SetToolTip(this.CB_Numbers, "The range is: \"0-9\"");
            toolTip1.SetToolTip(this.RB_Both, "The range is: \"a-zA-Z\"");
            toolTip1.SetToolTip(this.RB_Lowercase, "The range is: \"a-z\"");
            toolTip1.SetToolTip(this.RB_Uppercase, "The range is: \"A-Z\"");
            toolTip1.SetToolTip(this.TB_Pass_Length, "The range is: \"6-9999\"");
        }

        private void PasswordGeneratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("symbols.txt");
        }

        private void B_Copy_To_Clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TB_Pass_Generated.Text);
        }

        private void TB_Pass_Generated_TextChanged(object sender, EventArgs e)
        {
            if (TB_Pass_Generated.Text.Length != 0)
            {
                B_Copy_To_Clipboard.Enabled = true;
            }
            else
            {
                B_Copy_To_Clipboard.Enabled = false;
            }
        }

    }
}