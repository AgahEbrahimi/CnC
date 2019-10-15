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
    public partial class MouseClick : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        string WhichForm = "MouseClick";
        public MouseClick()
        {
            InitializeComponent();
        }

        private void MouseClickPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MouseClick_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnCDataSet.Streaming_IPs' table. You can move, or remove it, as needed.
            this.streaming_IPsTableAdapter.Fill(this.cnCDataSet.Streaming_IPs);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel_Closing_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
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

                if (WhichForm == "MouseClick")
                {
                    MouseClickDemand MouseClickDatabase = new MouseClickDemand();
                    var Count = (from rows in DataBase.MouseClickDemands
                                 select rows).Count();
                    MouseClickDatabase.Action = "Mouse Click";
                    MouseClickDatabase.Button = Button.Text;
                    MouseClickDatabase.DateEnd = EndDate.Value.ToString();
                    MouseClickDatabase.DateStart = StartDate.Value.ToString();
                    MouseClickDatabase.Field = Field.Text;
                    MouseClickDatabase.ID = Count+1;
                    MouseClickDatabase.Operator = Operator.Text;
                    MouseClickDatabase.presstype = PressType.Text;
                    MouseClickDatabase.UserID = User.Text;
                    MouseClickDatabase.Value = Value.Text;
                    MouseClickDatabase.X = Int32.Parse(XTB.Text);
                    MouseClickDatabase.Y = Int32.Parse(YTB.Text);
                    DataBase.MouseClickDemands.InsertOnSubmit(MouseClickDatabase);
                    DataBase.SubmitChanges();
                }
                if (WhichForm == "MouseMove")
                {
                    MouseMoveDemand MouseMoveD = new MouseMoveDemand();
                    var Count = (from rows in DataBase.MouseMoveDemands
                                 select rows).Count();
                    MouseMoveD.EndDate = EndDate1.Value.ToString();
                    MouseMoveD.Field = Field.Text;
                    MouseMoveD.ID = Count+1;
                    MouseMoveD.Operator = Operator.Text;
                    MouseMoveD.StartDate = StartDate1.Text;
                    MouseMoveD.UserID = UserID.Text;
                    MouseMoveD.Value = Value.Text;
                    MouseMoveD.X =int.Parse(XText.Text);
                    MouseMoveD.Y =int.Parse(YText.Text);
                    DataBase.MouseMoveDemands.InsertOnSubmit(MouseMoveD);
                    DataBase.SubmitChanges();



                }

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void MouseClickPanelLogo_Click(object sender, EventArgs e)
        {
            MouseClickPanel.Visible = true;
            WhichForm = "MouseClick";
            MouseMovePanel.Visible = false;
        }

        private void MoveMousePanelLogo_Click(object sender, EventArgs e)
        {
            MouseClickPanel.Visible = false;
            WhichForm = "MouseMove";
            MouseMovePanel.Visible = true;
        }

        private void MouseClickPanelLogo_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(29, 29);
        }

        private void MouseClickPanelLogo_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(30, 30);
        }

        private void MoveMousePanelLogo_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(29, 29);
        }

        private void MoveMousePanelLogo_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(30, 30);
        }
    }
}
