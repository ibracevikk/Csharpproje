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
    public partial class Doktor_Paneli : Form
    {
        public Doktor_Paneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Doktor_Paneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_doktor", bgl.baglanti());
            da2.Fill(dt2);
            dtdoktor.DataSource = dt2;

            //brans
            SqlCommand komut2 = new SqlCommand("select bransad from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktor (doktorad,doktorsoyad,doktorbrans,doktortc,doktorsifre) values (@d1,@d2,@d3,@d4,@d5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@d5", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       

        private void dtdoktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtdoktor.SelectedCells[0].RowIndex;
            txtad.Text = dtdoktor.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dtdoktor.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dtdoktor.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dtdoktor.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dtdoktor.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete tbl_doktor where doktortc=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi gerçekleşti.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktor set doktorad=@d1,doktorsoyad=@d2,doktorbrans=@d3,doktorsifre=@d5 where doktortc=@d4",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@d5", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
