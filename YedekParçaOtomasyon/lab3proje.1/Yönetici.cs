using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 210229055_EkremTeyin

namespace lab3proje._1
{
    public partial class Yönetici : Form
    {
        public Yönetici()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="123456")
            {
                Form1 AnaMenü = new Form1();
                AnaMenü.Show();
                this.Hide();
            }
        }

        private void Yönetici_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "seller" && textBox4.Text == "123456")
            {
                BayiEkran bayiekrani = new BayiEkran();
                bayiekrani.Show();
                this.Hide();
            }
        }
    }
}
