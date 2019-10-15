using CnC.Properties;
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
    public partial class ListClients : Form
    {
        string User = Resources.Main_User;
        int TogMove;
        int MValX;
        int MValY;
        private string Which_Form_Private;
        public string Which_Form { set { Which_Form_Private = value; } }
        public ListClients()
        {
            InitializeComponent();
        }

        private void ListClients_Load(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var StreamingIps = (from rows in DataBase.Streaming_IPs
                                select rows);
            Table_Messages.DataSource = StreamingIps;
            Table_Messages.AutoResizeRows();
            Table_Messages.AutoResizeColumns();
            if (Int32.Parse(Which_Form_Private) == 1)
            {
                DeleteIP.Visible = true;

            }
            if (Int32.Parse(Which_Form_Private) == 0)
            {
                DeleteIP.Visible = false;
            }
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

        private void DeleteIP_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(23, 23);
        }

        private void DeleteIP_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(24, 24);
        }

        private void DeleteIP_Click(object sender, EventArgs e)
        {
            var rowindex = Table_Messages.CurrentCell.RowIndex;
            var IDTable = Table_Messages.Rows[rowindex].Cells[0].Value.ToString();

            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                var DeleteData = (from rows in DataBase.Streaming_IPs
                                  where rows.User == IDTable
                                  select rows).FirstOrDefault();

                DataBase.Streaming_IPs.DeleteOnSubmit(DeleteData);
                DataBase.SubmitChanges();
                var Data = from rows in DataBase.Streaming_IPs
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
