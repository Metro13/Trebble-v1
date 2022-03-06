namespace Exercise_4_1
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
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtNum3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdAverage = new System.Windows.Forms.Button();
            this.CmdLargest = new System.Windows.Forms.Button();
            this.CmdSmallest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(135, 107);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 20);
            this.TxtNum1.TabIndex = 0;
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(135, 168);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 20);
            this.TxtNum2.TabIndex = 1;
            // 
            // TxtNum3
            // 
            this.TxtNum3.Location = new System.Drawing.Point(135, 229);
            this.TxtNum3.Name = "TxtNum3";
            this.TxtNum3.Size = new System.Drawing.Size(100, 20);
            this.TxtNum3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Num 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num 3";
            // 
            // CmdAverage
            // 
            this.CmdAverage.Location = new System.Drawing.Point(46, 288);
            this.CmdAverage.Name = "CmdAverage";
            this.CmdAverage.Size = new System.Drawing.Size(75, 23);
            this.CmdAverage.TabIndex = 6;
            this.CmdAverage.Text = "Average";
            this.CmdAverage.UseVisualStyleBackColor = true;
            this.CmdAverage.Click += new System.EventHandler(this.CmdAverage_Click);
            // 
            // CmdLargest
            // 
            this.CmdLargest.Location = new System.Drawing.Point(151, 287);
            this.CmdLargest.Name = "CmdLargest";
            this.CmdLargest.Size = new System.Drawing.Size(75, 23);
            this.CmdLargest.TabIndex = 7;
            this.CmdLargest.Text = "Largest";
            this.CmdLargest.UseVisualStyleBackColor = true;
            this.CmdLargest.Click += new System.EventHandler(this.CmdLargest_Click);
            // 
            // CmdSmallest
            // 
            this.CmdSmallest.Location = new System.Drawing.Point(256, 288);
            this.CmdSmallest.Name = "CmdSmallest";
            this.CmdSmallest.Size = new System.Drawing.Size(75, 23);
            this.CmdSmallest.TabIndex = 8;
            this.CmdSmallest.Text = "Smallest";
            this.CmdSmallest.UseVisualStyleBackColor = true;
            this.CmdSmallest.Click += new System.EventHandler(this.CmdSmallest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 381);
            this.Controls.Add(this.CmdSmallest);
            this.Controls.Add(this.CmdLargest);
            this.Controls.Add(this.CmdAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum3);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtNum3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdAverage;
        private System.Windows.Forms.Button CmdLargest;
        private System.Windows.Forms.Button CmdSmallest;
    }
}

