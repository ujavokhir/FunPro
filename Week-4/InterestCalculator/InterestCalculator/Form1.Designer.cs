
namespace InterestCalculator
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
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.nudYears = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(50, 24);
            this.nudAmount.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(159, 20);
            this.nudAmount.TabIndex = 0;
            // 
            // nudRate
            // 
            this.nudRate.Location = new System.Drawing.Point(50, 59);
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(159, 20);
            this.nudRate.TabIndex = 1;
            // 
            // nudYears
            // 
            this.nudYears.Location = new System.Drawing.Point(50, 94);
            this.nudYears.Name = "nudYears";
            this.nudYears.Size = new System.Drawing.Size(159, 20);
            this.nudYears.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(106, 139);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 31);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 203);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudYears);
            this.Controls.Add(this.nudRate);
            this.Controls.Add(this.nudAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.NumericUpDown nudYears;
        private System.Windows.Forms.Button btnCalculate;
    }
}

