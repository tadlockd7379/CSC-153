
namespace WindowsFormsApp1
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
            this.sqrFt = new System.Windows.Forms.TextBox();
            this.sqrFtLabel = new System.Windows.Forms.Label();
            this.ppgLabel = new System.Windows.Forms.Label();
            this.ppg = new System.Windows.Forms.TextBox();
            this.gallonsOfPaint = new System.Windows.Forms.Label();
            this.hoursOfLabor = new System.Windows.Forms.Label();
            this.costOfPaint = new System.Windows.Forms.Label();
            this.costOfLabor = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqrFt
            // 
            this.sqrFt.Location = new System.Drawing.Point(435, 213);
            this.sqrFt.Name = "sqrFt";
            this.sqrFt.Size = new System.Drawing.Size(100, 20);
            this.sqrFt.TabIndex = 0;
            this.sqrFt.TextChanged += new System.EventHandler(this.sqrFt_TextChanged);
            // 
            // sqrFtLabel
            // 
            this.sqrFtLabel.AutoSize = true;
            this.sqrFtLabel.Location = new System.Drawing.Point(435, 194);
            this.sqrFtLabel.Name = "sqrFtLabel";
            this.sqrFtLabel.Size = new System.Drawing.Size(99, 13);
            this.sqrFtLabel.TabIndex = 1;
            this.sqrFtLabel.Text = "Sqr. Ft. Wall Space";
            // 
            // ppgLabel
            // 
            this.ppgLabel.AutoSize = true;
            this.ppgLabel.Location = new System.Drawing.Point(599, 194);
            this.ppgLabel.Name = "ppgLabel";
            this.ppgLabel.Size = new System.Drawing.Size(83, 13);
            this.ppgLabel.TabIndex = 2;
            this.ppgLabel.Text = "Price Per Gallon";
            // 
            // ppg
            // 
            this.ppg.Location = new System.Drawing.Point(602, 212);
            this.ppg.Name = "ppg";
            this.ppg.Size = new System.Drawing.Size(100, 20);
            this.ppg.TabIndex = 3;
            this.ppg.TextChanged += new System.EventHandler(this.ppg_TextChanged);
            // 
            // gallonsOfPaint
            // 
            this.gallonsOfPaint.AutoSize = true;
            this.gallonsOfPaint.Location = new System.Drawing.Point(435, 264);
            this.gallonsOfPaint.Name = "gallonsOfPaint";
            this.gallonsOfPaint.Size = new System.Drawing.Size(92, 13);
            this.gallonsOfPaint.TabIndex = 4;
            this.gallonsOfPaint.Text = "Gallons of paint: 0";
            // 
            // hoursOfLabor
            // 
            this.hoursOfLabor.AutoSize = true;
            this.hoursOfLabor.Location = new System.Drawing.Point(435, 281);
            this.hoursOfLabor.Name = "hoursOfLabor";
            this.hoursOfLabor.Size = new System.Drawing.Size(85, 13);
            this.hoursOfLabor.TabIndex = 5;
            this.hoursOfLabor.Text = "Hours of labor: 0";
            // 
            // costOfPaint
            // 
            this.costOfPaint.AutoSize = true;
            this.costOfPaint.Location = new System.Drawing.Point(435, 298);
            this.costOfPaint.Name = "costOfPaint";
            this.costOfPaint.Size = new System.Drawing.Size(84, 13);
            this.costOfPaint.TabIndex = 6;
            this.costOfPaint.Text = "Cost of paint: $0";
            // 
            // costOfLabor
            // 
            this.costOfLabor.AutoSize = true;
            this.costOfLabor.Location = new System.Drawing.Point(435, 315);
            this.costOfLabor.Name = "costOfLabor";
            this.costOfLabor.Size = new System.Drawing.Size(84, 13);
            this.costOfLabor.TabIndex = 7;
            this.costOfLabor.Text = "Cost of labor: $0";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(435, 356);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(73, 13);
            this.totalCost.TabIndex = 8;
            this.totalCost.Text = "Total Cost: $0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.costOfLabor);
            this.Controls.Add(this.costOfPaint);
            this.Controls.Add(this.hoursOfLabor);
            this.Controls.Add(this.gallonsOfPaint);
            this.Controls.Add(this.ppg);
            this.Controls.Add(this.ppgLabel);
            this.Controls.Add(this.sqrFtLabel);
            this.Controls.Add(this.sqrFt);
            this.Name = "Form1";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqrFt;
        private System.Windows.Forms.Label sqrFtLabel;
        private System.Windows.Forms.Label ppgLabel;
        private System.Windows.Forms.TextBox ppg;
        private System.Windows.Forms.Label gallonsOfPaint;
        private System.Windows.Forms.Label hoursOfLabor;
        private System.Windows.Forms.Label costOfPaint;
        private System.Windows.Forms.Label costOfLabor;
        private System.Windows.Forms.Label totalCost;
    }
}

