namespace CnC
{
    partial class Upload
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cnCDataSet = new CnC.CnCDataSet();
            this.streamingIPsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streaming_IPsTableAdapter = new CnC.CnCDataSetTableAdapters.Streaming_IPsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streamingIPsBindingSource, "User", true));
            this.comboBox1.DataSource = this.streamingIPsBindingSource;
            this.comboBox1.DisplayMember = "User";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "User";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 64);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Upload";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Upload";
            this.Load += new System.EventHandler(this.Upload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CnCDataSet cnCDataSet;
        private System.Windows.Forms.BindingSource streamingIPsBindingSource;
        private CnCDataSetTableAdapters.Streaming_IPsTableAdapter streaming_IPsTableAdapter;
    }
}