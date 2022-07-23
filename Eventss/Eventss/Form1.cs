using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            citiesLbox.Items.Add("Sivas");
            citiesLbox.Items.Add("Ankara");
            citiesLbox.Items.Add("İstanbul");
            citiesLbox.Items.Add("İzmir");
            citiesLbox.Items.Add("Aydın");
            citiesLbox.Items.Add("Mersin");
            citiesLbox.Items.Add("Adana");
            citiesLbox.Items.Add("Tokat");
            citiesLbox.Items.Add("Yozgat");
        }

        private void citiesLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectedCitiesLb.Items.Add(citiesLbox.Items[citiesLbox.SelectedIndex]);
            citiesLbox.Items.Remove(citiesLbox.Items[citiesLbox.SelectedIndex]);
            label1.Text = $" {citiesLbox.Items.Count}\n {SelectedCitiesLb.Items.Count}";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            citiesLbox.Items.Add(SelectedCitiesLb.Items[SelectedCitiesLb.SelectedIndex]);
            SelectedCitiesLb.Items.Remove(SelectedCitiesLb.Items[SelectedCitiesLb.SelectedIndex]);
            label1.Text = $" {citiesLbox.Items.Count}\n {SelectedCitiesLb.Items.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < citiesLbox.Items.Count; i++)
            {
                SelectedCitiesLb.Items.Add(citiesLbox.Items[i]);
                
            }
            citiesLbox.Items.Clear();
            
        }
    }
}
