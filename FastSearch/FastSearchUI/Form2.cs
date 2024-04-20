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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSearchOnGoogle_Click(object sender, EventArgs e)
        {
            SearchChrome();
        }
        private void SearchChrome()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(SearchChrome));
                return;
            }
            string copiedText = Clipboard.GetText();
            string question = tbxQuestion.Text;
            try
            {
                if (!string.IsNullOrEmpty(copiedText))
                {
                    string searchQuery = copiedText +" "+ question + " ";
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "chrome.exe";
                    startInfo.Arguments = "--start-fullscreen -incognito www.google.com"; // Chrome'u gizli modda başlatmak için -incognito parametresini kullanın
                    Process.Start(startInfo);
                    Thread.Sleep(3000);

                    SendKeys.SendWait("^l");

                    SendKeys.SendWait(searchQuery);

                    SendKeys.SendWait("{BACKSPACE}");

                    SendKeys.SendWait("{ENTER}");

                }
                else
                {
                    MessageBox.Show("Panoya kopyalanan metin bulunamadı.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("özel karakterlerden dolayı hata oluştu!");
            }

            this.Hide();
        }
    }
}
