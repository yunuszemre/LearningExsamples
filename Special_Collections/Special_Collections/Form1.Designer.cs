namespace Special_Collections
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
            this.btnList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHashTable = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(16, 16);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(149, 52);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(198, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(387, 466);
            this.listBox1.TabIndex = 1;
            // 
            // btnHashTable
            // 
            this.btnHashTable.Location = new System.Drawing.Point(16, 76);
            this.btnHashTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnHashTable.Name = "btnHashTable";
            this.btnHashTable.Size = new System.Drawing.Size(149, 52);
            this.btnHashTable.TabIndex = 2;
            this.btnHashTable.Text = "HashTable";
            this.btnHashTable.UseVisualStyleBackColor = true;
            this.btnHashTable.Click += new System.EventHandler(this.btnHashTable_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Location = new System.Drawing.Point(16, 136);
            this.btnHashSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(149, 52);
            this.btnHashSet.TabIndex = 3;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 466);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.btnHashTable);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnList);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHashTable;
        private System.Windows.Forms.Button btnHashSet;
    }
}

