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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt32(textBox1.Text);
            su = Convert.ToInt32(textBox2.Text);
            cay = Convert.ToInt32(textBox3.Text);
            bilet = Convert.ToInt32(textBox4.Text);
            toplam = misir * 100 + su * 10 + cay * 10 + bilet * 200;
            label10.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            label12.Text = kasatutar.ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label10.Text = "00TL";
            textBox1.Focus(); //imleci tekrar textbox1e odaklar
        }
    }
}
