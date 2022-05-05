
namespace ClickLog
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadRedditcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.xToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.xValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.yToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.yValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.countToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.countCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.logSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
        	this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.logFileLabel = new System.Windows.Forms.Label();
        	this.logFileTextBox = new System.Windows.Forms.TextBox();
        	this.browseButton = new System.Windows.Forms.Button();
        	this.startStopButton = new System.Windows.Forms.Button();
        	this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        	this.appendRadioButton = new System.Windows.Forms.RadioButton();
        	this.overwriteRadioButton = new System.Windows.Forms.RadioButton();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	this.tableLayoutPanel2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem1,
        	        	        	this.optionsToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(327, 24);
        	this.mainMenuStrip.TabIndex = 51;
        	// 
        	// fileToolStripMenuItem1
        	// 
        	this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem,
        	        	        	this.toolStripSeparator3,
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
        	this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem1.Text = "&File";
        	// 
        	// newToolStripMenuItem
        	// 
        	this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
        	this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        	this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.newToolStripMenuItem.Text = "&New";
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.alwaysOnTopToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// alwaysOnTopToolStripMenuItem
        	// 
        	this.alwaysOnTopToolStripMenuItem.Checked = true;
        	this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        	this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.freeReleasesPublicDomainisToolStripMenuItem,
        	        	        	this.originalThreadRedditcomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// freeReleasesPublicDomainisToolStripMenuItem
        	// 
        	this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
        	this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
        	this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
        	this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
        	// 
        	// originalThreadRedditcomToolStripMenuItem
        	// 
        	this.originalThreadRedditcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadRedditcomToolStripMenuItem.Image")));
        	this.originalThreadRedditcomToolStripMenuItem.Name = "originalThreadRedditcomToolStripMenuItem";
        	this.originalThreadRedditcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
        	this.originalThreadRedditcomToolStripMenuItem.Text = "Original thread @ Reddit.com";
        	this.originalThreadRedditcomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadRedditcomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.xToolStripStatusLabel,
        	        	        	this.xValueToolStripStatusLabel,
        	        	        	this.yToolStripStatusLabel,
        	        	        	this.yValueToolStripStatusLabel,
        	        	        	this.toolStripStatusLabel1,
        	        	        	this.countToolStripStatusLabel,
        	        	        	this.countCountToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 156);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(327, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 50;
        	// 
        	// xToolStripStatusLabel
        	// 
        	this.xToolStripStatusLabel.Name = "xToolStripStatusLabel";
        	this.xToolStripStatusLabel.Size = new System.Drawing.Size(17, 17);
        	this.xToolStripStatusLabel.Text = "X:";
        	// 
        	// xValueToolStripStatusLabel
        	// 
        	this.xValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.xValueToolStripStatusLabel.Name = "xValueToolStripStatusLabel";
        	this.xValueToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.xValueToolStripStatusLabel.Text = "0";
        	// 
        	// yToolStripStatusLabel
        	// 
        	this.yToolStripStatusLabel.Name = "yToolStripStatusLabel";
        	this.yToolStripStatusLabel.Size = new System.Drawing.Size(17, 17);
        	this.yToolStripStatusLabel.Text = "Y:";
        	// 
        	// yValueToolStripStatusLabel
        	// 
        	this.yValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.yValueToolStripStatusLabel.Name = "yValueToolStripStatusLabel";
        	this.yValueToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.yValueToolStripStatusLabel.Text = "0";
        	// 
        	// toolStripStatusLabel1
        	// 
        	this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        	this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 17);
        	this.toolStripStatusLabel1.Text = " / ";
        	// 
        	// countToolStripStatusLabel
        	// 
        	this.countToolStripStatusLabel.Name = "countToolStripStatusLabel";
        	this.countToolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
        	this.countToolStripStatusLabel.Text = "Count:";
        	// 
        	// countCountToolStripStatusLabel
        	// 
        	this.countCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.countCountToolStripStatusLabel.Name = "countCountToolStripStatusLabel";
        	this.countCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.countCountToolStripStatusLabel.Text = "0";
        	// 
        	// logSaveFileDialog
        	// 
        	this.logSaveFileDialog.DefaultExt = "txt";
        	this.logSaveFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
        	this.logSaveFileDialog.Title = "Set log file";
        	// 
        	// mainTableLayoutPanel
        	// 
        	this.mainTableLayoutPanel.ColumnCount = 2;
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
        	this.mainTableLayoutPanel.Controls.Add(this.logFileLabel, 0, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.logFileTextBox, 0, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.browseButton, 1, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.startStopButton, 0, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 2);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 4;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(327, 132);
        	this.mainTableLayoutPanel.TabIndex = 52;
        	// 
        	// logFileLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.logFileLabel, 2);
        	this.logFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.logFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.logFileLabel.Location = new System.Drawing.Point(3, 0);
        	this.logFileLabel.Name = "logFileLabel";
        	this.logFileLabel.Size = new System.Drawing.Size(321, 20);
        	this.logFileLabel.TabIndex = 0;
        	this.logFileLabel.Text = "&Log file:";
        	this.logFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// logFileTextBox
        	// 
        	this.logFileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.logFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.logFileTextBox.Location = new System.Drawing.Point(3, 23);
        	this.logFileTextBox.Name = "logFileTextBox";
        	this.logFileTextBox.Size = new System.Drawing.Size(241, 26);
        	this.logFileTextBox.TabIndex = 1;
        	// 
        	// browseButton
        	// 
        	this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.browseButton.Location = new System.Drawing.Point(250, 23);
        	this.browseButton.Name = "browseButton";
        	this.browseButton.Size = new System.Drawing.Size(74, 29);
        	this.browseButton.TabIndex = 2;
        	this.browseButton.Text = "&Browse";
        	this.browseButton.UseVisualStyleBackColor = true;
        	this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
        	// 
        	// startStopButton
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.startStopButton, 2);
        	this.startStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.startStopButton.ForeColor = System.Drawing.Color.DarkGreen;
        	this.startStopButton.Location = new System.Drawing.Point(3, 95);
        	this.startStopButton.Name = "startStopButton";
        	this.startStopButton.Size = new System.Drawing.Size(321, 34);
        	this.startStopButton.TabIndex = 5;
        	this.startStopButton.Text = "&Start";
        	this.startStopButton.UseVisualStyleBackColor = true;
        	this.startStopButton.Click += new System.EventHandler(this.OnStartStopButtonClick);
        	// 
        	// tableLayoutPanel2
        	// 
        	this.tableLayoutPanel2.ColumnCount = 2;
        	this.mainTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel2, 2);
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel2.Controls.Add(this.appendRadioButton, 0, 0);
        	this.tableLayoutPanel2.Controls.Add(this.overwriteRadioButton, 1, 0);
        	this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 58);
        	this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        	this.tableLayoutPanel2.RowCount = 1;
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 31);
        	this.tableLayoutPanel2.TabIndex = 6;
        	// 
        	// appendRadioButton
        	// 
        	this.appendRadioButton.Checked = true;
        	this.appendRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.appendRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.appendRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.appendRadioButton.Location = new System.Drawing.Point(3, 3);
        	this.appendRadioButton.Name = "appendRadioButton";
        	this.appendRadioButton.Size = new System.Drawing.Size(154, 25);
        	this.appendRadioButton.TabIndex = 3;
        	this.appendRadioButton.TabStop = true;
        	this.appendRadioButton.Text = "&Append";
        	this.appendRadioButton.UseVisualStyleBackColor = true;
        	// 
        	// overwriteRadioButton
        	// 
        	this.overwriteRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.overwriteRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.overwriteRadioButton.Location = new System.Drawing.Point(163, 3);
        	this.overwriteRadioButton.Name = "overwriteRadioButton";
        	this.overwriteRadioButton.Size = new System.Drawing.Size(155, 25);
        	this.overwriteRadioButton.TabIndex = 4;
        	this.overwriteRadioButton.Text = "&Overwrite";
        	this.overwriteRadioButton.UseVisualStyleBackColor = true;
        	// 
        	// MainForm
        	// 
        	this.AcceptButton = this.startStopButton;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(327, 178);
        	this.Controls.Add(this.mainTableLayoutPanel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "ClickLog";
        	this.TopMost = true;
        	this.Load += new System.EventHandler(this.OnMainFormLoad);
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.mainTableLayoutPanel.ResumeLayout(false);
        	this.mainTableLayoutPanel.PerformLayout();
        	this.tableLayoutPanel2.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel yValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel yToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel xValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel xToolStripStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox logFileTextBox;
        private System.Windows.Forms.RadioButton overwriteRadioButton;
        private System.Windows.Forms.RadioButton appendRadioButton;
        private System.Windows.Forms.Label logFileLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem originalThreadRedditcomToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog logSaveFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel countCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel countToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
