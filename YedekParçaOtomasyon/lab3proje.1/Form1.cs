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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 MüşteriGörüntüle = new Form2();
            MüşteriGörüntüle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BayiEkran bayiekrani = new BayiEkran();
            bayiekrani.Show();
            this.Hide();
        }
    }
}
