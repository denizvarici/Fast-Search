using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastSearchUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSearchOnChatGPT_Click(object sender, EventArgs e)
        {
            SearchChatGPT();
        }
        private void SearchChatGPT()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(SearchChatGPT));
                return;
            }
            string copiedText = Clipboard.GetText();
            string question = " " + tbxQuestion.Text;
            //Clipboard.SetText(Clipboard.GetText() + " " + question);
            copiedText = copiedText +" " + question;
            try
            {
                if (!string.IsNullOrEmpty(copiedText))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "chrome.exe";
                    startInfo.Arguments = "-incognito";
                    Process.Start(startInfo);
                    Thread.Sleep(2000);
                    SendKeys.SendWait("^l");
                    string searchQuery = "https://chat.openai.com/";
                    SendKeys.SendWait(searchQuery);
                    SendKeys.SendWait("{ENTER}");
                    Thread.Sleep(10000);
                    SendKeys.SendWait("^{v}");
                    SendKeys.SendWait(question);
                    SendKeys.SendWait("{ENTER}");
                }
                else
                {
                    MessageBox.Show("Panoya kopyalanan metin bulunamadı.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu!");
            }
            
            this.Hide();
        }
    }
}
