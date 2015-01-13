namespace Assignment5Threads
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbQueue4 = new System.Windows.Forms.ListBox();
            this.lstbQueue3 = new System.Windows.Forms.ListBox();
            this.lstbQueue2 = new System.Windows.Forms.ListBox();
            this.lstbQueue1 = new System.Windows.Forms.ListBox();
            this.btnQueue4 = new System.Windows.Forms.Button();
            this.btnQueue3 = new System.Windows.Forms.Button();
            this.btnQueue2 = new System.Windows.Forms.Button();
            this.btnQueue1 = new System.Windows.Forms.Button();
            this.lblQueue4 = new System.Windows.Forms.Label();
            this.lblQueue3 = new System.Windows.Forms.Label();
            this.lblQueue2 = new System.Windows.Forms.Label();
            this.lblQueue1 = new System.Windows.Forms.Label();
            this.lstbExit = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lstbParked = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstbQueue4);
            this.groupBox1.Controls.Add(this.lstbQueue3);
            this.groupBox1.Controls.Add(this.lstbQueue2);
            this.groupBox1.Controls.Add(this.lstbQueue1);
            this.groupBox1.Controls.Add(this.btnQueue4);
            this.groupBox1.Controls.Add(this.btnQueue3);
            this.groupBox1.Controls.Add(this.btnQueue2);
            this.groupBox1.Controls.Add(this.btnQueue1);
            this.groupBox1.Controls.Add(this.lblQueue4);
            this.groupBox1.Controls.Add(this.lblQueue3);
            this.groupBox1.Controls.Add(this.lblQueue2);
            this.groupBox1.Controls.Add(this.lblQueue1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 345);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Queue 4 Cars:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Queue 3 Cars:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Queue 2 Cars:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Queue 1 Cars:";
            // 
            // lstbQueue4
            // 
            this.lstbQueue4.FormattingEnabled = true;
            this.lstbQueue4.Location = new System.Drawing.Point(384, 48);
            this.lstbQueue4.Name = "lstbQueue4";
            this.lstbQueue4.Size = new System.Drawing.Size(120, 264);
            this.lstbQueue4.TabIndex = 15;
            // 
            // lstbQueue3
            // 
            this.lstbQueue3.FormattingEnabled = true;
            this.lstbQueue3.Location = new System.Drawing.Point(258, 48);
            this.lstbQueue3.Name = "lstbQueue3";
            this.lstbQueue3.Size = new System.Drawing.Size(120, 264);
            this.lstbQueue3.TabIndex = 14;
            // 
            // lstbQueue2
            // 
            this.lstbQueue2.FormattingEnabled = true;
            this.lstbQueue2.Location = new System.Drawing.Point(132, 48);
            this.lstbQueue2.Name = "lstbQueue2";
            this.lstbQueue2.Size = new System.Drawing.Size(120, 264);
            this.lstbQueue2.TabIndex = 13;
            // 
            // lstbQueue1
            // 
            this.lstbQueue1.FormattingEnabled = true;
            this.lstbQueue1.Location = new System.Drawing.Point(6, 48);
            this.lstbQueue1.Name = "lstbQueue1";
            this.lstbQueue1.Size = new System.Drawing.Size(120, 264);
            this.lstbQueue1.TabIndex = 12;
            // 
            // btnQueue4
            // 
            this.btnQueue4.Location = new System.Drawing.Point(384, 316);
            this.btnQueue4.Name = "btnQueue4";
            this.btnQueue4.Size = new System.Drawing.Size(120, 23);
            this.btnQueue4.TabIndex = 11;
            this.btnQueue4.Text = "OPEN";
            this.btnQueue4.UseVisualStyleBackColor = true;
            this.btnQueue4.Click += new System.EventHandler(this.btnQueue4_Click);
            // 
            // btnQueue3
            // 
            this.btnQueue3.Location = new System.Drawing.Point(258, 316);
            this.btnQueue3.Name = "btnQueue3";
            this.btnQueue3.Size = new System.Drawing.Size(120, 23);
            this.btnQueue3.TabIndex = 10;
            this.btnQueue3.Text = "OPEN";
            this.btnQueue3.UseVisualStyleBackColor = true;
            this.btnQueue3.Click += new System.EventHandler(this.btnQueue3_Click);
            // 
            // btnQueue2
            // 
            this.btnQueue2.Location = new System.Drawing.Point(132, 316);
            this.btnQueue2.Name = "btnQueue2";
            this.btnQueue2.Size = new System.Drawing.Size(120, 23);
            this.btnQueue2.TabIndex = 9;
            this.btnQueue2.Text = "OPEN";
            this.btnQueue2.UseVisualStyleBackColor = true;
            this.btnQueue2.Click += new System.EventHandler(this.btnQueue2_Click);
            // 
            // btnQueue1
            // 
            this.btnQueue1.Location = new System.Drawing.Point(6, 316);
            this.btnQueue1.Name = "btnQueue1";
            this.btnQueue1.Size = new System.Drawing.Size(120, 23);
            this.btnQueue1.TabIndex = 8;
            this.btnQueue1.Text = "OPEN";
            this.btnQueue1.UseVisualStyleBackColor = true;
            this.btnQueue1.Click += new System.EventHandler(this.btnQueue1_Click);
            // 
            // lblQueue4
            // 
            this.lblQueue4.AutoSize = true;
            this.lblQueue4.Location = new System.Drawing.Point(462, 28);
            this.lblQueue4.Name = "lblQueue4";
            this.lblQueue4.Size = new System.Drawing.Size(13, 13);
            this.lblQueue4.TabIndex = 7;
            this.lblQueue4.Text = "0";
            // 
            // lblQueue3
            // 
            this.lblQueue3.AutoSize = true;
            this.lblQueue3.Location = new System.Drawing.Point(336, 28);
            this.lblQueue3.Name = "lblQueue3";
            this.lblQueue3.Size = new System.Drawing.Size(13, 13);
            this.lblQueue3.TabIndex = 6;
            this.lblQueue3.Text = "0";
            // 
            // lblQueue2
            // 
            this.lblQueue2.AutoSize = true;
            this.lblQueue2.Location = new System.Drawing.Point(210, 28);
            this.lblQueue2.Name = "lblQueue2";
            this.lblQueue2.Size = new System.Drawing.Size(13, 13);
            this.lblQueue2.TabIndex = 5;
            this.lblQueue2.Text = "0";
            // 
            // lblQueue1
            // 
            this.lblQueue1.AutoSize = true;
            this.lblQueue1.Location = new System.Drawing.Point(84, 28);
            this.lblQueue1.Name = "lblQueue1";
            this.lblQueue1.Size = new System.Drawing.Size(13, 13);
            this.lblQueue1.TabIndex = 4;
            this.lblQueue1.Text = "0";
            // 
            // lstbExit
            // 
            this.lstbExit.FormattingEnabled = true;
            this.lstbExit.Location = new System.Drawing.Point(192, 48);
            this.lstbExit.Name = "lstbExit";
            this.lstbExit.Size = new System.Drawing.Size(180, 264);
            this.lstbExit.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbParked);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblExit);
            this.groupBox2.Controls.Add(this.lstbExit);
            this.groupBox2.Location = new System.Drawing.Point(529, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 345);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parking House";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parked Cars:";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(77, 28);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(13, 13);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "0";
            // 
            // lstbParked
            // 
            this.lstbParked.FormattingEnabled = true;
            this.lstbParked.Location = new System.Drawing.Point(6, 48);
            this.lstbParked.Name = "lstbParked";
            this.lstbParked.Size = new System.Drawing.Size(180, 264);
            this.lstbParked.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(934, 407);
            this.MinimumSize = new System.Drawing.Size(934, 407);
            this.Name = "MainForm";
            this.Text = "Parking House";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbQueue4;
        private System.Windows.Forms.ListBox lstbQueue3;
        private System.Windows.Forms.ListBox lstbQueue2;
        private System.Windows.Forms.ListBox lstbQueue1;
        private System.Windows.Forms.Button btnQueue4;
        private System.Windows.Forms.Button btnQueue3;
        private System.Windows.Forms.Button btnQueue2;
        private System.Windows.Forms.Button btnQueue1;
        private System.Windows.Forms.Label lblQueue4;
        private System.Windows.Forms.Label lblQueue3;
        private System.Windows.Forms.Label lblQueue2;
        private System.Windows.Forms.Label lblQueue1;
        private System.Windows.Forms.ListBox lstbExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.ListBox lstbParked;
    }
}

