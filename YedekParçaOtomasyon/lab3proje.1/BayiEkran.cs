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
//  210229055_EkremTeyin

namespace lab3proje._1
{
    public partial class BayiEkran : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-RKDH42P\\SQLEXPRESS;Initial Catalog=StokTakip;User ID=sa;Password=123456;TrustServerCertificate=True"); // SQL bağlantı cümlesini buraya ekleyin



        public BayiEkran()
        {
            InitializeComponent();
        }

        private void BayiEkran_Load(object sender, EventArgs e)
        {
           
            this.partsTableAdapter.Fill(this.stokTakipDataSet21.Parts);
            
            this.carsTableAdapter1.Fill(this.stokTakipDataSet21.Cars);

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.partsTableAdapter.FillBy(this.stokTakipDataSet21.Parts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}