using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;

namespace MedicalAssistant
{
    public static class utils
    {
        public static int GetTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 177);
                return (int)Math.Ceiling(size.Height);
            }
        }

        //internal static int GetTextHeight(BunifuLabel label1)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
