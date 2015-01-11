namespace Assignment3Threads
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
            this.cBoxNotifyUser = new System.Windows.Forms.CheckBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.rtxtSource = new System.Windows.Forms.RichTextBox();
            this.tabDestination = new System.Windows.Forms.TabPage();
            this.rtxtDestination = new System.Windows.Forms.RichTextBox();
            this.btnCreateDestination = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblChanges = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuFile.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxNotifyUser);
            this.groupBox1.Controls.Add(this.txtReplace);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // cBoxNotifyUser
            // 
            this.cBoxNotifyUser.AutoSize = true;
            this.cBoxNotifyUser.Checked = true;
            this.cBoxNotifyUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxNotifyUser.Location = new System.Drawing.Point(14, 89);
            this.cBoxNotifyUser.Name = "cBoxNotifyUser";
            this.cBoxNotifyUser.Size = new System.Drawing.Size(152, 17);
            this.cBoxNotifyUser.TabIndex = 4;
            this.cBoxNotifyUser.Text = "Notify user on every match";
            this.cBoxNotifyUser.UseVisualStyleBackColor = true;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(89, 54);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(312, 20);
            this.txtReplace.TabIndex = 3;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(89, 28);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(312, 20);
            this.txtFind.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace with:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // menuFile
            // 
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(608, 24);
            this.menuFile.TabIndex = 1;
            this.menuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSource);
            this.tabControl1.Controls.Add(this.tabDestination);
            this.tabControl1.Location = new System.Drawing.Point(12, 174);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 345);
            this.tabControl1.TabIndex = 2;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.rtxtSource);
            this.tabSource.Location = new System.Drawing.Point(4, 22);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(578, 319);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Source";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // rtxtSource
            // 
            this.rtxtSource.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtSource.Location = new System.Drawing.Point(6, 6);
            this.rtxtSource.Name = "rtxtSource";
            this.rtxtSource.ReadOnly = true;
            this.rtxtSource.Size = new System.Drawing.Size(566, 307);
            this.rtxtSource.TabIndex = 0;
            this.rtxtSource.Text = "";
            // 
            // tabDestination
            // 
            this.tabDestination.Controls.Add(this.rtxtDestination);
            this.tabDestination.Location = new System.Drawing.Point(4, 22);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tabDestination.Size = new System.Drawing.Size(578, 319);
            this.tabDestination.TabIndex = 1;
            this.tabDestination.Text = "Destination";
            this.tabDestination.UseVisualStyleBackColor = true;
            // 
            // rtxtDestination
            // 
            this.rtxtDestination.Location = new System.Drawing.Point(6, 6);
            this.rtxtDestination.Name = "rtxtDestination";
            this.rtxtDestination.ReadOnly = true;
            this.rtxtDestination.Size = new System.Drawing.Size(566, 307);
            this.rtxtDestination.TabIndex = 0;
            this.rtxtDestination.Text = "";
            // 
            // btnCreateDestination
            // 
            this.btnCreateDestination.Location = new System.Drawing.Point(442, 113);
            this.btnCreateDestination.Name = "btnCreateDestination";
            this.btnCreateDestination.Size = new System.Drawing.Size(154, 23);
            this.btnCreateDestination.TabIndex = 3;
            this.btnCreateDestination.Text = "Create the Destination File";
            this.btnCreateDestination.UseVisualStyleBackColor = true;
            this.btnCreateDestination.Click += new System.EventHandler(this.btnCreateDestination_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(442, 142);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Dest. and remove mark";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblChanges
            // 
            this.lblChanges.AutoSize = true;
            this.lblChanges.Location = new System.Drawing.Point(257, 158);
            this.lblChanges.Name = "lblChanges";
            this.lblChanges.Size = new System.Drawing.Size(86, 13);
            this.lblChanges.TabIndex = 5;
            this.lblChanges.Text = "0 changes made";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(608, 531);
            this.Controls.Add(this.lblChanges);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateDestination);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuFile);
            this.MainMenuStrip = this.menuFile;
            this.Name = "MainForm";
            this.Text = "Text File Copier - with Find and Replace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabDestination.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxNotifyUser;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.RichTextBox rtxtSource;
        private System.Windows.Forms.TabPage tabDestination;
        private System.Windows.Forms.RichTextBox rtxtDestination;
        private System.Windows.Forms.Button btnCreateDestination;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblChanges;
    }
}

