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
    public partial class Sekreter_Detay : Form
    {
        public Sekreter_Detay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Sekreter_Detay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            //ad soyad
            SqlCommand komut = new SqlCommand("select sekreterads from tbl_sekreter where sekretertc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //branşlar
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktor ads
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorad+' '+doktorsoyad) as 'Doktorlar',Doktorbrans from tbl_doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //bransı comboboxa çekme
            SqlCommand komut2 = new SqlCommand("select bransad from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //doktorlar comboboxı
            

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (randevutarih,randevusaat,randevubrans,randevudoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktorad,doktorsoyad from tbl_doktor where doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti();
        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular(duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.");
        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            Doktor_Paneli dp = new Doktor_Paneli();
            dp.Show();
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            Branş_Panel bp = new Branş_Panel();
            bp.Show();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            Randevu_Listesi rn = new Randevu_Listesi();
            rn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Duyurular dr = new Duyurular();
            dr.Show();
        }
    }
}
