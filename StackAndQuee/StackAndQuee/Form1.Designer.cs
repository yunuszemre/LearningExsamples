namespace StackAndQuee
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
            this.btnStack = new System.Windows.Forms.Button();
            this.btnQuee = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(12, 13);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(111, 52);
            this.btnStack.TabIndex = 0;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnQuee
            // 
            this.btnQuee.Location = new System.Drawing.Point(12, 71);
            this.btnQuee.Name = "btnQuee";
            this.btnQuee.Size = new System.Drawing.Size(111, 53);
            this.btnQuee.TabIndex = 1;
            this.btnQuee.Text = "Quee";
            this.btnQuee.UseVisualStyleBackColor = true;
            this.btnQuee.Click += new System.EventHandler(this.btnQuee_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(129, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 355);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 372);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnQuee);
            this.Controls.Add(this.btnStack);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnQuee;
        private System.Windows.Forms.ListBox listBox1;
    }
}

