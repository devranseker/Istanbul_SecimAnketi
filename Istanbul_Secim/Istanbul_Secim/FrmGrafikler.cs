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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        // Sql Baglantısını alalım
        SqlConnection sqlbaglantisi = new SqlConnection(@"Data Source=DEVRAN-PC\SQLEXPRESS;Initial Catalog=ISTANBULSECİM;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // İlce adlarını cmb'ye aktarma
            sqlbaglantisi.Open();
            SqlCommand komut = new SqlCommand("Select ILCEAD From TBLILCE ", sqlbaglantisi);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                // yukarıdaki sql kodda sadece ilce adlarını getirir yani Index == 0
                CmbIlceler.Items.Add(reader[0]);
            }
            sqlbaglantisi.Close();

            // Grafiğe Toplam Sonucları Getirme 

            sqlbaglantisi.Open();
            SqlCommand komut1 = new SqlCommand("Select SUM(APARTI) , SUM(BPARTI), SUM(CPARTI), SUM(DPARTI),SUM(EPARTI) From TBLILCE ", sqlbaglantisi);
            SqlDataReader reader1 = komut1.ExecuteReader();
            while (reader1.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", reader1[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", reader1[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", reader1[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", reader1[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", reader1[4]);
            }
            sqlbaglantisi.Close();
        }

        // simdi ilceleri oy oranlarını goruntuleyelim 
        private void CmbIlceler_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlbaglantisi.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLILCE where ILCEAD = @P1", sqlbaglantisi);
            komut.Parameters.AddWithValue("@P1", CmbIlceler.Text);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                progressBar1AParti.Value = int.Parse(reader[2].ToString());
                progressBar2BParti.Value = int.Parse(reader[3].ToString());
                progressBar3CParti.Value = int.Parse(reader[4].ToString());
                progressBar4DParti.Value = int.Parse(reader[5].ToString());
                progressBar5EParti.Value = int.Parse(reader[6].ToString());


                // simdi Toplam Oy Oranlarını getirelim 
                LblOyOraniA.Text = reader[2].ToString();
                LblOyOraniB.Text = reader[3].ToString();
                LblOyOraniC.Text = reader[4].ToString();
                LblOyOraniD.Text = reader[5].ToString();
                LblOyOraniE.Text = reader[6].ToString();

            }
            sqlbaglantisi.Close();
        }
        // odev 

    }
}
