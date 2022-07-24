using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GenericMethod(new Button());
            GenericMethod<Button>(new Button());
            GenericMethod("asd", 1223);
        }

        private void GenericMethod<T>(T parameter)
        {

        }
        private void GenericMethod(object paramter)
        {

        }

        private void GenericMethod<T, U>(T param1, U param2)
        {

        }
    }
}
