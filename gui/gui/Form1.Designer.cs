namespace gui
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.TextBox();
            this.inv1 = new System.Windows.Forms.TextBox();
            this.obj1 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "numbers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "object name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "count";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "price";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(3, 111);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(191, 22);
            this.num1.TabIndex = 6;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(290, 111);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(241, 22);
            this.date1.TabIndex = 7;
            // 
            // inv1
            // 
            this.inv1.Location = new System.Drawing.Point(604, 111);
            this.inv1.Name = "inv1";
            this.inv1.Size = new System.Drawing.Size(184, 22);
            this.inv1.TabIndex = 8;
            // 
            // obj1
            // 
            this.obj1.Location = new System.Drawing.Point(31, 224);
            this.obj1.Name = "obj1";
            this.obj1.Size = new System.Drawing.Size(403, 22);
            this.obj1.TabIndex = 9;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(557, 361);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 22);
            this.p1.TabIndex = 10;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(31, 343);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(220, 22);
            this.c1.TabIndex = 12;
            this.c1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(232, 457);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(172, 38);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(719, 457);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(182, 38);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 583);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.obj1);
            this.Controls.Add(this.inv1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox date1;
        private System.Windows.Forms.TextBox inv1;
        private System.Windows.Forms.TextBox obj1;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
    }
}

