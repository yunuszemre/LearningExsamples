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

namespace Collection_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sehirler.Add("Ankara");
            sehirler.Add("Sivas");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add(123.2m);
        }
        ArrayList sehirler = new ArrayList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtEklenecekItem.Text);
            ListRefresh();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    //ArrayList sehirler = new ArrayList();
        //    //sehirler.Add("Ankara");
        //    //sehirler.Add("Sivas");
        //    //sehirler.Add("İstanbul");
        //    //sehirler.Add("İzmir");
        //    //sehirler.Add(123.2m);

        //}
        private void ListRefresh()
        {
            lstNumber.Items.Clear();
            foreach (var item in sehirler)
            {
                lstNumber.Items.Add(item);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNumber.SelectedIndex<0)
            {
                return;
            }
            var dialogResult = MessageBox.Show("Seçilen öğeyi silmek istiyor musunuz?","ArraList", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                //delete item
                object selectedItem = lstNumber.SelectedItem;
                sehirler.Remove(selectedItem);

                ListRefresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sehirler.Clear();
            ListRefresh();

            RefreshProgressBar();
        }

        void RefreshProgressBar()
        {
            do
            {
                progressBar1.Maximum = sehirler.Count;
                progressBar1.Value = sehirler.Count - 1;
            } while (true);
            
        }

        
    }
}
