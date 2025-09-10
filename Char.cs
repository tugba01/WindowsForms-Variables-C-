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
    public partial class Char : Form
    {
        public Char()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //char tek karakterli veriler için kullanılıyor
            //bellekte çok daha az yer kaplar
            //ascıı kodları = bilgisayardki karakterlerin derleyici tarafında karşılığı
            //ascıı = uluslararası karakter tablosu
            //ascıı = karakterlerin sayı karşılıkları
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //char tanımlanırken çift tırnak değil tek tırnak kullanılır
            //char takim;
            //takim = 'g';
            //label1.Text = takim.ToString(); 

            char ders;
            ders = Convert.ToChar(textBox1.Text); //textbox1den gelen string değerini chara dönüştürecek ve onu derse atayacak
            label1.Text = ders.ToString(); //char tipindeki ders değerini stringe dönüştürerek label1e yazdıracak
            //null değerler stringde çalışır ama charda çalışmz
        }
    }
}
