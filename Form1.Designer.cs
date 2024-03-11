namespace _7mart2024
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
            listele_btn = new Button();
            dataGridView1 = new DataGridView();
            ekle_btn = new Button();
            guncelle_btn = new Button();
            sil_btn = new Button();
            model_textbox = new TextBox();
            marka_textbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox_Kisi = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox_Plaka = new ComboBox();
            comboBox_Muhendis = new ComboBox();
            label6 = new Label();
            muhEkle_btn = new Button();
            muhSil_btn = new Button();
            label7 = new Label();
            muhListele_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listele_btn
            // 
            listele_btn.BackColor = Color.FromArgb(0, 192, 192);
            listele_btn.Location = new Point(506, 93);
            listele_btn.Margin = new Padding(3, 4, 3, 4);
            listele_btn.Name = "listele_btn";
            listele_btn.Size = new Size(111, 31);
            listele_btn.TabIndex = 0;
            listele_btn.Text = "LİSTELE";
            listele_btn.UseVisualStyleBackColor = false;
            listele_btn.Click += listele_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 308);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 259);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ekle_btn
            // 
            ekle_btn.BackColor = Color.FromArgb(0, 192, 192);
            ekle_btn.Location = new Point(506, 197);
            ekle_btn.Margin = new Padding(3, 4, 3, 4);
            ekle_btn.Name = "ekle_btn";
            ekle_btn.Size = new Size(111, 31);
            ekle_btn.TabIndex = 2;
            ekle_btn.Text = "EKLE";
            ekle_btn.UseVisualStyleBackColor = false;
            ekle_btn.Click += ekle_btn_Click;
            // 
            // guncelle_btn
            // 
            guncelle_btn.BackColor = Color.FromArgb(0, 192, 192);
            guncelle_btn.Location = new Point(506, 145);
            guncelle_btn.Margin = new Padding(3, 4, 3, 4);
            guncelle_btn.Name = "guncelle_btn";
            guncelle_btn.Size = new Size(111, 31);
            guncelle_btn.TabIndex = 3;
            guncelle_btn.Text = "GÜNCELLE";
            guncelle_btn.UseVisualStyleBackColor = false;
            guncelle_btn.Click += guncelle_btn_Click;
            // 
            // sil_btn
            // 
            sil_btn.BackColor = Color.FromArgb(0, 192, 192);
            sil_btn.Location = new Point(506, 249);
            sil_btn.Margin = new Padding(3, 4, 3, 4);
            sil_btn.Name = "sil_btn";
            sil_btn.Size = new Size(111, 31);
            sil_btn.TabIndex = 4;
            sil_btn.Text = "SİL";
            sil_btn.UseVisualStyleBackColor = false;
            sil_btn.Click += sil_btn_Click;
            // 
            // model_textbox
            // 
            model_textbox.Location = new Point(133, 145);
            model_textbox.Margin = new Padding(3, 4, 3, 4);
            model_textbox.Name = "model_textbox";
            model_textbox.Size = new Size(354, 27);
            model_textbox.TabIndex = 5;
            // 
            // marka_textbox
            // 
            marka_textbox.Location = new Point(133, 95);
            marka_textbox.Margin = new Padding(3, 4, 3, 4);
            marka_textbox.Multiline = true;
            marka_textbox.Name = "marka_textbox";
            marka_textbox.Size = new Size(354, 29);
            marka_textbox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1755, 200);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(35, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "MARKA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(35, 151);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "MODEL";
            // 
            // comboBox_Kisi
            // 
            comboBox_Kisi.FormattingEnabled = true;
            comboBox_Kisi.Location = new Point(133, 197);
            comboBox_Kisi.Name = "comboBox_Kisi";
            comboBox_Kisi.Size = new Size(354, 28);
            comboBox_Kisi.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(35, 205);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 11;
            label4.Text = "KİŞİ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(35, 260);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 12;
            label5.Text = "PLAKA";
            // 
            // comboBox_Plaka
            // 
            comboBox_Plaka.FormattingEnabled = true;
            comboBox_Plaka.Location = new Point(133, 249);
            comboBox_Plaka.Name = "comboBox_Plaka";
            comboBox_Plaka.Size = new Size(354, 28);
            comboBox_Plaka.TabIndex = 13;
            // 
            // comboBox_Muhendis
            // 
            comboBox_Muhendis.FormattingEnabled = true;
            comboBox_Muhendis.Location = new Point(656, 145);
            comboBox_Muhendis.Name = "comboBox_Muhendis";
            comboBox_Muhendis.Size = new Size(308, 28);
            comboBox_Muhendis.TabIndex = 18;
            comboBox_Muhendis.SelectedIndexChanged += comboBox_Muhendis_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(656, 93);
            label6.Name = "label6";
            label6.Size = new Size(310, 28);
            label6.TabIndex = 17;
            label6.Text = "MUHENDİS BİLGELERİ MENÜSÜ";
            // 
            // muhEkle_btn
            // 
            muhEkle_btn.BackColor = Color.FromArgb(0, 192, 192);
            muhEkle_btn.Location = new Point(654, 197);
            muhEkle_btn.Margin = new Padding(3, 4, 3, 4);
            muhEkle_btn.Name = "muhEkle_btn";
            muhEkle_btn.Size = new Size(144, 31);
            muhEkle_btn.TabIndex = 19;
            muhEkle_btn.Text = "MÜH. EKLE";
            muhEkle_btn.UseVisualStyleBackColor = false;
            muhEkle_btn.Click += muhEkle_btn_Click;
            // 
            // muhSil_btn
            // 
            muhSil_btn.BackColor = Color.FromArgb(0, 192, 192);
            muhSil_btn.Location = new Point(826, 197);
            muhSil_btn.Margin = new Padding(3, 4, 3, 4);
            muhSil_btn.Name = "muhSil_btn";
            muhSil_btn.Size = new Size(135, 31);
            muhSil_btn.TabIndex = 20;
            muhSil_btn.Text = "MÜH. SİL";
            muhSil_btn.UseVisualStyleBackColor = false;
            muhSil_btn.Click += muhSil_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(35, 53);
            label7.Name = "label7";
            label7.Size = new Size(288, 31);
            label7.TabIndex = 21;
            label7.Text = "ARAC BİLGİLERİ MENÜSÜ";
            // 
            // muhListele_btn
            // 
            muhListele_btn.BackColor = Color.FromArgb(0, 192, 192);
            muhListele_btn.Location = new Point(654, 249);
            muhListele_btn.Margin = new Padding(3, 4, 3, 4);
            muhListele_btn.Name = "muhListele_btn";
            muhListele_btn.Size = new Size(307, 31);
            muhListele_btn.TabIndex = 22;
            muhListele_btn.Text = "MÜHENDİS-ARAC LİSTESİ";
            muhListele_btn.UseVisualStyleBackColor = false;
            muhListele_btn.Click += muhListele_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 600);
            Controls.Add(muhListele_btn);
            Controls.Add(label7);
            Controls.Add(muhSil_btn);
            Controls.Add(muhEkle_btn);
            Controls.Add(comboBox_Muhendis);
            Controls.Add(label6);
            Controls.Add(comboBox_Plaka);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox_Kisi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(marka_textbox);
            Controls.Add(model_textbox);
            Controls.Add(sil_btn);
            Controls.Add(guncelle_btn);
            Controls.Add(ekle_btn);
            Controls.Add(dataGridView1);
            Controls.Add(listele_btn);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARAC DATABASE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button listele_btn;
        private DataGridView dataGridView1;
        private Button ekle_btn;
        private Button guncelle_btn;
        private Button sil_btn;
        private TextBox model_textbox;
        private TextBox marka_textbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_Kisi;
        private Label label4;
        private Label label5;
        private ComboBox comboBox_Plaka;
        private ComboBox comboBox_Muhendis;
        private Label label6;
        private Button muhEkle_btn;
        private Button muhSil_btn;
        private Label label7;
        private Button muhListele_btn;
    }
}
