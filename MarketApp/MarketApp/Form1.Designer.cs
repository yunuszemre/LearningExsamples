namespace MarketApp
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
            this.productList = new System.Windows.Forms.ListBox();
            this.bucketList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCreditCardNumber = new System.Windows.Forms.RichTextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.ItemHeight = 20;
            this.productList.Location = new System.Drawing.Point(22, 40);
            this.productList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(323, 364);
            this.productList.TabIndex = 0;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // bucketList
            // 
            this.bucketList.FormattingEnabled = true;
            this.bucketList.ItemHeight = 20;
            this.bucketList.Location = new System.Drawing.Point(355, 40);
            this.bucketList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bucketList.Name = "bucketList";
            this.bucketList.Size = new System.Drawing.Size(293, 364);
            this.bucketList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sepet Toplamı: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürünler";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sepetiniz";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(847, 130);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(179, 36);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "Alışverişi Tamamla";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(662, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(662, 58);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(354, 33);
            this.txtCreditCardNumber.TabIndex = 7;
            this.txtCreditCardNumber.Text = "Enter Your Credit/Bank Card Number";
            this.txtCreditCardNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCreditCardNumber_MouseClick);
            this.txtCreditCardNumber.TextChanged += new System.EventHandler(this.txtCreditCardNumber_TextChanged);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(662, 98);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(60, 26);
            this.txtMonth.TabIndex = 8;
            this.txtMonth.Text = "Month";
            this.txtMonth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMonth_MouseClick);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(728, 98);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(60, 26);
            this.txtYear.TabIndex = 9;
            this.txtYear.Text = "Year";
            this.txtYear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtYear_MouseClick);
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(960, 98);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(56, 26);
            this.txtCvv.TabIndex = 10;
            this.txtCvv.Text = "CVV";
            this.txtCvv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCvv_MouseClick);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(514, 412);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(134, 36);
            this.removeBtn.TabIndex = 12;
            this.removeBtn.Text = "Çıkart";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sepeti Boşalt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1028, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bucketList);
            this.Controls.Add(this.productList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.ListBox bucketList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox txtCreditCardNumber;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button button1;
    }
}

