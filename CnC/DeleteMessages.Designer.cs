﻿namespace CnC
{
    partial class DeleteMessages
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Closing = new System.Windows.Forms.Panel();
            this.Minimize_btn = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Table_Messages = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Panel_Closing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Messages)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Closing
            // 
            this.Panel_Closing.BackColor = System.Drawing.Color.Firebrick;
            this.Panel_Closing.Controls.Add(this.Minimize_btn);
            this.Panel_Closing.Controls.Add(this.Close_btn);
            this.Panel_Closing.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel_Closing.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Closing.Location = new System.Drawing.Point(0, 0);
            this.Panel_Closing.Name = "Panel_Closing";
            this.Panel_Closing.Size = new System.Drawing.Size(855, 42);
            this.Panel_Closing.TabIndex = 16;
            this.Panel_Closing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseDown);
            this.Panel_Closing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseMove);
            this.Panel_Closing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Closing_MouseUp);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.Image = global::CnC.Properties.Resources.Minimize_Main;
            this.Minimize_btn.Location = new System.Drawing.Point(793, 10);
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
            this.Close_btn.Location = new System.Drawing.Point(820, 10);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(24, 24);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_btn.TabIndex = 0;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.Close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.Close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // Table_Messages
            // 
            this.Table_Messages.AllowUserToAddRows = false;
            this.Table_Messages.AllowUserToDeleteRows = false;
            this.Table_Messages.AllowUserToOrderColumns = true;
            this.Table_Messages.BackgroundColor = System.Drawing.Color.IndianRed;
            this.Table_Messages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table_Messages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Table_Messages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Table_Messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_Messages.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table_Messages.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Table_Messages.EnableHeadersVisualStyles = false;
            this.Table_Messages.GridColor = System.Drawing.Color.LightCyan;
            this.Table_Messages.Location = new System.Drawing.Point(11, 51);
            this.Table_Messages.Name = "Table_Messages";
            this.Table_Messages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Table_Messages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table_Messages.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Table_Messages.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.Table_Messages.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Table_Messages.Size = new System.Drawing.Size(726, 319);
            this.Table_Messages.TabIndex = 17;
            this.Table_Messages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Pics_CellContentClick);
            this.Table_Messages.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Table_Messages_ColumnHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 321);
            this.panel1.TabIndex = 18;
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
            this.SubmitBtn.Location = new System.Drawing.Point(748, 329);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(95, 41);
            this.SubmitBtn.TabIndex = 28;
            this.SubmitBtn.Text = "Delete";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // DeleteMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(855, 382);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Table_Messages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Closing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteMessages";
            this.Text = "IndianRed";
            this.Load += new System.EventHandler(this.DeleteMessages_Load);
            this.Panel_Closing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Messages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Closing;
        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.DataGridView Table_Messages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SubmitBtn;
    }
}