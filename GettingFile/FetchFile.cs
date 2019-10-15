using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingFile
{
    public partial class FetchFile : Form
    {
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
        public FetchFile()
        {
            InitializeComponent();
            Server.path = GetRealPath() ; 

        }

        private void FetchFile_Load(object sender, EventArgs e)
        {
            Server.path = GetRealPath();
            if (Server.path.Length > 0)
            {
                backgroundWorker1.RunWorkerAsync();

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Server.MessageCurrent +Environment.NewLine+ Server.path ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        Server server = new Server();

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            server.StartServer();

        }
    }
}
