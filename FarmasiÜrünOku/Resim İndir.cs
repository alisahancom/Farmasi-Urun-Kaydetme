using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmasiÜrünOku
{
    public partial class Resim_İndir : Form
    {
        public Resim_İndir()
        {
            InitializeComponent();
        }

        private void Resim_İndir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lnk, dosya_adi,dosyax;
            dosyax = "";
             dosya_adi = "Kampanya-";
            lnk = "http://cdn.farmasi.com.tr/onlinecatalog/124/shop/big/";
            dosya_adi = "resim";
            for (int i = 99; i < 173; i++)
            {
                dosyax = i.ToString() ;
                if (i < 100)
                {
                    dosyax = "0" + i;
                }

                if (i<10)
                {
                    dosyax = "00" + i;
                }
                


                try
                {
                    new WebClient().DownloadFile(lnk + dosyax.ToString() + ".jpg", dosya_adi+i + ".jpg");
                    label2.Text = dosya_adi + i + ".jpg";
                    Update();
                }
                catch (Exception hata)
                
                {
                    MessageBox.Show("Hata" + hata.Message);
                    //devam

                }
            }
         
        }
    }
}
