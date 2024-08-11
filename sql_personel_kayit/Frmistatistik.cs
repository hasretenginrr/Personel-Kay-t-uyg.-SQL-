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

namespace sql_personel_kayit
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=HASRET\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frmistatistik_Load_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From tbl_personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbltoplamper.Text = dr1[0].ToString(); // ilk sütun sayıyıyı verdiği için 0. indexi aldık. 
            }

            baglanti.Close();
            // evli personel sayisi

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select count(*) From tbl_personel Where PerDurum=1", baglanti);
            SqlDataReader dr2 =komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblevliper.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar personel sayisi
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select count(*) From tbl_personel Where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblbekarper.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Şehir Sayisi

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select count(distinct PerSehir) From tbl_personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblsehir.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam maas

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(PerMaas) From tbl_personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbltopmaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //ort maas

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From tbl_personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblortmaas.Text = dr6[0].ToString();
            }
            baglanti.Close();



        }
    }





}
