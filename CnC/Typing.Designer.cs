namespace CnC
{
    partial class Typing
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
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.streamingIPsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnCDataSet = new CnC.CnCDataSet();
            this.TextLabel = new System.Windows.Forms.Label();
            this.TheText = new System.Windows.Forms.TextBox();
            this.streaming_IPsTableAdapter = new CnC.CnCDataSetTableAdapters.Streaming_IPsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            this.Panel_Closing.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ValuePanel.SuspendLayout();
            this.OperatorPanel.SuspendLayout();
            this.PanelField.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.Image = global::CnC.Properties.Resources.Minimize_Main;
            this.Minimize_btn.Location = new System.Drawing.Point(675, 10);
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
            this.Close_btn.Location = new System.Drawing.Point(702, 10);
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
            this.Panel_Closing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Closing.Controls.Add(this.Minimize_btn);
            this.Panel_Closing.Controls.Add(this.Close_btn);
            this.Panel_Closing.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel_Closing.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Closing.Location = new System.Drawing.Point(0, 0);
            this.Panel_Closing.Name = "Panel_Closing";
            this.Panel_Closing.Size = new System.Drawing.Size(737, 42);
            this.Panel_Closing.TabIndex = 9;
            this.Panel_Closing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseDown);
            this.Panel_Closing.MouseLeave += new System.EventHandler(this.Panel_Closing_MouseLeave);
            this.Panel_Closing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseMove);
            this.Panel_Closing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.Value);
            this.panel1.Controls.Add(this.SubmitBtn);
            this.panel1.Controls.Add(this.Operator);
            this.panel1.Controls.Add(this.Field);
            this.panel1.Controls.Add(this.ValuePanel);
            this.panel1.Controls.Add(this.OperatorPanel);
            this.panel1.Controls.Add(this.PanelField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 120);
            this.panel1.TabIndex = 10;
            // 
            // Value
            // 
            this.Value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Value.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(390, 87);
            this.Value.Multiline = true;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(172, 20);
            this.Value.TabIndex = 21;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(191)))));
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
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
            this.Operator.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Field.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ValuePanel.BackColor = System.Drawing.Color.Gray;
            this.ValuePanel.Controls.Add(this.ValueLabel);
            this.ValuePanel.Location = new System.Drawing.Point(387, 36);
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
            this.OperatorPanel.BackColor = System.Drawing.Color.Gray;
            this.OperatorPanel.Controls.Add(this.OperatorLabel);
            this.OperatorPanel.Location = new System.Drawing.Point(194, 36);
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
            // 
            // PanelField
            // 
            this.PanelField.BackColor = System.Drawing.Color.Gray;
            this.PanelField.Controls.Add(this.FieldLabel);
            this.PanelField.Location = new System.Drawing.Point(1, 36);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.ConditionLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 36);
            this.panel2.TabIndex = 0;
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
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLabel.Location = new System.Drawing.Point(6, 55);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(44, 14);
            this.UserIDLabel.TabIndex = 11;
            this.UserIDLabel.Text = "UserID";
            // 
            // UserID
            // 
            this.UserID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streamingIPsBindingSource, "User", true));
            this.UserID.DataSource = this.streamingIPsBindingSource;
            this.UserID.DisplayMember = "User";
            this.UserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserID.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(47, 52);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(121, 21);
            this.UserID.TabIndex = 12;
            this.UserID.ValueMember = "User";
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
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.Location = new System.Drawing.Point(185, 55);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(28, 14);
            this.TextLabel.TabIndex = 13;
            this.TextLabel.Text = "Text";
            // 
            // TheText
            // 
            this.TheText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TheText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheText.Location = new System.Drawing.Point(226, 52);
            this.TheText.Multiline = true;
            this.TheText.Name = "TheText";
            this.TheText.Size = new System.Drawing.Size(499, 59);
            this.TheText.TabIndex = 14;
            // 
            // streaming_IPsTableAdapter
            // 
            this.streaming_IPsTableAdapter.ClearBeforeFill = true;
            // 
            // Typing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 249);
            this.Controls.Add(this.TheText);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Closing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Typing";
            this.Text = "Typing";
            this.Load += new System.EventHandler(this.Typing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            this.Panel_Closing.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.Panel Panel_Closing;
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
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox TheText;
        private CnCDataSet cnCDataSet;
        private System.Windows.Forms.BindingSource streamingIPsBindingSource;
        private CnCDataSetTableAdapters.Streaming_IPsTableAdapter streaming_IPsTableAdapter;
    }
}