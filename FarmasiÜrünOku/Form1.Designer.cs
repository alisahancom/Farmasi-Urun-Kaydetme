namespace FarmasiÜrünOku
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_etiket = new System.Windows.Forms.RichTextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_aciklama = new System.Windows.Forms.RichTextBox();
            this.txt_resim = new System.Windows.Forms.TextBox();
            this.txt_urun_adi = new System.Windows.Forms.TextBox();
            this.txt_kodu = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txt_etiket);
            this.groupBox1.Controls.Add(this.txt_fiyat);
            this.groupBox1.Controls.Add(this.txt_aciklama);
            this.groupBox1.Controls.Add(this.txt_resim);
            this.groupBox1.Controls.Add(this.txt_urun_adi);
            this.groupBox1.Controls.Add(this.txt_kodu);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "BB && CC Krem",
            "Pudra",
            "Allık",
            "Kapatıcı"});
            this.comboBox3.Location = new System.Drawing.Point(244, 58);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(215, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.Text = "Kategori Seç";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(353, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "Tüm Resimleri İndir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(496, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Yeni mi ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 51);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ürünü Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txt_etiket
            // 
            this.txt_etiket.Location = new System.Drawing.Point(595, 76);
            this.txt_etiket.Name = "txt_etiket";
            this.txt_etiket.Size = new System.Drawing.Size(339, 31);
            this.txt_etiket.TabIndex = 10;
            this.txt_etiket.Text = "Etiketler";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(493, 76);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(96, 20);
            this.txt_fiyat.TabIndex = 9;
            this.txt_fiyat.Text = "Fiyat";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(946, 26);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(266, 96);
            this.txt_aciklama.TabIndex = 8;
            this.txt_aciklama.Text = "Ürün Açıklaması";
            // 
            // txt_resim
            // 
            this.txt_resim.Location = new System.Drawing.Point(493, 50);
            this.txt_resim.Name = "txt_resim";
            this.txt_resim.Size = new System.Drawing.Size(441, 20);
            this.txt_resim.TabIndex = 7;
            this.txt_resim.Text = "Resim Kodu";
            this.txt_resim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_resim_KeyPress);
            // 
            // txt_urun_adi
            // 
            this.txt_urun_adi.Location = new System.Drawing.Point(595, 24);
            this.txt_urun_adi.Name = "txt_urun_adi";
            this.txt_urun_adi.Size = new System.Drawing.Size(339, 20);
            this.txt_urun_adi.TabIndex = 6;
            this.txt_urun_adi.Text = "Ürünün Adı";
            // 
            // txt_kodu
            // 
            this.txt_kodu.Location = new System.Drawing.Point(493, 24);
            this.txt_kodu.Name = "txt_kodu";
            this.txt_kodu.Size = new System.Drawing.Size(96, 20);
            this.txt_kodu.TabIndex = 5;
            this.txt_kodu.Text = "Stok Kodu";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yüz"});
            this.comboBox2.Location = new System.Drawing.Point(23, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Kategori Seç";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ürünü Oku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Makyaj",
            "Parfüm",
            "Kişisel Bakım",
            "Aksesuar",
            "Temizlik Ürünleri",
            "Aktif Yaşam"});
            this.comboBox1.Location = new System.Drawing.Point(23, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Kategori Seç";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Siteyi Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1218, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Site";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1212, 361);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1206, 342);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1212, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(244, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(356, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 29);
            this.button5.TabIndex = 15;
            this.button5.Text = "Fiyat Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txt_urun_adi;
        private System.Windows.Forms.TextBox txt_kodu;
        private System.Windows.Forms.TextBox txt_resim;
        private System.Windows.Forms.RichTextBox txt_aciklama;
        private System.Windows.Forms.RichTextBox txt_etiket;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}

