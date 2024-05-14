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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüşteriEkle ekle = new MüşteriEkle();
            ekle.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           MüşteriListele listele = new MüşteriListele();
           listele.ShowDialog();
            
        }
    }
}
