using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       int salise=0;
        int saniye = 0;
        int dakika = 0;
        int sayac = 0;
        int salise1 = 0;
        int saniye1= 0;
        int dakika1= 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Start();
            salise++;
            label1.Text = salise.ToString();
            if (salise==100)
            {
                salise = 0;
                saniye++;
                label2.Text = saniye.ToString();
            }
            if (saniye==59)
            {
                saniye = 0;
                dakika++;
                label3.Text = dakika.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            sayac++;
            int sira = listView1.Items.Count;
            listView1.Items.Add(sayac.ToString());
            listView1.Items[sira].SubItems.Add(label3.Text + ":" + label2.Text + ":" + label1.Text);
            listView1.Items[sira].SubItems.Add(label6.Text + ":" + label5.Text + ":" + label4.Text);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            salise1++;
            label4.Text = salise1.ToString();
            if (salise1 == 100)
            {
                salise1 = 0;
                saniye++;
                label5.Text = saniye1.ToString();
            }
            if (saniye1 == 59)
            {
                saniye1 = 0;
                dakika1++;
                label6.Text = dakika1.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
    }
}
