using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnC
{
    public partial class OneMessage : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public OneMessage()
        {
            InitializeComponent();
        }

        private void OneMessage_Load(object sender, EventArgs e)
        {

        }
        private void Panel_Closing_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);

            }
        }

        private void Panel_Closing_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Panel_Closing_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Minimize_btn_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(23, 23);
        }

        private void Minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(24, 24);
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(23, 23);
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(24, 24);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                var Count = (from rows in DataBase.OneTimeMessages
                             select rows).Count();

                OneTimeMessage OneMessages = new OneTimeMessage();
                OneMessages.ID = Count + 1;
                OneMessages.Message = Messages.Text;
                OneMessages.UserID = UserID.Text;
                DataBase.OneTimeMessages.InsertOnSubmit(OneMessages);
                DataBase.SubmitChanges();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
