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
            this.toLabel = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.populateButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.FileSelectionButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel.Controls.Add(this.toLabel, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.dateTo, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.dateFrom, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.fromLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.populateButton, 2, 8);
            this.tableLayoutPanel.Controls.Add(this.titleLabel, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.fileNameLabel, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.FileSelectionButton, 2, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(339, 224);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(15, 81);
            this.toLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "To";
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTo.Location = new System.Drawing.Point(103, 79);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(220, 20);
            this.dateTo.TabIndex = 1;
            // 
            // dateFrom
            // 
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.Location = new System.Drawing.Point(103, 33);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(220, 20);
            this.dateFrom.TabIndex = 0;
            // 
            // fromlabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromLabel.Location = new System.Drawing.Point(15, 35);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(82, 18);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From";
            // 
            // populateButton
            // 
            this.populateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.populateButton.Location = new System.Drawing.Point(104, 186);
            this.populateButton.Margin = new System.Windows.Forms.Padding(4);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(218, 28);
            this.populateButton.TabIndex = 4;
            this.populateButton.Text = "Populate";
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.PopulateButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Location = new System.Drawing.Point(103, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(220, 13);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "SpreadSheet Tool";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileLocationlabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameLabel.Location = new System.Drawing.Point(15, 127);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.fileNameLabel.Name = "fileLocationLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(82, 12);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "Excel file:";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileSelectionButton
            // 
            this.FileSelectionButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileSelectionButton.Location = new System.Drawing.Point(103, 125);
            this.FileSelectionButton.Name = "FileSelectionButton";
            this.tableLayoutPanel.SetRowSpan(this.FileSelectionButton, 2);
            this.FileSelectionButton.Size = new System.Drawing.Size(77, 33);
            this.FileSelectionButton.TabIndex = 7;
            this.FileSelectionButton.Text = "Select File";
            this.FileSelectionButton.UseVisualStyleBackColor = true;
            this.FileSelectionButton.UseWaitCursor = true;
            this.FileSelectionButton.Click += new System.EventHandler(this.FileSelectionButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 224);
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
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button populateButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button FileSelectionButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

