namespace FastSearchUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnSearchOnGoogle = new Button();
            label1 = new Label();
            tbxQuestion = new TextBox();
            SuspendLayout();
            // 
            // btnSearchOnGoogle
            // 
            btnSearchOnGoogle.Location = new Point(12, 12);
            btnSearchOnGoogle.Name = "btnSearchOnGoogle";
            btnSearchOnGoogle.Size = new Size(286, 33);
            btnSearchOnGoogle.TabIndex = 0;
            btnSearchOnGoogle.Text = "Google'da Ara";
            btnSearchOnGoogle.UseVisualStyleBackColor = true;
            btnSearchOnGoogle.Click += btnSearchOnGoogle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Metnin Sonuna Ekle:";
            // 
            // tbxQuestion
            // 
            tbxQuestion.Location = new Point(12, 66);
            tbxQuestion.Name = "tbxQuestion";
            tbxQuestion.Size = new Size(286, 27);
            tbxQuestion.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 107);
            Controls.Add(tbxQuestion);
            Controls.Add(label1);
            Controls.Add(btnSearchOnGoogle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Onay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchOnGoogle;
        private Label label1;
        private TextBox tbxQuestion;
    }
}