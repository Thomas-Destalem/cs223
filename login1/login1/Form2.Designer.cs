namespace login1
{
    partial class Form2
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
            this.lblhello = new System.Windows.Forms.Label();
            this.btnset = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Location = new System.Drawing.Point(372, 99);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(36, 16);
            this.lblhello.TabIndex = 0;
            this.lblhello.Text = "hello";
            // 
            // btnset
            // 
            this.btnset.Location = new System.Drawing.Point(100, 243);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(75, 23);
            this.btnset.TabIndex = 5;
            this.btnset.Text = "set";
            this.btnset.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(341, 243);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(657, 243);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.lblhello);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnlogout;
    }
}