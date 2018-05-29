namespace Poem_Generator
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BtnCatPoem = new System.Windows.Forms.Button();
            this.BtnCupcakePoem = new System.Windows.Forms.Button();
            this.BtnCoffeePoem = new System.Windows.Forms.Button();
            this.BtnCustom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 168);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(396, 72);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(526, 395);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // BtnCatPoem
            // 
            this.BtnCatPoem.Location = new System.Drawing.Point(31, 263);
            this.BtnCatPoem.Name = "BtnCatPoem";
            this.BtnCatPoem.Size = new System.Drawing.Size(322, 42);
            this.BtnCatPoem.TabIndex = 2;
            this.BtnCatPoem.Text = "Cat Haiku";
            this.BtnCatPoem.UseVisualStyleBackColor = true;
            this.BtnCatPoem.Click += new System.EventHandler(this.BtnCatPoem_Click);
            // 
            // BtnCupcakePoem
            // 
            this.BtnCupcakePoem.Location = new System.Drawing.Point(31, 318);
            this.BtnCupcakePoem.Name = "BtnCupcakePoem";
            this.BtnCupcakePoem.Size = new System.Drawing.Size(322, 42);
            this.BtnCupcakePoem.TabIndex = 3;
            this.BtnCupcakePoem.Text = "Cupcake Haiku";
            this.BtnCupcakePoem.UseVisualStyleBackColor = true;
            this.BtnCupcakePoem.Click += new System.EventHandler(this.BtnCupcakePoem_Click);
            // 
            // BtnCoffeePoem
            // 
            this.BtnCoffeePoem.Location = new System.Drawing.Point(31, 372);
            this.BtnCoffeePoem.Name = "BtnCoffeePoem";
            this.BtnCoffeePoem.Size = new System.Drawing.Size(322, 42);
            this.BtnCoffeePoem.TabIndex = 4;
            this.BtnCoffeePoem.Text = "Coffee Haiku";
            this.BtnCoffeePoem.UseVisualStyleBackColor = true;
            this.BtnCoffeePoem.Click += new System.EventHandler(this.BtnCoffeePoem_Click);
            // 
            // BtnCustom
            // 
            this.BtnCustom.Location = new System.Drawing.Point(31, 425);
            this.BtnCustom.Name = "BtnCustom";
            this.BtnCustom.Size = new System.Drawing.Size(322, 42);
            this.BtnCustom.TabIndex = 5;
            this.BtnCustom.Text = "Your Own Haiku";
            this.BtnCustom.UseVisualStyleBackColor = true;
            this.BtnCustom.Click += new System.EventHandler(this.BtnCustom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter random words to create your own haiku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCustom);
            this.Controls.Add(this.BtnCoffeePoem);
            this.Controls.Add(this.BtnCupcakePoem);
            this.Controls.Add(this.BtnCatPoem);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button BtnCatPoem;
        private System.Windows.Forms.Button BtnCupcakePoem;
        private System.Windows.Forms.Button BtnCoffeePoem;
        private System.Windows.Forms.Button BtnCustom;
        private System.Windows.Forms.Label label1;
    }
}

