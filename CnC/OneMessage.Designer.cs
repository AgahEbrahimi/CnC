namespace CnC
{
    partial class OneMessage
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.Messages = new System.Windows.Forms.TextBox();
            this.MeLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.Panel_Closing = new System.Windows.Forms.Panel();
            this.Minimize_btn = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Panel_Closing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            this.SuspendLayout();
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
            this.SubmitBtn.Location = new System.Drawing.Point(426, 97);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(84, 34);
            this.SubmitBtn.TabIndex = 40;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // UserID
            // 
            this.UserID.DisplayMember = "User";
            this.UserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(67, 105);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(152, 22);
            this.UserID.TabIndex = 39;
            this.UserID.ValueMember = "User";
            // 
            // Messages
            // 
            this.Messages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Messages.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages.Location = new System.Drawing.Point(67, 58);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(443, 33);
            this.Messages.TabIndex = 38;
            // 
            // MeLabel
            // 
            this.MeLabel.AutoSize = true;
            this.MeLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeLabel.ForeColor = System.Drawing.Color.Black;
            this.MeLabel.Location = new System.Drawing.Point(2, 59);
            this.MeLabel.Name = "MeLabel";
            this.MeLabel.Size = new System.Drawing.Size(62, 14);
            this.MeLabel.TabIndex = 37;
            this.MeLabel.Text = "Messages";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLabel.ForeColor = System.Drawing.Color.Black;
            this.UserIDLabel.Location = new System.Drawing.Point(11, 109);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(44, 14);
            this.UserIDLabel.TabIndex = 36;
            this.UserIDLabel.Text = "UserID";
            // 
            // Panel_Closing
            // 
            this.Panel_Closing.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Panel_Closing.Controls.Add(this.Minimize_btn);
            this.Panel_Closing.Controls.Add(this.Close_btn);
            this.Panel_Closing.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel_Closing.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Closing.Location = new System.Drawing.Point(0, 0);
            this.Panel_Closing.Name = "Panel_Closing";
            this.Panel_Closing.Size = new System.Drawing.Size(522, 42);
            this.Panel_Closing.TabIndex = 35;
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
            // OneMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 133);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.MeLabel);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.Panel_Closing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneMessage";
            this.Text = "OneMessage";
            this.Load += new System.EventHandler(this.OneMessage_Load);
            this.Panel_Closing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.TextBox Messages;
        private System.Windows.Forms.Label MeLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Panel Panel_Closing;
        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.PictureBox Close_btn;
    }
}