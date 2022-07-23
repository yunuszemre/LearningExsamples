using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> Students = new Dictionary<int, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Students.Add(1, "Yunus");
            Students.Add(2, "Erdi");
            Students.Add(3, "Taha");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Students[3]}");

            foreach (KeyValuePair<int, string> item in Students)
            {
                listBox1.Items.Add(item.Key+" - " + item.Value);
            }
        }
    }
}
