using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace lr_3_sopad
{
    public partial class TrialForm : Form
    {
        public TrialForm()
        {
            InitializeComponent();
        }

        private string password = "69d59-B1y27-hD88A-a3kJg-34aRX";

        public static void SetValue(string key, object value)
        {
            RegistryKey currRegistryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\TrialProgram");
            if (currRegistryKey != null)
            {
                currRegistryKey.SetValue(key, value);
                currRegistryKey.Close();
            }
        }

        public static object GetValue(string key)
        {
            object val = null;

            RegistryKey currRegistryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\TrialProgram");
            if (currRegistryKey != null)
            {
                val = currRegistryKey.GetValue(key);
                currRegistryKey.Close();
            }

            return val;
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Accept_Click(object sender, EventArgs e)
        {
            if (TB_Password.Text.Equals(password))
            {
                TrialForm.SetValue("TrialProgram", (int) 3);
                MessageBox.Show("Trial is reset!");
                Close();
            }
            else
            {
                MessageBox.Show("Password isn't correct!");
                Close();
            }
        }

        private void TrialForm_Load(object sender, EventArgs e)
        {
            int value = (int)TrialForm.GetValue("TrialProgram");
            if (value > 0)
            {
                TrialForm.SetValue("TrialProgram", --value);
                MessageBox.Show("Left " + value.ToString() + " program executions!");
            }
            if (value == 0)
            {
                MessageBox.Show("Insert password to reset trial!");
            }
        }
    }
}