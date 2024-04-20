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
            notifyIcon.Visible = false; // Ba�lang��ta gizli simgeyi g�r�nmez yap�n
            notifyIcon.Click += NotifyIcon_Click;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide(); // Formu gizle
                notifyIcon.Visible = true; // Gizli simgeyi g�ster
            }
        }
        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            Show(); // Formu tekrar g�ster
            WindowState = FormWindowState.Normal; // Formun normal boyutta g�r�nmesini sa�la
            notifyIcon.Visible = false; // Gizli simgeyi gizle
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Fast Search uygulamas� panonuzda kopyalanm�� (Ctrl+C) olan metni h�zl� bir �ekilde Google Chrome �zerinden arat�r veya ChatGPT'ye giderek sorar. Uygulamay� k���ltme butonuna basarak arka planda da �al��mas�n� sa�layabilirsiniz. Windows'ta gizli simgeleri g�ster k�sm�ndan uygulamay� yeniden a�arak tamamen kapanmas�n� sa�layabilirsiniz. Bu uygulama Deniz Var�c� taraf�ndan geli�tirilmi�tir. https://github.com/denizvarici", "Fast Search", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
