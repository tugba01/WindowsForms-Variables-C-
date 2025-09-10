using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            int sayi1, sayi2, proje;
            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox4.Text);
            proje = Convert.ToInt32(textBox5.Text);
            double ortalama;
            ortalama = (sayi1 + sayi2 + proje) / 3;
            listBox1.Items.Add(ad + " " + soyad + " Ortalaması: "+ ortalama);

        }
    }
}
