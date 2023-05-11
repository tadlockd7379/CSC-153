
namespace PenniesForPay
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
            this.daysLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(202, 144);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(45, 20);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Days";
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Location = new System.Drawing.Point(202, 200);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(61, 20);
            this.payLabel.TabIndex = 2;
            this.payLabel.Text = "Pay: ¢0";
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(202, 167);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(100, 26);
            this.daysBox.TabIndex = 3;
            this.daysBox.TextChanged += new System.EventHandler(this.daysBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.daysLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.TextBox daysBox;
    }
}

