using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;    //ovallik için
using System.IO;

namespace ob_proje_deneme
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public int koordinatX = 4;
        public int koordinatY = 4;
        public int noktaX = 0;
        private int sayac1 = 0;
        private static int raketBaslangicX = 0;
        Timer zamanlayici = new Timer();


        public Form1()
        {
            frm2 = new Form2();
            InitializeComponent();
            frm2.frm1 = this;           //yetkilerini buna aktar.
           // timer1.Enabled = true;       //zamanlayıcı etkin(ekrana çift tıklandığında etkin olduğu için oyun başında başlatmaya gerek kalmadı
                                     //Cursor: Hide();          //imleci gizle
                                     // this.FormBorderStyle = FormBorderStyle.None;    //form kenarlık sınırı(stili) yok.
                                     //  this.TopMost = true;        //formu ön tarafa getir.
                                     //  this.Bounds = Screen.PrimaryScreen.Bounds;  //tam ekran yap.

            raketBaslangicX= platform.Bottom - (platform.Bottom / 10);  //raketin başlangıç konumu
            raket.Top = raketBaslangicX;
           // Cursor.Hide();       imleci gizle
            DoubleBuffered = true;//Formlar ve Denetimler için İki Kez Arabelleğe Alma ile Grafik Titreşimini Azaltma

            zamanlayici = new Timer();
            zamanlayici.Interval = 10;
            zamanlayici.Tick += timer1_Tick;
            DoubleBuffered = true;
        }



        int salise = 0;
        int saniye = 0;
        int dakika = 0;
        int sayac5 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {


            if ((Cursor.Position.X - (raket.Width) > platform.Left))
                sayac5 = 0;  //raketin ortasına imlecin konumu ayarlandı (raket mouse'u takip ediyor.)


            if (sayac5 == 0)
                raket.Left = Cursor.Position.X - (raket.Width);

            if ((raket.Left <= platform.Left))
                sayac5 = 1;  //raketin ortasına imlecin konumu ayarlandı (raket mouse'u takip ediyor.)
            if (!(Cursor.Position.X - (raket.Width) > platform.Left))
                sayac5 = 1;

            top.Left += koordinatX;
            top.Top += koordinatY;


            if (top.Bottom>= raket.Top &&top.Bottom<=raket.Bottom && top.Left>=raket.Left &&top.Right<=raket.Right)
            {
                koordinatX += 2;
                koordinatY += 2;
                koordinatY = -koordinatY;
                noktaX += 1;
            }
            if(top.Left<=platform.Left)
            {
                koordinatX = -koordinatX;
            }
            if(top.Right>=platform.Right)
            {
                koordinatX = -koordinatX;
            }
            if(top.Top<=platform.Top)
            {
                koordinatY = -koordinatY;
            }
            if(top.Bottom>=platform.Bottom)
            {
                timer1.Enabled = false;  //top dışarıda kalır oyun biter.
                MessageBox.Show("Game Over");
                sayac1 = 0;
                timer1.Stop();
                top.Location = new Point(350, 15);

            }
            if (sayac1 == 1)
            {

            }

            salise += 5;
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }
            if (saniye==60)
            {
                saniye = 0;
                dakika++;
            }
            Zaman.Text = string.Format(" {0:00}:{1:00}:{2:00}", dakika, saniye, salise);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }  //çıkmak için çıkış tuşuna basın.
        }
        
        

        private void yuksekSkorlar_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }
        
        private void raket_MouseMove(object sender, MouseEventArgs e)
        {
            raket.Left = e.X;
        }

        private void platform_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;      //ekrana çift tıkladığında oyun başlar.
        }


        public void okuma()
        {

            FileStream file = new FileStream("Skorlar.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string metin = reader.ReadLine();
            int sayma = 0;
            while (metin != null)
            {
                if (sayma == 5)        //ilk beşini yazacağımızdan dolayı 5. satıra geldiğimizde döngüden çıktık.
                {
                    break;
                }
                yuksekSkorlar.Text = metin + '\n';      //satır satır okutup txt e yazdırma
                metin = reader.ReadLine();
                sayma++;
            }
            reader.Close();
            file.Close();
        }
        

    }
}
