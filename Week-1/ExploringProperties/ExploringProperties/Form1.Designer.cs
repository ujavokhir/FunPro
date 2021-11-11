
namespace ExploringProperties
{
    partial class ExploringProperties
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
            this.lbl_hello = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(40, 24);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(84, 13);
            this.lbl_hello.TabIndex = 0;
            this.lbl_hello.Text = "Enter your name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(40, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(101, 20);
            this.txt_name.TabIndex = 1;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(40, 100);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(101, 27);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Click Me";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // ExploringProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 171);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_hello);
            this.Name = "ExploringProperties";
            this.Text = "ExploringProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_show;
    }
}

