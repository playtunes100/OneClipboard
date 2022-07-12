namespace OneClipboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.richTextBoxClipboard = new System.Windows.Forms.RichTextBox();
            this.labelRecentlyAdded = new System.Windows.Forms.Label();
            this.checkBoxStartup = new System.Windows.Forms.CheckBox();
            this.buttonAddtoClip = new System.Windows.Forms.Button();
            this.labelFileSelector = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.labelFileSelected = new System.Windows.Forms.Label();
            this.buttonStartWatch = new System.Windows.Forms.Button();
            this.labelStartWatch = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.sharpClipboard = new WK.Libraries.SharpClipboardNS.SharpClipboard(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(199, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(115, 23);
            this.Title.TabIndex = 0;
            this.Title.Text = "OneClipboard";
            // 
            // richTextBoxClipboard
            // 
            this.richTextBoxClipboard.Location = new System.Drawing.Point(24, 60);
            this.richTextBoxClipboard.Name = "richTextBoxClipboard";
            this.richTextBoxClipboard.Size = new System.Drawing.Size(485, 173);
            this.richTextBoxClipboard.TabIndex = 1;
            this.richTextBoxClipboard.Text = "";
            // 
            // labelRecentlyAdded
            // 
            this.labelRecentlyAdded.AutoSize = true;
            this.labelRecentlyAdded.Location = new System.Drawing.Point(21, 44);
            this.labelRecentlyAdded.Name = "labelRecentlyAdded";
            this.labelRecentlyAdded.Size = new System.Drawing.Size(83, 13);
            this.labelRecentlyAdded.TabIndex = 2;
            this.labelRecentlyAdded.Text = "Recently Added";
            // 
            // checkBoxStartup
            // 
            this.checkBoxStartup.AutoSize = true;
            this.checkBoxStartup.Location = new System.Drawing.Point(24, 240);
            this.checkBoxStartup.Name = "checkBoxStartup";
            this.checkBoxStartup.Size = new System.Drawing.Size(95, 17);
            this.checkBoxStartup.TabIndex = 3;
            this.checkBoxStartup.Text = "Run at Startup";
            this.checkBoxStartup.UseVisualStyleBackColor = true;
            this.checkBoxStartup.CheckedChanged += new System.EventHandler(this.checkBoxStartup_CheckedChanged);
            // 
            // buttonAddtoClip
            // 
            this.buttonAddtoClip.Location = new System.Drawing.Point(401, 240);
            this.buttonAddtoClip.Name = "buttonAddtoClip";
            this.buttonAddtoClip.Size = new System.Drawing.Size(109, 23);
            this.buttonAddtoClip.TabIndex = 4;
            this.buttonAddtoClip.Text = "Sync Clipboard";
            this.buttonAddtoClip.UseVisualStyleBackColor = true;
            this.buttonAddtoClip.Click += new System.EventHandler(this.buttonAddtoClip_Click);
            // 
            // labelFileSelector
            // 
            this.labelFileSelector.AutoSize = true;
            this.labelFileSelector.Location = new System.Drawing.Point(24, 273);
            this.labelFileSelector.Name = "labelFileSelector";
            this.labelFileSelector.Size = new System.Drawing.Size(247, 13);
            this.labelFileSelector.TabIndex = 5;
            this.labelFileSelector.Text = "Select or Create clipboard.txt file in OneDrive folder";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFileSelected
            // 
            this.labelFileSelected.AutoSize = true;
            this.labelFileSelected.Location = new System.Drawing.Point(105, 295);
            this.labelFileSelected.MaximumSize = new System.Drawing.Size(230, 30);
            this.labelFileSelected.Name = "labelFileSelected";
            this.labelFileSelected.Size = new System.Drawing.Size(88, 13);
            this.labelFileSelected.TabIndex = 7;
            this.labelFileSelected.Text = "No File Selected.";
            // 
            // buttonStartWatch
            // 
            this.buttonStartWatch.Location = new System.Drawing.Point(339, 285);
            this.buttonStartWatch.Name = "buttonStartWatch";
            this.buttonStartWatch.Size = new System.Drawing.Size(51, 23);
            this.buttonStartWatch.TabIndex = 8;
            this.buttonStartWatch.Text = "Start";
            this.buttonStartWatch.UseVisualStyleBackColor = true;
            this.buttonStartWatch.Click += new System.EventHandler(this.buttonStartWatch_Click);
            // 
            // labelStartWatch
            // 
            this.labelStartWatch.AutoSize = true;
            this.labelStartWatch.Location = new System.Drawing.Point(396, 290);
            this.labelStartWatch.Name = "labelStartWatch";
            this.labelStartWatch.Size = new System.Drawing.Size(108, 13);
            this.labelStartWatch.TabIndex = 9;
            this.labelStartWatch.Text = "Not Watching Folder.";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "OneCliboard";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.Filter = "*.txt*";
            this.fileSystemWatcher.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.LastWrite)));
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // sharpClipboard
            // 
            this.sharpClipboard.MonitorClipboard = true;
            this.sharpClipboard.ObservableFormats.All = true;
            this.sharpClipboard.ObservableFormats.Files = false;
            this.sharpClipboard.ObservableFormats.Images = false;
            this.sharpClipboard.ObservableFormats.Others = false;
            this.sharpClipboard.ObservableFormats.Texts = true;
            this.sharpClipboard.ObserveLastEntry = true;
            this.sharpClipboard.Tag = null;
            this.sharpClipboard.ClipboardChanged += new System.EventHandler<WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs>(this.sharpClipboard_ClipboardChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(531, 342);
            this.Controls.Add(this.labelStartWatch);
            this.Controls.Add(this.buttonStartWatch);
            this.Controls.Add(this.labelFileSelected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFileSelector);
            this.Controls.Add(this.buttonAddtoClip);
            this.Controls.Add(this.checkBoxStartup);
            this.Controls.Add(this.labelRecentlyAdded);
            this.Controls.Add(this.richTextBoxClipboard);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "OneClipboard";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox richTextBoxClipboard;
        private System.Windows.Forms.Label labelRecentlyAdded;
        private System.Windows.Forms.CheckBox checkBoxStartup;
        private System.Windows.Forms.Button buttonAddtoClip;
        private System.Windows.Forms.Label labelFileSelector;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFileSelected;
        private System.Windows.Forms.Button buttonStartWatch;
        private System.Windows.Forms.Label labelStartWatch;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private WK.Libraries.SharpClipboardNS.SharpClipboard sharpClipboard;
    }
}

