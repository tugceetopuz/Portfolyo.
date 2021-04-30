using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png|video|*..avi|Tüm Dosyalar|*.*";
            dosya.Title = "";
            dosya.ShowDialog();
            string Dosyayolu = dosya.FileName;
            pictureBox1.ImageLocation = Dosyayolu;
            pictureBox2.ImageLocation = Dosyayolu;

        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.BackColor = Color.White;
            textBox2.Enabled = true;
            textBox2.BackColor = Color.White;
            Btn4.Enabled = true;
            Btn4.BackColor = Color.White;
            Btn6.Enabled = true;
            Btn6.BackColor = Color.White;
            Btn5.Enabled = true;
            Btn5.BackColor = Color.White;
            Btn_yaziekle.Enabled = true;
            Btn_yaziekle.BackColor = Color.White;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.BackColor = Color.Black;
            textBox2.Enabled = false;
            textBox2.BackColor = Color.Black;
            Btn4.Enabled = false;
            Btn4.BackColor = Color.Black;
            Btn6.Enabled = false;
            Btn6.BackColor = Color.Black;
            Btn5.Enabled = false;
            Btn5.BackColor = Color.Black;
            Btn_yaziekle.Enabled = false;
            Btn_yaziekle.BackColor = Color.Black;
        }
        Bitmap bmp;
        public void Btn3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Resim Dosyası |*.jpg;*.nef;*.png|video|*..avi|Tüm Dosyalar|*.*";
            sfd.Title = "";
            sfd.FileName = "resim";
            DialogResult sonuc = sfd.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                pictureBox2.Image.Save(sfd.FileName);
            }
        }

        public void Btn6_Click(object sender, EventArgs e)
        {
            int xofseti, yofseti;
            var a=Convert.ToInt32(textBox1.Text);
            

            var orjinalGoruntu=new Bitmap (pictureBox1.Image);
            var goruntuGenislik = orjinalGoruntu.Width;
            var goruntuYukseklik = orjinalGoruntu.Height;

            var piksellestirilmisGoruntu = new Bitmap(goruntuGenislik, goruntuYukseklik);

            for (var i=0;i<goruntuGenislik;i += a)
            {
                for (var j = 0; j < goruntuYukseklik; j += a)
                {
                    xofseti = yofseti = a/2;
                    if(i+xofseti>=goruntuGenislik)
                    {
                        xofseti = goruntuGenislik - i - 1;
                    }
                    if (j + yofseti >= goruntuYukseklik)
                    {
                        yofseti = goruntuYukseklik - j - 1;
                    }
                    var piksel = orjinalGoruntu.GetPixel(i + xofseti , j + yofseti);

                    for (var x=i;x<i+a && x < goruntuGenislik;x++)
                    {
                        for (var y = j; y < j + a && y < goruntuYukseklik; y++)
                        {
                            piksellestirilmisGoruntu.SetPixel(x, y, piksel);
                        }
                    }
                }
            }
            pictureBox2.Image = piksellestirilmisGoruntu;

        }
        
    }

    
}
