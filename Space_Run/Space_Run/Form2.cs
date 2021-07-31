using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Space_Run
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

       public static int NesneSayısı = 100,TasSayisi = 100,InsanSayisi=100;
       public static int NesneSırası = 0,TasSirasi = 0,InsanSirasi =0;
       public static int deger,sayi,rakam;
       public static int can = 3;
       public static int puan = 0;
        int yer = 140,konum=500;
        int x, y,z=5;


        ArrayList Taslar = new ArrayList();
        Random pnd = new Random();
        public void YeniTas()
        {
            for (int k = 0; k < TasSayisi; k++)
            {
                PictureBox tas = new PictureBox();
                sayi = pnd.Next(1, 7);
                x = pnd.Next(0,1250);
                y = pnd.Next(200,650);
                tas.Size = new Size(50, 50);
                tas.SizeMode = PictureBoxSizeMode.StretchImage;
                tas.BackColor = Color.Transparent;
                tas.ImageLocation = "taslar/" + sayi + ".png";
                tas.Location = new Point(0,0);
                tas.Visible = false;
                this.Controls.Add(tas);
                Taslar.Add(tas);
            }
        }
        
        
        public void DusenTas()
        {
            if (TasSirasi < TasSayisi)
            {
                Random r = new Random();
                PictureBox tas = ((PictureBox)Taslar[TasSirasi]);
                tas.Visible = true;

               
                tas.Location = new Point(x,y);
                
              
                

                if (tas.Bottom >= kahraman.Top && tas.Left >= kahraman.Left && tas.Right <= kahraman.Right)
                {
                    x = r.Next(0,1250);
                    y = r.Next(200,650);
                    TasSirasi++;
                    tas.Visible = false;
                    can = can + 1;
                    
                }
            }
        }



        ArrayList Insanlar = new ArrayList();
        Random ins = new Random();
        public void YeniInsan()
        {
            for (int t = 0; t < InsanSayisi; t++)
            {
                PictureBox insan = new PictureBox();
                rakam = ins.Next(1, 7);
                insan.Size = new Size(120,120);
                insan.SizeMode = PictureBoxSizeMode.StretchImage;
                insan.BackColor = Color.Transparent;
                insan.ImageLocation = "insan/" + rakam + ".png";
                insan.Location = new Point(120,270);
                insan.Visible = false;
                this.Controls.Add(insan);
                Insanlar.Add(insan);
            }

        }

        private void DusenInsan()
        {
            if (InsanSirasi < InsanSayisi)
            {
                PictureBox insan = ((PictureBox)Insanlar[InsanSirasi]);
                insan.Visible = true;
                insan.Top = insan.Top + 5;
                insan.Location = new Point(konum, insan.Location.Y);

                if (insan.Bottom >= kahraman.Top && insan.Left >= kahraman.Left && insan.Right <= kahraman.Right)
                {
                    InsanSirasi++;
                    insan.Visible = false;
                    puan = puan - 10;
                    
                }
                lblskor.Text = puan.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti");
                this.Close();

            }
        }








        ArrayList Nesneler = new ArrayList();
        Random rnd = new Random();
        public void YeniNesne()
        {
            for (int i = 0; i <NesneSayısı; i++)
            {
                PictureBox nesne = new PictureBox();
                deger = rnd.Next(1, 6);
                nesne.Size = new Size(175, 175);
                nesne.SizeMode = PictureBoxSizeMode.StretchImage;
                nesne.BackColor = Color.Transparent;
                nesne.ImageLocation = "dusman/" + deger + ".png";
                nesne.Location = new Point(387, 5);
                nesne.Visible = false;
                this.Controls.Add(nesne);
                Nesneler.Add(nesne);
            }

        }

        private void DusenNesne()
        {
            if (NesneSırası < NesneSayısı)
            {
                PictureBox nesne = ((PictureBox)Nesneler[NesneSırası]);
                nesne.Visible = true;
                nesne.Top = nesne.Top + z;
                nesne.Location = new Point(yer, nesne.Location.Y);

                if (nesne.Bottom >= kahraman.Top && nesne.Left >= kahraman.Left && nesne.Right <= kahraman.Right)
                {
                    NesneSırası++;
                    nesne.Visible = false;
                    puan = puan + 10;
                }
                lblskor.Text = puan.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti");
                this.Close();
                
            }
        }

        private void level(object sender, EventArgs e)
        {
            
            if (puan > 10)
            {
                
                z = z + 5;

                
            }
            if (puan > 40)
            {
              
                z = z + 5;
                
            }
        }
        private void kalanCan(object sender, EventArgs e)
        {
            if (NesneSırası < NesneSayısı)
            {
                PictureBox nesne = ((PictureBox)Nesneler[NesneSırası]);
                if (nesne.Bottom > kahraman.Bottom && !(nesne.Right >= kahraman.Left && nesne.Left <= kahraman.Right))
                {
                    can--;
                    for (int j = 0; j < Nesneler.Count; j++)
                    {
                        PictureBox xd = ((PictureBox)Nesneler[NesneSırası]);
                        ((PictureBox)Nesneler[NesneSırası]).Dispose();
                    }
                    Nesneler.Clear();
                 //  DialogResult dd = DialogResult.None;
                    timer1.Stop();
                    if (can > 0)
                    {
                   //   dd = MessageBox.Show("Yandınız! Kalan canınız" + " -->" + can.ToString());
                    //if (dd == DialogResult.OK)
                        {
                            Form2_Load(sender, e);
                        }
                  }
                    else if (can == 0)
                    {
                        MessageBox.Show("oyun bitti skorunuz "+ "--> " +puan.ToString());
                        this.Close();
                        Application.Exit();
                    }

                    }
                lblcan.Text = can.ToString();

            }
                
            
            else
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti");
                this.Close();
                
            }
        }
      
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            DusenNesne();
            DusenTas();
            DusenInsan();
            level(sender, e);
            kalanCan(sender , e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            YeniNesne();
            YeniTas();
            YeniInsan();
            
            timer1.Start();
            
            
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                kahraman.Top -= 50;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                kahraman.Left += 50;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                kahraman.Left -= 50;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                kahraman.Top += 50;
            }
        }
        Random rst = new Random();
        private void lblskor_TextChanged(object sender, EventArgs e)
        {
            yer = rnd.Next(0,1250);
            konum = rst.Next(0, 1250);
        }    
    } 
}
