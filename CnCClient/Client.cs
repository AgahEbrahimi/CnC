using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace CnCClient
{
    class client
    {
        public static string MesajCurrent = "Idle";
        public static string ipadress;
        public client(string ipad)
        {
            ipadress = ipad;
        }


        public static void SendFile(string fName)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(ipadress);
                IPEndPoint end = new IPEndPoint(ip, 2016);
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string path = "";
                fName = fName.Replace("\\", "/");
                while (fName.IndexOf("/") > -1)
                {
                    path += fName.Substring(0, fName.IndexOf("/") + 1);
                    fName = fName.Substring(fName.IndexOf("/") + 1);

                }
                byte[] fnameByte = Encoding.ASCII.GetBytes(fName);
                if (fnameByte.Length > 850 * 1024)
                {
                    MesajCurrent = "more than 850 kb";
                    return;
                }

                MesajCurrent = "Buffering ...";
                byte[] filedata = File.ReadAllBytes(path + fName);
                byte[] ClientData = new byte[4 + fnameByte.Length + filedata.Length];
                byte[] fNameLen = BitConverter.GetBytes(fnameByte.Length);
                fNameLen.CopyTo(ClientData, 0);
                fnameByte.CopyTo(ClientData, 4);
                filedata.CopyTo(ClientData, 4 + fnameByte.Length);
                MesajCurrent = "Connect to server";
                sock.Connect(end);
                sock.Send(ClientData);
                MesajCurrent = "Disconnect ... ";
                sock.Close();
                MesajCurrent = "Finished";

            }
            catch (Exception ex)
            {


            }
        }
    }
}
