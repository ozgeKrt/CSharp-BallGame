using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ob_proje_deneme
{
    public partial class Form2 : Form
    {

        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void yazdır()
        {
            StreamWriter writer = File.AppendText("Skorlar.txt");       //dosyaya ekleme yapma.Bu sayede daha önceki verileri silmeden ekleme yapmış oluruz.
            writer.WriteLine(AdTextBox.Text + " " + zamanLabel.Text);
            writer.Close();
            Form2 frm2 = new Form2();           //yüksek skor formu açılacak
            frm2.Show();
            this.Hide();    //yeni form açıldıktan sonra bu formu gizledik.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
