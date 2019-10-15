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
    public partial class Upload : Form
    {
        public static string ip;
        public Upload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            client client = new client(ip);

            if ((fd.ShowDialog() == DialogResult.OK) && ip!=null)
            {
                client.SendFile(fd.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = client.MesajCurrent;
        }

        private void Upload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnCDataSet.Streaming_IPs' table. You can move, or remove it, as needed.
            this.streaming_IPsTableAdapter.Fill(this.cnCDataSet.Streaming_IPs);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CnC_DatabaseDataContext Databse = new CnC_DatabaseDataContext();
            try
            {
                var IP = (from rows in Databse.Streaming_IPs
                          where rows.User == comboBox1.Text && rows.AreOn == "true"
                          select rows).FirstOrDefault().IP;
                ip = IP;
            }
            catch (Exception)
            {

               MessageBox.Show("Not Available");
            }
            

        }
    }
}
