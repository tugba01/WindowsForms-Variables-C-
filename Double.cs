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
    public partial class Double : Form
    {
        public Double()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        //double ondalıklı ifadeler
        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 4.25;
            label1.Text = sayi.ToString(); //double sayi değerini stringe çevirip labela yazdırdık


            double ortalama, sinav1, sinav2, sinav3;
            sinav1 = 60;
            sinav2 = 70;
            sinav3 = 79;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label2.Text = ortalama.ToString();
            //label2.Text = ortalama.ToString(0.00); => virgülden sonra 2 basamak getirecek şekilde formatladık
            //label2.Text = ortalama.ToString(0.000); => virgülden sonra 3 basamak getirecek şekilde formatladık.sınırlandırdık

            double number;
            number = Convert.ToDouble(textBox1.Text); //textbox1den gelen değeri doublea dönüştürüp numbera atadık
            label3.Text = number.ToString();
        }
    }
}
