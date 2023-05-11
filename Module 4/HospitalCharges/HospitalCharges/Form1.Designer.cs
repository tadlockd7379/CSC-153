
namespace HospitalCharges
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
            this.hospitalDaysLabel = new System.Windows.Forms.Label();
            this.daysInput = new System.Windows.Forms.TextBox();
            this.medicationChargesInput = new System.Windows.Forms.TextBox();
            this.medicationChargesLabel = new System.Windows.Forms.Label();
            this.surgicalChargesInput = new System.Windows.Forms.TextBox();
            this.surgicalChargesLabel = new System.Windows.Forms.Label();
            this.labChargesInput = new System.Windows.Forms.TextBox();
            this.labChargesLabel = new System.Windows.Forms.Label();
            this.rehabChargesInput = new System.Windows.Forms.TextBox();
            this.rehabChargesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hospitalDaysLabel
            // 
            this.hospitalDaysLabel.AutoSize = true;
            this.hospitalDaysLabel.Location = new System.Drawing.Point(310, 58);
            this.hospitalDaysLabel.Name = "hospitalDaysLabel";
            this.hospitalDaysLabel.Size = new System.Drawing.Size(149, 13);
            this.hospitalDaysLabel.TabIndex = 0;
            this.hospitalDaysLabel.Text = "Number of days in the hospital";
            // 
            // daysInput
            // 
            this.daysInput.Location = new System.Drawing.Point(324, 74);
            this.daysInput.Name = "daysInput";
            this.daysInput.Size = new System.Drawing.Size(100, 20);
            this.daysInput.TabIndex = 1;
            this.daysInput.Text = "0";
            // 
            // medicationChargesInput
            // 
            this.medicationChargesInput.Location = new System.Drawing.Point(247, 154);
            this.medicationChargesInput.Name = "medicationChargesInput";
            this.medicationChargesInput.Size = new System.Drawing.Size(100, 20);
            this.medicationChargesInput.TabIndex = 3;
            this.medicationChargesInput.Text = "0";
            // 
            // medicationChargesLabel
            // 
            this.medicationChargesLabel.AutoSize = true;
            this.medicationChargesLabel.Location = new System.Drawing.Point(244, 137);
            this.medicationChargesLabel.Name = "medicationChargesLabel";
            this.medicationChargesLabel.Size = new System.Drawing.Size(135, 13);
            this.medicationChargesLabel.TabIndex = 2;
            this.medicationChargesLabel.Text = "Cost of medication charges";
            // 
            // surgicalChargesInput
            // 
            this.surgicalChargesInput.Location = new System.Drawing.Point(247, 114);
            this.surgicalChargesInput.Name = "surgicalChargesInput";
            this.surgicalChargesInput.Size = new System.Drawing.Size(100, 20);
            this.surgicalChargesInput.TabIndex = 5;
            this.surgicalChargesInput.Text = "0";
            // 
            // surgicalChargesLabel
            // 
            this.surgicalChargesLabel.AutoSize = true;
            this.surgicalChargesLabel.Location = new System.Drawing.Point(244, 97);
            this.surgicalChargesLabel.Name = "surgicalChargesLabel";
            this.surgicalChargesLabel.Size = new System.Drawing.Size(120, 13);
            this.surgicalChargesLabel.TabIndex = 4;
            this.surgicalChargesLabel.Text = "Cost of surgical charges";
            // 
            // labChargesInput
            // 
            this.labChargesInput.Location = new System.Drawing.Point(402, 114);
            this.labChargesInput.Name = "labChargesInput";
            this.labChargesInput.Size = new System.Drawing.Size(100, 20);
            this.labChargesInput.TabIndex = 7;
            this.labChargesInput.Text = "0";
            // 
            // labChargesLabel
            // 
            this.labChargesLabel.AutoSize = true;
            this.labChargesLabel.Location = new System.Drawing.Point(399, 97);
            this.labChargesLabel.Name = "labChargesLabel";
            this.labChargesLabel.Size = new System.Drawing.Size(98, 13);
            this.labChargesLabel.TabIndex = 6;
            this.labChargesLabel.Text = "Cost of lab charges";
            // 
            // rehabChargesInput
            // 
            this.rehabChargesInput.Location = new System.Drawing.Point(402, 154);
            this.rehabChargesInput.Name = "rehabChargesInput";
            this.rehabChargesInput.Size = new System.Drawing.Size(100, 20);
            this.rehabChargesInput.TabIndex = 9;
            this.rehabChargesInput.Text = "0";
            // 
            // rehabChargesLabel
            // 
            this.rehabChargesLabel.AutoSize = true;
            this.rehabChargesLabel.Location = new System.Drawing.Point(399, 137);
            this.rehabChargesLabel.Name = "rehabChargesLabel";
            this.rehabChargesLabel.Size = new System.Drawing.Size(111, 13);
            this.rehabChargesLabel.TabIndex = 8;
            this.rehabChargesLabel.Text = "Cost of rehab charges";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(324, 193);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rehabChargesInput);
            this.Controls.Add(this.rehabChargesLabel);
            this.Controls.Add(this.labChargesInput);
            this.Controls.Add(this.labChargesLabel);
            this.Controls.Add(this.surgicalChargesInput);
            this.Controls.Add(this.surgicalChargesLabel);
            this.Controls.Add(this.medicationChargesInput);
            this.Controls.Add(this.medicationChargesLabel);
            this.Controls.Add(this.daysInput);
            this.Controls.Add(this.hospitalDaysLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hospitalDaysLabel;
        private System.Windows.Forms.TextBox daysInput;
        private System.Windows.Forms.TextBox medicationChargesInput;
        private System.Windows.Forms.Label medicationChargesLabel;
        private System.Windows.Forms.TextBox surgicalChargesInput;
        private System.Windows.Forms.Label surgicalChargesLabel;
        private System.Windows.Forms.TextBox labChargesInput;
        private System.Windows.Forms.Label labChargesLabel;
        private System.Windows.Forms.TextBox rehabChargesInput;
        private System.Windows.Forms.Label rehabChargesLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

