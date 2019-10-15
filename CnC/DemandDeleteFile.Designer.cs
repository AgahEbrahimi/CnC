namespace CnC
{
    partial class DemandDeleteFile
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
            this.UserIP = new System.Windows.Forms.ComboBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FileType = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.UserIPLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.cnCDataSet = new CnC.CnCDataSet();
            this.cnCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streamingIPsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streaming_IPsTableAdapter = new CnC.CnCDataSetTableAdapters.Streaming_IPsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserIP
            // 
            this.UserIP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streamingIPsBindingSource, "IP", true));
            this.UserIP.DataSource = this.streamingIPsBindingSource;
            this.UserIP.DisplayMember = "IP";
            this.UserIP.FormattingEnabled = true;
            this.UserIP.Location = new System.Drawing.Point(285, 31);
            this.UserIP.Name = "UserIP";
            this.UserIP.Size = new System.Drawing.Size(149, 21);
            this.UserIP.TabIndex = 26;
            this.UserIP.ValueMember = "IP";
            this.UserIP.SelectedIndexChanged += new System.EventHandler(this.UserIP_SelectedIndexChanged);
            // 
            // UserID
            // 
            this.UserID.DisplayMember = "User";
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(63, 31);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(149, 21);
            this.UserID.TabIndex = 25;
            this.UserID.ValueMember = "User";
            this.UserID.SelectedIndexChanged += new System.EventHandler(this.UserID_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Visible = false;
            // 
            // FileType
            // 
            this.FileType.Location = new System.Drawing.Point(285, 101);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(149, 20);
            this.FileType.TabIndex = 23;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(63, 101);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(149, 20);
            this.FileName.TabIndex = 22;
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Location = new System.Drawing.Point(236, 104);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(47, 13);
            this.FileTypeLabel.TabIndex = 21;
            this.FileTypeLabel.Text = "FileType";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 104);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(51, 13);
            this.FileNameLabel.TabIndex = 20;
            this.FileNameLabel.Text = "FileName";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(359, 165);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 19;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // UserIPLabel
            // 
            this.UserIPLabel.AutoSize = true;
            this.UserIPLabel.Location = new System.Drawing.Point(244, 34);
            this.UserIPLabel.Name = "UserIPLabel";
            this.UserIPLabel.Size = new System.Drawing.Size(39, 13);
            this.UserIPLabel.TabIndex = 18;
            this.UserIPLabel.Text = "UserIP";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(22, 34);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(40, 13);
            this.UserIDLabel.TabIndex = 17;
            this.UserIDLabel.Text = "UserID";
            // 
            // cnCDataSet
            // 
            this.cnCDataSet.DataSetName = "CnCDataSet";
            this.cnCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cnCDataSetBindingSource
            // 
            this.cnCDataSetBindingSource.DataSource = this.cnCDataSet;
            this.cnCDataSetBindingSource.Position = 0;
            // 
            // streamingIPsBindingSource
            // 
            this.streamingIPsBindingSource.DataMember = "Streaming_IPs";
            this.streamingIPsBindingSource.DataSource = this.cnCDataSet;
            // 
            // streaming_IPsTableAdapter
            // 
            this.streaming_IPsTableAdapter.ClearBeforeFill = true;
            // 
            // DemandDeleteFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 219);
            this.Controls.Add(this.UserIP);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FileType);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.FileTypeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.UserIPLabel);
            this.Controls.Add(this.UserIDLabel);
            this.Name = "DemandDeleteFile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.DemandDeleteFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserIP;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox FileType;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label UserIPLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.BindingSource cnCDataSetBindingSource;
        private CnCDataSet cnCDataSet;
        private System.Windows.Forms.BindingSource streamingIPsBindingSource;
        private CnCDataSetTableAdapters.Streaming_IPsTableAdapter streaming_IPsTableAdapter;
    }
}