
namespace TestinSouceControle
{
    partial class testing
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
            this.Lbcounter1 = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Lbcounter2 = new System.Windows.Forms.Label();
            this.Lbcounter3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbcounter1
            // 
            this.Lbcounter1.AutoSize = true;
            this.Lbcounter1.Location = new System.Drawing.Point(72, 61);
            this.Lbcounter1.Name = "Lbcounter1";
            this.Lbcounter1.Size = new System.Drawing.Size(18, 20);
            this.Lbcounter1.TabIndex = 0;
            this.Lbcounter1.Text = "0";
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(76, 241);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(101, 40);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "add";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(288, 241);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(101, 40);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "add 1,2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(503, 242);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(101, 40);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "add all";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lbcounter2
            // 
            this.Lbcounter2.AutoSize = true;
            this.Lbcounter2.Location = new System.Drawing.Point(288, 61);
            this.Lbcounter2.Name = "Lbcounter2";
            this.Lbcounter2.Size = new System.Drawing.Size(18, 20);
            this.Lbcounter2.TabIndex = 4;
            this.Lbcounter2.Text = "0";
            // 
            // Lbcounter3
            // 
            this.Lbcounter3.AutoSize = true;
            this.Lbcounter3.Location = new System.Drawing.Point(503, 61);
            this.Lbcounter3.Name = "Lbcounter3";
            this.Lbcounter3.Size = new System.Drawing.Size(18, 20);
            this.Lbcounter3.TabIndex = 5;
            this.Lbcounter3.Text = "0";
            // 
            // testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbcounter3);
            this.Controls.Add(this.Lbcounter2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Lbcounter1);
            this.Name = "testing";
            this.Text = "SourceControleTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbcounter1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label Lbcounter2;
        private System.Windows.Forms.Label Lbcounter3;
    }
}

