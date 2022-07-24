using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericKavrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Generic => Tasarlanan interface, class,method yada parametrelerin belirli bir şablon yapısında çalışması için generic tanımlanabilir

        ArrayList arrayCollection = new ArrayList();

        //Generic
        List<string> listCollection = new List<string>();
        List<double> doubleCollection = new List<double>();
        List<int> intCollection = new List<int>();


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

    
}
