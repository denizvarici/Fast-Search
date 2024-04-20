using NonInvasiveKeyboardHookLibrary;
using System.Diagnostics;

namespace FastSearchUI
{
    public partial class Form1 : Form
    {
        private NotifyIcon notifyIcon;
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            InitializeNotifyIcon();
            InitializeSearcher();
        }

        private void InitializeSearcher()
        {
            var keyboardHookManager = new KeyboardHookManager();
            keyboardHookManager.Start();


            keyboardHookManager.RegisterHotkey(new[] { NonInvasiveKeyboardHookLibrary.ModifierKeys.Shift, NonInvasiveKeyboardHookLibrary.ModifierKeys.Alt }, 0x43, () =>
            {
                OpenForm2();
            });
            keyboardHookManager.RegisterHotkey(new[] { NonInvasiveKeyboardHookLibrary.ModifierKeys.Shift, NonInvasiveKeyboardHookLibrary.ModifierKeys.Alt }, 0x47, () =>
            {
                OpenForm3();
            });
        }
        private void OpenForm2()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(OpenForm2));
                return;
            }

            Form2 form2 = new Form2();
            form2.Show();
        }
        private void OpenForm3()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(OpenForm3));
                return;
            }

            Form3 form3 = new Form3();
            form3.Show();
        }
        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = this.Icon; // Uygulama ikonunu kullanabilirsiniz
            notifyIcon.Visible = false; // Baþlangýçta gizli simgeyi görünmez yapýn
            notifyIcon.Click += NotifyIcon_Click;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide(); // Formu gizle
                notifyIcon.Visible = true; // Gizli simgeyi göster
            }
        }
        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            Show(); // Formu tekrar göster
            WindowState = FormWindowState.Normal; // Formun normal boyutta görünmesini saðla
            notifyIcon.Visible = false; // Gizli simgeyi gizle
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Fast Search uygulamasý panonuzda kopyalanmýþ (Ctrl+C) olan metni hýzlý bir þekilde Google Chrome üzerinden aratýr veya ChatGPT'ye giderek sorar. Uygulamayý küçültme butonuna basarak arka planda da çalýþmasýný saðlayabilirsiniz. Windows'ta gizli simgeleri göster kýsmýndan uygulamayý yeniden açarak tamamen kapanmasýný saðlayabilirsiniz. Bu uygulama Deniz Varýcý tarafýndan geliþtirilmiþtir. https://github.com/denizvarici", "Fast Search", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void lnkLabelDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "chrome.exe";
            startInfo.Arguments = "https://www.denizvarici.com.tr";
            Process.Start(startInfo);
        }
    }
}
