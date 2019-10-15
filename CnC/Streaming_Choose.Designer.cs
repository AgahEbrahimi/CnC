namespace CnC
{
    partial class Streaming_Choose
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
            this.Minimize_btn = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Panel_Closing = new System.Windows.Forms.Panel();
            this.Divider_Left = new System.Windows.Forms.Panel();
            this.Divider_Right = new System.Windows.Forms.Panel();
            this.Divider_Down = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PortLabel = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.UserIPLabel = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.PictureBox();
            this.UserIP = new System.Windows.Forms.ComboBox();
            this.cnCDataSet = new CnC.CnCDataSet();
            this.streamingIPsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streaming_IPsTableAdapter = new CnC.CnCDataSetTableAdapters.Streaming_IPsTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            this.Panel_Closing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.Image = global::CnC.Properties.Resources.Minimize_Main;
            this.Minimize_btn.Location = new System.Drawing.Point(241, 9);
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
            this.Close_btn.Location = new System.Drawing.Point(268, 9);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(24, 24);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_btn.TabIndex = 0;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.Close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.Close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // Panel_Closing
            // 
            this.Panel_Closing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.Panel_Closing.Controls.Add(this.Minimize_btn);
            this.Panel_Closing.Controls.Add(this.Close_btn);
            this.Panel_Closing.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel_Closing.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Closing.Location = new System.Drawing.Point(0, 0);
            this.Panel_Closing.Name = "Panel_Closing";
            this.Panel_Closing.Size = new System.Drawing.Size(300, 42);
            this.Panel_Closing.TabIndex = 9;
            this.Panel_Closing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseDown);
            this.Panel_Closing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseMove);
            this.Panel_Closing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseUp);
            // 
            // Divider_Left
            // 
            this.Divider_Left.BackColor = System.Drawing.Color.Indigo;
            this.Divider_Left.Location = new System.Drawing.Point(0, 0);
            this.Divider_Left.Name = "Divider_Left";
            this.Divider_Left.Size = new System.Drawing.Size(1, 300);
            this.Divider_Left.TabIndex = 10;
            // 
            // Divider_Right
            // 
            this.Divider_Right.BackColor = System.Drawing.Color.Indigo;
            this.Divider_Right.Location = new System.Drawing.Point(299, 0);
            this.Divider_Right.Name = "Divider_Right";
            this.Divider_Right.Size = new System.Drawing.Size(1, 300);
            this.Divider_Right.TabIndex = 11;
            // 
            // Divider_Down
            // 
            this.Divider_Down.BackColor = System.Drawing.Color.Indigo;
            this.Divider_Down.Location = new System.Drawing.Point(0, 209);
            this.Divider_Down.Name = "Divider_Down";
            this.Divider_Down.Size = new System.Drawing.Size(300, 1);
            this.Divider_Down.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 13;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.ForeColor = System.Drawing.Color.White;
            this.PortLabel.Location = new System.Drawing.Point(20, 102);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(28, 14);
            this.PortLabel.TabIndex = 14;
            this.PortLabel.Text = "Port";
            // 
            // Port
            // 
            this.Port.Enabled = false;
            this.Port.Location = new System.Drawing.Point(65, 99);
            this.Port.Multiline = true;
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(200, 24);
            this.Port.TabIndex = 17;
            this.Port.Text = "2016";
            // 
            // UserIPLabel
            // 
            this.UserIPLabel.AutoSize = true;
            this.UserIPLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIPLabel.ForeColor = System.Drawing.Color.White;
            this.UserIPLabel.Location = new System.Drawing.Point(20, 66);
            this.UserIPLabel.Name = "UserIPLabel";
            this.UserIPLabel.Size = new System.Drawing.Size(42, 14);
            this.UserIPLabel.TabIndex = 16;
            this.UserIPLabel.Text = "UserIP";
            // 
            // Connect
            // 
            this.Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect.Image = global::CnC.Properties.Resources.Connection_Submit;
            this.Connect.Location = new System.Drawing.Point(233, 129);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(32, 32);
            this.Connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Connect.TabIndex = 18;
            this.Connect.TabStop = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            this.Connect.MouseEnter += new System.EventHandler(this.Connect_MouseEnter);
            this.Connect.MouseLeave += new System.EventHandler(this.Connect_MouseLeave);
            // 
            // UserIP
            // 
            this.UserIP.DataSource = this.streamingIPsBindingSource;
            this.UserIP.DisplayMember = "User";
            this.UserIP.FormattingEnabled = true;
            this.UserIP.Location = new System.Drawing.Point(65, 63);
            this.UserIP.Name = "UserIP";
            this.UserIP.Size = new System.Drawing.Size(200, 21);
            this.UserIP.TabIndex = 19;
            this.UserIP.ValueMember = "User";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Visible = false;
            // 
            // Streaming_Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.UserIP);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.UserIPLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Divider_Down);
            this.Controls.Add(this.Divider_Right);
            this.Controls.Add(this.Divider_Left);
            this.Controls.Add(this.Panel_Closing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Streaming_Choose";
            this.Text = "Streaming_Choose";
            this.Load += new System.EventHandler(this.Streaming_Choose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            this.Panel_Closing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.Panel Panel_Closing;
        private System.Windows.Forms.Panel Divider_Left;
        private System.Windows.Forms.Panel Divider_Right;
        private System.Windows.Forms.Panel Divider_Down;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label UserIPLabel;
        private System.Windows.Forms.PictureBox Connect;
        private System.Windows.Forms.ComboBox UserIP;
        private CnCDataSet cnCDataSet;
        private System.Windows.Forms.BindingSource streamingIPsBindingSource;
        private CnCDataSetTableAdapters.Streaming_IPsTableAdapter streaming_IPsTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}