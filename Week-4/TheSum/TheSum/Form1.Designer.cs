
namespace TheSum
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
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdd
            // 
            this.btnOdd.Location = new System.Drawing.Point(44, 12);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(75, 27);
            this.btnOdd.TabIndex = 0;
            this.btnOdd.Text = "Odd";
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(44, 54);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(75, 29);
            this.btnEven.TabIndex = 1;
            this.btnEven.Text = "Even";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 111);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnOdd);
            this.Name = "Form1";
            this.Text = "The Sum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnEven;
    }
}

