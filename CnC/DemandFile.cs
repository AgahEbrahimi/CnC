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
    public partial class DemandFile : Form
    {
        public DemandFile()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                DemandedFile Demand = new DemandedFile();
                var Count = (from rows in DataBase.DemandedFiles
                             select rows).Count();
                Demand.DoneOrNot = "false";
                Demand.FileName = FileName.Text;
                Demand.FileType = FileType.Text;
                Demand.ID = Count + 1;
                Demand.UserID = UserID.Text;
                Demand.UserIP = UserIP.Text;
                DataBase.DemandedFiles.InsertOnSubmit(Demand);
                DataBase.SubmitChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }
            

        }

        private void DemandFile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnCDataSet.Streaming_IPs' table. You can move, or remove it, as needed.
            this.streaming_IPsTableAdapter.Fill(this.cnCDataSet.Streaming_IPs);

        }
    }
}
