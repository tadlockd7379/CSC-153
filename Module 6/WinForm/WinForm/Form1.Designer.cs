
namespace WinForm
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
            this.circleLabel = new System.Windows.Forms.Label();
            this.rectangleLabel = new System.Windows.Forms.Label();
            this.cylinderLabel = new System.Windows.Forms.Label();
            this.circleArea = new System.Windows.Forms.Label();
            this.rectangleArea = new System.Windows.Forms.Label();
            this.cylinderArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circleLabel
            // 
            this.circleLabel.AutoSize = true;
            this.circleLabel.Location = new System.Drawing.Point(90, 132);
            this.circleLabel.Name = "circleLabel";
            this.circleLabel.Size = new System.Drawing.Size(123, 20);
            this.circleLabel.TabIndex = 0;
            this.circleLabel.Text = "Circle, Radius: 5";
            this.circleLabel.UseWaitCursor = true;
            // 
            // rectangleLabel
            // 
            this.rectangleLabel.AutoSize = true;
            this.rectangleLabel.Location = new System.Drawing.Point(251, 132);
            this.rectangleLabel.Name = "rectangleLabel";
            this.rectangleLabel.Size = new System.Drawing.Size(232, 20);
            this.rectangleLabel.TabIndex = 1;
            this.rectangleLabel.Text = "Rectangle, Length: 5; Width: 10";
            // 
            // cylinderLabel
            // 
            this.cylinderLabel.AutoSize = true;
            this.cylinderLabel.Location = new System.Drawing.Point(524, 131);
            this.cylinderLabel.Name = "cylinderLabel";
            this.cylinderLabel.Size = new System.Drawing.Size(221, 20);
            this.cylinderLabel.TabIndex = 2;
            this.cylinderLabel.Text = "Cylinder, Radius: 5; Height: 10";
            // 
            // circleArea
            // 
            this.circleArea.AutoSize = true;
            this.circleArea.Location = new System.Drawing.Point(90, 156);
            this.circleArea.Name = "circleArea";
            this.circleArea.Size = new System.Drawing.Size(60, 20);
            this.circleArea.TabIndex = 3;
            this.circleArea.Text = "Area: 0";
            // 
            // rectangleArea
            // 
            this.rectangleArea.AutoSize = true;
            this.rectangleArea.Location = new System.Drawing.Point(251, 156);
            this.rectangleArea.Name = "rectangleArea";
            this.rectangleArea.Size = new System.Drawing.Size(60, 20);
            this.rectangleArea.TabIndex = 4;
            this.rectangleArea.Text = "Area: 0";
            // 
            // cylinderArea
            // 
            this.cylinderArea.AutoSize = true;
            this.cylinderArea.Location = new System.Drawing.Point(524, 156);
            this.cylinderArea.Name = "cylinderArea";
            this.cylinderArea.Size = new System.Drawing.Size(60, 20);
            this.cylinderArea.TabIndex = 5;
            this.cylinderArea.Text = "Area: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cylinderArea);
            this.Controls.Add(this.rectangleArea);
            this.Controls.Add(this.circleArea);
            this.Controls.Add(this.cylinderLabel);
            this.Controls.Add(this.rectangleLabel);
            this.Controls.Add(this.circleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label circleLabel;
        private System.Windows.Forms.Label rectangleLabel;
        private System.Windows.Forms.Label cylinderLabel;
        private System.Windows.Forms.Label circleArea;
        private System.Windows.Forms.Label rectangleArea;
        private System.Windows.Forms.Label cylinderArea;
    }
}

