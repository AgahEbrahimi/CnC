using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnC
{
    public partial class Streaming_Choose : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public Streaming_Choose()
        {
            InitializeComponent();
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

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //IP Configuration
                string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                var IsOn = (from rows in DataBase.Streaming_IPs
                            where rows.User == UserIP.Text
                            select rows).FirstOrDefault();

                if (IsOn.AreOn == "true")
                {
                    var Count = (from rows in DataBase.Streaming_IPs
                             select rows).Count();
                    if (Count != 0)
                    {
                        var IPs = (from rows in DataBase.Streaming_IPs
                                   where rows.UserType == "Server" && rows.User == UserName
                                   select rows).FirstOrDefault();
                        DataBase.Streaming_IPs.DeleteOnSubmit(IPs);
                        DataBase.SubmitChanges();

                        Streaming_IP IP_Submit = new Streaming_IP();
                        IP_Submit.AreOn = "true";
                        IP_Submit.ID = Count+1;
                        IP_Submit.IP = GetIpAdress();
                        IP_Submit.Port = 2016;
                        IP_Submit.User = UserName;
                        IP_Submit.UserType = "Server";
                        DataBase.Streaming_IPs.InsertOnSubmit(IP_Submit);
                        DataBase.SubmitChanges();
                    }
                    if (Count == 0)
                    {
                        Streaming_IP IPs = new Streaming_IP();

                        IPs.AreOn = "true";
                        IPs.ID = Count+1;
                        IPs.IP = GetIpAdress();
                        IPs.Port = 2016;
                        IPs.User = UserName;
                        IPs.UserType = "Server";
                        DataBase.Streaming_IPs.InsertOnSubmit(IPs);
                        DataBase.SubmitChanges();
                    }

                    //Command
                    var Count_ = (from rows in DataBase.Streaming_Commands
                                 select rows).Count();
                    Streaming_Command Command_Sumbit = new Streaming_Command();
                    Command_Sumbit.Date = dateTimePicker1.Value.ToString();
                    Command_Sumbit.Done = "false";
                    Command_Sumbit.ID = Count_ + 1;
                    Command_Sumbit.Port = 2016;
                    Command_Sumbit.User = UserIP.Text;
                    DataBase.Streaming_Commands.InsertOnSubmit(Command_Sumbit);
                    DataBase.SubmitChanges();


                    //Load
                    Streaming_Show Show = new Streaming_Show();
                    Show.Show();
                }
                else
                {
                    MessageBox.Show("They Aren't online");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

           
        }
        string GetIpAdress()
        {
            IPHostEntry host;
            string localip = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localip = ip.ToString();
                }
            }
            return localip;
        }

        private void Streaming_Choose_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnCDataSet.Streaming_IPs' table. You can move, or remove it, as needed.
            this.streaming_IPsTableAdapter.Fill(this.cnCDataSet.Streaming_IPs);

        }

        private void Connect_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(31, 31);
        }

        private void Connect_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(32, 32);
        }
    }
}
