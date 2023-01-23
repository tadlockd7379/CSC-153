
namespace Tax
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
            this.propertyValue = new System.Windows.Forms.TextBox();
            this.propertyValueLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.salesTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propertyValue
            // 
            this.propertyValue.Location = new System.Drawing.Point(104, 25);
            this.propertyValue.Name = "propertyValue";
            this.propertyValue.Size = new System.Drawing.Size(100, 20);
            this.propertyValue.TabIndex = 0;
            this.propertyValue.TextChanged += new System.EventHandler(this.propertyValue_TextChanged);
            // 
            // propertyValueLabel
            // 
            this.propertyValueLabel.AutoSize = true;
            this.propertyValueLabel.Location = new System.Drawing.Point(114, 9);
            this.propertyValueLabel.Name = "propertyValueLabel";
            this.propertyValueLabel.Size = new System.Drawing.Size(76, 13);
            this.propertyValueLabel.TabIndex = 1;
            this.propertyValueLabel.Text = "Property Value";
            this.propertyValueLabel.Click += new System.EventHandler(this.propertyValueLabel_Click);
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(125, 48);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(54, 13);
            this.salesTaxLabel.TabIndex = 2;
            this.salesTaxLabel.Text = "Sales Tax";
            // 
            // salesTax
            // 
            this.salesTax.AutoSize = true;
            this.salesTax.Location = new System.Drawing.Point(140, 61);
            this.salesTax.Name = "salesTax";
            this.salesTax.Size = new System.Drawing.Size(19, 13);
            this.salesTax.TabIndex = 3;
            this.salesTax.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 89);
            this.Controls.Add(this.salesTax);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.propertyValueLabel);
            this.Controls.Add(this.propertyValue);
            this.Name = "Form1";
            this.Text = "Property Tax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox propertyValue;
        private System.Windows.Forms.Label propertyValueLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label salesTax;
    }
}

