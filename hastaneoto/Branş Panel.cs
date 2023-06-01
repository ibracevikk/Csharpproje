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
    public partial class Branş_Panel : Form
    {
        public Branş_Panel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Branş_Panel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       private void Btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_brans (bransad) values (@d1)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@d1", bransad.Text);
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ekleme işlemi başarılı.");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_brans where bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_brans set bransad=@p1 where bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransad.Text);
            komut.Parameters.AddWithValue("@p2", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi başarılı");

        }
    }
}
