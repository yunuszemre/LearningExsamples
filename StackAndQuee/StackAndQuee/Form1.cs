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

namespace StackAndQuee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Stack stackCollection = new Stack();
            stackCollection.Push(1);
            stackCollection.Push(2);
            stackCollection.Push(3);
            stackCollection.Push(4);
            

            MessageBox.Show(stackCollection.Pop().ToString());
            foreach (var item in stackCollection)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnQuee_Click(object sender, EventArgs e)
        {
            Queue queueCollection = new Queue();
            queueCollection.Enqueue(1);
            queueCollection.Enqueue(2);
            queueCollection.Enqueue(3);
            queueCollection.Enqueue(4);

            MessageBox.Show(queueCollection.Dequeue().ToString());
            foreach (var item in queueCollection)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
