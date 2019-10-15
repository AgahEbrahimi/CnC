namespace CnC
{
    partial class ServerWatch
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
            this.Data_ = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data_)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_
            // 
            this.Data_.AllowUserToAddRows = false;
            this.Data_.AllowUserToDeleteRows = false;
            this.Data_.AllowUserToOrderColumns = true;
            this.Data_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_.Location = new System.Drawing.Point(0, 0);
            this.Data_.Name = "Data_";
            this.Data_.ReadOnly = true;
            this.Data_.Size = new System.Drawing.Size(519, 261);
            this.Data_.TabIndex = 0;
            // 
            // ServerWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.Data_);
            this.Name = "ServerWatch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ServerWatch";
            this.Load += new System.EventHandler(this.ServerWatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_;
    }
}