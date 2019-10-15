namespace CnC
{
    partial class MouseClick
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
            this.Panel_Closing = new System.Windows.Forms.Panel();
            this.Minimize_btn = new System.Windows.Forms.PictureBox();
            this.MouseClickPanelLogo = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.MoveMousePanelLogo = new System.Windows.Forms.PictureBox();
            this.MouseClickPanel = new System.Windows.Forms.Panel();
            this.MouseMovePanel = new System.Windows.Forms.Panel();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.EndDate1 = new System.Windows.Forms.DateTimePicker();
            this.StartDate1 = new System.Windows.Forms.DateTimePicker();
            this.YText = new System.Windows.Forms.TextBox();
            this.XText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.X1Label = new System.Windows.Forms.Label();
            this.StartDate2label = new System.Windows.Forms.Label();
            this.Y2Label = new System.Windows.Forms.Label();
            this.EndDate1Label = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.ComboBox();
            this.streamingIPsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnCDataSet = new CnC.CnCDataSet();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.YTB = new System.Windows.Forms.TextBox();
            this.XTB = new System.Windows.Forms.TextBox();
            this.PressType = new System.Windows.Forms.ComboBox();
            this.Button = new System.Windows.Forms.ComboBox();
            this.PressTypeLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.ButtonLabel = new System.Windows.Forms.Label();
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
            this.streaming_IPsTableAdapter = new CnC.CnCDataSetTableAdapters.Streaming_IPsTableAdapter();
            this.Panel_Closing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouseClickPanelLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveMousePanelLogo)).BeginInit();
            this.MouseClickPanel.SuspendLayout();
            this.MouseMovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamingIPsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.ValuePanel.SuspendLayout();
            this.OperatorPanel.SuspendLayout();
            this.PanelField.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Closing
            // 
            this.Panel_Closing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(41)))));
            this.Panel_Closing.Controls.Add(this.Minimize_btn);
            this.Panel_Closing.Controls.Add(this.MouseClickPanelLogo);
            this.Panel_Closing.Controls.Add(this.Close_btn);
            this.Panel_Closing.Controls.Add(this.MoveMousePanelLogo);
            this.Panel_Closing.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel_Closing.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Closing.Location = new System.Drawing.Point(0, 0);
            this.Panel_Closing.Name = "Panel_Closing";
            this.Panel_Closing.Size = new System.Drawing.Size(738, 42);
            this.Panel_Closing.TabIndex = 9;
            this.Panel_Closing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseDown);
            this.Panel_Closing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseMove);
            this.Panel_Closing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseUp);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(41)))));
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
            // MouseClickPanelLogo
            // 
            this.MouseClickPanelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MouseClickPanelLogo.Image = global::CnC.Properties.Resources.MouseClick_Logo;
            this.MouseClickPanelLogo.Location = new System.Drawing.Point(7, 6);
            this.MouseClickPanelLogo.Name = "MouseClickPanelLogo";
            this.MouseClickPanelLogo.Size = new System.Drawing.Size(30, 30);
            this.MouseClickPanelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MouseClickPanelLogo.TabIndex = 21;
            this.MouseClickPanelLogo.TabStop = false;
            this.MouseClickPanelLogo.Click += new System.EventHandler(this.MouseClickPanelLogo_Click);
            this.MouseClickPanelLogo.MouseEnter += new System.EventHandler(this.MouseClickPanelLogo_MouseEnter);
            this.MouseClickPanelLogo.MouseLeave += new System.EventHandler(this.MouseClickPanelLogo_MouseLeave);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(41)))));
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
            // MoveMousePanelLogo
            // 
            this.MoveMousePanelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveMousePanelLogo.Image = global::CnC.Properties.Resources.MouseMove_Logo;
            this.MoveMousePanelLogo.Location = new System.Drawing.Point(43, 6);
            this.MoveMousePanelLogo.Name = "MoveMousePanelLogo";
            this.MoveMousePanelLogo.Size = new System.Drawing.Size(30, 30);
            this.MoveMousePanelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoveMousePanelLogo.TabIndex = 20;
            this.MoveMousePanelLogo.TabStop = false;
            this.MoveMousePanelLogo.Click += new System.EventHandler(this.MoveMousePanelLogo_Click);
            this.MoveMousePanelLogo.MouseEnter += new System.EventHandler(this.MoveMousePanelLogo_MouseEnter);
            this.MoveMousePanelLogo.MouseLeave += new System.EventHandler(this.MoveMousePanelLogo_MouseLeave);
            // 
            // MouseClickPanel
            // 
            this.MouseClickPanel.Controls.Add(this.EndDateLabel);
            this.MouseClickPanel.Controls.Add(this.User);
            this.MouseClickPanel.Controls.Add(this.StartDate);
            this.MouseClickPanel.Controls.Add(this.EndDate);
            this.MouseClickPanel.Controls.Add(this.YTB);
            this.MouseClickPanel.Controls.Add(this.XTB);
            this.MouseClickPanel.Controls.Add(this.PressType);
            this.MouseClickPanel.Controls.Add(this.Button);
            this.MouseClickPanel.Controls.Add(this.PressTypeLabel);
            this.MouseClickPanel.Controls.Add(this.XLabel);
            this.MouseClickPanel.Controls.Add(this.StartDateLabel);
            this.MouseClickPanel.Controls.Add(this.UserLabel);
            this.MouseClickPanel.Controls.Add(this.YLabel);
            this.MouseClickPanel.Controls.Add(this.ButtonLabel);
            this.MouseClickPanel.Location = new System.Drawing.Point(7, 48);
            this.MouseClickPanel.Name = "MouseClickPanel";
            this.MouseClickPanel.Size = new System.Drawing.Size(728, 219);
            this.MouseClickPanel.TabIndex = 10;
            this.MouseClickPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MouseClickPanel_Paint);
            // 
            // MouseMovePanel
            // 
            this.MouseMovePanel.Controls.Add(this.UserID);
            this.MouseMovePanel.Controls.Add(this.EndDate1);
            this.MouseMovePanel.Controls.Add(this.StartDate1);
            this.MouseMovePanel.Controls.Add(this.YText);
            this.MouseMovePanel.Controls.Add(this.XText);
            this.MouseMovePanel.Controls.Add(this.pictureBox1);
            this.MouseMovePanel.Controls.Add(this.UserIDLabel);
            this.MouseMovePanel.Controls.Add(this.X1Label);
            this.MouseMovePanel.Controls.Add(this.StartDate2label);
            this.MouseMovePanel.Controls.Add(this.Y2Label);
            this.MouseMovePanel.Controls.Add(this.EndDate1Label);
            this.MouseMovePanel.Location = new System.Drawing.Point(0, 42);
            this.MouseMovePanel.Name = "MouseMovePanel";
            this.MouseMovePanel.Size = new System.Drawing.Size(755, 225);
            this.MouseMovePanel.TabIndex = 21;
            this.MouseMovePanel.Visible = false;
            // 
            // UserID
            // 
            this.UserID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streamingIPsBindingSource, "User", true));
            this.UserID.DataSource = this.streamingIPsBindingSource;
            this.UserID.DisplayMember = "User";
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(84, 32);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(121, 21);
            this.UserID.TabIndex = 11;
            this.UserID.ValueMember = "User";
            // 
            // EndDate1
            // 
            this.EndDate1.Location = new System.Drawing.Point(353, 122);
            this.EndDate1.Name = "EndDate1";
            this.EndDate1.Size = new System.Drawing.Size(200, 20);
            this.EndDate1.TabIndex = 10;
            // 
            // StartDate1
            // 
            this.StartDate1.Location = new System.Drawing.Point(84, 122);
            this.StartDate1.Name = "StartDate1";
            this.StartDate1.Size = new System.Drawing.Size(200, 20);
            this.StartDate1.TabIndex = 9;
            // 
            // YText
            // 
            this.YText.Location = new System.Drawing.Point(263, 78);
            this.YText.Name = "YText";
            this.YText.Size = new System.Drawing.Size(121, 20);
            this.YText.TabIndex = 8;
            // 
            // XText
            // 
            this.XText.Location = new System.Drawing.Point(84, 78);
            this.XText.Name = "XText";
            this.XText.Size = new System.Drawing.Size(121, 20);
            this.XText.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CnC.Properties.Resources.Mouse_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(571, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLabel.ForeColor = System.Drawing.Color.White;
            this.UserIDLabel.Location = new System.Drawing.Point(34, 35);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(44, 15);
            this.UserIDLabel.TabIndex = 4;
            this.UserIDLabel.Text = "UserID";
            // 
            // X1Label
            // 
            this.X1Label.AutoSize = true;
            this.X1Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1Label.ForeColor = System.Drawing.Color.White;
            this.X1Label.Location = new System.Drawing.Point(47, 81);
            this.X1Label.Name = "X1Label";
            this.X1Label.Size = new System.Drawing.Size(14, 15);
            this.X1Label.TabIndex = 3;
            this.X1Label.Text = "X";
            // 
            // StartDate2label
            // 
            this.StartDate2label.AutoSize = true;
            this.StartDate2label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate2label.ForeColor = System.Drawing.Color.White;
            this.StartDate2label.Location = new System.Drawing.Point(28, 127);
            this.StartDate2label.Name = "StartDate2label";
            this.StartDate2label.Size = new System.Drawing.Size(58, 15);
            this.StartDate2label.TabIndex = 2;
            this.StartDate2label.Text = "StartDate";
            // 
            // Y2Label
            // 
            this.Y2Label.AutoSize = true;
            this.Y2Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y2Label.ForeColor = System.Drawing.Color.White;
            this.Y2Label.Location = new System.Drawing.Point(223, 81);
            this.Y2Label.Name = "Y2Label";
            this.Y2Label.Size = new System.Drawing.Size(13, 15);
            this.Y2Label.TabIndex = 1;
            this.Y2Label.Text = "Y";
            // 
            // EndDate1Label
            // 
            this.EndDate1Label.AutoSize = true;
            this.EndDate1Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate1Label.ForeColor = System.Drawing.Color.White;
            this.EndDate1Label.Location = new System.Drawing.Point(298, 127);
            this.EndDate1Label.Name = "EndDate1Label";
            this.EndDate1Label.Size = new System.Drawing.Size(52, 15);
            this.EndDate1Label.TabIndex = 0;
            this.EndDate1Label.Text = "EndDate";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.ForeColor = System.Drawing.Color.White;
            this.EndDateLabel.Location = new System.Drawing.Point(293, 149);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(53, 14);
            this.EndDateLabel.TabIndex = 20;
            this.EndDateLabel.Text = "EndDate";
            // 
            // User
            // 
            this.User.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streamingIPsBindingSource, "User", true));
            this.User.DataSource = this.streamingIPsBindingSource;
            this.User.DisplayMember = "User";
            this.User.FormattingEnabled = true;
            this.User.Location = new System.Drawing.Point(87, 190);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(166, 21);
            this.User.TabIndex = 18;
            this.User.ValueMember = "User";
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
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(87, 148);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 20);
            this.StartDate.TabIndex = 17;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(352, 148);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 20);
            this.EndDate.TabIndex = 16;
            // 
            // YTB
            // 
            this.YTB.Location = new System.Drawing.Point(269, 106);
            this.YTB.Name = "YTB";
            this.YTB.Size = new System.Drawing.Size(152, 20);
            this.YTB.TabIndex = 15;
            // 
            // XTB
            // 
            this.XTB.Location = new System.Drawing.Point(87, 106);
            this.XTB.Name = "XTB";
            this.XTB.Size = new System.Drawing.Size(152, 20);
            this.XTB.TabIndex = 14;
            // 
            // PressType
            // 
            this.PressType.FormattingEnabled = true;
            this.PressType.Items.AddRange(new object[] {
            "Down",
            "Up",
            "Down+Up",
            "Double Click"});
            this.PressType.Location = new System.Drawing.Point(87, 63);
            this.PressType.Name = "PressType";
            this.PressType.Size = new System.Drawing.Size(152, 21);
            this.PressType.TabIndex = 13;
            this.PressType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Button
            // 
            this.Button.FormattingEnabled = true;
            this.Button.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle",
            "Wheele Scroll"});
            this.Button.Location = new System.Drawing.Point(87, 20);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(152, 21);
            this.Button.TabIndex = 12;
            // 
            // PressTypeLabel
            // 
            this.PressTypeLabel.AutoSize = true;
            this.PressTypeLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressTypeLabel.ForeColor = System.Drawing.Color.White;
            this.PressTypeLabel.Location = new System.Drawing.Point(24, 65);
            this.PressTypeLabel.Name = "PressTypeLabel";
            this.PressTypeLabel.Size = new System.Drawing.Size(60, 14);
            this.PressTypeLabel.TabIndex = 10;
            this.PressTypeLabel.Text = "PressType";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.ForeColor = System.Drawing.Color.White;
            this.XLabel.Location = new System.Drawing.Point(48, 107);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(13, 14);
            this.XLabel.TabIndex = 9;
            this.XLabel.Text = "X";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.ForeColor = System.Drawing.Color.White;
            this.StartDateLabel.Location = new System.Drawing.Point(25, 149);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(58, 14);
            this.StartDateLabel.TabIndex = 8;
            this.StartDateLabel.Text = "StartDate";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(38, 191);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(32, 14);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "User";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.ForeColor = System.Drawing.Color.White;
            this.YLabel.Location = new System.Drawing.Point(250, 107);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(13, 14);
            this.YLabel.TabIndex = 5;
            this.YLabel.Text = "Y";
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.AutoSize = true;
            this.ButtonLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLabel.ForeColor = System.Drawing.Color.White;
            this.ButtonLabel.Location = new System.Drawing.Point(33, 23);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.Size = new System.Drawing.Size(43, 14);
            this.ButtonLabel.TabIndex = 4;
            this.ButtonLabel.Text = "Button";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.Value);
            this.panel1.Controls.Add(this.SubmitBtn);
            this.panel1.Controls.Add(this.Operator);
            this.panel1.Controls.Add(this.Field);
            this.panel1.Controls.Add(this.ValuePanel);
            this.panel1.Controls.Add(this.OperatorPanel);
            this.panel1.Controls.Add(this.PanelField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 120);
            this.panel1.TabIndex = 0;
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
            this.ValuePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
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
            this.OperatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
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
            // 
            // PanelField
            // 
            this.PanelField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
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
            // streaming_IPsTableAdapter
            // 
            this.streaming_IPsTableAdapter.ClearBeforeFill = true;
            // 
            // MouseClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(738, 396);
            this.Controls.Add(this.MouseMovePanel);
            this.Controls.Add(this.MouseClickPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Closing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MouseClick";
            this.Text = "MouseClick";
            this.Load += new System.EventHandler(this.MouseClick_Load);
            this.Panel_Closing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouseClickPanelLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveMousePanelLogo)).EndInit();
            this.MouseClickPanel.ResumeLayout(false);
            this.MouseClickPanel.PerformLayout();
            this.MouseMovePanel.ResumeLayout(false);
            this.MouseMovePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Closing;
        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.PictureBox MouseClickPanelLogo;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.PictureBox MoveMousePanelLogo;
        private System.Windows.Forms.Panel MouseClickPanel;
        private System.Windows.Forms.Label PressTypeLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label ButtonLabel;
        private System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.TextBox YTB;
        private System.Windows.Forms.TextBox XTB;
        private System.Windows.Forms.ComboBox PressType;
        private System.Windows.Forms.ComboBox Button;
        private CnCDataSet cnCDataSet;
        private System.Windows.Forms.BindingSource streamingIPsBindingSource;
        private CnCDataSetTableAdapters.Streaming_IPsTableAdapter streaming_IPsTableAdapter;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Panel ValuePanel;
        private System.Windows.Forms.Panel OperatorPanel;
        private System.Windows.Forms.Panel PanelField;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.ComboBox Field;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.Label FieldLabel;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Panel MouseMovePanel;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.DateTimePicker EndDate1;
        private System.Windows.Forms.DateTimePicker StartDate1;
        private System.Windows.Forms.TextBox YText;
        private System.Windows.Forms.TextBox XText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Label X1Label;
        private System.Windows.Forms.Label StartDate2label;
        private System.Windows.Forms.Label Y2Label;
        private System.Windows.Forms.Label EndDate1Label;
    }
}