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
    public partial class Doktor_Detay : Form
    {
        public Doktor_Detay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;
        private void Doktor_Detay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            //doktor ad soyad
            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktor where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevudoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            Doktor_Bilgi_Düzenle bd = new Doktor_Bilgi_Düzenle();
            bd.tc = lbltc.Text;
            bd.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
