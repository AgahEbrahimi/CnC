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
    public partial class DeleteMessages : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public DeleteMessages()
        {
            InitializeComponent();
        }

        private void Table_Pics_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void DeleteMessages_Load(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var Data = from rows in DataBase.CaseMessages
                       select rows;
            Table_Messages.DataSource = Data;
            Table_Messages.AutoResizeRows();
            Table_Messages.AutoResizeColumns();

        }

        private void Table_Messages_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Table_Messages.AutoResizeRows();
            Table_Messages.AutoResizeColumns();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            var rowindex = Table_Messages.CurrentCell.RowIndex;
            var IDTable = Table_Messages.Rows[rowindex].Cells[4].Value.ToString();

            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                var DeleteData = (from rows in DataBase.CaseMessages
                                  where rows.ID == Int32.Parse(IDTable)
                                  select rows).FirstOrDefault();

                DataBase.CaseMessages.DeleteOnSubmit(DeleteData);
                DataBase.SubmitChanges();
                var Data = from rows in DataBase.CaseMessages
                           select rows;
                Table_Messages.DataSource = Data;
                Table_Messages.AutoResizeRows();
                Table_Messages.AutoResizeColumns();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
