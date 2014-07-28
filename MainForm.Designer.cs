namespace TimeSheetTool
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.populateButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.FileSelectionButton = new System.Windows.Forms.Button();
            this.targetSheetName = new System.Windows.Forms.TextBox();
            this.targetSheetLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel.Controls.Add(this.endDateLabel, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.dateTo, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.dateFrom, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.startDateLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.populateButton, 2, 10);
            this.tableLayoutPanel.Controls.Add(this.titleLabel, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.fileNameLabel, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.FileSelectionButton, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.targetSheetName, 2, 8);
            this.tableLayoutPanel.Controls.Add(this.targetSheetLabel, 1, 8);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 12;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(331, 274);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(15, 82);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(50, 13);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End date";
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTo.Location = new System.Drawing.Point(101, 80);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(150, 20);
            this.dateTo.TabIndex = 1;
            // 
            // dateFrom
            // 
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateFrom.Location = new System.Drawing.Point(101, 33);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(150, 20);
            this.dateFrom.TabIndex = 0;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDateLabel.Location = new System.Drawing.Point(15, 35);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(80, 18);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start date";
            // 
            // populateButton
            // 
            this.populateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.populateButton.Location = new System.Drawing.Point(102, 226);
            this.populateButton.Margin = new System.Windows.Forms.Padding(4);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(212, 28);
            this.populateButton.TabIndex = 4;
            this.populateButton.Text = "Populate";
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.PopulateButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(101, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(214, 30);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "SPREAD SHEET TOOL";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameLabel.Location = new System.Drawing.Point(15, 127);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(80, 12);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "Excel file:";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileSelectionButton
            // 
            this.FileSelectionButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileSelectionButton.Location = new System.Drawing.Point(101, 125);
            this.FileSelectionButton.Name = "FileSelectionButton";
            this.tableLayoutPanel.SetRowSpan(this.FileSelectionButton, 2);
            this.FileSelectionButton.Size = new System.Drawing.Size(118, 33);
            this.FileSelectionButton.TabIndex = 7;
            this.FileSelectionButton.Text = "Select spreadsheet";
            this.FileSelectionButton.UseVisualStyleBackColor = true;
            this.FileSelectionButton.UseWaitCursor = true;
            this.FileSelectionButton.Click += new System.EventHandler(this.FileSelectionButton_Click);
            // 
            // targetSheetName
            // 
            this.targetSheetName.Location = new System.Drawing.Point(101, 184);
            this.targetSheetName.Name = "targetSheetName";
            this.targetSheetName.Size = new System.Drawing.Size(176, 20);
            this.targetSheetName.TabIndex = 9;
            // 
            // targetSheetLabel
            // 
            this.targetSheetLabel.AutoSize = true;
            this.targetSheetLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.targetSheetLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.targetSheetLabel.Location = new System.Drawing.Point(13, 188);
            this.targetSheetLabel.Name = "targetSheetLabel";
            this.targetSheetLabel.Size = new System.Drawing.Size(82, 13);
            this.targetSheetLabel.TabIndex = 10;
            this.targetSheetLabel.Text = "Target sheet";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 274);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "SpreadSheet Tool";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button populateButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button FileSelectionButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox targetSheetName;
        private System.Windows.Forms.Label targetSheetLabel;
    }
}

