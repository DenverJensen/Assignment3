using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int i = 1; i <= 5; i++)
            {
                pictureBox1.Image = Image.FromFile("die" + i.ToString() + ".gif");
                pictureBox1.Refresh();
                Thread.Sleep(300);



                /*
                pbImage.Image = Image.FromFile("C:/Users/jense/OneDrive/Desktop/C#/Assignments/Assignment2/images/die6.gif");
                pbImage.Refresh();
                Thread.Sleep(300);
                pbImage.Image = Image.FromFile("C:/Users/jense/OneDrive/Desktop/C#/Assignments/Assignment2/images/die5.gif");
                pbImage.Refresh();
                Thread.Sleep(300);
                pbImage.Image = Image.FromFile("C:/Users/jense/OneDrive/Desktop/C#/Assignments/Assignment2/images/die4.gif");
                pbImage.Refresh();
                Thread.Sleep(300);*/
            }
        }
    }
}
