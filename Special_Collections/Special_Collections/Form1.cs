using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Special_Collections
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

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("Emre");
            list.Add("Yunus");
            list.Remove("Emre");
            
        }

        private void btnHashTable_Click(object sender, EventArgs e)
        {
            Hashtable hashtableCollection = new Hashtable();
            hashtableCollection.Add(0, "Yunus");
            hashtableCollection.Add(1, "Taha Kayapınar");
            hashtableCollection.Add(3, "Biyaz Dana");

            MessageBox.Show(hashtableCollection[0].ToString());
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            HashSet<string> hash = new HashSet<string>();
            HashSet<string> hash2 = new HashSet<string>();
            //eklenen değer ikinci kez eklenemez
            hash.Add("x");
            hash.Add("y");
            hash.Add("z");
            hash.Add("z");
            //------------------------------------
            hash2.Add("x");
            hash2.Add("y");
            hash2.Add("t");

            //hash.IntersectWith(hash2);

            //foreach (var item in hash)
            //{
            //    listBox1.Items.Add(item);
            //}
            hash2.UnionWith(hash);
            foreach (var item in hash2)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
