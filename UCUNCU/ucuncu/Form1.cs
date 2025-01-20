using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucuncu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // MaskCompleted ile kullanıcının yazdığı verinin doğru bir biçimde olup olmadığının kontrolü yapılır ve true false olarak tcTam, telTam, dogumTam verilerien atanır.
               var tcTam = tcbilgisi.MaskCompleted;
                var telTam = telefonbil.MaskCompleted;
                 var dogumTam = dogumbil.MaskCompleted;


            
            //True false verileri için bool dizisi oluşturuyoruz ki giren kullanıcıya daha sonra hangi veriyi yanlış girdiğinin bilgisini verebilelim. 
            bool[] kontrol = new bool[3];
            kontrol[0] = tcTam;
            kontrol[1] = telTam;
            kontrol[2] = dogumTam;

            //Kullanıcıya true false verisini gösterdiğimizde herhangi bir şey anlamayacağından kaynaklı bunlara karşılık gelen bir dizi açtık. 
            string[] isimler = new string[] { "TC", "TELEFON", "DOĞUM TARİHİ" };


            // isimler dizisi statik bir dizi olduğundan kaynaklı sonrasında verileri işlemesi zor oluyor bu yüzden bir liste açtım. Kullanıcı Telefon bilgisini yanlış girdi diyelim.
            // Telefon bilgisi verisi false dönecek. Bizde bu false dönen veriyi isimler dizisi ile isimlendirip, bu ismi eksik veriler listesine atayacağız.
            List<string> eksikVeriler = new List<string>();


            // İsimler dizisi uzunluğunda bir döngü çalıştırıyoruz. Eğer kontrol dizisinde false varsa, bu veriyi eksikVeriler listesine ekliyoruz.
             for (int i = 0; i < isimler.Length; i++)
            {
                if (kontrol[i] == false) // burada başta aldığımız verileri kontrol ettiriyoruz. Eğer yanlış ise gelen veri komutu çalışır. 
                {
                    eksikVeriler.Add(isimler[i]); // burada artık i kaçıncı sayıdaysa eksikveriler listesine, isimler içerisinde bulunan ve i' sayısına atanan değere(0,1,2) karşılık gelen veriyi ekler
                }
            }
            if (tcTam == true  && telTam == true  && dogumTam == true)  // hepsi true ise gir
            {
                //verileri listbox1'e ekle
                listBox1.Items.Add(tcbilgisi.Text);
                listBox1.Items.Add(telefonbil.Text);
                listBox1.Items.Add(dogumbil.Text);
                listBox1.Items.Add("--------"); //veriler karışmasın babacım illa isim mi alıcaz
            }
            else
            {
                string eksikler = string.Join(", ", eksikVeriler); // eksikveriler listesindeki verilerin arasına virgül koyduk her zaman gelen veriyi bilemeyiz isimler dizisinde oynama yapmadan bu şekilde güncellenebilir.
                MessageBox.Show("Lütfen Tüm Bilgileri Eksiksiz Doldurunuz! Yanlış Ya da Eksik Bilgiler: " + eksikler ); // gelen eskik verilerin ne olduğunu ekrana yazdık  
                
            }
        }
    }
}
