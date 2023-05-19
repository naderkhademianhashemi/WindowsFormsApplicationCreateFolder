namespace WindowsFormsApplicationCreateFolder
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDisplayImg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewNamePrefix = new System.Windows.Forms.TextBox();
            this.btnRenameFiles = new System.Windows.Forms.Button();
            this.btnBrowseRnm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfldr2Rnm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(533, 578);
            this.listBox1.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDisplayImg);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtNewNamePrefix);
            this.splitContainer1.Panel1.Controls.Add(this.btnRenameFiles);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowseRnm);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtfldr2Rnm);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFolderName);
            this.splitContainer1.Panel1.Controls.Add(this.txtLocation);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateFolder);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 578);
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 14;
            // 
            // btnDisplayImg
            // 
            this.btnDisplayImg.Location = new System.Drawing.Point(352, 86);
            this.btnDisplayImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayImg.Name = "btnDisplayImg";
            this.btnDisplayImg.Size = new System.Drawing.Size(100, 46);
            this.btnDisplayImg.TabIndex = 25;
            this.btnDisplayImg.Text = "Display Image Files";
            this.btnDisplayImg.UseVisualStyleBackColor = true;
            this.btnDisplayImg.Click += new System.EventHandler(this.btnDisplayImg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "New Name Prefix";
            // 
            // txtNewNamePrefix
            // 
            this.txtNewNamePrefix.Location = new System.Drawing.Point(40, 284);
            this.txtNewNamePrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewNamePrefix.Name = "txtNewNamePrefix";
            this.txtNewNamePrefix.Size = new System.Drawing.Size(268, 22);
            this.txtNewNamePrefix.TabIndex = 23;
            this.txtNewNamePrefix.Text = "Khademian-";
            // 
            // btnRenameFiles
            // 
            this.btnRenameFiles.Location = new System.Drawing.Point(352, 284);
            this.btnRenameFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenameFiles.Name = "btnRenameFiles";
            this.btnRenameFiles.Size = new System.Drawing.Size(100, 28);
            this.btnRenameFiles.TabIndex = 22;
            this.btnRenameFiles.Text = "Rename";
            this.btnRenameFiles.UseVisualStyleBackColor = true;
            this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);
            // 
            // btnBrowseRnm
            // 
            this.btnBrowseRnm.Location = new System.Drawing.Point(352, 226);
            this.btnBrowseRnm.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseRnm.Name = "btnBrowseRnm";
            this.btnBrowseRnm.Size = new System.Drawing.Size(100, 28);
            this.btnBrowseRnm.TabIndex = 21;
            this.btnBrowseRnm.Text = "...";
            this.btnBrowseRnm.UseVisualStyleBackColor = true;
            this.btnBrowseRnm.Click += new System.EventHandler(this.btnBrowseRnm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "folder name to rename jpg files by adding prefix ";
            // 
            // txtfldr2Rnm
            // 
            this.txtfldr2Rnm.Location = new System.Drawing.Point(40, 229);
            this.txtfldr2Rnm.Margin = new System.Windows.Forms.Padding(4);
            this.txtfldr2Rnm.Name = "txtfldr2Rnm";
            this.txtfldr2Rnm.Size = new System.Drawing.Size(268, 22);
            this.txtfldr2Rnm.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "folder name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "location to create dir there";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(40, 139);
            this.txtFolderName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(268, 22);
            this.txtFolderName.TabIndex = 16;
            this.txtFolderName.Text = "Hashemi-";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(28, 53);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(268, 22);
            this.txtLocation.TabIndex = 15;
            this.txtLocation.Text = "d:\\";
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(352, 139);
            this.btnCreateFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(100, 28);
            this.btnCreateFolder.TabIndex = 14;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(352, 49);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 578);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDisplayImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewNamePrefix;
        private System.Windows.Forms.Button btnRenameFiles;
        private System.Windows.Forms.Button btnBrowseRnm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfldr2Rnm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnBrowse;
    }
}

