using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Constructure Method
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //İnput içerisindeki değer değiştiğinde tetiklenir
            //Sender Eventi teikleyen controlmhangisi ise parametre olarak o gönderilir
            if (textBox1.Text == "a" || textBox1.Text == "A")
            {
                MessageBox.Show("A karakterine basıldı");
                //char pressedCaharacter = 
            }

            

        }
    }
}
