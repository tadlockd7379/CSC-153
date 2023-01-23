
namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(282, 63);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 4;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(282, 98);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(100, 20);
            this.middleName.TabIndex = 5;
            this.middleName.TextChanged += new System.EventHandler(this.middleName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(282, 134);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 6;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(282, 170);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 7;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 23);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(539, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 23);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(539, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 23);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(539, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 23);
            this.button6.TabIndex = 13;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

