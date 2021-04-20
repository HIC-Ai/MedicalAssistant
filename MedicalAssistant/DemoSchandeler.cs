using MedicalAssistant.Properties;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MedicalAssistant
{
    public partial class DemoSchandeler : Form
    {
        public DemoSchandeler()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        public WaveOutEvent spt = new WaveOutEvent(); // or WaveOutEvent()
        public string message_send = "مرحبا";
        public string message_rev = "السلام عليكم";
        WaveIn waveIn;
        WaveFileWriter writer;
        bool voice = false;
        int one = 0;


        Bitmap Gradient2D(Rectangle r, Color c1, Color c2, Color c3, Color c4)
        {
            Bitmap bmp = new Bitmap(r.Width, r.Height);

            float delta12R = 1f * (c2.R - c1.R) / r.Height;
            float delta12G = 1f * (c2.G - c1.G) / r.Height;
            float delta12B = 1f * (c2.B - c1.B) / r.Height;
            float delta34R = 1f * (c4.R - c3.R) / r.Height;
            float delta34G = 1f * (c4.G - c3.G) / r.Height;
            float delta34B = 1f * (c4.B - c3.B) / r.Height;
            using (Graphics G = Graphics.FromImage(bmp))
                for (int y = 0; y < r.Height; y++)
                {
                    Color c12 = Color.FromArgb(255, c1.R + (int)(y * delta12R),
                          c1.G + (int)(y * delta12G), c1.B + (int)(y * delta12B));
                    Color c34 = Color.FromArgb(255, c3.R + (int)(y * delta34R),
                          c3.G + (int)(y * delta34G), c3.B + (int)(y * delta34B));
                    using (LinearGradientBrush lgBrush = new LinearGradientBrush(
                          new Rectangle(0, y, r.Width, 1), c12, c34, 0f))
                    { G.FillRectangle(lgBrush, 0, y, r.Width, 1); }
                }
            return bmp;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackgroundImage = Gradient2D(panel3.ClientRectangle, Color.LightPink, Color.LightPink, Color.LightPink, Color.LightPink);
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuUserControl2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (voice == true)
            {

                waveIn = new WaveIn();
                waveIn.DeviceNumber = 0;
                waveIn.DataAvailable += waveIn_DataAvailable;
                waveIn.RecordingStopped +=
                    new EventHandler<NAudio.Wave.StoppedEventArgs>(waveIn_RecordingStopped);
                waveIn.WaveFormat = new WaveFormat(16000, 1);
                writer = new WaveFileWriter("test.wav", waveIn.WaveFormat);
                waveIn.StartRecording();


                pictureBox2.Image = Resources.block_microphone;
            }
            else
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                writer.Close();
                writer.Dispose();


                voice = true;
                message_rev = new recognitionArabic().SpeakRecognition();
                Label2.Text = message_rev;
                pictureBox2.Image = Resources.add_record;


            }
        }

        [Obsolete]
        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                writer.WriteData(e.Buffer, 0, e.BytesRecorded);

            }
            catch
            {

            }
        }

        void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            try
            {
                waveIn.Dispose();
                waveIn = null;
                writer.Close();
                writer = null;
            }
            catch
            {

            }

        }

        [Obsolete]

        private void DemoSchandeler_Load(object sender, EventArgs e)
        {
        }
    }
}
