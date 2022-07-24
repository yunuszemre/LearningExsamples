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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

    public class ServiceResult
    {
        public bool Succes { get; set; }
        public object Data { get; set; }
    }

    public class GenericServiceResult<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }

    
}
