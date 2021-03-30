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

            Label2.Height = utils.GetTextHeight(Label2) + 3;
            bunifuUserControl2.Height = Label2.Top + bunifuUserControl2.Top + Label2.Height;
            this.Height = bunifuUserControl2.Bottom + 2;

        }


        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void Outgoing_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void bunifuUserControl2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
