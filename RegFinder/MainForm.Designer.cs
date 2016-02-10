namespace RegFinder
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
            this.lblInputEntry = new System.Windows.Forms.Label();
            this.txtInputEntry = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddEntries = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnViewRecords = new System.Windows.Forms.Button();
            this.btnDownloadTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputEntry
            // 
            this.lblInputEntry.AutoSize = true;
            this.lblInputEntry.Location = new System.Drawing.Point(12, 9);
            this.lblInputEntry.Name = "lblInputEntry";
            this.lblInputEntry.Size = new System.Drawing.Size(73, 13);
            this.lblInputEntry.TabIndex = 0;
            this.lblInputEntry.Text = "Enter number:";
            // 
            // txtInputEntry
            // 
            this.txtInputEntry.Location = new System.Drawing.Point(91, 6);
            this.txtInputEntry.Name = "txtInputEntry";
            this.txtInputEntry.Size = new System.Drawing.Size(100, 20);
            this.txtInputEntry.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(96, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddEntries
            // 
            this.btnAddEntries.Location = new System.Drawing.Point(294, 12);
            this.btnAddEntries.Name = "btnAddEntries";
            this.btnAddEntries.Size = new System.Drawing.Size(164, 23);
            this.btnAddEntries.TabIndex = 3;
            this.btnAddEntries.Text = "Add Entry";
            this.btnAddEntries.UseVisualStyleBackColor = true;
            this.btnAddEntries.Click += new System.EventHandler(this.btnAddEntries_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(294, 50);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(164, 23);
            this.btnImportExcel.TabIndex = 4;
            this.btnImportExcel.Text = "Import from excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnViewRecords
            // 
            this.btnViewRecords.Location = new System.Drawing.Point(294, 89);
            this.btnViewRecords.Name = "btnViewRecords";
            this.btnViewRecords.Size = new System.Drawing.Size(164, 23);
            this.btnViewRecords.TabIndex = 5;
            this.btnViewRecords.Text = "View records";
            this.btnViewRecords.UseVisualStyleBackColor = true;
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Location = new System.Drawing.Point(294, 126);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(164, 23);
            this.btnDownloadTemplate.TabIndex = 6;
            this.btnDownloadTemplate.Text = "Download Template";
            this.btnDownloadTemplate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 156);
            this.Controls.Add(this.btnDownloadTemplate);
            this.Controls.Add(this.btnViewRecords);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnAddEntries);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtInputEntry);
            this.Controls.Add(this.lblInputEntry);
            this.Name = "MainForm";
            this.Text = "Registry Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputEntry;
        private System.Windows.Forms.TextBox txtInputEntry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddEntries;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnViewRecords;
        private System.Windows.Forms.Button btnDownloadTemplate;
    }
}

