using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public double input;
        public double res;
        public double temp;
        public string opt = "";
        bool isNumeric = false;
        private bool firstInput = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private double Calculate(string op)
        {
            switch (op)
            {
                case "+":
                    Sum();
                    break;
                case "-":
                    Deduct();
                    break;
                case "x":
                    Multiply();
                    break;
                case "/":
                    Divide();
                    break;
                case "%":
                    Percent();
                    break;

            }
            label1.Text = temp.ToString();
            return temp;
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            label1.Text = Calculate("%").ToString();
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            label1.Text = Calculate("+").ToString();
        }
        private void btnRes_Click(object sender, EventArgs e)
        {
            txtInput.Text = res.ToString();
        }

        private void btnDeduct_Click(object sender, EventArgs e)
        {
            label1.Text = Calculate("-").ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            label1.Text = Calculate("x").ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            label1.Text = Calculate("/").ToString();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtInput.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtInput.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtInput.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtInput.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtInput.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtInput.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtInput.Text += "7";
        }

        private void bntEight_Click(object sender, EventArgs e)
        {
            txtInput.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtInput.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtInput.Text += "0";
        }

        private void Sum()
        {
            if (txtInput.Text != "" && firstInput)
            {
                isNumeric = double.TryParse(txtInput.Text, out temp);
                txtInput.Text = "";
                firstInput = false;
            }
            else if (txtInput.Text != "" && !firstInput)
            {
                input = Convert.ToDouble(txtInput.Text);
                temp += input;
                txtInput.Text = "";
                label1.Text = temp.ToString();
            }
        }

        private void Deduct()
        {
            if (txtInput.Text != "" && firstInput)
            {
                isNumeric = double.TryParse(txtInput.Text, out temp);
                txtInput.Text = "";
                firstInput = false;
            }
            else if (txtInput.Text != "" && !firstInput)
            {
                input = Convert.ToDouble(txtInput.Text);
                temp -= input;
                txtInput.Text = "";
                label1.Text = temp.ToString();
            }
        }

        private void Multiply()
        {
            if (txtInput.Text != "" && firstInput)
            {
                isNumeric = double.TryParse(txtInput.Text, out temp);
                txtInput.Text = "";
                firstInput = false;
            }
            else if (txtInput.Text != "" && !firstInput)
            {
                input = Convert.ToDouble(txtInput.Text);
                temp *= input;
                txtInput.Text = "";
                label1.Text = temp.ToString();
            }
        }

        private void Divide()
        {
            if (txtInput.Text != "" && firstInput)
            {
                isNumeric = double.TryParse(txtInput.Text, out temp);
                txtInput.Text = "";
                firstInput = false;
            }
            else if (txtInput.Text != "" && !firstInput)
            {
                input = Convert.ToDouble(txtInput.Text);
                temp /= input;
                txtInput.Text = "";
                label1.Text = $"{temp.ToString()}";
            }
        }

        private void Percent()
        {
            if (txtInput.Text != "" && firstInput)
            {
                isNumeric = double.TryParse(txtInput.Text, out temp);
                txtInput.Text = "";
                firstInput = false;
            }
            else if (txtInput.Text != "" && !firstInput)
            {
                input = Convert.ToDouble(txtInput.Text);
                temp %= input;
                txtInput.Text = "";
                label1.Text = temp.ToString();
            }
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            input = 0;
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            temp = 0;
            input = 0;
            txtInput.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput.Text.Remove(txtInput.Text.Length - 1);
        }
        /*
* CE -->Input u sııfırlar
* C --> tamamını sil
*/
    }

}
