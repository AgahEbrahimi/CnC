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
    public partial class ServerWatch : Form
    {
        public ServerWatch()
        {
            InitializeComponent();
        }

        private void ServerWatch_Load(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var Data = from rows in DataBase.ServerDetails
                       select rows;
            Data_.DataSource = Data;
            

        }
    }
}
