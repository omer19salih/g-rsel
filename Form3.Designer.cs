namespace Manavodev2
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
            this.adBox = new System.Windows.Forms.TextBox();
            this.soyadBox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.mailDogrulaPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.KodDogrulaBtn = new System.Windows.Forms.Button();
            this.koddogrulaBox = new System.Windows.Forms.TextBox();
            this.sifrebelirlePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SetSifreBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.sifreBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cikBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mailDogrulaPanel.SuspendLayout();
            this.sifrebelirlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adBox
            // 
            this.adBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adBox.Location = new System.Drawing.Point(102, 54);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(281, 27);
            this.adBox.TabIndex = 0;
            // 
            // soyadBox
            // 
            this.soyadBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadBox.Location = new System.Drawing.Point(102, 93);
            this.soyadBox.Name = "soyadBox";
            this.soyadBox.Size = new System.Drawing.Size(282, 27);
            this.soyadBox.TabIndex = 1;
            // 
            // MailBox
            // 
            this.MailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailBox.Location = new System.Drawing.Point(102, 140);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(281, 27);
            this.MailBox.TabIndex = 2;
            // 
            // mailDogrulaPanel
            // 
            this.mailDogrulaPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mailDogrulaPanel.Controls.Add(this.label6);
            this.mailDogrulaPanel.Controls.Add(this.KodDogrulaBtn);
            this.mailDogrulaPanel.Controls.Add(this.koddogrulaBox);
            this.mailDogrulaPanel.Location = new System.Drawing.Point(379, 299);
            this.mailDogrulaPanel.Name = "mailDogrulaPanel";
            this.mailDogrulaPanel.Size = new System.Drawing.Size(367, 132);
            this.mailDogrulaPanel.TabIndex = 6;
            this.mailDogrulaPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Maile Gelen Doğrulama kodunu Girin";
            // 
            // KodDogrulaBtn
            // 
            this.KodDogrulaBtn.BackgroundImage = global::Manavodev2.Properties.Resources.promo;
            this.KodDogrulaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KodDogrulaBtn.Location = new System.Drawing.Point(107, 72);
            this.KodDogrulaBtn.Name = "KodDogrulaBtn";
            this.KodDogrulaBtn.Size = new System.Drawing.Size(134, 45);
            this.KodDogrulaBtn.TabIndex = 1;
            this.KodDogrulaBtn.UseVisualStyleBackColor = true;
            this.KodDogrulaBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // koddogrulaBox
            // 
            this.koddogrulaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.koddogrulaBox.Location = new System.Drawing.Point(107, 44);
            this.koddogrulaBox.Name = "koddogrulaBox";
            this.koddogrulaBox.Size = new System.Drawing.Size(134, 27);
            this.koddogrulaBox.TabIndex = 0;
            // 
            // sifrebelirlePanel
            // 
            this.sifrebelirlePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sifrebelirlePanel.Controls.Add(this.label5);
            this.sifrebelirlePanel.Controls.Add(this.label4);
            this.sifrebelirlePanel.Controls.Add(this.SetSifreBtn);
            this.sifrebelirlePanel.Controls.Add(this.checkBox1);
            this.sifrebelirlePanel.Controls.Add(this.textBox7);
            this.sifrebelirlePanel.Controls.Add(this.sifreBox);
            this.sifrebelirlePanel.Location = new System.Drawing.Point(429, 109);
            this.sifrebelirlePanel.Name = "sifrebelirlePanel";
            this.sifrebelirlePanel.Size = new System.Drawing.Size(365, 184);
            this.sifrebelirlePanel.TabIndex = 7;
            this.sifrebelirlePanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tekrar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şifre :";
            // 
            // SetSifreBtn
            // 
            this.SetSifreBtn.BackgroundImage = global::Manavodev2.Properties.Resources.user;
            this.SetSifreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetSifreBtn.Location = new System.Drawing.Point(123, 122);
            this.SetSifreBtn.Name = "SetSifreBtn";
            this.SetSifreBtn.Size = new System.Drawing.Size(115, 50);
            this.SetSifreBtn.TabIndex = 3;
            this.SetSifreBtn.UseVisualStyleBackColor = true;
            this.SetSifreBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(236, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Gizle";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(99, 83);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(131, 27);
            this.textBox7.TabIndex = 1;
            // 
            // sifreBox
            // 
            this.sifreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreBox.Location = new System.Drawing.Point(99, 35);
            this.sifreBox.Name = "sifreBox";
            this.sifreBox.Size = new System.Drawing.Size(131, 27);
            this.sifreBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "İsim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-5, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-5, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-mail";
            // 
            // cikBtn
            // 
            this.cikBtn.BackColor = System.Drawing.Color.Transparent;
            this.cikBtn.BackgroundImage = global::Manavodev2.Properties.Resources.remove;
            this.cikBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikBtn.Location = new System.Drawing.Point(713, 0);
            this.cikBtn.Name = "cikBtn";
            this.cikBtn.Size = new System.Drawing.Size(75, 77);
            this.cikBtn.TabIndex = 10;
            this.cikBtn.UseVisualStyleBackColor = false;
            this.cikBtn.Click += new System.EventHandler(this.cikBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Manavodev2.Properties.Resources.add_group;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(75, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 56);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Manavodev2.Properties.Resources.manav_barkod_sistemi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.sifrebelirlePanel);
            this.Controls.Add(this.mailDogrulaPanel);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.soyadBox);
            this.Controls.Add(this.adBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.mailDogrulaPanel.ResumeLayout(false);
            this.mailDogrulaPanel.PerformLayout();
            this.sifrebelirlePanel.ResumeLayout(false);
            this.sifrebelirlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.TextBox soyadBox;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Panel mailDogrulaPanel;
        private System.Windows.Forms.Button KodDogrulaBtn;
        private System.Windows.Forms.TextBox koddogrulaBox;
        private System.Windows.Forms.Panel sifrebelirlePanel;
        private System.Windows.Forms.Button SetSifreBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox sifreBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cikBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}