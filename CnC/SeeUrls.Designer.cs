namespace CnC
{
    partial class SeeUrls
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Panel_Closing = new System.Windows.Forms.Panel();
            this.Minimize_btn = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.URLLabel = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.cnCDataSet = new CnC.CnCDataSet();
            this.streamingIPsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streaming_IPsTableAdapter = new CnC.CnCDataSetTableAdapters.Streaming_IPsTableAdapter();
            this.SubmitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.Panel_Closing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Panel_Closing
            // 
            this.Panel_Closing.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Panel_Closing.Controls.Add(this.Minimize_btn);
            this.Panel_Closing.Controls.Add(this.Close_btn);
            this.Panel_Closing.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel_Closing.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Closing.Location = new System.Drawing.Point(0, 0);
            this.Panel_Closing.Name = "Panel_Closing";
            this.Panel_Closing.Size = new System.Drawing.Size(522, 42);
            this.Panel_Closing.TabIndex = 10;
            this.Panel_Closing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseDown);
            this.Panel_Closing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseMove);
            this.Panel_Closing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseUp);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.Image = global::CnC.Properties.Resources.Minimize_Main;
            this.Minimize_btn.Location = new System.Drawing.Point(459, 10);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(24, 24);
            this.Minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize_btn.TabIndex = 8;
            this.Minimize_btn.TabStop = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            this.Minimize_btn.MouseEnter += new System.EventHandler(this.Minimize_btn_MouseEnter);
            this.Minimize_btn.MouseLeave += new System.EventHandler(this.Minimize_btn_MouseLeave);
            // 
            // Close_btn
            // 
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.Image = global::CnC.Properties.Resources.Close_Main;
            this.Close_btn.Location = new System.Drawing.Point(486, 10);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(24, 24);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_btn.TabIndex = 0;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.Close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.Close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLabel.ForeColor = System.Drawing.Color.White;
            this.UserIDLabel.Location = new System.Drawing.Point(14, 103);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(44, 14);
            this.UserIDLabel.TabIndex = 11;
            this.UserIDLabel.Text = "UserID";
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLabel.ForeColor = System.Drawing.Color.White;
            this.URLLabel.Location = new System.Drawing.Point(25, 53);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(23, 14);
            this.URLLabel.TabIndex = 12;
            this.URLLabel.Text = "Url";
            // 
            // URL
            // 
            this.URL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(67, 53);
            this.URL.Multiline = true;
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(443, 33);
            this.URL.TabIndex = 13;
            // 
            // UserID
            // 
            this.UserID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streamingIPsBindingSource, "User", true));
            this.UserID.DataSource = this.streamingIPsBindingSource;
            this.UserID.DisplayMember = "User";
            this.UserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(67, 100);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(152, 22);
            this.UserID.TabIndex = 14;
            this.UserID.ValueMember = "User";
            // 
            // cnCDataSet
            // 
            this.cnCDataSet.DataSetName = "CnCDataSet";
            this.cnCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(191)))));
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SubmitBtn.Location = new System.Drawing.Point(426, 92);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(84, 34);
            this.SubmitBtn.TabIndex = 28;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // SeeUrls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(522, 133);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.Panel_Closing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeUrls";
            this.Text = "SeeUrls";
            this.Load += new System.EventHandler(this.SeeUrls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.Panel_Closing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel Panel_Closing;
        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private CnCDataSet cnCDataSet;
        private System.Windows.Forms.BindingSource streamingIPsBindingSource;
        private CnCDataSetTableAdapters.Streaming_IPsTableAdapter streaming_IPsTableAdapter;
        private System.Windows.Forms.Button SubmitBtn;
    }
}