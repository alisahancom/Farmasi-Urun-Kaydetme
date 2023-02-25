using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace FarmasiÜrünOku
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public OracleCommand sql = new OracleCommand();
        public OracleDataAdapter da = new OracleDataAdapter();
        public OracleConnection con = new OracleConnection();

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            label3.Text = textBox2.Text.Length.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "User Id =farmasi; Password = farmasi; Data Source = orcl";
                con.Open();
                sql = new OracleCommand("select kategori from urunler group by kategori", con);
                OracleDataReader dr1 = sql.ExecuteReader();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                while (dr1.Read())
                {
                    comboBox1.Items.Add(dr1["kategori"].ToString());
                }
                sql = new OracleCommand("select mini_kategori from urunler group by mini_kategori", con);
                OracleDataReader dr2 = sql.ExecuteReader();
                while (dr2.Read())
                {
                    comboBox2.Items.Add(dr2["mini_kategori"].ToString());
                }

                this.Text = "Farmasi Ürün Çekme Programı /Database Open";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = new OracleCommand("select mini_kategori from urunler where kategori='" + comboBox1.Text + "' group by mini_kategori ", con);
            OracleDataReader dr3 = sql.ExecuteReader();
            comboBox2.Items.Clear();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3["mini_kategori"].ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = new OracleCommand("select a.STOK_KODU,a.ISIM,a.FIYAT,a.KATEGORI,a.ETIKET,a.GORSELLER,a.MINI_KATEGORI,a.PAYLASILDI from urunler a where mini_kategori = '" + comboBox2.Text + "' and a.paylasildi=0 ", con);
            da = new OracleDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["STOK_KODU"].Width = 100;
            gridView1.Columns["ISIM"].BestFit();
            gridView1.Columns["FIYAT"].Width = 100;
            gridView1.Columns["KATEGORI"].Width = 100;
            gridView1.Columns["GORSELLER"].Width = 200;
            gridView1.Columns["PAYLASILDI"].Width = 100;
        }

        private string urun_kodu;

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "Web Sitesi: www.farmasiurunmagazasi.com " + Environment.NewLine + "% 10 ile % 40 Varan İndirimler için Üyelik  Formu";
            urun_kodu = gridView1.GetFocusedRowCellValue("STOK_KODU").ToString();

            textBox2.Text = "Ürün Kodu:" + gridView1.GetFocusedRowCellValue("STOK_KODU").ToString() + Environment.NewLine + gridView1.GetFocusedRowCellValue("ISIM").ToString() +
                                Environment.NewLine + "Fiyat:" + gridView1.GetFocusedRowCellValue("FIYAT").ToString() + " TL";
            if (gridView1.GetFocusedRowCellValue("ETIKET").ToString().Length < 60)
            {
                textBox2.Text = textBox2.Text + Environment.NewLine + "#" + gridView1.GetFocusedRowCellValue("ETIKET").ToString().Replace(",", ",#").Replace(" ", "")
                    + Environment.NewLine + "Web Sitesi: http://www.farmasiurunmagazasi.com/farmasi-ucretsiz-uyelik/ " +
                     Environment.NewLine + "% 10 ile % 40 Varan İndirimler için Üyelik  Formu";
            }
            else
            {
                textBox2.Text = textBox2.Text + Environment.NewLine + "#" + gridView1.GetFocusedRowCellValue("ETIKET").ToString().Substring(0, 160).Replace(",", ",#").Replace(" ", "")
                          + Environment.NewLine + "Web Sitesi: http://www.farmasiurunmagazasi.com/farmasi-ucretsiz-uyelik/ " +
                          Environment.NewLine + "% 10 ile % 40 Varan İndirimler için Üyelik  Formu";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            sql = new OracleCommand("update urunler set paylasildi=paylasildi+1 where stok_kodu='" + urun_kodu + "'", con);
            sql.ExecuteNonQuery();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sql = new OracleCommand("select * from urunler where stok_kodu='" + textBox3.Text + "'", con);
            OracleDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = "Ürün Kodu:" + gridView1.GetFocusedRowCellValue("STOK_KODU").ToString() + Environment.NewLine + gridView1.GetFocusedRowCellValue("ISIM").ToString() +
                                Environment.NewLine + "Fiyat:" + gridView1.GetFocusedRowCellValue("FIYAT").ToString() + " TL";
                if (gridView1.GetFocusedRowCellValue("ETIKET").ToString().Length > 60)
                {
                    textBox2.Text = textBox2.Text + Environment.NewLine + "#" + gridView1.GetFocusedRowCellValue("ETIKET").ToString().Substring(0, 60).Replace(",", ",#");
                }
                else
                {
                    textBox2.Text = textBox2.Text + Environment.NewLine + "#" + gridView1.GetFocusedRowCellValue("ETIKET").ToString().Substring(0, Convert.ToInt32(gridView1.GetFocusedRowCellValue("ETIKET").ToString().Length / 2)).Replace(",", ",#");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FarmasiÜrünOku.Form1.ActiveForm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}