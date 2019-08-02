using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilk = Convert.ToInt32(textBox1.Text);
            int son = Convert.ToInt32(textBox2.Text);
            for (int i = ilk; i < son; i++)
            {
                DateTime tarih = new DateTime(i, 1, 1);
                string kontrol = tarih.ToString("dddd");
                if (kontrol == "Pazartesi")
                {
                    listBox1.Items.Add(i);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int gün = rnd.Next(1, 30);
                int ay = rnd.Next(1, 12);
                int yıl = rnd.Next(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                DateTime tarih = new DateTime(yıl, ay, gün);
                listBox2.Items.Add(tarih.ToString("d"));
                listBox3.Items.Add(tarih.ToString("dddd"));
            }
        }
    }
}
