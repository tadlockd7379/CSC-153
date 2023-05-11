
namespace RandomNumberFileReader
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
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.totalNumbersLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.ItemHeight = 20;
            this.numbersListBox.Location = new System.Drawing.Point(289, 130);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(120, 84);
            this.numbersListBox.TabIndex = 0;
            // 
            // totalNumbersLabel
            // 
            this.totalNumbersLabel.AutoSize = true;
            this.totalNumbersLabel.Location = new System.Drawing.Point(289, 249);
            this.totalNumbersLabel.Name = "totalNumbersLabel";
            this.totalNumbersLabel.Size = new System.Drawing.Size(86, 20);
            this.totalNumbersLabel.TabIndex = 1;
            this.totalNumbersLabel.Text = "0 Numbers";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(426, 249);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(145, 20);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total of numbers: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalNumbersLabel);
            this.Controls.Add(this.numbersListBox);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.Label totalNumbersLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}

