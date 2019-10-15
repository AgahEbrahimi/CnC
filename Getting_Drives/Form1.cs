using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Getting_Drives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            ServerDetailsClassDataContext DataBase = new ServerDetailsClassDataContext();
            ServerDetail Details = new ServerDetail();
            var Count = (from rows in DataBase.ServerDetails
                         select rows).Count();
            foreach (DriveInfo d in allDrives)
            {
                Details.Drive = (d.Name);
                if (d.IsReady == true)
                {
                    
                    Details.AvailableSpace = ((d.AvailableFreeSpace)/1000000).ToString();
                    Details.TotalFreeSpace = (d.TotalFreeSpace / 1000000).ToString();
                    Details.TotalSize = (d.TotalSize / 1000000).ToString();

                    
                }
                Details.ID = Count + 1;
                DataBase.ServerDetails.InsertOnSubmit(Details);
                DataBase.SubmitChanges();

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
