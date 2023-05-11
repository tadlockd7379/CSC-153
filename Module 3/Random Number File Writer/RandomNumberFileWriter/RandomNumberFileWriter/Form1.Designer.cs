
namespace RandomNumberFileWriter
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
            this.randomNumbersLabel = new System.Windows.Forms.Label();
            this.randomNumbersInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomNumbersLabel
            // 
            this.randomNumbersLabel.AutoSize = true;
            this.randomNumbersLabel.Location = new System.Drawing.Point(217, 136);
            this.randomNumbersLabel.Name = "randomNumbersLabel";
            this.randomNumbersLabel.Size = new System.Drawing.Size(216, 20);
            this.randomNumbersLabel.TabIndex = 0;
            this.randomNumbersLabel.Text = "Amount of Random Numbers";
            // 
            // randomNumbersInput
            // 
            this.randomNumbersInput.Location = new System.Drawing.Point(221, 160);
            this.randomNumbersInput.Name = "randomNumbersInput";
            this.randomNumbersInput.Size = new System.Drawing.Size(100, 26);
            this.randomNumbersInput.TabIndex = 1;
            this.randomNumbersInput.Text = "1";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(221, 193);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(212, 57);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.randomNumbersInput);
            this.Controls.Add(this.randomNumbersLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomNumbersLabel;
        private System.Windows.Forms.TextBox randomNumbersInput;
        private System.Windows.Forms.Button saveButton;
    }
}

