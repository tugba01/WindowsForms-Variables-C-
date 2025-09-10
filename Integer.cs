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
    public partial class Integer : Form
    {
        public Integer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //araçların büyük çoğunluğu string formatta. listbox, combobox hariç vs. label textbox maskedtextbox => string formatındadır.
            //int değerlerle çalışırken muhakkak stringe dönüştürmemiz lazım
            int sayi;
            sayi = 24;
            //label1.Text = sayi => bu hata verir çünkü label string formatında = sayi int formatında. kısaca string = int gibi bir şey yapılmış oluyor. bu yüzden stringe çevirmemiz lazım

            label1.Text = sayi.ToString(); //int değerini stringe çevirdik

            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2 = 4;
            toplam = sayi1 + sayi2;
            label2.Text = toplam.ToString();

            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = 4 * kenar;
            label3.Text = "Alan: " + alan + " Çevre: " + cevre; //burada alan değişkenini stringe dönüştürmeye gerek yok çünkü "Alan: " ifadesi zaten bir string türüdür. bir tane string türü olması diğer string olmayan türlerin stringe çevrilmesi şartını düşürür
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //C#da integer'ın 3 temel dönüşümü var
            //toint16 => en küçük aralık, -32 +32bin arası
            //toint32 => en yaygını.
            //toint64

            int sayii; //sayı başlangıçta int
            sayii = Convert.ToInt32(textBox1.Text); //ama textbox string değerinde ve bu string değerini int'a çevirdik
            label5.Text = sayii.ToString(); //daha sonra çevrilmiş int değerini bir kez daha stringe çeviriyoruz çünkü label string türünde
        }

        private void button3_Click(object sender, EventArgs e) //girilen sayının küpünü alacak ve label'da yazdıracak
        {
            int sayiii, sonuc;
            sayiii = Convert.ToInt32(textBox2.Text); //textbox2den gelen değeri int'a çevirip sayiii değerine atadık
            sonuc = sayiii * sayiii * sayiii; //sonuc değerini tanımladık
            label7.Text = sonuc.ToString(); //sonuc değerini stringe çevirip label7'ye yazdırdık
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1, number2, toplamx, carpimx, farkx, bolumx;
            number1 = Convert.ToInt32(textBox3.Text);
            number2 = Convert.ToInt32(textBox4.Text);
            toplamx = number1 + number2;
            carpimx = number1 * number2;
            bolumx = number1 / number2;
            farkx = number1 - number2;
            MessageBox.Show("Toplam " + toplamx + "\nFark: " + farkx + "\nBölme: " + bolumx + "\nÇarpma: " + carpimx);
            //ctrl + k + d => kodların düzenlenmesi

        }
    }
}
