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
using System.Threading;
namespace CnC
{
    public partial class Streaming_Show : Form
    {
        public Streaming_Show()
        {
            InitializeComponent();
        }
        TcpListener tl;
        Socket skt;
        NetworkStream ns;
        StreamReader sr;
        Thread th;
        void RecieveImage()
        {
            try
            {
                tl = new TcpListener(53100);
                tl.Start();
                skt = tl.AcceptSocket();
                ns = new NetworkStream(skt);
                pictureBox1.Image = Image.FromStream(ns);
                tl.Stop();
                if (skt.Connected == true)
                {
                    while (true)
                    {
                        RecieveImage();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"baba");
            }
            

        }

        private void Streaming_Show_Load(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(RecieveImage));
            th.Start();

        }
    }
}
