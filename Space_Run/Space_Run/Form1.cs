using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Space_Run
{
    public partial class Form1 : Form
    {
        Form2 nor = new Form2();
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Space_Run";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nor.Show();//Form 2'ye geçmek için.
            this.Hide();//Form 1'i gizlemek için.
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\avg.wav";
            ses.SoundLocation = dizin;
            ses.Play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yön tuşlarını kullanarak kötü adamların üstüne gelerek puan toplayabilirsiniz.Ama insanlara dikkat edin onlara değerseniz puanınız azalıcaktır azalıcaktır ayrıca kötü adamı kaçırırsanız canınız azalır.Yaşam taşlarını toplayarak canınızı arttırabilirsiniz");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
