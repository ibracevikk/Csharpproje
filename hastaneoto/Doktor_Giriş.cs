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

namespace hastaneoto
{
    public partial class Doktor_Giriş : Form
    {
        public Doktor_Giriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi blg = new sqlbaglantisi();

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_doktor where doktortc=@p1 and doktorsifre=@p2", blg.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Doktor_Detay dt = new Doktor_Detay();
                dt.tc = msktc.Text;
                dt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc numarası ya da şifre.");
            }
            blg.baglanti().Close();
        }
    }
}
