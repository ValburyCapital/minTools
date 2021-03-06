﻿namespace minTools
{
    partial class FolderTools
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
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.tbFolderName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBatchFileRename = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRename = new System.Windows.Forms.Button();
            this.gbSearchOptions = new System.Windows.Forms.GroupBox();
            this.lbEstimatedMatchesAnswer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.cbKeywords = new System.Windows.Forms.CheckBox();
            this.lbEstimatedMatchesAmount = new System.Windows.Forms.Label();
            this.lbEstimatedMatches = new System.Windows.Forms.Label();
            this.lbFilesInFolderAmount = new System.Windows.Forms.Label();
            this.comboKeywords = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFileSize = new System.Windows.Forms.CheckBox();
            this.comboFileSize = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboFileSizeSize = new System.Windows.Forms.ComboBox();
            this.dtpDateModified = new System.Windows.Forms.DateTimePicker();
            this.comboDateModified = new System.Windows.Forms.ComboBox();
            this.cbDateModified = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReplacement = new System.Windows.Forms.TextBox();
            this.comboReplacement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpBatchFileRename.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSearchOptions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnChooseFolder);
            this.groupBox1.Controls.Add(this.tbFolderName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChooseFolder.Location = new System.Drawing.Point(834, 19);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(25, 20);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // tbFolderName
            // 
            this.tbFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolderName.Location = new System.Drawing.Point(6, 19);
            this.tbFolderName.Name = "tbFolderName";
            this.tbFolderName.Size = new System.Drawing.Size(822, 20);
            this.tbFolderName.TabIndex = 0;
            this.tbFolderName.TextChanged += new System.EventHandler(this.tbFolderName_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpBatchFileRename);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 349);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 63);
            this.tabControl1.TabIndex = 1;
            // 
            // tpBatchFileRename
            // 
            this.tpBatchFileRename.Controls.Add(this.panel1);
            this.tpBatchFileRename.Location = new System.Drawing.Point(4, 22);
            this.tpBatchFileRename.Name = "tpBatchFileRename";
            this.tpBatchFileRename.Padding = new System.Windows.Forms.Padding(3);
            this.tpBatchFileRename.Size = new System.Drawing.Size(857, 37);
            this.tpBatchFileRename.TabIndex = 0;
            this.tpBatchFileRename.Text = "Batch File Rename";
            this.tpBatchFileRename.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnRename);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 31);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(4, 5);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 1;
            this.btnRename.Text = "Rename All";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbSearchOptions
            // 
            this.gbSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchOptions.Controls.Add(this.lbEstimatedMatchesAnswer);
            this.gbSearchOptions.Controls.Add(this.tableLayoutPanel1);
            this.gbSearchOptions.Enabled = false;
            this.gbSearchOptions.Location = new System.Drawing.Point(12, 71);
            this.gbSearchOptions.Name = "gbSearchOptions";
            this.gbSearchOptions.Size = new System.Drawing.Size(865, 272);
            this.gbSearchOptions.TabIndex = 0;
            this.gbSearchOptions.TabStop = false;
            this.gbSearchOptions.Text = "Search Options";
            this.gbSearchOptions.Enter += new System.EventHandler(this.gbFileRename_Enter);
            // 
            // lbEstimatedMatchesAnswer
            // 
            this.lbEstimatedMatchesAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEstimatedMatchesAnswer.AutoSize = true;
            this.lbEstimatedMatchesAnswer.Location = new System.Drawing.Point(115, 209);
            this.lbEstimatedMatchesAnswer.Name = "lbEstimatedMatchesAnswer";
            this.lbEstimatedMatchesAnswer.Size = new System.Drawing.Size(0, 13);
            this.lbEstimatedMatchesAnswer.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.43234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.72526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99297F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.87269F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.976745F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbKeywords, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbKeywords, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbEstimatedMatchesAmount, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbEstimatedMatches, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbFilesInFolderAmount, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboKeywords, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbFileSize, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboFileSize, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboFileSizeSize, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateModified, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboDateModified, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbDateModified, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbReplacement, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboReplacement, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 243);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estimated Matches: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keywords";
            // 
            // tbKeywords
            // 
            this.tbKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeywords.Location = new System.Drawing.Point(378, 5);
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.Size = new System.Drawing.Size(411, 20);
            this.tbKeywords.TabIndex = 1;
            this.tbKeywords.TextChanged += new System.EventHandler(this.tbKeywords_TextChanged);
            // 
            // cbKeywords
            // 
            this.cbKeywords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKeywords.AutoSize = true;
            this.cbKeywords.Checked = true;
            this.cbKeywords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKeywords.Location = new System.Drawing.Point(130, 8);
            this.cbKeywords.Name = "cbKeywords";
            this.cbKeywords.Size = new System.Drawing.Size(15, 14);
            this.cbKeywords.TabIndex = 2;
            this.cbKeywords.UseVisualStyleBackColor = true;
            this.cbKeywords.CheckedChanged += new System.EventHandler(this.cbKeywords_CheckedChanged);
            // 
            // lbEstimatedMatchesAmount
            // 
            this.lbEstimatedMatchesAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEstimatedMatchesAmount.AutoSize = true;
            this.lbEstimatedMatchesAmount.Location = new System.Drawing.Point(117, 220);
            this.lbEstimatedMatchesAmount.Name = "lbEstimatedMatchesAmount";
            this.lbEstimatedMatchesAmount.Size = new System.Drawing.Size(42, 13);
            this.lbEstimatedMatchesAmount.TabIndex = 7;
            this.lbEstimatedMatchesAmount.Text = "0";
            this.lbEstimatedMatchesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEstimatedMatches
            // 
            this.lbEstimatedMatches.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbEstimatedMatches.AutoSize = true;
            this.lbEstimatedMatches.Location = new System.Drawing.Point(34, 188);
            this.lbEstimatedMatches.Name = "lbEstimatedMatches";
            this.lbEstimatedMatches.Size = new System.Drawing.Size(77, 13);
            this.lbEstimatedMatches.TabIndex = 3;
            this.lbEstimatedMatches.Text = "Files in Folder: ";
            // 
            // lbFilesInFolderAmount
            // 
            this.lbFilesInFolderAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilesInFolderAmount.AutoSize = true;
            this.lbFilesInFolderAmount.Location = new System.Drawing.Point(117, 188);
            this.lbFilesInFolderAmount.Name = "lbFilesInFolderAmount";
            this.lbFilesInFolderAmount.Size = new System.Drawing.Size(42, 13);
            this.lbFilesInFolderAmount.TabIndex = 10;
            this.lbFilesInFolderAmount.Text = "0";
            this.lbFilesInFolderAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboKeywords
            // 
            this.comboKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboKeywords.FormattingEnabled = true;
            this.comboKeywords.Items.AddRange(new object[] {
            "contains",
            "starts with"});
            this.comboKeywords.Location = new System.Drawing.Point(165, 4);
            this.comboKeywords.Name = "comboKeywords";
            this.comboKeywords.Size = new System.Drawing.Size(207, 21);
            this.comboKeywords.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "File Size";
            // 
            // cbFileSize
            // 
            this.cbFileSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFileSize.AutoSize = true;
            this.cbFileSize.Location = new System.Drawing.Point(130, 98);
            this.cbFileSize.Name = "cbFileSize";
            this.cbFileSize.Size = new System.Drawing.Size(15, 14);
            this.cbFileSize.TabIndex = 13;
            this.cbFileSize.UseVisualStyleBackColor = true;
            this.cbFileSize.CheckedChanged += new System.EventHandler(this.cbFileSize_CheckedChanged);
            // 
            // comboFileSize
            // 
            this.comboFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFileSize.Enabled = false;
            this.comboFileSize.FormattingEnabled = true;
            this.comboFileSize.Items.AddRange(new object[] {
            "is exactly",
            "",
            "is more than",
            "is less than",
            "is equal to or less than",
            "is equal to or more than"});
            this.comboFileSize.Location = new System.Drawing.Point(165, 94);
            this.comboFileSize.Name = "comboFileSize";
            this.comboFileSize.Size = new System.Drawing.Size(207, 21);
            this.comboFileSize.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(378, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(411, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // comboFileSizeSize
            // 
            this.comboFileSizeSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFileSizeSize.FormattingEnabled = true;
            this.comboFileSizeSize.Items.AddRange(new object[] {
            "Kb",
            "Mb",
            "Gb"});
            this.comboFileSizeSize.Location = new System.Drawing.Point(795, 94);
            this.comboFileSizeSize.Name = "comboFileSizeSize";
            this.comboFileSizeSize.Size = new System.Drawing.Size(57, 21);
            this.comboFileSizeSize.TabIndex = 16;
            // 
            // dtpDateModified
            // 
            this.dtpDateModified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateModified.Enabled = false;
            this.dtpDateModified.Location = new System.Drawing.Point(378, 65);
            this.dtpDateModified.Name = "dtpDateModified";
            this.dtpDateModified.Size = new System.Drawing.Size(411, 20);
            this.dtpDateModified.TabIndex = 6;
            // 
            // comboDateModified
            // 
            this.comboDateModified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDateModified.Enabled = false;
            this.comboDateModified.FormattingEnabled = true;
            this.comboDateModified.Items.AddRange(new object[] {
            "On this day",
            "Before this day",
            "On or before this day",
            "After this day",
            "On or after this day"});
            this.comboDateModified.Location = new System.Drawing.Point(165, 64);
            this.comboDateModified.Name = "comboDateModified";
            this.comboDateModified.Size = new System.Drawing.Size(207, 21);
            this.comboDateModified.TabIndex = 8;
            // 
            // cbDateModified
            // 
            this.cbDateModified.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDateModified.AutoSize = true;
            this.cbDateModified.Location = new System.Drawing.Point(130, 68);
            this.cbDateModified.Name = "cbDateModified";
            this.cbDateModified.Size = new System.Drawing.Size(15, 14);
            this.cbDateModified.TabIndex = 5;
            this.cbDateModified.UseVisualStyleBackColor = true;
            this.cbDateModified.CheckedChanged += new System.EventHandler(this.cbDateModified_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Modified";
            // 
            // tbReplacement
            // 
            this.tbReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplacement.Location = new System.Drawing.Point(378, 35);
            this.tbReplacement.Name = "tbReplacement";
            this.tbReplacement.Size = new System.Drawing.Size(411, 20);
            this.tbReplacement.TabIndex = 18;
            // 
            // comboReplacement
            // 
            this.comboReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboReplacement.FormattingEnabled = true;
            this.comboReplacement.Items.AddRange(new object[] {
            "Replace Keyword"});
            this.comboReplacement.Location = new System.Drawing.Point(165, 34);
            this.comboReplacement.Name = "comboReplacement";
            this.comboReplacement.Size = new System.Drawing.Size(207, 21);
            this.comboReplacement.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Replacement";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 69);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Combine Files";
            // 
            // FolderTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbSearchOptions);
            this.Controls.Add(this.groupBox1);
            this.Name = "FolderTools";
            this.Text = "FolderTools";
            this.Load += new System.EventHandler(this.FolderTools_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpBatchFileRename.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbSearchOptions.ResumeLayout(false);
            this.gbSearchOptions.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox tbFolderName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBatchFileRename;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSearchOptions;
        private System.Windows.Forms.Label lbEstimatedMatchesAnswer;
        private System.Windows.Forms.Label lbEstimatedMatches;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeywords;
        private System.Windows.Forms.CheckBox cbKeywords;
        private System.Windows.Forms.CheckBox cbDateModified;
        private System.Windows.Forms.DateTimePicker dtpDateModified;
        private System.Windows.Forms.Label lbEstimatedMatchesAmount;
        private System.Windows.Forms.ComboBox comboDateModified;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFilesInFolderAmount;
        private System.Windows.Forms.ComboBox comboKeywords;
        private System.Windows.Forms.ComboBox comboFileSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbFileSize;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.ComboBox comboFileSizeSize;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboReplacement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReplacement;
    }
}