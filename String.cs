namespace Degiskenler
{
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //değişkentürü değişkenadı; ⇒ değişken tanımlama
        {
            //string metin; //ilk başta altı çizili olacak. bunun anlamı tanımladın ama daha önce hiç kullanmadın uyarısıdır
            //metin = "Merhaba bugün 3 Eylül Çarşamba";
            //label1.Text = metin; //not: c#ta araçların başlangıçta büyük çoğunluğu default olarak string formattadır

            string adsoyad, meslek;
            adsoyad = "Ahmet Yılmaz";
            meslek = "Öğretmen";
            label1.Text = adsoyad;
            label2.Text = meslek;

            string sehir;
            sehir = textBox1.Text;
            label3.Text = sehir; //burada zik zak çiziyoruz gibi. önce değer atandı. sonra textboxtan gelen değer bu değere atandı. sonra bu değer label'a yazdırıldı

        }
    }
}
