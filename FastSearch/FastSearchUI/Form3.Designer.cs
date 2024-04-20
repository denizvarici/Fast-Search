namespace FastSearchUI
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnSearchOnChatGPT = new Button();
            tbxQuestion = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSearchOnChatGPT
            // 
            btnSearchOnChatGPT.Location = new Point(12, 12);
            btnSearchOnChatGPT.Name = "btnSearchOnChatGPT";
            btnSearchOnChatGPT.Size = new Size(286, 33);
            btnSearchOnChatGPT.TabIndex = 1;
            btnSearchOnChatGPT.Text = "ChatGPT'ye sor";
            btnSearchOnChatGPT.UseVisualStyleBackColor = true;
            btnSearchOnChatGPT.Click += btnSearchOnChatGPT_Click;
            // 
            // tbxQuestion
            // 
            tbxQuestion.Location = new Point(13, 71);
            tbxQuestion.Name = "tbxQuestion";
            tbxQuestion.Size = new Size(286, 27);
            tbxQuestion.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 53);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 3;
            label1.Text = "Metnin Sonuna Ekle:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 111);
            Controls.Add(tbxQuestion);
            Controls.Add(label1);
            Controls.Add(btnSearchOnChatGPT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Onay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchOnChatGPT;
        private TextBox tbxQuestion;
        private Label label1;
    }
}