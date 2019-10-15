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
    public partial class DemandDeleteFile : Form
    {
        public DemandDeleteFile()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
                Demand_Delete Demand = new Demand_Delete();
                var Count = (from rows in DataBase.Demand_Deletes
                             select rows).Count();
                Demand.date = dateTimePicker1.Value.ToString();
                Demand.DoneOrNot = "false";
                Demand.FileName = FileName.Text;
                Demand.FileType = FileType.Text;
                Demand.ID = Count + 1;
                Demand.UserID = UserID.Text;
                Demand.UserIP = UserIP.Text;
                DataBase.Demand_Deletes.InsertOnSubmit(Demand);
                DataBase.SubmitChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }
        }

        private void DemandDeleteFile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnCDataSet.Streaming_IPs' table. You can move, or remove it, as needed.
            this.streaming_IPsTableAdapter.Fill(this.cnCDataSet.Streaming_IPs);
        }

        private void UserIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var User = (from rows in DataBase.Demand_Deletes
                        where rows.UserIP == UserIP.Text
                        select rows).FirstOrDefault().UserID;
            UserID.Text = User;

        }

        private void UserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var User = (from rows in DataBase.Demand_Deletes
                        where rows.UserID == UserID.Text
                        select rows).FirstOrDefault().UserIP;
            UserIP.Text = User;
        }
    }
}
