namespace FastSearchUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            lnkLabelDev = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 0;
            label1.Text = "Search On Google : Shift+Alt+C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 42);
            label2.Name = "label2";
            label2.Size = new Size(226, 20);
            label2.TabIndex = 1;
            label2.Text = "Search On ChatGPT : Shift+Alt+G";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(254, 75);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(35, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Info";
            linkLabel1.VisitedLinkColor = Color.Blue;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(12, 217);
            button1.Name = "button1";
            button1.Size = new Size(277, 29);
            button1.TabIndex = 3;
            button1.Text = "Panodaki Metni görüntüle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(12, 252);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(277, 168);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // lnkLabelDev
            // 
            lnkLabelDev.AutoSize = true;
            lnkLabelDev.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            lnkLabelDev.Location = new Point(12, 81);
            lnkLabelDev.Name = "lnkLabelDev";
            lnkLabelDev.Size = new Size(119, 12);
            lnkLabelDev.TabIndex = 6;
            lnkLabelDev.TabStop = true;
            lnkLabelDev.Text = "Developed By Deniz Varıcı";
            lnkLabelDev.VisitedLinkColor = Color.Blue;
            lnkLabelDev.LinkClicked += lnkLabelDev_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 100);
            Controls.Add(lnkLabelDev);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fast Search";
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button button1;
        private RichTextBox richTextBox1;
        private LinkLabel lnkLabelDev;
    }
}
