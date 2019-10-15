using CnC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnC
{
    public partial class ScreenShot_Form : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public ScreenShot_Form()
        {
            InitializeComponent();
        }

        private void ScreenShot_Form_Load(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var Data = from rows in DataBase.Screen_Shots
                       select rows;
            Table_Pics.DataSource = Data;
            Table_Pics.AutoResizeRows();
            Table_Pics.AutoResizeColumns();
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

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void ClockChoose_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(29, 29);
        }

        private void ClockChoose_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(30, 30);
        }

        private void WarningChoose_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(29, 29);
        }

        private void WarningChoose_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(30, 30);
        }

        private void WatchChoose_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(29, 29);
        }

        private void WatchChoose_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(30, 30);
        }

        private void Submit_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(34, 34);
        }

        private void Submit_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Submit_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(35, 35);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var Count_Table = from rows in DataBase.ScreenShot_Actions
                              select rows;
            ScreenShot_Action ActionDataTable = new ScreenShot_Action();
            try
            {
                ActionDataTable.From = FromHour.Text + ":" + FromMinute.Text;
                ActionDataTable.Until = UntilHour.Text + ":" + FromMinute.Text;
                ActionDataTable.Frameinsecond =Int32.Parse(FPSPicker.Text);
                ActionDataTable.ID = Count_Table.Count() + 1;
                ActionDataTable.Date = DateTimePicker.Value.ToString();
                ActionDataTable.UserID = UserIDCombo.Text;
                DataBase.ScreenShot_Actions.InsertOnSubmit(ActionDataTable);
                DataBase.SubmitChanges();
                MessageBox.Show("Submission was succesfull");
            }
            catch (Exception)
            {

                MessageBox.Show("Action cant be done");
            }
            
        }

        private void WarningChoose_Click(object sender, EventArgs e)
        {
            PanelWarning.Visible = true;
            PanelTimeScreenShot.Visible = false;
            Panel_See.Visible = false;
        }

        private void ClockChoose_Click(object sender, EventArgs e)
        {
            PanelWarning.Visible = false;
            PanelTimeScreenShot.Visible = true;
            Panel_See.Visible = false;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var Count_Table = from rows in DataBase.Warning_ScreenShots
                              select rows;
            Warning_ScreenShot ActionDataTable = new Warning_ScreenShot();
            try
            {
                ActionDataTable.DateSubmited = UntilDatePicker.Value.ToString();
                ActionDataTable.Description = Description.Text;
                ActionDataTable.FrameInSecond = Every.Text;
                ActionDataTable.ID = Count_Table.Count() + 1;
                ActionDataTable.StatementAction = StatementType.Text;
                ActionDataTable.StatementItself = StatementItself.Text;
                ActionDataTable.StatementWay = Statement.Text;
                ActionDataTable.UserIDs = UserID.Text;
                DataBase.Warning_ScreenShots.InsertOnSubmit(ActionDataTable);
                DataBase.SubmitChanges();
                MessageBox.Show("Submission was succesfull");
            }
            catch (Exception)
            {

                MessageBox.Show("Action cant be done");
            }
            
        }

        private void Statement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBtn_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(34, 34);
        }

        private void CheckBtn_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(35, 35);
        }

        private void WatchChoose_Click(object sender, EventArgs e)
        {
            PanelWarning.Visible = false;
            PanelTimeScreenShot.Visible = false;
            Panel_See.Visible = true;
            Table_Pics.AutoResizeRows();
            Table_Pics.AutoResizeColumns();
        }

        private void Table_Pics_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Table_Pics.AutoResizeRows();
            Table_Pics.AutoResizeColumns();
        }

        private void Table_Pics_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Table_Pics.AutoResizeRows();
            Table_Pics.AutoResizeColumns();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var rowindex = Table_Pics.CurrentCell.RowIndex;
            var ScreenShot_ID = Table_Pics.Rows[rowindex].Cells[4].Value.ToString();
            var ScreenShot = Table_Pics.Rows[rowindex].Cells[0].Value;
            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                var Data = (from rows in DataBase.Screen_Shots
                            where rows.ID == int.Parse(ScreenShot_ID)
                            select rows).FirstOrDefault();
                byte[] MyData = new byte[0];
                MyData = (Data.Screenshot).ToArray();
                MemoryStream stream = new MemoryStream(MyData);
                pictureBox1.Image = Image.FromStream(stream);
                SaveFileDialog sfd = new SaveFileDialog();

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = sfd.FileName;
                    pictureBox1.Image.Save(path, ImageFormat.Jpeg);
                    

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*byte[] img = null;
            FileStream fs = new FileStream(@"C:\Users\Public\Pictures\Sample Pictures\Chrysanthemum.jpg", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Screen_Shot asd = new Screen_Shot();
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            asd.Screenshot = img;
            asd.ID = 3;
            DataBase.Screen_Shots.InsertOnSubmit(asd);
            DataBase.SubmitChanges();
            */
        }

        private void Download_Pic_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(31, 31);
        }

        private void Download_Pic_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(32, 32);
        }
    }
}
