
namespace FallingDistance
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
            this.fallenLabel = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fallenLabel
            // 
            this.fallenLabel.AutoSize = true;
            this.fallenLabel.Location = new System.Drawing.Point(277, 126);
            this.fallenLabel.Name = "fallenLabel";
            this.fallenLabel.Size = new System.Drawing.Size(236, 20);
            this.fallenLabel.TabIndex = 0;
            this.fallenLabel.Text = "Amount of time object has fallen";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(281, 150);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 26);
            this.input.TabIndex = 1;
            this.input.Text = "0";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(277, 179);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(157, 20);
            this.results.TabIndex = 3;
            this.results.Text = "It has fallen 0 meters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.results);
            this.Controls.Add(this.input);
            this.Controls.Add(this.fallenLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fallenLabel;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label results;
    }
}

