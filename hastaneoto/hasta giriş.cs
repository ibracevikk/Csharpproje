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
    public partial class hasta_giriş : Form
    {
        public hasta_giriş()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void lnküyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hasta_Kayıt fr = new Hasta_Kayıt();
            fr.Show();
            
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hastatc=@p1 and hastasifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Hasta_Detay fr = new Hasta_Detay();
                fr.tc = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC numarası ya da şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
