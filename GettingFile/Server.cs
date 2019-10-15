﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace GettingFile
{
    class Server
    {
        IPEndPoint end;
        Socket sock;

        public Server()
        {
            end = new IPEndPoint(IPAddress.Any, 2016);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(end); 

        }
        public static string path;
        public static string MessageCurrent = "stop";

        public void StartServer()
        {
            try
            {
                MessageCurrent = "starting";
                sock.Listen(100);
                MessageCurrent = "sth sth";
                Socket clientscok = sock.Accept();
                byte[] ClientData = new byte[1024 * 5000];
                int recievedByteLen = clientscok.Receive(ClientData);
                MessageCurrent = "some other stuff";
                int fNameLen = BitConverter.ToInt32(ClientData, 0);
                string fName = Encoding.ASCII.GetString(ClientData, 4, fNameLen);
                BinaryWriter write = new BinaryWriter(File.Open(path + "/" + fName, FileMode.Append));
                write.Write(ClientData, 4 + fNameLen, recievedByteLen - 4 - fNameLen);
                MessageCurrent = "saving file";
                write.Close();
                clientscok.Close();
                MessageCurrent = "something happpned ";

            }
            catch (Exception)
            {


                MessageCurrent = "somthing not happened";

            }
        }

    }
}
