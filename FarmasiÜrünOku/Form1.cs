using HtmlAgilityPack;
using System;
using System.Data.Common;
using System.Data.OracleClient;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FarmasiÜrünOku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public OracleCommand sql = new OracleCommand();
        public OracleDataAdapter da = new OracleDataAdapter();
        public OracleConnection con = new OracleConnection();

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "User Id =farmasi; Password = farmasi; Data Source = orcl";
                con.Open();
                
                this.Text = "Farmasi Ürün Çekme Programı /Database Open";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.farmasi.com.tr/farmasi-bb-krem-acik-50-ml/9316");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urun_adi,urun_kodu,urun_aciklama,resim_kodu,etiket;
            string fiyat;
            try
            {
                string link = textBox1.Text;//Web Site Link
                Uri url = new Uri(link);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);

                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);

                //Urun Adı
                HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("//div[@class='product-name']");
                foreach (var baslik in basliklar) { txt_urun_adi.Text = baslik.InnerText; }

                //Urun Fiyat
                HtmlNodeCollection aranan2 = dokuman.DocumentNode.SelectNodes("//div[@class='product-price']");
                foreach (var bul2 in aranan2) { txt_fiyat.Text =bul2.InnerText; }


                try
                {
                    //Urun Adı
                    HtmlNodeCollection aranan6 = dokuman.DocumentNode.SelectNodes("//div[@class='tags']");
                    foreach (var bul6 in aranan6) { txt_etiket.Text = bul6.InnerText.Replace("\r\n", "").Replace("                            ", ",").Trim(); }
                    //txt_etiket.Text = txt_etiket.Text.Replace(System.Environment.NewLine, ",");
                }
                catch (Exception)
                {

                    txt_etiket.Text = "Farmasi,Yeni Ürünler,Katalog,"+comboBox3.Text+","+comboBox2.Text;
                }


                //Urun Adı
                //<div class="product-quick-detail"><b>Ürün Kodu : </b>
                HtmlNodeCollection aranan3 = dokuman.DocumentNode.SelectNodes("//div[@class='product-quick-detail']");
                int a;
                a = 0;
                foreach (var bul3 in aranan3)
                {
                    if (a == 0)
                    {
                        txt_kodu.Text = bul3.ChildNodes[1].InnerHtml.ToString().Trim();

                    }
                    a += 1;

                }


                //Urun Fiyat
                HtmlNodeCollection aranan4 = dokuman.DocumentNode.SelectNodes("//p");
                
                a = 0;
                foreach (var bul4 in aranan4)
                {
                    if (a == 1)
                    {
                        txt_aciklama.Text = bul4.ChildNodes[0].InnerHtml.ToString();

                    }
                    a += 1;

                }

                //Urun Fiyat

                HtmlNodeCollection aranan5 = dokuman.DocumentNode.SelectNodes("//div[@class='flexslider manual']//ul[@class='slides']//li[@class='easyzoom easyzoom--overlay']//a//img[@class='imgNormal']");
                foreach (var bul5 in aranan5) { txt_resim.Text = bul5.GetAttributeValue("src", "nothing"); }
                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                return;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }
        string yenimi;
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked==true)
                {
                    yenimi = "T";

                }
                else
                {
                    yenimi = "F";

                }
                sql = new OracleCommand(
                    " insert into urunler (  " +
                    " ID, STOK_KODU, ISIM, " +
                    " ACIKLAMA, FIYAT, " +
                    " KATEGORI, ETIKET, GORSELLER, " +
                    " LINK, GUNCELLEME_TARIHI, ALT_KATEGORI, " +
                    " MINI_KATEGORI,NEW) " +
                    " values " +
                    " (FAR_URUN_ID.nextval, " +
                    " '" + txt_kodu.Text.Trim() + "', " +
                    " '" + txt_urun_adi.Text + "', " +
                    " '" + txt_aciklama.Text + "', " +

                    " '" + txt_fiyat.Text.Replace("TL", "") + "', '" + comboBox1.Text + "', '" + txt_etiket.Text + "', '" + txt_resim.Text + "', '" + textBox1.Text + "', to_date('" + DateTime.Now.ToShortDateString() + "', 'dd.mm.yyyy'), '" + comboBox2.Text + "', '" + comboBox3.Text + "','"+yenimi+"')", con);
                sql.ExecuteNonQuery();
                this.Text = txt_kodu.Text + ">>" + txt_urun_adi.Text;
                //MessageBox.Show("Kayıt Edildi");
                txt_aciklama.Text = "";
                txt_etiket.Text = "";
                txt_fiyat.Text = "";
                txt_kodu.Text = "";
                txt_resim.Text = "";
                txt_urun_adi.Text = "";
                checkBox1.Checked = false;
                webBrowser1.GoBack();
                
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string lnk, dosya_adi;
            sql = new OracleCommand("select * from urunler where resim_download='F'", con);
            OracleDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            {
                lnk = dr["GORSELLER"].ToString();
                dosya_adi = dr["STOK_KODU"].ToString();
                try
                {
                    new WebClient().DownloadFile(lnk, @"D:\Windows Uygulamalar\Projeler2019\FarmasiÜrünler\FarmasiÜrünOku\FarmasiÜrünOku\bin\Debug\urunler\farmasi-" + dosya_adi+".jpg");
                    sql = new OracleCommand("update urunler set resim_download='T' where stok_kodu='" + dosya_adi+"' ", con);
                    sql.ExecuteNonQuery();
                    label1.Text = dosya_adi;
                    Update();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                    
                }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                webBrowser1.Navigate(textBox1.Text);
                webBrowser1.ScriptErrorsSuppressed = true;
            }
        }

        private void txt_resim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_resim.Text = "https://cdn.farmasi.com.tr//product/"+txt_kodu.Text.Trim()+".jpg";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string lnk, stok_kodu;
            lnk = "";

            sql = new OracleCommand("select * from urunler where FIYAT_GUNCELLE='F'", con);
            OracleDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            { 

                lnk = dr["LINK"].ToString();
            stok_kodu = dr["STOK_KODU"].ToString();
           
            string link = lnk;
            Uri url = new Uri(link);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);

            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);

            HtmlNodeCollection aranan2 = dokuman.DocumentNode.SelectNodes("//div[@class='product-price']");
            foreach (var bul2 in aranan2) { txt_fiyat.Text = bul2.InnerText; }
            try
            {

                sql = new OracleCommand("update urunler set FIYAT_GUNCELLE='T',new_fiyat='"+ txt_fiyat.Text.Replace("TL", "") + "' ,eski_fiyat=fiyat,guncelleme_tarihi=to_date('"+DateTime.Now.ToShortDateString()+"','dd.mm.yyyy') where stok_kodu='" + stok_kodu + "' ", con);
                sql.ExecuteNonQuery();
                label1.Text = stok_kodu;
                Update();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

            }

            }
            MessageBox.Show("Fiyatlar Tamam");
             





            //}
        }
    }
}