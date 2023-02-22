
namespace ColorMixer
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
            this.firstColorBox = new System.Windows.Forms.GroupBox();
            this.yellow1 = new System.Windows.Forms.RadioButton();
            this.green1 = new System.Windows.Forms.RadioButton();
            this.red1 = new System.Windows.Forms.RadioButton();
            this.secondColorBox = new System.Windows.Forms.GroupBox();
            this.yellow2 = new System.Windows.Forms.RadioButton();
            this.green2 = new System.Windows.Forms.RadioButton();
            this.red2 = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.mixButton = new System.Windows.Forms.Button();
            this.firstColorBox.SuspendLayout();
            this.secondColorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstColorBox
            // 
            this.firstColorBox.Controls.Add(this.yellow1);
            this.firstColorBox.Controls.Add(this.green1);
            this.firstColorBox.Controls.Add(this.red1);
            this.firstColorBox.Location = new System.Drawing.Point(198, 100);
            this.firstColorBox.Name = "firstColorBox";
            this.firstColorBox.Size = new System.Drawing.Size(125, 154);
            this.firstColorBox.TabIndex = 0;
            this.firstColorBox.TabStop = false;
            this.firstColorBox.Text = "First Color";
            // 
            // yellow1
            // 
            this.yellow1.AutoSize = true;
            this.yellow1.Location = new System.Drawing.Point(6, 86);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(80, 24);
            this.yellow1.TabIndex = 2;
            this.yellow1.TabStop = true;
            this.yellow1.Text = "Yellow";
            this.yellow1.UseVisualStyleBackColor = true;
            // 
            // green1
            // 
            this.green1.AutoSize = true;
            this.green1.Location = new System.Drawing.Point(6, 56);
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(79, 24);
            this.green1.TabIndex = 1;
            this.green1.TabStop = true;
            this.green1.Text = "Green";
            this.green1.UseVisualStyleBackColor = true;
            // 
            // red1
            // 
            this.red1.AutoSize = true;
            this.red1.Location = new System.Drawing.Point(6, 25);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(64, 24);
            this.red1.TabIndex = 0;
            this.red1.TabStop = true;
            this.red1.Text = "Red";
            this.red1.UseVisualStyleBackColor = true;
            // 
            // secondColorBox
            // 
            this.secondColorBox.Controls.Add(this.yellow2);
            this.secondColorBox.Controls.Add(this.green2);
            this.secondColorBox.Controls.Add(this.red2);
            this.secondColorBox.Location = new System.Drawing.Point(329, 100);
            this.secondColorBox.Name = "secondColorBox";
            this.secondColorBox.Size = new System.Drawing.Size(165, 154);
            this.secondColorBox.TabIndex = 1;
            this.secondColorBox.TabStop = false;
            this.secondColorBox.Text = "Second Color";
            // 
            // yellow2
            // 
            this.yellow2.AutoSize = true;
            this.yellow2.Location = new System.Drawing.Point(6, 86);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(80, 24);
            this.yellow2.TabIndex = 2;
            this.yellow2.TabStop = true;
            this.yellow2.Text = "Yellow";
            this.yellow2.UseVisualStyleBackColor = true;
            // 
            // green2
            // 
            this.green2.AutoSize = true;
            this.green2.Location = new System.Drawing.Point(6, 56);
            this.green2.Name = "green2";
            this.green2.Size = new System.Drawing.Size(79, 24);
            this.green2.TabIndex = 1;
            this.green2.TabStop = true;
            this.green2.Text = "Green";
            this.green2.UseVisualStyleBackColor = true;
            // 
            // red2
            // 
            this.red2.AutoSize = true;
            this.red2.Location = new System.Drawing.Point(6, 25);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(64, 24);
            this.red2.TabIndex = 0;
            this.red2.TabStop = true;
            this.red2.Text = "Red";
            this.red2.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(195, 260);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(329, 260);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(165, 34);
            this.mixButton.TabIndex = 3;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.secondColorBox);
            this.Controls.Add(this.firstColorBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.firstColorBox.ResumeLayout(false);
            this.firstColorBox.PerformLayout();
            this.secondColorBox.ResumeLayout(false);
            this.secondColorBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox firstColorBox;
        private System.Windows.Forms.RadioButton yellow1;
        private System.Windows.Forms.RadioButton green1;
        private System.Windows.Forms.RadioButton red1;
        private System.Windows.Forms.GroupBox secondColorBox;
        private System.Windows.Forms.RadioButton yellow2;
        private System.Windows.Forms.RadioButton green2;
        private System.Windows.Forms.RadioButton red2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mixButton;
    }
}

