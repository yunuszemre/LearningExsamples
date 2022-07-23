namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.bntEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnDeduct = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 13);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(322, 75);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(13, 95);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(76, 53);
            this.btnPercent.TabIndex = 1;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnCe
            // 
            this.btnCe.Location = new System.Drawing.Point(95, 94);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(76, 53);
            this.btnCe.TabIndex = 2;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(177, 95);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(76, 53);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 53);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "<=";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(259, 154);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(76, 53);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(177, 154);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(76, 53);
            this.btnNine.TabIndex = 7;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // bntEight
            // 
            this.bntEight.Location = new System.Drawing.Point(95, 153);
            this.bntEight.Name = "bntEight";
            this.bntEight.Size = new System.Drawing.Size(76, 53);
            this.bntEight.TabIndex = 6;
            this.bntEight.Text = "8";
            this.bntEight.UseVisualStyleBackColor = true;
            this.bntEight.Click += new System.EventHandler(this.bntEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(13, 154);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(76, 53);
            this.btnSeven.TabIndex = 5;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(259, 213);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(76, 53);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(177, 213);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(76, 53);
            this.btnSix.TabIndex = 11;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(95, 213);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(76, 53);
            this.btnFive.TabIndex = 10;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(13, 213);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(76, 53);
            this.btnFour.TabIndex = 9;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnDeduct
            // 
            this.btnDeduct.Location = new System.Drawing.Point(259, 272);
            this.btnDeduct.Name = "btnDeduct";
            this.btnDeduct.Size = new System.Drawing.Size(76, 53);
            this.btnDeduct.TabIndex = 16;
            this.btnDeduct.Text = "-";
            this.btnDeduct.UseVisualStyleBackColor = true;
            this.btnDeduct.Click += new System.EventHandler(this.btnDeduct_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(177, 272);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(76, 53);
            this.btnThree.TabIndex = 15;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(95, 272);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(76, 53);
            this.btnTwo.TabIndex = 14;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(13, 272);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(76, 53);
            this.btnOne.TabIndex = 13;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(259, 331);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(76, 53);
            this.btnSum.TabIndex = 20;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(177, 331);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(76, 53);
            this.btnDot.TabIndex = 19;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(95, 331);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(76, 53);
            this.btnZero.TabIndex = 18;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(13, 331);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(76, 53);
            this.btnRes.TabIndex = 17;
            this.btnRes.Text = "=";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnDeduct);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.bntEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button bntEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnDeduct;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label label1;
    }
}

