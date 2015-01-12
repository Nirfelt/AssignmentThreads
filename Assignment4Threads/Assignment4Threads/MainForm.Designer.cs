namespace Assignment4Threads
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
            this.lstbBag = new System.Windows.Forms.ListBox();
            this.btnFactory1 = new System.Windows.Forms.Button();
            this.btnFactory2 = new System.Windows.Forms.Button();
            this.lstbActivities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFactory1 = new System.Windows.Forms.Label();
            this.lblFactory2 = new System.Windows.Forms.Label();
            this.btnStopFactory1 = new System.Windows.Forms.Button();
            this.btnStopFactory2 = new System.Windows.Forms.Button();
            this.lblWV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbBag
            // 
            this.lstbBag.FormattingEnabled = true;
            this.lstbBag.Location = new System.Drawing.Point(12, 34);
            this.lstbBag.Name = "lstbBag";
            this.lstbBag.Size = new System.Drawing.Size(240, 316);
            this.lstbBag.TabIndex = 0;
            // 
            // btnFactory1
            // 
            this.btnFactory1.Location = new System.Drawing.Point(258, 35);
            this.btnFactory1.Name = "btnFactory1";
            this.btnFactory1.Size = new System.Drawing.Size(135, 23);
            this.btnFactory1.TabIndex = 1;
            this.btnFactory1.Text = "Start Factory 1";
            this.btnFactory1.UseVisualStyleBackColor = true;
            this.btnFactory1.Click += new System.EventHandler(this.btnFactory1_Click);
            // 
            // btnFactory2
            // 
            this.btnFactory2.Location = new System.Drawing.Point(258, 180);
            this.btnFactory2.Name = "btnFactory2";
            this.btnFactory2.Size = new System.Drawing.Size(135, 23);
            this.btnFactory2.TabIndex = 2;
            this.btnFactory2.Text = "Start Factory 2";
            this.btnFactory2.UseVisualStyleBackColor = true;
            this.btnFactory2.Click += new System.EventHandler(this.btnFactory2_Click);
            // 
            // lstbActivities
            // 
            this.lstbActivities.FormattingEnabled = true;
            this.lstbActivities.Location = new System.Drawing.Point(399, 35);
            this.lstbActivities.Name = "lstbActivities";
            this.lstbActivities.Size = new System.Drawing.Size(240, 316);
            this.lstbActivities.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Santas Bag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Santa Activities";
            // 
            // lblFactory1
            // 
            this.lblFactory1.AutoSize = true;
            this.lblFactory1.Location = new System.Drawing.Point(258, 61);
            this.lblFactory1.Name = "lblFactory1";
            this.lblFactory1.Size = new System.Drawing.Size(35, 13);
            this.lblFactory1.TabIndex = 6;
            this.lblFactory1.Text = "label3";
            // 
            // lblFactory2
            // 
            this.lblFactory2.AutoSize = true;
            this.lblFactory2.Location = new System.Drawing.Point(258, 206);
            this.lblFactory2.Name = "lblFactory2";
            this.lblFactory2.Size = new System.Drawing.Size(35, 13);
            this.lblFactory2.TabIndex = 7;
            this.lblFactory2.Text = "label4";
            // 
            // btnStopFactory1
            // 
            this.btnStopFactory1.Location = new System.Drawing.Point(258, 151);
            this.btnStopFactory1.Name = "btnStopFactory1";
            this.btnStopFactory1.Size = new System.Drawing.Size(135, 23);
            this.btnStopFactory1.TabIndex = 8;
            this.btnStopFactory1.Text = "Stop Factory 1";
            this.btnStopFactory1.UseVisualStyleBackColor = true;
            this.btnStopFactory1.Click += new System.EventHandler(this.btnStopFactory1_Click);
            // 
            // btnStopFactory2
            // 
            this.btnStopFactory2.Location = new System.Drawing.Point(261, 326);
            this.btnStopFactory2.Name = "btnStopFactory2";
            this.btnStopFactory2.Size = new System.Drawing.Size(132, 23);
            this.btnStopFactory2.TabIndex = 9;
            this.btnStopFactory2.Text = "Stop Factory 2";
            this.btnStopFactory2.UseVisualStyleBackColor = true;
            this.btnStopFactory2.Click += new System.EventHandler(this.btnStopFactory2_Click);
            // 
            // lblWV
            // 
            this.lblWV.AutoSize = true;
            this.lblWV.Location = new System.Drawing.Point(111, 16);
            this.lblWV.Name = "lblWV";
            this.lblWV.Size = new System.Drawing.Size(103, 13);
            this.lblWV.TabIndex = 10;
            this.lblWV.Text = "Weight: 0 Volume: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 360);
            this.Controls.Add(this.lblWV);
            this.Controls.Add(this.btnStopFactory2);
            this.Controls.Add(this.btnStopFactory1);
            this.Controls.Add(this.lblFactory2);
            this.Controls.Add(this.lblFactory1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbActivities);
            this.Controls.Add(this.btnFactory2);
            this.Controls.Add(this.btnFactory1);
            this.Controls.Add(this.lstbBag);
            this.Name = "MainForm";
            this.Text = "Christamas gift delivery system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbBag;
        private System.Windows.Forms.Button btnFactory1;
        private System.Windows.Forms.Button btnFactory2;
        private System.Windows.Forms.ListBox lstbActivities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFactory1;
        private System.Windows.Forms.Label lblFactory2;
        private System.Windows.Forms.Button btnStopFactory1;
        private System.Windows.Forms.Button btnStopFactory2;
        private System.Windows.Forms.Label lblWV;
    }
}

