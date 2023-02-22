
namespace ChangeGame
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
            this.penniesBox = new System.Windows.Forms.GroupBox();
            this.pennies = new System.Windows.Forms.TextBox();
            this.dimesBox = new System.Windows.Forms.GroupBox();
            this.dimes = new System.Windows.Forms.TextBox();
            this.nicklesBox = new System.Windows.Forms.GroupBox();
            this.nickles = new System.Windows.Forms.TextBox();
            this.quartersBox = new System.Windows.Forms.GroupBox();
            this.quarters = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.penniesBox.SuspendLayout();
            this.dimesBox.SuspendLayout();
            this.nicklesBox.SuspendLayout();
            this.quartersBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // penniesBox
            // 
            this.penniesBox.Controls.Add(this.pennies);
            this.penniesBox.Location = new System.Drawing.Point(230, 171);
            this.penniesBox.Name = "penniesBox";
            this.penniesBox.Size = new System.Drawing.Size(64, 57);
            this.penniesBox.TabIndex = 1;
            this.penniesBox.TabStop = false;
            this.penniesBox.Text = "Pennies";
            // 
            // pennies
            // 
            this.pennies.Location = new System.Drawing.Point(7, 20);
            this.pennies.Name = "pennies";
            this.pennies.Size = new System.Drawing.Size(41, 20);
            this.pennies.TabIndex = 0;
            this.pennies.Text = "0";
            // 
            // dimesBox
            // 
            this.dimesBox.Controls.Add(this.dimes);
            this.dimesBox.Location = new System.Drawing.Point(370, 171);
            this.dimesBox.Name = "dimesBox";
            this.dimesBox.Size = new System.Drawing.Size(64, 57);
            this.dimesBox.TabIndex = 2;
            this.dimesBox.TabStop = false;
            this.dimesBox.Text = "Dimes";
            // 
            // dimes
            // 
            this.dimes.Location = new System.Drawing.Point(7, 20);
            this.dimes.Name = "dimes";
            this.dimes.Size = new System.Drawing.Size(41, 20);
            this.dimes.TabIndex = 0;
            this.dimes.Text = "0";
            // 
            // nicklesBox
            // 
            this.nicklesBox.Controls.Add(this.nickles);
            this.nicklesBox.Location = new System.Drawing.Point(300, 171);
            this.nicklesBox.Name = "nicklesBox";
            this.nicklesBox.Size = new System.Drawing.Size(64, 57);
            this.nicklesBox.TabIndex = 2;
            this.nicklesBox.TabStop = false;
            this.nicklesBox.Text = "Nickles";
            // 
            // nickles
            // 
            this.nickles.Location = new System.Drawing.Point(7, 20);
            this.nickles.Name = "nickles";
            this.nickles.Size = new System.Drawing.Size(41, 20);
            this.nickles.TabIndex = 0;
            this.nickles.Text = "0";
            // 
            // quartersBox
            // 
            this.quartersBox.Controls.Add(this.quarters);
            this.quartersBox.Location = new System.Drawing.Point(440, 171);
            this.quartersBox.Name = "quartersBox";
            this.quartersBox.Size = new System.Drawing.Size(64, 57);
            this.quartersBox.TabIndex = 2;
            this.quartersBox.TabStop = false;
            this.quartersBox.Text = "Quarters";
            // 
            // quarters
            // 
            this.quarters.Location = new System.Drawing.Point(7, 20);
            this.quarters.Name = "quarters";
            this.quarters.Size = new System.Drawing.Size(41, 20);
            this.quarters.TabIndex = 0;
            this.quarters.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(230, 234);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.nicklesBox);
            this.Controls.Add(this.quartersBox);
            this.Controls.Add(this.dimesBox);
            this.Controls.Add(this.penniesBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.penniesBox.ResumeLayout(false);
            this.penniesBox.PerformLayout();
            this.dimesBox.ResumeLayout(false);
            this.dimesBox.PerformLayout();
            this.nicklesBox.ResumeLayout(false);
            this.nicklesBox.PerformLayout();
            this.quartersBox.ResumeLayout(false);
            this.quartersBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox penniesBox;
        internal System.Windows.Forms.TextBox pennies;
        internal System.Windows.Forms.GroupBox dimesBox;
        internal System.Windows.Forms.TextBox dimes;
        internal System.Windows.Forms.GroupBox nicklesBox;
        internal System.Windows.Forms.TextBox nickles;
        internal System.Windows.Forms.GroupBox quartersBox;
        internal System.Windows.Forms.TextBox quarters;
        private System.Windows.Forms.Button calculateButton;
    }
}

