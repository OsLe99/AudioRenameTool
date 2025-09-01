namespace AudioRenameTool
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            txtFolder = new TextBox();
            btnBrowse = new Button();
            listBoxFiles = new ListBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            textBoxRename = new TextBox();
            buttonPanel = new TableLayoutPanel();
            btnRename = new Button();
            btnExportLua = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(txtFolder, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBrowse, 1, 0);
            tableLayoutPanel1.Controls.Add(listBoxFiles, 0, 1);
            tableLayoutPanel1.Controls.Add(axWindowsMediaPlayer1, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxRename, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonPanel, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(800, 590);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtFolder
            // 
            txtFolder.Dock = DockStyle.Fill;
            txtFolder.Location = new Point(3, 3);
            txtFolder.Name = "txtFolder";
            txtFolder.PlaceholderText = "Insert folder path here...";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(634, 23);
            txtFolder.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Dock = DockStyle.Fill;
            btnBrowse.Location = new Point(643, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(154, 29);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // listBoxFiles
            // 
            tableLayoutPanel1.SetColumnSpan(listBoxFiles, 2);
            listBoxFiles.Dock = DockStyle.Fill;
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new Point(3, 38);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(794, 359);
            listBoxFiles.TabIndex = 2;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            tableLayoutPanel1.SetColumnSpan(axWindowsMediaPlayer1, 2);
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(3, 403);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(794, 144);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // textBoxRename
            // 
            textBoxRename.Dock = DockStyle.Fill;
            textBoxRename.Location = new Point(3, 553);
            textBoxRename.Name = "textBoxRename";
            textBoxRename.PlaceholderText = "Insert new name here...";
            textBoxRename.Size = new Size(634, 23);
            textBoxRename.TabIndex = 4;
            // 
            // buttonPanel
            // 
            buttonPanel.ColumnCount = 2;
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonPanel.Controls.Add(btnRename, 0, 0);
            buttonPanel.Controls.Add(btnExportLua, 1, 0);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(643, 553);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(2);
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonPanel.Size = new Size(154, 34);
            buttonPanel.TabIndex = 5;
            // 
            // btnRename
            // 
            btnRename.Dock = DockStyle.Fill;
            btnRename.Location = new Point(4, 4);
            btnRename.Margin = new Padding(2);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(71, 26);
            btnRename.TabIndex = 0;
            btnRename.Text = "Rename";
            btnRename.Click += btnRename_Click;
            // 
            // btnExportLua
            // 
            btnExportLua.Dock = DockStyle.Fill;
            btnExportLua.Location = new Point(79, 4);
            btnExportLua.Margin = new Padding(2);
            btnExportLua.Name = "btnExportLua";
            btnExportLua.Size = new Size(71, 26);
            btnExportLua.TabIndex = 1;
            btnExportLua.Text = "Export Lua";
            btnExportLua.Click += btnExportLua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 590);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audio Rename Tool";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox listBoxFiles;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox textBoxRename;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnExportLua;
        private TableLayoutPanel buttonPanel;
    }
}
