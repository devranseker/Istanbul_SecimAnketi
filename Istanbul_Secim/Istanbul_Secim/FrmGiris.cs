using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Istanbul_Secim
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        // Sql Baglantısını alalım
        SqlConnection sqlbaglantisi = new SqlConnection(@"Data Source=DEVRAN-PC\SQLEXPRESS;Initial Catalog=ISTANBULSECİM;Integrated Security=True");

        // Oy girisi Butonu (insert into)
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)", sqlbaglantisi);
            // Parametre atamaları
            komut.Parameters.AddWithValue("@P1", TxtilceAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtPartiA.Text);
            komut.Parameters.AddWithValue("@P3", TxtPartiB.Text);
            komut.Parameters.AddWithValue("@P4", TxtPartiC.Text);
            komut.Parameters.AddWithValue("@P5", TxtPartiD.Text);
            komut.Parameters.AddWithValue("@P6", TxtPartiE.Text);
            komut.ExecuteNonQuery();
            sqlbaglantisi.Close();
            MessageBox.Show("Oy Girişi Yapıldı.");
        }

        // Grafikler ,butonu
        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frGrfk = new FrmGrafikler();
            frGrfk.Show();
         }
    }
}
