namespace Manavodev2
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mailDogrulaBox = new System.Windows.Forms.TextBox();
            this.kodDogrulaBox = new System.Windows.Forms.TextBox();
            this.yenisifreBox = new System.Windows.Forms.TextBox();
            this.sifreTekrarBox = new System.Windows.Forms.TextBox();
            this.dogrulaPanel = new System.Windows.Forms.Panel();
            this.sifreYenilePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.sifreBelirleBtn = new System.Windows.Forms.Button();
            this.kodDogrulaBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.mailDogrulamaBox = new System.Windows.Forms.Button();
            this.dogrulaPanel.SuspendLayout();
            this.sifreYenilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(242, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "sifremi unuttum sayfası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "hesap maili";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(107, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kodu giriniz ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "yeni sifre :";
            // 
            // mailDogrulaBox
            // 
            this.mailDogrulaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailDogrulaBox.Location = new System.Drawing.Point(160, 105);
            this.mailDogrulaBox.Name = "mailDogrulaBox";
            this.mailDogrulaBox.Size = new System.Drawing.Size(184, 27);
            this.mailDogrulaBox.TabIndex = 4;
            // 
            // kodDogrulaBox
            // 
            this.kodDogrulaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodDogrulaBox.Location = new System.Drawing.Point(100, 63);
            this.kodDogrulaBox.Name = "kodDogrulaBox";
            this.kodDogrulaBox.Size = new System.Drawing.Size(156, 27);
            this.kodDogrulaBox.TabIndex = 5;
            // 
            // yenisifreBox
            // 
            this.yenisifreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenisifreBox.Location = new System.Drawing.Point(102, 33);
            this.yenisifreBox.Name = "yenisifreBox";
            this.yenisifreBox.Size = new System.Drawing.Size(213, 30);
            this.yenisifreBox.TabIndex = 7;
            // 
            // sifreTekrarBox
            // 
            this.sifreTekrarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTekrarBox.Location = new System.Drawing.Point(102, 69);
            this.sifreTekrarBox.Name = "sifreTekrarBox";
            this.sifreTekrarBox.Size = new System.Drawing.Size(213, 30);
            this.sifreTekrarBox.TabIndex = 12;
            // 
            // dogrulaPanel
            // 
            this.dogrulaPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.dogrulaPanel.Controls.Add(this.label3);
            this.dogrulaPanel.Controls.Add(this.kodDogrulaBtn);
            this.dogrulaPanel.Controls.Add(this.kodDogrulaBox);
            this.dogrulaPanel.Location = new System.Drawing.Point(365, 78);
            this.dogrulaPanel.Name = "dogrulaPanel";
            this.dogrulaPanel.Size = new System.Drawing.Size(355, 177);
            this.dogrulaPanel.TabIndex = 13;
            this.dogrulaPanel.Visible = false;
            // 
            // sifreYenilePanel
            // 
            this.sifreYenilePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sifreYenilePanel.Controls.Add(this.label5);
            this.sifreYenilePanel.Controls.Add(this.yenisifreBox);
            this.sifreYenilePanel.Controls.Add(this.sifreTekrarBox);
            this.sifreYenilePanel.Controls.Add(this.sifreBelirleBtn);
            this.sifreYenilePanel.Controls.Add(this.label4);
            this.sifreYenilePanel.Location = new System.Drawing.Point(326, 271);
            this.sifreYenilePanel.Name = "sifreYenilePanel";
            this.sifreYenilePanel.Size = new System.Drawing.Size(444, 178);
            this.sifreYenilePanel.TabIndex = 14;
            this.sifreYenilePanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sifre Tekrar :";
            // 
            // sifreBelirleBtn
            // 
            this.sifreBelirleBtn.BackgroundImage = global::Manavodev2.Properties.Resources.user;
            this.sifreBelirleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sifreBelirleBtn.Location = new System.Drawing.Point(138, 105);
            this.sifreBelirleBtn.Name = "sifreBelirleBtn";
            this.sifreBelirleBtn.Size = new System.Drawing.Size(135, 62);
            this.sifreBelirleBtn.TabIndex = 10;
            this.sifreBelirleBtn.UseVisualStyleBackColor = true;
            this.sifreBelirleBtn.Click += new System.EventHandler(this.sifreBelirleBtn_Click);
            // 
            // kodDogrulaBtn
            // 
            this.kodDogrulaBtn.BackgroundImage = global::Manavodev2.Properties.Resources.promo;
            this.kodDogrulaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kodDogrulaBtn.Location = new System.Drawing.Point(100, 106);
            this.kodDogrulaBtn.Name = "kodDogrulaBtn";
            this.kodDogrulaBtn.Size = new System.Drawing.Size(156, 53);
            this.kodDogrulaBtn.TabIndex = 9;
            this.kodDogrulaBtn.UseVisualStyleBackColor = true;
            this.kodDogrulaBtn.Click += new System.EventHandler(this.kodDogrulaBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackgroundImage = global::Manavodev2.Properties.Resources.remove;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisBtn.Location = new System.Drawing.Point(709, 2);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(90, 45);
            this.cikisBtn.TabIndex = 11;
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // mailDogrulamaBox
            // 
            this.mailDogrulamaBox.BackgroundImage = global::Manavodev2.Properties.Resources.check;
            this.mailDogrulamaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailDogrulamaBox.Location = new System.Drawing.Point(129, 151);
            this.mailDogrulamaBox.Name = "mailDogrulamaBox";
            this.mailDogrulamaBox.Size = new System.Drawing.Size(125, 55);
            this.mailDogrulamaBox.TabIndex = 8;
            this.mailDogrulamaBox.UseVisualStyleBackColor = true;
            this.mailDogrulamaBox.Click += new System.EventHandler(this.mailDogrulamaBox_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Manavodev2.Properties.Resources.manav_barkod_sistemi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifreYenilePanel);
            this.Controls.Add(this.dogrulaPanel);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.mailDogrulamaBox);
            this.Controls.Add(this.mailDogrulaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.dogrulaPanel.ResumeLayout(false);
            this.dogrulaPanel.PerformLayout();
            this.sifreYenilePanel.ResumeLayout(false);
            this.sifreYenilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailDogrulaBox;
        private System.Windows.Forms.TextBox kodDogrulaBox;
        private System.Windows.Forms.TextBox yenisifreBox;
        private System.Windows.Forms.Button mailDogrulamaBox;
        private System.Windows.Forms.Button kodDogrulaBtn;
        private System.Windows.Forms.Button sifreBelirleBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.TextBox sifreTekrarBox;
        private System.Windows.Forms.Panel dogrulaPanel;
        private System.Windows.Forms.Panel sifreYenilePanel;
        private System.Windows.Forms.Label label5;
    }
}