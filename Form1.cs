using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hızlıyazmatesti1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Random rnd = new Random();
            InitializeComponent();
        }
       // Random rast = new Random();
        int sure = 61;
        int kelime = 0;

        void say()
        {
            Random rnd = new Random();
            int sayi1 = rnd.Next(1, 62);
            if (sayi1 == 1)
            {
                lblkelime.Text = "araba";
            }
            if (sayi1 == 2)
            {
                lblkelime.Text = "rap";
            }
            if (sayi1 == 3)
            {
                lblkelime.Text = "sansar";
            }
            if (sayi1 == 4)
            {
                lblkelime.Text = "sözlük";
            }
            if (sayi1 == 5)
            {
                lblkelime.Text = "karaca";
            }
            if (sayi1 == 6)
            {
                lblkelime.Text = "fare";
            }
            if (sayi1 == 7)
            {
                lblkelime.Text = "çarpmak";
            }
            if (sayi1 == 8)
            {
                lblkelime.Text = "yıldırım";
            }
            if (sayi1 == 9)
            {
                lblkelime.Text = "klavye";
            }
            if (sayi1 == 10)
            {
                lblkelime.Text = "üstad";
            }
            if (sayi1 == 11)
            {
                lblkelime.Text = "fiş";
            }
            if (sayi1 == 12)
            {
                lblkelime.Text = "oyuncak";
            }
            if (sayi1 == 13)
            {
                lblkelime.Text = "panik";
            }






            if (sayi1 == 14)
            {
                lblkelime.Text = "ihanet";
            }
            if (sayi1 == 15)
            {
                lblkelime.Text = "makas";
            }
            if (sayi1 == 16)
            {
                lblkelime.Text = "bilgisayar";
            }
            if (sayi1 == 17)
            {
                lblkelime.Text = "fotoğraf";
            }
            if (sayi1 == 18)
            {
                lblkelime.Text = "kılıf";
            }
            if (sayi1 == 19)
            {
                lblkelime.Text = "dosya";
            }
            if (sayi1 == 20)
            {
                lblkelime.Text = "şarj";
            }
            if (sayi1 == 21)
            {
                lblkelime.Text = "şarkı";
            }
            if (sayi1 == 22)
            {
                lblkelime.Text = "tarayıcı";
            }
            if (sayi1 == 23)
            {
                lblkelime.Text = "takvim";
            }
            if (sayi1 == 24)
            {
                lblkelime.Text = "olmak";
            }
            if (sayi1 == 25)
            {
                lblkelime.Text = "uyumak";
            }
            if (sayi1 == 26)
            {
                lblkelime.Text = "yemek";
            }







            if (sayi1 == 27)
            {
                lblkelime.Text = "mola";
            }
            if (sayi1 == 28)
            {
                lblkelime.Text = "şirket";
            }
            if (sayi1 == 29)
            {
                lblkelime.Text = "yaş";
            }
            if (sayi1 == 30)
            {
                lblkelime.Text = "kaşıntı";
            }
            if (sayi1 == 31)
            {
                lblkelime.Text = "karışım";
            }
            if (sayi1 == 32)
            {
                lblkelime.Text = "tüfek";
            }
            if (sayi1 == 33)
            {
                lblkelime.Text = "gizli";
            }
            if (sayi1 == 34)
            {
                lblkelime.Text = "söz";
            }
            if (sayi1 == 35)
            {
                lblkelime.Text = "dünya";
            }
            if (sayi1 == 36)
            {
                lblkelime.Text = "hikaye";
            }
            if (sayi1 == 37)
            {
                lblkelime.Text = "komplo";
            }
            if (sayi1 == 38)
            {
                lblkelime.Text = "düş";
            }
            if (sayi1 == 39)
            {
                lblkelime.Text = "rüya";
            }








            if (sayi1 == 40)
            {
                lblkelime.Text = "dert";
            }
            if (sayi1 == 41)
            {
                lblkelime.Text = "huzur";
            }
            if (sayi1 == 42)
            {
                lblkelime.Text = "hayat";
            }
            if (sayi1 == 43)
            {
                lblkelime.Text = "gitmek";
            }
            if (sayi1 == 44)
            {
                lblkelime.Text = "olacak";
            }
            if (sayi1 == 45)
            {
                lblkelime.Text = "kazanmak";
            }
            if (sayi1 == 46)
            {
                lblkelime.Text = "başarmak";
            }
            if (sayi1 == 47)
            {
                lblkelime.Text = "azim";
            }
            if (sayi1 == 48)
            {
                lblkelime.Text = "kaybolmak";
            }
            if (sayi1 == 49)
            {
                lblkelime.Text = "gece";
            }
            if (sayi1 == 50)
            {
                lblkelime.Text = "çalışmak";
            }
            if (sayi1 == 51)
            {
                lblkelime.Text = "gülmek";
            }
            if (sayi1 == 52)
            {
                lblkelime.Text = "kral";
            }
            if (sayi1 == 53)
            {
                lblkelime.Text = "ölmek";
            }
            if (sayi1 == 54)
            {
                lblkelime.Text = "sarsılmak";
            }
            if (sayi1 == 55)
            {
                lblkelime.Text = "yıkılmak";
            }
            if (sayi1 == 56)
            {
                lblkelime.Text = "devrilmek";
            }
            if (sayi1 == 57)
            {
                lblkelime.Text = "parça";
            }
            if (sayi1 == 58)
            {
                lblkelime.Text = "elma";
            }
            if (sayi1 == 59)
            {
                lblkelime.Text = "gazoz";
            }
            if (sayi1 == 60)
            {
                lblkelime.Text = "pencere";
            }
            if (sayi1 == 61)
            {
                lblkelime.Text = "cam";
            }

        }   
                    
                
            
        

   


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            say();
            textBox1.Focus();
            timer1.Start();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == lblkelime.Text)
            {
                kelime++;
                textBox1.Clear();
                label3.Text = "Yazılan Kelime Sayısı: " + kelime.ToString();
                say();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label2.Text = "Süre: "+sure.ToString();
            if (sure == 0)
            {
                textBox1.Enabled = false;
                timer1.Stop();
            }
        }
}
}
