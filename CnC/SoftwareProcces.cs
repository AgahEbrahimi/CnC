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
    public partial class SoftwareProcces : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public SoftwareProcces()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                var Count = (from rows in DataBase.DemandProcces
                             select rows).Count();
                DemandProcce Process = new DemandProcce();
                Process.Date = dateTimePicker1.Value.ToString();
                Process.Field = Field.Text;
                Process.ID = Count + 1;
                Process.Operator = Operator.Text;
                Process.Program_Document = DocumentName.Text;
                Process.UserID = UserID.Text;
                DataBase.DemandProcces.InsertOnSubmit(Process);
                DataBase.SubmitChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            

        }

        private void SoftwareProcces_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnCDataSet.Streaming_IPs' table. You can move, or remove it, as needed.
            this.streaming_IPsTableAdapter.Fill(this.cnCDataSet.Streaming_IPs);

        }

        private void Panel_Closing_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Panel_Closing_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Panel_Closing_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);

            }
            
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

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
