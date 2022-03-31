using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac <= 29)
            {
                int artis = int.Parse(numericUpDown1.Value.ToString());
                sayac += artis;
                label1.Text = sayac.ToString();
            }
            else
            {
                label1.Text = "30";
                MessageBox.Show("Sayınız 30 dan büyük olamaz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac >= 1)
            {
                int artis = int.Parse(numericUpDown1.Value.ToString());
                sayac -= artis;
                label1.Text = sayac.ToString();
            }
            else
            {
                label1.Text = "0";
                MessageBox.Show("Sayınız - olamaz.");
            }

           

        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
