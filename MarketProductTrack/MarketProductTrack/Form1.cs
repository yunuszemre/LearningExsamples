﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProductTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ArrayList products = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListProducts()
        {
            foreach (Pr product in products)
            {
                
            }
        }
    }
}
