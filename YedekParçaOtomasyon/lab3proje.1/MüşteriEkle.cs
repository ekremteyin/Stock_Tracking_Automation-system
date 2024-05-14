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
// 210229055_EkremTeyin

namespace lab3proje._1
{
    public partial class MüşteriEkle : Form
    {
        public MüşteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RKDH42P\\SQLEXPRESS;Initial Catalog=StokTakip;User ID=sa;Password=123456;TrustServerCertificate=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into musteri(Ad,Soyad,telefon,eposta) values(@Ad,@Soyad,@telefon,@eposta)", baglan);
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", textBox3.Text);
            komut.Parameters.AddWithValue("@eposta", textBox4.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Müşteri kaydı eklendi");
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void MüşteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
