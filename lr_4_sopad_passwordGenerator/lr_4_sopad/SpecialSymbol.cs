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
    public partial class SpecialSymbol : Form
    {
        public SpecialSymbol()
        {
            InitializeComponent();
        }

        private bool value = true;
        private string symbols = "";

        private void B_Check_All_Click(object sender, EventArgs e)
        {
            if (value)
            {
                CB_Checker(true);
                value = false;
                B_Check_All.Text = "Uncheck all";
            }
            else
            {
                CB_Checker(false);
                value = true;
                B_Check_All.Text = "Check all";
            }     
        }

        private void CB_Checker(bool value)
        {
            CB_Ampersand.Checked = value;
            CB_Angular_Closing_Bracket.Checked = value;
            CB_Angular_Opening_Bracket.Checked = value;
            CB_At_Sign.Checked = value;
            CB_Back_Apostrophe.Checked = value;
            CB_Backslash.Checked = value;
            CB_Caret.Checked = value;
            CB_Closing_Brace.Checked = value;
            CB_Closing_Bracket.Checked = value;
            CB_Closing_Parenthese.Checked = value;
            CB_Opening_Brace.Checked = value;
            CB_Opening_Bracket.Checked = value;
            CB_Opening_Parenthese.Checked = value;
            CB_Colon.Checked = value;
            CB_Comma.Checked = value;
            CB_Dollar_Sign.Checked = value;
            CB_Dot.Checked = value;
            CB_Double_Quotes.Checked = value;
            CB_Equals_Sign.Checked = value;
            CB_Exclamation_Point.Checked = value;
            CB_Hash.Checked = value;
            CB_Minus_Sign.Checked = value;
            CB_Percent_Sign.Checked = value;
            CB_Plus_Sign.Checked = value;
            CB_Question_Sign.Checked = value;
            CB_Quote.Checked = value;
            CB_Semicolon.Checked = value;
            CB_Slash.Checked = value;
            CB_Tilde.Checked = value;
            CB_Vertical_Bar.Checked = value;
        }

        private void symbolsToWrite()
        {
            if (CB_Ampersand.Checked) symbols +=  CB_Ampersand.Text[0];
            if (CB_Angular_Closing_Bracket.Checked) symbols += CB_Angular_Closing_Bracket.Text;
            if (CB_Angular_Opening_Bracket.Checked) symbols += CB_Angular_Opening_Bracket.Text;
            if (CB_At_Sign.Checked) symbols += CB_At_Sign.Text;
            if (CB_Back_Apostrophe.Checked) symbols += CB_Back_Apostrophe.Text;
            if (CB_Backslash.Checked) symbols += CB_Backslash.Text;
            if (CB_Caret.Checked) symbols += CB_Caret.Text;
            if (CB_Closing_Brace.Checked) symbols += CB_Closing_Brace.Text;
            if (CB_Closing_Bracket.Checked) symbols += CB_Closing_Bracket.Text;
            if (CB_Closing_Parenthese.Checked) symbols += CB_Closing_Parenthese.Text;
            if (CB_Opening_Brace.Checked) symbols += CB_Opening_Brace.Text;
            if (CB_Opening_Bracket.Checked) symbols += CB_Opening_Bracket.Text;
            if (CB_Opening_Parenthese.Checked) symbols += CB_Opening_Parenthese.Text;
            if (CB_Colon.Checked) symbols += CB_Colon.Text;
            if (CB_Comma.Checked) symbols += CB_Comma.Text;
            if (CB_Dollar_Sign.Checked) symbols += CB_Dollar_Sign.Text;
            if (CB_Dot.Checked) symbols += CB_Dot.Text;
            if (CB_Double_Quotes.Checked) symbols += CB_Double_Quotes.Text;
            if (CB_Equals_Sign.Checked) symbols += CB_Equals_Sign.Text;
            if (CB_Exclamation_Point.Checked) symbols += CB_Exclamation_Point.Text;
            if (CB_Hash.Checked) symbols += CB_Hash.Text;
            if (CB_Minus_Sign.Checked) symbols += CB_Minus_Sign.Text;
            if (CB_Percent_Sign.Checked) symbols += CB_Percent_Sign.Text;
            if (CB_Plus_Sign.Checked) symbols += CB_Plus_Sign.Text;
            if (CB_Question_Sign.Checked) symbols += CB_Question_Sign.Text;
            if (CB_Quote.Checked) symbols += CB_Quote.Text;
            if (CB_Semicolon.Checked) symbols += CB_Semicolon.Text;
            if (CB_Slash.Checked) symbols += CB_Slash.Text;
            if (CB_Tilde.Checked) symbols += CB_Tilde.Text;
            if (CB_Vertical_Bar.Checked) symbols += CB_Vertical_Bar.Text;
        }

        private void loadCheckBoxexState()
        {
            if (!symbols.Equals("*_"))
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    CB_Ampersand.Checked = (CB_Ampersand.Text[0] == symbols[i]) ? true : CB_Ampersand.Checked;
                    CB_Angular_Closing_Bracket.Checked = (CB_Angular_Closing_Bracket.Text[0] == symbols[i]) ? true : CB_Angular_Closing_Bracket.Checked;
                    CB_Angular_Opening_Bracket.Checked = (CB_Angular_Opening_Bracket.Text[0] == symbols[i]) ? true : CB_Angular_Opening_Bracket.Checked;
                    CB_At_Sign.Checked = (CB_At_Sign.Text[0] == symbols[i]) ? true : CB_At_Sign.Checked;
                    CB_Back_Apostrophe.Checked = (CB_Back_Apostrophe.Text[0] == symbols[i]) ? true : CB_Back_Apostrophe.Checked;
                    CB_Backslash.Checked = (CB_Backslash.Text[0] == symbols[i]) ? true : CB_Backslash.Checked;
                    CB_Caret.Checked = (CB_Caret.Text[0] == symbols[i]) ? true : CB_Caret.Checked;
                    CB_Closing_Brace.Checked = (CB_Closing_Brace.Text[0] == symbols[i]) ? true : CB_Closing_Brace.Checked;
                    CB_Closing_Bracket.Checked = (CB_Closing_Bracket.Text[0] == symbols[i]) ? true : CB_Closing_Bracket.Checked;
                    CB_Closing_Parenthese.Checked = (CB_Closing_Parenthese.Text[0] == symbols[i]) ? true : CB_Closing_Parenthese.Checked;
                    CB_Opening_Brace.Checked = (CB_Opening_Brace.Text[0] == symbols[i]) ? true : CB_Opening_Brace.Checked;
                    CB_Opening_Bracket.Checked = (CB_Opening_Bracket.Text[0] == symbols[i]) ? true : CB_Opening_Bracket.Checked;
                    CB_Opening_Parenthese.Checked = (CB_Opening_Parenthese.Text[0] == symbols[i]) ? true : CB_Opening_Parenthese.Checked;
                    CB_Colon.Checked = (CB_Colon.Text[0] == symbols[i]) ? true : CB_Colon.Checked;
                    CB_Comma.Checked = (CB_Comma.Text[0] == symbols[i]) ? true : CB_Comma.Checked;
                    CB_Dollar_Sign.Checked = (CB_Dollar_Sign.Text[0] == symbols[i]) ? true : CB_Dollar_Sign.Checked;
                    CB_Dot.Checked = (CB_Dot.Text[0] == symbols[i]) ? true : CB_Dot.Checked;
                    CB_Double_Quotes.Checked = (CB_Double_Quotes.Text[0] == symbols[i]) ? true : CB_Double_Quotes.Checked;
                    CB_Equals_Sign.Checked = (CB_Equals_Sign.Text[0] == symbols[i]) ? true : CB_Equals_Sign.Checked;
                    CB_Exclamation_Point.Checked = (CB_Exclamation_Point.Text[0] == symbols[i]) ? true : CB_Exclamation_Point.Checked;
                    CB_Hash.Checked = (CB_Hash.Text[0] == symbols[i]) ? true : CB_Hash.Checked;
                    CB_Minus_Sign.Checked = (CB_Minus_Sign.Text[0] == symbols[i]) ? true : CB_Minus_Sign.Checked;
                    CB_Percent_Sign.Checked = (CB_Percent_Sign.Text[0] == symbols[i]) ? true : CB_Percent_Sign.Checked;
                    CB_Plus_Sign.Checked = (CB_Plus_Sign.Text[0] == symbols[i]) ? true : CB_Plus_Sign.Checked;
                    CB_Question_Sign.Checked = (CB_Question_Sign.Text[0] == symbols[i]) ? true : CB_Question_Sign.Checked;
                    CB_Quote.Checked = (CB_Quote.Text[0] == symbols[i]) ? true : CB_Quote.Checked;
                    CB_Semicolon.Checked = (CB_Semicolon.Text[0] == symbols[i]) ? true : CB_Semicolon.Checked;
                    CB_Slash.Checked = (CB_Slash.Text[0] == symbols[i]) ? true : CB_Slash.Checked;
                    CB_Tilde.Checked = (CB_Tilde.Text[0] == symbols[i]) ? true : CB_Tilde.Checked;
                    CB_Vertical_Bar.Checked = (CB_Vertical_Bar.Text[0] == symbols[i]) ? true : CB_Vertical_Bar.Checked;
                }
            }
        }

        private void Form_Close(object sender, FormClosingEventArgs e)
        {
            StreamWriter sW = new StreamWriter("symbols.txt");
            sW.Write(CB_Asterisk.Text + CB_Underscore.Text);
            symbols = "";
            symbolsToWrite();
            sW.Write(symbols);
            sW.Close();      
        }

        private void SpecialSymbol_Load(object sender, EventArgs e)
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
            loadCheckBoxexState();
        }

        private void B_Accept_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
