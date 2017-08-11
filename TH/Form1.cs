using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "THIAGO E CHININHA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int Numero = rand.Next(0, trackBar1.Value);

            label1.Text = Numero.ToString();

           
            
            textBox1.Enabled = !checkBox1.Enabled;

            checkBox1.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         
        }
    }
}
