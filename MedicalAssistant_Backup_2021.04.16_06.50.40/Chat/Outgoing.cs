using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAssistant.chat
{
    public partial class Outgoing : UserControl
    {
        public Outgoing()
        {
            InitializeComponent();
        }
        public string Message
        {
            get
            {
                return Label2.Text;
            }
            set
            {
                Label2.Text = value;
                AdjustHeight();
            } 
        }
        void AdjustHeight()
        {

            //Label2.Height = utils.GetTextHeight(Label2) + 3;
            //bunifuUserControl2.Height = Label2.Top + bunifuUserControl2.Top + Label2.Height - 10;
            //this.Height = bunifuUserControl2.Bottom + 2 - 5;

            //Label2.Height = utils.GetTextHeight(Label2) + 4;
            //bunifuUserControl2.Height = Label2.Top + bunifuUserControl2.Top + Label2.Height;
            //this.Height = bunifuUserControl2.Bottom + 3;


            //Label2.Height = utils.GetTextHeight(Label2) + 3 + 0;
            //bunifuUserControl2.Height = Label2.Top + bunifuUserControl2.Top + Label2.Height;
            //this.Height = bunifuUserControl2.Bottom + 5;
            //bunifuUserControl2.Height = bunifuUserControl2.Height + 47;
            //// 109
            //// 165 20
            //Console.WriteLine("Out Height " + this.Height); // 145

            //Console.WriteLine("Out bunifuUserControl2 " + bunifuUserControl2.Height); // 136

            //Console.WriteLine("Out Label2 " + Label2.Height); // 176



            var size = TextRenderer.MeasureText(Label2.Text, Label2.Font, new Size(226, 16), TextFormatFlags.WordBreak);

            //Label3.Height = utils.GetTextHeight(Label3);
            this.Height = size.Height + 50;
            bunifuUserControl2.Height = size.Height + 30;

            Label2.Height = size.Height;

        }

    }
}
