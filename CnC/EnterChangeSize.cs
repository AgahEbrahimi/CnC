using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnC
{
    public class EnterChangeSize
    {
        public System.Windows.Forms.PictureBox Pic;


        // Constructor that takes one argument.
        public EnterChangeSize(System.Windows.Forms.PictureBox Pic1)
        {
            Pic = Pic1;
        }

        // Method
        public void ChangeSize(int x,int y)
        {
            Pic.Height = x;
            Pic.Width = y;
        }
    }
}
