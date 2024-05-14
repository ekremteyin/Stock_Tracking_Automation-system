using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// 210229055_EkremTeyin

namespace lab3proje._1
{
    public partial class MüşteriListele : Form
    {
        public MüşteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RKDH42P\\SQLEXPRESS;Initial Catalog=StokTakip;User ID=sa;Password=123456;TrustServerCertificate=True");
        DataSet daset= new DataSet();
        private void MüşteriListele_Load(object sender, EventArgs e)
        {
            verileriGoruntule();
        }
        private void verileriGoruntule()
        {
            baglan.Open();
            SqlDataAdapter adtr= new SqlDataAdapter("Select *From musteri",baglan);
            adtr.Fill(daset, "musteri");
            dataGridView1.DataSource = daset.Tables["musteri"];
            baglan.Close();

           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void MüşteriListele_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            verileriGoruntule();
        }

       
        
        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from musteri where Ad=@Ad", baglan);
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            daset.Tables["musteri"].Clear();
            verileriGoruntule();
            MessageBox.Show("Kayıt Silindi");
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["eposta"].Value.ToString();
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
