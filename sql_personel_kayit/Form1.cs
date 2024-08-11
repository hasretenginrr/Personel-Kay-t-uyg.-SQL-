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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti=new SqlConnection("Data Source=HASRET\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        void temizle()
        {
            idtxt.Text = "";
            adtxt.Text = "";
            soyadtxt.Text = "";
            meslektxt.Text = "";
            sehirtext.Text = "";
            maastxt.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            adtxt.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personelVeriTabaniDataSet.tbl_personel);

        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personelVeriTabaniDataSet.tbl_personel);

        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komut=new SqlCommand("insert into tbl_personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1, @p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1",adtxt.Text);
            komut.Parameters.AddWithValue("@p2",soyadtxt.Text);
            komut.Parameters.AddWithValue("@p3",sehirtext.Text);
            komut.Parameters.AddWithValue("@p4",maastxt.Text);
            komut.Parameters.AddWithValue("@p5",meslektxt.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("personel eklendi.");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;

            idtxt.Text=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adtxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadtxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sehirtext.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maastxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            meslektxt.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            else { 
                 radioButton2.Checked = true;
            }
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete From tbl_personel where perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", idtxt.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update tbl_personel Set PerAd=@a1, PerSoyad=@a2, PerSehir=@a3, PerMaas=@a4,PerDurum=@a5, PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1",adtxt.Text);
            komutguncelle.Parameters.AddWithValue("@a2",soyadtxt.Text);
            komutguncelle.Parameters.AddWithValue("@a3",sehirtext.Text);
            komutguncelle.Parameters.AddWithValue("@a4",maastxt.Text);
            komutguncelle.Parameters.AddWithValue("@a5",label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6",meslektxt.Text);
            komutguncelle.Parameters.AddWithValue("@a7",idtxt.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Personel bilgisi güncellendi.");


            baglanti.Close();
        }

        private void istatistikbtn_Click(object sender, EventArgs e)
        {
            Frmistatistik fr= new Frmistatistik();
            fr.Show();
        }
    }
}
