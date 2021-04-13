using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MedicalAssistant.chat
{
    public partial class Incomming : UserControl
    {

        public Incomming()
        {
            InitializeComponent();


        }

        public string Message
        {
            get
            {
                return Label3.Text;
            }

            set
            {
                Label3.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            //gunaCirclePictureBox1.Location = new Point(1, 1);
            //Label3.Height = utils.GetTextHeight(Label3) + 0;
            //bunifuUserControl1.Height = Label3.Top + bunifuUserControl1.Top + Label3.Height;
            //this.Height = bunifuUserControl1.Bottom + 0;


            ////radPanel1.Height = Label3.Top + radPanel1.Top + Label3.Height;
            ////this.Height = radPanel1.Bottom + 1;

            //gunaCirclePictureBox1.Location = new Point(1, 1);



            //Label3.Height = utils.GetTextHeight(Label3) - 9;
            ////bunifuUserControl1.Height = Label3.Top + bunifuUserControl1.Top + Label3.Height;
            //this.Height = Label3.Height + 50;
            //bunifuUserControl1.Height = this.Height - 8;




            //Label3.Height = utils.GetTextHeight(Label3) + 3 + 0;
            //bunifuUserControl1.Height = Label3.Top + bunifuUserControl1.Top + Label3.Height + 20;
            //this.Height = bunifuUserControl1.Bottom + 1;


            //Console.WriteLine(this.Height); // 42

            //Console.WriteLine(bunifuUserControl1.Height); // 37

            //Console.WriteLine(Label3.Height); // 37

            var size = TextRenderer.MeasureText(Label3.Text, Label3.Font, new Size(157, 13), TextFormatFlags.WordBreak);

            //Label3.Height = utils.GetTextHeight(Label3);
            this.Height = size.Height + 50;
            bunifuUserControl1.Height = size.Height + 30;

            Label3.Height = size.Height;
        }
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            //Upper-right arc:
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            //Lower-right arc:
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            //Lower-left arc:
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            //Upper-left arc:
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }
        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, Pens.Pink, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
        }
    }
}

