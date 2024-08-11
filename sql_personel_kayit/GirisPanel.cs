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
    public partial class GirisPanel : Form
    {
        public GirisPanel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=HASRET\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        private void btngiris_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tbl_yonetici where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da Şifre!");
            }

            baglanti.Close();


        }

        private void GirisPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
