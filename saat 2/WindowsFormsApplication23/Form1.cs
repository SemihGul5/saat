using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0, dakika = 0, saat = 0;
        int s = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s++;
            int sira = listView1.Items.Count;
            listView1.Items.Add(s.ToString());
            listView1.Items[sira].SubItems.Add(saat+":"+dakika+":"+saniye);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if (saniye==60)
            {
                saniye = 0;
                dakika++;
                label2.Text = dakika.ToString();
                if (dakika==59)
                {
                    dakika = 0;
                    saat++;
                    label1.Text = saat.ToString();

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            s++;
            timer1.Start();
        }
    }
}
