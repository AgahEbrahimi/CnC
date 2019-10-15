namespace CnC
{
    partial class System_Closing
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.streamingIPsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnCDataSet = new CnC.CnCDataSet();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Value = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Operator = new System.Windows.Forms.ComboBox();
            this.Field = new System.Windows.Forms.ComboBox();
            this.ValuePanel = new System.Windows.Forms.Panel();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.OperatorPanel = new System.Windows.Forms.Panel();
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.PanelField = new System.Windows.Forms.Panel();
            this.FieldLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.streaming_IPsTableAdapter = new CnC.CnCDataSetTableAdapters.Streaming_IPsTableAdapter();
            this.MouseClickPanel = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.ComboBox();
            this.Command = new System.Windows.Forms.ComboBox();
            this.PressTypeLabel = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Minimize_btn = new System.Windows.Forms.PictureBox();
            this.Panel_Closing = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.ValuePanel.SuspendLayout();
            this.OperatorPanel.SuspendLayout();
            this.PanelField.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MouseClickPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            this.Panel_Closing.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(26, 57);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(32, 14);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "User";
            // 
            // streamingIPsBindingSource
            // 
            this.streamingIPsBindingSource.DataMember = "Streaming_IPs";
            this.streamingIPsBindingSource.DataSource = this.cnCDataSet;
            // 
            // cnCDataSet
            // 
            this.cnCDataSet.DataSetName = "CnCDataSet";
            this.cnCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.ForeColor = System.Drawing.Color.White;
            this.ConditionLabel.Location = new System.Drawing.Point(7, 11);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(68, 18);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.Value);
            this.panel1.Controls.Add(this.SubmitBtn);
            this.panel1.Controls.Add(this.Operator);
            this.panel1.Controls.Add(this.Field);
            this.panel1.Controls.Add(this.ValuePanel);
            this.panel1.Controls.Add(this.OperatorPanel);
            this.panel1.Controls.Add(this.PanelField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 120);
            this.panel1.TabIndex = 22;
            // 
            // Value
            // 
            this.Value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Value.Location = new System.Drawing.Point(390, 87);
            this.Value.Multiline = true;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(172, 20);
            this.Value.TabIndex = 21;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(191)))));
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(191)))));
            this.SubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(200)))));
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SubmitBtn.Location = new System.Drawing.Point(599, 39);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(95, 41);
            this.SubmitBtn.TabIndex = 27;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Operator
            // 
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "Contains",
            "Does Not Contain",
            "Equal To",
            "Greater Than",
            "Starts With"});
            this.Operator.Location = new System.Drawing.Point(196, 86);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(172, 21);
            this.Operator.TabIndex = 25;
            // 
            // Field
            // 
            this.Field.FormattingEnabled = true;
            this.Field.Items.AddRange(new object[] {
            "Computer",
            "Executable",
            "Title Bar"});
            this.Field.Location = new System.Drawing.Point(2, 86);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(172, 21);
            this.Field.TabIndex = 11;
            // 
            // ValuePanel
            // 
            this.ValuePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(106)))));
            this.ValuePanel.Controls.Add(this.ValueLabel);
            this.ValuePanel.Location = new System.Drawing.Point(390, 36);
            this.ValuePanel.Name = "ValuePanel";
            this.ValuePanel.Size = new System.Drawing.Size(192, 41);
            this.ValuePanel.TabIndex = 23;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.ForeColor = System.Drawing.Color.White;
            this.ValueLabel.Location = new System.Drawing.Point(4, 13);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(45, 19);
            this.ValueLabel.TabIndex = 24;
            this.ValueLabel.Text = "Value";
            // 
            // OperatorPanel
            // 
            this.OperatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(106)))));
            this.OperatorPanel.Controls.Add(this.OperatorLabel);
            this.OperatorPanel.Location = new System.Drawing.Point(196, 36);
            this.OperatorPanel.Name = "OperatorPanel";
            this.OperatorPanel.Size = new System.Drawing.Size(192, 41);
            this.OperatorPanel.TabIndex = 22;
            // 
            // OperatorLabel
            // 
            this.OperatorLabel.AutoSize = true;
            this.OperatorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorLabel.ForeColor = System.Drawing.Color.White;
            this.OperatorLabel.Location = new System.Drawing.Point(4, 13);
            this.OperatorLabel.Name = "OperatorLabel";
            this.OperatorLabel.Size = new System.Drawing.Size(67, 19);
            this.OperatorLabel.TabIndex = 24;
            this.OperatorLabel.Text = "Operator";
            this.OperatorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseDown);
            this.OperatorLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseMove);
            this.OperatorLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseUp);
            // 
            // PanelField
            // 
            this.PanelField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(106)))));
            this.PanelField.Controls.Add(this.FieldLabel);
            this.PanelField.Location = new System.Drawing.Point(2, 36);
            this.PanelField.Name = "PanelField";
            this.PanelField.Size = new System.Drawing.Size(192, 41);
            this.PanelField.TabIndex = 21;
            // 
            // FieldLabel
            // 
            this.FieldLabel.AutoSize = true;
            this.FieldLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldLabel.ForeColor = System.Drawing.Color.White;
            this.FieldLabel.Location = new System.Drawing.Point(2, 13);
            this.FieldLabel.Name = "FieldLabel";
            this.FieldLabel.Size = new System.Drawing.Size(40, 19);
            this.FieldLabel.TabIndex = 23;
            this.FieldLabel.Text = "Field";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.ConditionLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 36);
            this.panel2.TabIndex = 0;
            // 
            // streaming_IPsTableAdapter
            // 
            this.streaming_IPsTableAdapter.ClearBeforeFill = true;
            // 
            // MouseClickPanel
            // 
            this.MouseClickPanel.Controls.Add(this.User);
            this.MouseClickPanel.Controls.Add(this.Command);
            this.MouseClickPanel.Controls.Add(this.PressTypeLabel);
            this.MouseClickPanel.Controls.Add(this.UserLabel);
            this.MouseClickPanel.Location = new System.Drawing.Point(4, 46);
            this.MouseClickPanel.Name = "MouseClickPanel";
            this.MouseClickPanel.Size = new System.Drawing.Size(728, 98);
            this.MouseClickPanel.TabIndex = 24;
            // 
            // User
            // 
            this.User.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streamingIPsBindingSource, "User", true));
            this.User.DataSource = this.streamingIPsBindingSource;
            this.User.DisplayMember = "User";
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.FormattingEnabled = true;
            this.User.Location = new System.Drawing.Point(75, 56);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(166, 21);
            this.User.TabIndex = 18;
            this.User.ValueMember = "User";
            // 
            // Command
            // 
            this.Command.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Command.FormattingEnabled = true;
            this.Command.Items.AddRange(new object[] {
            "ShutDown",
            "Restart",
            "Logoff",
            "Sleep"});
            this.Command.Location = new System.Drawing.Point(75, 22);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(166, 21);
            this.Command.TabIndex = 13;
            // 
            // PressTypeLabel
            // 
            this.PressTypeLabel.AutoSize = true;
            this.PressTypeLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressTypeLabel.ForeColor = System.Drawing.Color.White;
            this.PressTypeLabel.Location = new System.Drawing.Point(12, 24);
            this.PressTypeLabel.Name = "PressTypeLabel";
            this.PressTypeLabel.Size = new System.Drawing.Size(61, 14);
            this.PressTypeLabel.TabIndex = 10;
            this.PressTypeLabel.Text = "Command";
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.Image = global::CnC.Properties.Resources.Close_Main;
            this.Close_btn.Location = new System.Drawing.Point(704, 9);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(24, 24);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_btn.TabIndex = 0;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.Close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.Close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.Image = global::CnC.Properties.Resources.Minimize_Main;
            this.Minimize_btn.Location = new System.Drawing.Point(677, 9);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(24, 24);
            this.Minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize_btn.TabIndex = 8;
            this.Minimize_btn.TabStop = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            this.Minimize_btn.MouseEnter += new System.EventHandler(this.Minimize_btn_MouseEnter);
            this.Minimize_btn.MouseLeave += new System.EventHandler(this.Minimize_btn_MouseLeave);
            // 
            // Panel_Closing
            // 
            this.Panel_Closing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Panel_Closing.Controls.Add(this.Minimize_btn);
            this.Panel_Closing.Controls.Add(this.Close_btn);
            this.Panel_Closing.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel_Closing.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Closing.Location = new System.Drawing.Point(0, 0);
            this.Panel_Closing.Name = "Panel_Closing";
            this.Panel_Closing.Size = new System.Drawing.Size(738, 42);
            this.Panel_Closing.TabIndex = 23;
            this.Panel_Closing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseDown);
            this.Panel_Closing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseMove);
            this.Panel_Closing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseUp);
            // 
            // System_Closing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(35)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(738, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MouseClickPanel);
            this.Controls.Add(this.Panel_Closing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "System_Closing";
            this.Text = "System_Closing";
            this.Load += new System.EventHandler(this.System_Closing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ValuePanel.ResumeLayout(false);
            this.ValuePanel.PerformLayout();
            this.OperatorPanel.ResumeLayout(false);
            this.OperatorPanel.PerformLayout();
            this.PanelField.ResumeLayout(false);
            this.PanelField.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MouseClickPanel.ResumeLayout(false);
            this.MouseClickPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            this.Panel_Closing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.BindingSource streamingIPsBindingSource;
        private CnCDataSet cnCDataSet;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.ComboBox Field;
        private System.Windows.Forms.Panel ValuePanel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Panel OperatorPanel;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.Panel PanelField;
        private System.Windows.Forms.Label FieldLabel;
        private System.Windows.Forms.Panel panel2;
        private CnCDataSetTableAdapters.Streaming_IPsTableAdapter streaming_IPsTableAdapter;
        private System.Windows.Forms.Panel MouseClickPanel;
        private System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.ComboBox Command;
        private System.Windows.Forms.Label PressTypeLabel;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.Panel Panel_Closing;
    }
}