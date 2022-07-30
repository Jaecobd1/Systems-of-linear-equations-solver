namespace Systems_of_linear_equations_solver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xValue1 = new System.Windows.Forms.TextBox();
            this.yValue1 = new System.Windows.Forms.TextBox();
            this.xValue2 = new System.Windows.Forms.TextBox();
            this.yValue2 = new System.Windows.Forms.TextBox();
            this.Equals2 = new System.Windows.Forms.TextBox();
            this.equals1 = new System.Windows.Forms.TextBox();
            this.EqualsSign = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Solutions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xValue1
            // 
            this.xValue1.Location = new System.Drawing.Point(239, 123);
            this.xValue1.Name = "xValue1";
            this.xValue1.PlaceholderText = "(x)";
            this.xValue1.Size = new System.Drawing.Size(56, 23);
            this.xValue1.TabIndex = 0;
            // 
            // yValue1
            // 
            this.yValue1.Location = new System.Drawing.Point(364, 123);
            this.yValue1.Name = "yValue1";
            this.yValue1.PlaceholderText = "(y)";
            this.yValue1.Size = new System.Drawing.Size(56, 23);
            this.yValue1.TabIndex = 1;
            // 
            // xValue2
            // 
            this.xValue2.Location = new System.Drawing.Point(239, 198);
            this.xValue2.Name = "xValue2";
            this.xValue2.PlaceholderText = "(x2)";
            this.xValue2.Size = new System.Drawing.Size(56, 23);
            this.xValue2.TabIndex = 2;
            // 
            // yValue2
            // 
            this.yValue2.Location = new System.Drawing.Point(364, 198);
            this.yValue2.Name = "yValue2";
            this.yValue2.PlaceholderText = "(y2)";
            this.yValue2.Size = new System.Drawing.Size(56, 23);
            this.yValue2.TabIndex = 3;
            // 
            // Equals2
            // 
            this.Equals2.Location = new System.Drawing.Point(482, 198);
            this.Equals2.Name = "Equals2";
            this.Equals2.PlaceholderText = "(Equals)";
            this.Equals2.Size = new System.Drawing.Size(56, 23);
            this.Equals2.TabIndex = 4;
            // 
            // equals1
            // 
            this.equals1.Location = new System.Drawing.Point(468, 123);
            this.equals1.Name = "equals1";
            this.equals1.PlaceholderText = "(Equals)";
            this.equals1.Size = new System.Drawing.Size(56, 23);
            this.equals1.TabIndex = 5;
            // 
            // EqualsSign
            // 
            this.EqualsSign.AutoSize = true;
            this.EqualsSign.Location = new System.Drawing.Point(438, 126);
            this.EqualsSign.Name = "EqualsSign";
            this.EqualsSign.Size = new System.Drawing.Size(15, 15);
            this.EqualsSign.TabIndex = 6;
            this.EqualsSign.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Find Solution";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Solutions
            // 
            this.Solutions.FormattingEnabled = true;
            this.Solutions.ItemHeight = 15;
            this.Solutions.Location = new System.Drawing.Point(225, 271);
            this.Solutions.Name = "Solutions";
            this.Solutions.Size = new System.Drawing.Size(313, 124);
            this.Solutions.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "+";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Parse from File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Solutions);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EqualsSign);
            this.Controls.Add(this.equals1);
            this.Controls.Add(this.Equals2);
            this.Controls.Add(this.yValue2);
            this.Controls.Add(this.xValue2);
            this.Controls.Add(this.yValue1);
            this.Controls.Add(this.xValue1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xValue1;
        private System.Windows.Forms.TextBox yValue1;
        private System.Windows.Forms.TextBox xValue2;
        private System.Windows.Forms.TextBox yValue2;
        private System.Windows.Forms.TextBox Equals2;
        private System.Windows.Forms.TextBox equals1;
        private System.Windows.Forms.Label EqualsSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Solutions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}
