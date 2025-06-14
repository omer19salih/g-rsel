namespace Manavodev2
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbarkodno = new System.Windows.Forms.TextBox();
            this.textkatogori = new System.Windows.Forms.TextBox();
            this.texturunadi = new System.Windows.Forms.TextBox();
            this.textfiyat = new System.Windows.Forms.TextBox();
            this.textstok = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaxMin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Top5 = new System.Windows.Forms.Button();
            this.SortDataGrid = new System.Windows.Forms.Button();
            this.buttonSortListView = new System.Windows.Forms.Button();
            this.buttonSortListViewDesc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 250);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEkle.Location = new System.Drawing.Point(352, 26);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(142, 62);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click_1);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSil.Location = new System.Drawing.Point(352, 165);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(142, 56);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click_1);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGüncelle.Location = new System.Drawing.Point(352, 96);
            this.buttonGüncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(142, 60);
            this.buttonGüncelle.TabIndex = 3;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Barkodno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(45, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Urunadi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(68, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fiyat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(68, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stok";
            // 
            // textbarkodno
            // 
            this.textbarkodno.BackColor = System.Drawing.SystemColors.Menu;
            this.textbarkodno.Enabled = false;
            this.textbarkodno.Location = new System.Drawing.Point(147, 29);
            this.textbarkodno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbarkodno.Name = "textbarkodno";
            this.textbarkodno.Size = new System.Drawing.Size(171, 27);
            this.textbarkodno.TabIndex = 9;
            // 
            // textkatogori
            // 
            this.textkatogori.BackColor = System.Drawing.SystemColors.Menu;
            this.textkatogori.Location = new System.Drawing.Point(147, 62);
            this.textkatogori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textkatogori.Name = "textkatogori";
            this.textkatogori.Size = new System.Drawing.Size(171, 27);
            this.textkatogori.TabIndex = 10;
            // 
            // texturunadi
            // 
            this.texturunadi.BackColor = System.Drawing.SystemColors.Menu;
            this.texturunadi.Location = new System.Drawing.Point(147, 102);
            this.texturunadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texturunadi.Name = "texturunadi";
            this.texturunadi.Size = new System.Drawing.Size(171, 27);
            this.texturunadi.TabIndex = 11;
            // 
            // textfiyat
            // 
            this.textfiyat.BackColor = System.Drawing.SystemColors.Menu;
            this.textfiyat.Location = new System.Drawing.Point(147, 142);
            this.textfiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textfiyat.Name = "textfiyat";
            this.textfiyat.Size = new System.Drawing.Size(171, 27);
            this.textfiyat.TabIndex = 12;
            // 
            // textstok
            // 
            this.textstok.BackColor = System.Drawing.SystemColors.Menu;
            this.textstok.Location = new System.Drawing.Point(147, 194);
            this.textstok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textstok.Name = "textstok";
            this.textstok.Size = new System.Drawing.Size(171, 27);
            this.textstok.TabIndex = 13;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(542, 250);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 379);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MaxMin
            // 
            this.MaxMin.BackColor = System.Drawing.SystemColors.Highlight;
            this.MaxMin.Location = new System.Drawing.Point(862, 26);
            this.MaxMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxMin.Name = "MaxMin";
            this.MaxMin.Size = new System.Drawing.Size(132, 38);
            this.MaxMin.TabIndex = 15;
            this.MaxMin.Text = "MaxMin";
            this.MaxMin.UseVisualStyleBackColor = false;
            this.MaxMin.Click += new System.EventHandler(this.MaxMin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(897, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = " Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(897, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Min";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Top5
            // 
            this.Top5.BackColor = System.Drawing.SystemColors.Highlight;
            this.Top5.Location = new System.Drawing.Point(708, 25);
            this.Top5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(103, 58);
            this.Top5.TabIndex = 18;
            this.Top5.Text = "Top5";
            this.Top5.UseVisualStyleBackColor = false;
            this.Top5.Click += new System.EventHandler(this.Top5_Click);
            // 
            // SortDataGrid
            // 
            this.SortDataGrid.BackColor = System.Drawing.SystemColors.Highlight;
            this.SortDataGrid.Location = new System.Drawing.Point(560, 25);
            this.SortDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortDataGrid.Name = "SortDataGrid";
            this.SortDataGrid.Size = new System.Drawing.Size(128, 58);
            this.SortDataGrid.TabIndex = 19;
            this.SortDataGrid.Text = "Sırala";
            this.SortDataGrid.UseVisualStyleBackColor = false;
            this.SortDataGrid.Click += new System.EventHandler(this.SortDataGrid_Click);
            // 
            // buttonSortListView
            // 
            this.buttonSortListView.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSortListView.Location = new System.Drawing.Point(560, 120);
            this.buttonSortListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSortListView.Name = "buttonSortListView";
            this.buttonSortListView.Size = new System.Drawing.Size(133, 42);
            this.buttonSortListView.TabIndex = 20;
            this.buttonSortListView.Text = "Azalan Fiyat ";
            this.buttonSortListView.UseVisualStyleBackColor = false;
            this.buttonSortListView.Click += new System.EventHandler(this.buttonSortListView_Click);
            // 
            // buttonSortListViewDesc
            // 
            this.buttonSortListViewDesc.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSortListViewDesc.Location = new System.Drawing.Point(708, 120);
            this.buttonSortListViewDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSortListViewDesc.Name = "buttonSortListViewDesc";
            this.buttonSortListViewDesc.Size = new System.Drawing.Size(132, 42);
            this.buttonSortListViewDesc.TabIndex = 21;
            this.buttonSortListViewDesc.Text = "Artan Fiyat";
            this.buttonSortListViewDesc.UseVisualStyleBackColor = false;
            this.buttonSortListViewDesc.Click += new System.EventHandler(this.buttonSortListViewDesc_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Manavodev2.Properties.Resources.remove;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1049, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImage = global::Manavodev2.Properties.Resources.manav_barkod_sistemi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSortListViewDesc);
            this.Controls.Add(this.buttonSortListView);
            this.Controls.Add(this.SortDataGrid);
            this.Controls.Add(this.Top5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaxMin);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textstok);
            this.Controls.Add(this.textfiyat);
            this.Controls.Add(this.texturunadi);
            this.Controls.Add(this.textkatogori);
            this.Controls.Add(this.textbarkodno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbarkodno;
        private System.Windows.Forms.TextBox textkatogori;
        private System.Windows.Forms.TextBox texturunadi;
        private System.Windows.Forms.TextBox textfiyat;
        private System.Windows.Forms.TextBox textstok;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button MaxMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Top5;
        private System.Windows.Forms.Button SortDataGrid;
        private System.Windows.Forms.Button buttonSortListView;
        private System.Windows.Forms.Button buttonSortListViewDesc;
        private System.Windows.Forms.Button button1;
    }
}

