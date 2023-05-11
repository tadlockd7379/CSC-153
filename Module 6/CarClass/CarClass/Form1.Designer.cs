
namespace CarClass
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
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.makeInput = new System.Windows.Forms.TextBox();
            this.modelInput = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brakeButton = new System.Windows.Forms.Button();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.mphLabel = new System.Windows.Forms.Label();
            this.createCarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(351, 69);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(354, 85);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(35, 20);
            this.yearInput.TabIndex = 1;
            this.yearInput.Text = "2023";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(430, 69);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(34, 13);
            this.makeLabel.TabIndex = 2;
            this.makeLabel.Text = "Make";
            // 
            // makeInput
            // 
            this.makeInput.Location = new System.Drawing.Point(433, 84);
            this.makeInput.Name = "makeInput";
            this.makeInput.Size = new System.Drawing.Size(100, 20);
            this.makeInput.TabIndex = 3;
            this.makeInput.Text = "Nissan";
            // 
            // modelInput
            // 
            this.modelInput.Location = new System.Drawing.Point(591, 84);
            this.modelInput.Name = "modelInput";
            this.modelInput.Size = new System.Drawing.Size(100, 20);
            this.modelInput.TabIndex = 4;
            this.modelInput.Text = "Altima";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(591, 65);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model";
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(354, 136);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(75, 23);
            this.brakeButton.TabIndex = 6;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Visible = false;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(471, 135);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(75, 23);
            this.accelerateButton.TabIndex = 7;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Visible = false;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // mphLabel
            // 
            this.mphLabel.AutoSize = true;
            this.mphLabel.Location = new System.Drawing.Point(354, 190);
            this.mphLabel.Name = "mphLabel";
            this.mphLabel.Size = new System.Drawing.Size(36, 13);
            this.mphLabel.TabIndex = 8;
            this.mphLabel.Text = "0 mph";
            // 
            // createCarButton
            // 
            this.createCarButton.Location = new System.Drawing.Point(719, 81);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(75, 23);
            this.createCarButton.TabIndex = 9;
            this.createCarButton.Text = "Create Car";
            this.createCarButton.UseVisualStyleBackColor = true;
            this.createCarButton.Click += new System.EventHandler(this.createCarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createCarButton);
            this.Controls.Add(this.mphLabel);
            this.Controls.Add(this.accelerateButton);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelInput);
            this.Controls.Add(this.makeInput);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.yearLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.TextBox makeInput;
        private System.Windows.Forms.TextBox modelInput;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Label mphLabel;
        private System.Windows.Forms.Button createCarButton;
    }
}

