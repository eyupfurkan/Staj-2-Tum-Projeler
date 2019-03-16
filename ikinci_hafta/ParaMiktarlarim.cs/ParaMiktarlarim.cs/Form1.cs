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

namespace ParaMiktarlarim.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-0QD5K3T;Initial Catalog=ParaMiktari;Integrated Security=True");

        string Tamsayi, tamsayitut, degertut1, Ondalik, ParaMiktari, Sayi, TamsayiString,SayiGetir,TamKismiGetir,OndalikKismiGetir;
        decimal Param;
        int i,modkalan=0,sayac=0,sayacgetir;
        private void TxtTamsayi_TextChanged(object sender, EventArgs e)
        {
            Tamsayi = "";
            for (i = 0; i < TxtTamsayi.Text.Length; i++)
            {
                if (TxtTamsayi.Text[i].ToString() != ".")
                {
                    Tamsayi += TxtTamsayi.Text[i].ToString();
                }
            }
            int TamsayiUzunluk = int.Parse(Tamsayi.Length.ToString());
            tamsayitut = Tamsayi;
            if (TamsayiUzunluk > 3)
            {
                modkalan = (TamsayiUzunluk - 3) % 3;
                girme = true;
            }
            else
            {
                TamsayiString = tamsayitut.ToString();
                TxtTamsayi.Text = tamsayitut.ToString();
                girme = false;
            }
            //*tamsayitut += TxtTamsayi.Text[sayac1++].ToString();
            degertut1 = "";
            if (modkalan == 1 && girme == true)
            {
                degertut1 += tamsayitut[0] + ".";
                degertutma(1, TamsayiUzunluk);
            }
            if (modkalan == 2 && girme == true)
            {

                degertut1 = tamsayitut[0].ToString() + tamsayitut[1].ToString() + ".";
                degertutma(2, TamsayiUzunluk);
            }
            if (modkalan == 0 && TamsayiUzunluk > 3 && girme == true)
            {
                degertutma(0, TamsayiUzunluk);
            }
            if (TamsayiUzunluk > 3)
            {
                for (i = TamsayiUzunluk - 3; i < TamsayiUzunluk; i++)
                {
                    degertut1 += tamsayitut[i];
                }
            }
            if (TamsayiUzunluk > 3)
            {
                TamsayiString = degertut1.ToString();
                TxtTamsayi.Text = degertut1.ToString();
            }  
            /***burası*/
            /*TxtTamsayi.Focus();
            TxtTamsayi.SelectionStart = TxtTamsayi.Text.Length;*/
        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_ParaMiktarlari where ParaMiktariid=@p1", bgl);
            komut.Parameters.AddWithValue("@p1", TxtParaMiktariid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SayiGetir = dr[1].ToString();
            }
            bgl.Close();
            int GetirUzunluk = SayiGetir.Length;
            TamKismiGetir = "";
            OndalikKismiGetir = "";
            sayacgetir = 0;
            for (i = 0; i < GetirUzunluk; i++)
            {
                if (SayiGetir[i].ToString() != "," && sayacgetir == 0)
                {
                    TamKismiGetir += SayiGetir[i];
                }
                else if (sayacgetir == 0)
                {
                    sayacgetir = 1;
                }
                else
                {
                    OndalikKismiGetir += SayiGetir[i];
                }
            }
            TxtTamsayi.Text = TamKismiGetir;
            TxtOndalik.Text = OndalikKismiGetir;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtParaMiktariid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgl.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_ParaMiktarlari", bgl);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Ondalik = TxtOndalik.Text;
            ParaMiktari = TamsayiString + "," + Ondalik;
            Sayi = tamsayitut + "," + Ondalik;
            Param = Convert.ToDecimal(Sayi);
            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_ParaMiktarlari(ParaMiktari) values(@p1)",bgl);
            komut.Parameters.AddWithValue("@p1", Param);
            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Para miktarı kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtOndalik_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                case (char)Keys.Delete:
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        bool girme = false;

        public void degertutma(int i,int TamsayiUzunluk)
        {
            for (i=i; i < TamsayiUzunluk - 3; i++)
            {
                if (sayac < 2)
                {
                    degertut1 += tamsayitut[i];
                    sayac++;
                }
                else
                {
                    degertut1 += tamsayitut[i] + ".";
                    sayac = 0;
                }
            }
        }

        private void TxtTamsayi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 37 && e.KeyValue != 39 && e.KeyCode != Keys.Delete)
            {
                TxtTamsayi.Focus();
                TxtTamsayi.SelectionStart = TxtTamsayi.Text.Length;
            }     
        }

        private void TxtTamsayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                case (char)Keys.Delete:
                    break;
                default: e.Handled = true;
                    break;
            }    
        }
    }
}
