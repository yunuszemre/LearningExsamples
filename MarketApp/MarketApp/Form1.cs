using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp
{
    public partial class Form1 : Form
    {
        private string[] products =
        {
            "Bilgisayar", "Ekran Kartı", "İşlemci", "Ram", "SSD", "Monitör", "Klavye", "Mouse", "Anakart", "Güç Kaynağı"
        };

        private decimal[] prices = { 25000, 15000, 5000, 2200, 1100, 3000, 750, 225.9m, 855.85m, 1000 };
        
        public int[] priceIndexes = new int[0];
        public Form1()
        {
            InitializeComponent();
            ListProducts(products);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtCreditCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreditCardNumber_MouseClick(object sender, MouseEventArgs e)
        {
            txtCreditCardNumber.Clear();
        }

        private void txtMonth_MouseClick(object sender, MouseEventArgs e)
        {
            txtMonth.Clear();
        }

        private void txtYear_MouseClick(object sender, MouseEventArgs e)
        {
            txtYear.Clear();
        }

        private void txtCvv_MouseClick(object sender, MouseEventArgs e)
        {
            txtCvv.Clear();
        }

        private void ListProducts(string[] product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                productList.Items.Add(products[i] + ": " + prices[i]);
            }


        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bucketList.Items.Add(productList.Items[productList.SelectedIndex]);

            Array.Resize(ref priceIndexes, priceIndexes.Length + 1);
            priceIndexes[priceIndexes.Length - 1] = productList.SelectedIndex;

            label1.Text = $"Sepet Toplamı: {BucketSum(priceIndexes)}Tl";

        }

        private decimal BucketSum(int[] arr)
        {
            decimal totalPrice = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                totalPrice += prices[arr[i]];
            }
            
            return totalPrice;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            label1.Text = $"Sepet Toplamı: {BucketSum(priceIndexes)}Tl";
        }
    }
}
