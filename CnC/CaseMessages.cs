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
    public partial class CaseMessages : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public CaseMessages()
        {
            InitializeComponent();
        }

        private void CaseMessage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnCDataSet.Streaming_IPs' table. You can move, or remove it, as needed.
            this.streaming_IPsTableAdapter.Fill(this.cnCDataSet.Streaming_IPs);

        }
        private void Panel_Closing_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);

            }
        }

        private void Panel_Closing_MouseLeave(object sender, EventArgs e)
        {

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

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();

                CaseMessage InsertData = new CaseMessage();
                var Count = (from rows in DataBase.CaseMessages
                             select rows).AsEnumerable().LastOrDefault();
                InsertData.Field = Field.Text;
                InsertData.ID = Count.ID + 1;
                InsertData.Operator = Operator.Text;
                InsertData.UserID = UserID.Text;
                InsertData.Message = TheText.Text;
                InsertData.Value = Value.Text;
                DataBase.CaseMessages.InsertOnSubmit(InsertData);
                DataBase.SubmitChanges();
                MessageBox.Show("Succesfull");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_Closing_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
