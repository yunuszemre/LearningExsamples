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


namespace WindowsFormsExample_1
{
    public partial class Form1 : Form
    {
        bool tiklandi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOliveGreen;
            button1.ForeColor = Color.White;
        }



        private void changeClick(object sender, EventArgs e)
        {
            Console.Beep();
            if (!tiklandi)
            {
                label1.Text = "Tıklanmadı";
                tiklandi = false;
                MessageBox.Show("Test","info" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label1.Text = "Tıklandı";
                tiklandi = true;
            }
        }
    }
}
