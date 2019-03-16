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

namespace Yonetim_Hastane
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTC="+tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branş Çekme

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='" + CmbBrans.Text + "' and RandevuDoktor='"+CmbDoktor.Text+"' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        public string RandevuTarihi, RandevuSaati;
        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum=1, HastaTC=@r1, Sikayet=@r2 where Randevuid=@r3",bgl.baglanti());
            komut.Parameters.AddWithValue("@r1", LblTC.Text);
            komut.Parameters.AddWithValue("@r2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@r3", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            //dataGridView2_CellClick özelliği çalışmadığı için Randevuid gelmiyor ve aşağıdaki kodda veri gelirken hata veriyor.
            SqlCommand komut2 = new SqlCommand("select RandevuTarih,RandevuSaat from Tbl_Randevular where Randevuid=@r4", bgl.baglanti());
            komut2.Parameters.AddWithValue("@r4", Txtid.Text);
            SqlDataReader dr = komut2.ExecuteReader();
            RandevuTarihi = dr[1].ToString();
            RandevuSaati = dr[2].ToString();
            MessageBox.Show(CmbBrans.Text + " bölümünden " + CmbDoktor.Text + " doktordan \n" + RandevuTarihi + " tarihinde " + RandevuSaati + " ve saatinde randevunuz alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            //Buraya kadar!
        }
    }
}
