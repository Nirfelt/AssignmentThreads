namespace Assignment2Threads
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
            this.lstbWriter = new System.Windows.Forms.ListBox();
            this.lstbReader = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnSync = new System.Windows.Forms.RadioButton();
            this.rbtnAsync = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txbStringToTransfer = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTransmitted = new System.Windows.Forms.Label();
            this.lblRecieved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbWriter
            // 
            this.lstbWriter.FormattingEnabled = true;
            this.lstbWriter.Location = new System.Drawing.Point(12, 54);
            this.lstbWriter.Name = "lstbWriter";
            this.lstbWriter.Size = new System.Drawing.Size(346, 407);
            this.lstbWriter.TabIndex = 0;
            // 
            // lstbReader
            // 
            this.lstbReader.FormattingEnabled = true;
            this.lstbReader.Location = new System.Drawing.Point(526, 54);
            this.lstbReader.Name = "lstbReader";
            this.lstbReader.Size = new System.Drawing.Size(341, 407);
            this.lstbReader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Writer Thread Logger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reader Thread Logger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concurrent Tester";
            // 
            // rbtnSync
            // 
            this.rbtnSync.AutoSize = true;
            this.rbtnSync.Location = new System.Drawing.Point(379, 93);
            this.rbtnSync.Name = "rbtnSync";
            this.rbtnSync.Size = new System.Drawing.Size(111, 17);
            this.rbtnSync.TabIndex = 5;
            this.rbtnSync.TabStop = true;
            this.rbtnSync.Text = "Syncronous Mode";
            this.rbtnSync.UseVisualStyleBackColor = true;
            // 
            // rbtnAsync
            // 
            this.rbtnAsync.AutoSize = true;
            this.rbtnAsync.Location = new System.Drawing.Point(379, 116);
            this.rbtnAsync.Name = "rbtnAsync";
            this.rbtnAsync.Size = new System.Drawing.Size(116, 17);
            this.rbtnAsync.TabIndex = 6;
            this.rbtnAsync.TabStop = true;
            this.rbtnAsync.Text = "Asyncronous Mode";
            this.rbtnAsync.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "String to transfer";
            // 
            // txbStringToTransfer
            // 
            this.txbStringToTransfer.Location = new System.Drawing.Point(376, 169);
            this.txbStringToTransfer.Name = "txbStringToTransfer";
            this.txbStringToTransfer.Size = new System.Drawing.Size(131, 20);
            this.txbStringToTransfer.TabIndex = 8;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(402, 205);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(390, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 41);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Location = new System.Drawing.Point(390, 279);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(110, 61);
            this.pnlStatus.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Running status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(387, 358);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Run for match";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Transmitted:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Recieved:";
            // 
            // lblTransmitted
            // 
            this.lblTransmitted.AutoSize = true;
            this.lblTransmitted.Location = new System.Drawing.Point(9, 496);
            this.lblTransmitted.Name = "lblTransmitted";
            this.lblTransmitted.Size = new System.Drawing.Size(35, 13);
            this.lblTransmitted.TabIndex = 16;
            this.lblTransmitted.Text = "label9";
            // 
            // lblRecieved
            // 
            this.lblRecieved.AutoSize = true;
            this.lblRecieved.Location = new System.Drawing.Point(523, 496);
            this.lblRecieved.Name = "lblRecieved";
            this.lblRecieved.Size = new System.Drawing.Size(41, 13);
            this.lblRecieved.TabIndex = 17;
            this.lblRecieved.Text = "label10";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 521);
            this.Controls.Add(this.lblRecieved);
            this.Controls.Add(this.lblTransmitted);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txbStringToTransfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnAsync);
            this.Controls.Add(this.rbtnSync);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbReader);
            this.Controls.Add(this.lstbWriter);
            this.Name = "MainForm";
            this.Text = "Concurrent Read/Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbWriter;
        private System.Windows.Forms.ListBox lstbReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnSync;
        private System.Windows.Forms.RadioButton rbtnAsync;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbStringToTransfer;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTransmitted;
        private System.Windows.Forms.Label lblRecieved;
    }
}

