namespace Assignment1Threads
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
            this.gboxMusic = new System.Windows.Forms.GroupBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopMusic = new System.Windows.Forms.Button();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.btnOpenMusic = new System.Windows.Forms.Button();
            this.gboxDisplay = new System.Windows.Forms.GroupBox();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.btnStopDisplay = new System.Windows.Forms.Button();
            this.btnStartDisplay = new System.Windows.Forms.Button();
            this.gboxTriangle = new System.Windows.Forms.GroupBox();
            this.pnlTriangle = new System.Windows.Forms.Panel();
            this.btnStopTriangle = new System.Windows.Forms.Button();
            this.btnStartTriangle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblClock = new System.Windows.Forms.Label();
            this.gboxMusic.SuspendLayout();
            this.gboxDisplay.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.gboxTriangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMusic
            // 
            this.gboxMusic.Controls.Add(this.lblFilePath);
            this.gboxMusic.Controls.Add(this.label1);
            this.gboxMusic.Controls.Add(this.btnStopMusic);
            this.gboxMusic.Controls.Add(this.btnPlayMusic);
            this.gboxMusic.Controls.Add(this.btnOpenMusic);
            this.gboxMusic.Location = new System.Drawing.Point(12, 12);
            this.gboxMusic.Name = "gboxMusic";
            this.gboxMusic.Size = new System.Drawing.Size(444, 100);
            this.gboxMusic.TabIndex = 0;
            this.gboxMusic.TabStop = false;
            this.gboxMusic.Text = "Music Player";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(103, 36);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(16, 13);
            this.lblFilePath.TabIndex = 6;
            this.lblFilePath.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loaded audio file:";
            // 
            // btnStopMusic
            // 
            this.btnStopMusic.Location = new System.Drawing.Point(171, 67);
            this.btnStopMusic.Name = "btnStopMusic";
            this.btnStopMusic.Size = new System.Drawing.Size(75, 23);
            this.btnStopMusic.TabIndex = 4;
            this.btnStopMusic.Text = "Stop";
            this.btnStopMusic.UseVisualStyleBackColor = true;
            this.btnStopMusic.Click += new System.EventHandler(this.btnStopMusic_Click);
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Location = new System.Drawing.Point(90, 67);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(75, 23);
            this.btnPlayMusic.TabIndex = 3;
            this.btnPlayMusic.Text = "Play";
            this.btnPlayMusic.UseVisualStyleBackColor = true;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click);
            // 
            // btnOpenMusic
            // 
            this.btnOpenMusic.Location = new System.Drawing.Point(9, 67);
            this.btnOpenMusic.Name = "btnOpenMusic";
            this.btnOpenMusic.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMusic.TabIndex = 2;
            this.btnOpenMusic.Text = "Open";
            this.btnOpenMusic.UseVisualStyleBackColor = true;
            this.btnOpenMusic.Click += new System.EventHandler(this.btnOpenMusic_Click);
            // 
            // gboxDisplay
            // 
            this.gboxDisplay.Controls.Add(this.pnlDisplay);
            this.gboxDisplay.Controls.Add(this.btnStopDisplay);
            this.gboxDisplay.Controls.Add(this.btnStartDisplay);
            this.gboxDisplay.Location = new System.Drawing.Point(12, 118);
            this.gboxDisplay.Name = "gboxDisplay";
            this.gboxDisplay.Size = new System.Drawing.Size(217, 264);
            this.gboxDisplay.TabIndex = 1;
            this.gboxDisplay.TabStop = false;
            this.gboxDisplay.Text = "Display Thread";
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.lblClock);
            this.pnlDisplay.Location = new System.Drawing.Point(6, 19);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(205, 210);
            this.pnlDisplay.TabIndex = 2;
            // 
            // btnStopDisplay
            // 
            this.btnStopDisplay.Location = new System.Drawing.Point(87, 235);
            this.btnStopDisplay.Name = "btnStopDisplay";
            this.btnStopDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnStopDisplay.TabIndex = 1;
            this.btnStopDisplay.Text = "Stop";
            this.btnStopDisplay.UseVisualStyleBackColor = true;
            this.btnStopDisplay.Click += new System.EventHandler(this.btnStopDisplay_Click);
            // 
            // btnStartDisplay
            // 
            this.btnStartDisplay.Location = new System.Drawing.Point(6, 235);
            this.btnStartDisplay.Name = "btnStartDisplay";
            this.btnStartDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnStartDisplay.TabIndex = 0;
            this.btnStartDisplay.Text = "Start Display";
            this.btnStartDisplay.UseVisualStyleBackColor = true;
            this.btnStartDisplay.Click += new System.EventHandler(this.btnStartDisplay_Click);
            // 
            // gboxTriangle
            // 
            this.gboxTriangle.Controls.Add(this.pnlTriangle);
            this.gboxTriangle.Controls.Add(this.btnStopTriangle);
            this.gboxTriangle.Controls.Add(this.btnStartTriangle);
            this.gboxTriangle.Location = new System.Drawing.Point(235, 118);
            this.gboxTriangle.Name = "gboxTriangle";
            this.gboxTriangle.Size = new System.Drawing.Size(221, 264);
            this.gboxTriangle.TabIndex = 2;
            this.gboxTriangle.TabStop = false;
            this.gboxTriangle.Text = "Triangle Thread";
            // 
            // pnlTriangle
            // 
            this.pnlTriangle.Location = new System.Drawing.Point(6, 19);
            this.pnlTriangle.Name = "pnlTriangle";
            this.pnlTriangle.Size = new System.Drawing.Size(209, 210);
            this.pnlTriangle.TabIndex = 2;
            // 
            // btnStopTriangle
            // 
            this.btnStopTriangle.Location = new System.Drawing.Point(87, 235);
            this.btnStopTriangle.Name = "btnStopTriangle";
            this.btnStopTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnStopTriangle.TabIndex = 1;
            this.btnStopTriangle.Text = "Stop";
            this.btnStopTriangle.UseVisualStyleBackColor = true;
            this.btnStopTriangle.Click += new System.EventHandler(this.btnStopTriangle_Click);
            // 
            // btnStartTriangle
            // 
            this.btnStartTriangle.Location = new System.Drawing.Point(6, 235);
            this.btnStartTriangle.Name = "btnStartTriangle";
            this.btnStartTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnStartTriangle.TabIndex = 0;
            this.btnStartTriangle.Text = "Start Rotate";
            this.btnStartTriangle.UseVisualStyleBackColor = true;
            this.btnStartTriangle.Click += new System.EventHandler(this.btnStartTriangle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(57, 87);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(90, 22);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(464, 389);
            this.Controls.Add(this.gboxTriangle);
            this.Controls.Add(this.gboxDisplay);
            this.Controls.Add(this.gboxMusic);
            this.MaximumSize = new System.Drawing.Size(480, 427);
            this.MinimumSize = new System.Drawing.Size(480, 427);
            this.Name = "MainForm";
            this.Text = "Multiple thread demonstrator";
            this.gboxMusic.ResumeLayout(false);
            this.gboxMusic.PerformLayout();
            this.gboxDisplay.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            this.gboxTriangle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMusic;
        private System.Windows.Forms.Button btnStopMusic;
        private System.Windows.Forms.Button btnPlayMusic;
        private System.Windows.Forms.Button btnOpenMusic;
        private System.Windows.Forms.GroupBox gboxDisplay;
        private System.Windows.Forms.GroupBox gboxTriangle;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Button btnStopDisplay;
        private System.Windows.Forms.Button btnStartDisplay;
        private System.Windows.Forms.Panel pnlTriangle;
        private System.Windows.Forms.Button btnStopTriangle;
        private System.Windows.Forms.Button btnStartTriangle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblClock;
    }
}

