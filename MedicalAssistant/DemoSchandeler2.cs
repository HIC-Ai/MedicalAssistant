using MedicalAssistant.Properties;
using NAudio.Wave;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MedicalAssistant
{
    public partial class DemoSchandeler2 : RadForm
    {
        public WaveOutEvent spt = new WaveOutEvent(); // or WaveOutEvent()
        public string message_send = "مرحبا";
        public string message_rev = "السلام عليكم";
        WaveIn waveIn;
        WaveFileWriter writer;
        bool voice = true;

        public DemoSchandeler2()
        {
            InitializeComponent();
            //Color.FromArgb(36, 24, 58)
            panel3.BackgroundImage = Gradient2D(panel3.ClientRectangle, Color.LightPink, Color.LightPink, Color.LightPink, Color.LightPink);

        }
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

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            startDateTimePicker.Value = DateTime.Now;
            endDateTimePicker.Value = DateTime.Now.AddHours(1);
            this.startDateTimePicker.DateTimePickerElement.ShowTimePicker = true;
            this.endDateTimePicker.DateTimePickerElement.ShowTimePicker = true;



        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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
        string name, place, sub;
        private ErrorProvider errorProvider;

        private bool AreRequiredFieldsValid()
        {
            if (this.Label2.Text == "")
            {
                spt = new recognitionArabic().CloudTextToSpeech("برجاء قول البيانات بشكل صحيح", "male");
                return false;
            }
            if (this.startDateTimePicker.DateTimePickerElement.Value == null)
            {
                this.errorProvider.SetError(this.startDateTimePicker, "Start Date is required");
                return false;
            }
            if (this.endDateTimePicker.DateTimePickerElement.Value == null)
            {
                this.errorProvider.SetError(this.endDateTimePicker, "End Date is required");
                return false;
            }

            return true;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {

            if (!this.AreRequiredFieldsValid())
            {
                return;
            }

            PatientsDataSet.AppointmentsRow appointment = (PatientsDataSet.AppointmentsRow)DataSources.PatientsDataSet.Appointments.Rows.Add();
            appointment.NameDoc = name;
            appointment.Start = this.startDateTimePicker.Value;
            appointment.End = this.endDateTimePicker.Value;
            appointment.Location = place;
            appointment.Description = sub;

            this.appointmentsTableAdapter1.Update(DataSources.PatientsDataSet.Appointments);
            this.appointmentsTableAdapter1.Fill(DataSources.PatientsDataSet.Appointments);
            RadMessageBox.Show(this, "Appointment added.");

            new recognitionArabic().CloudTextToSpeech("تم اضافة المَوعِد", "male");

            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        [Obsolete]
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
                voice = false;
            }
            else
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                writer.Close();
                writer.Dispose();


                voice = true;
                message_rev = new recognitionArabic().SpeakRecognition();

                Console.WriteLine(message_rev);
                try
                {
                    //message_rev = "الميعاد مع الدكتور احمد والمكان في شارع المحطه والموضوع عن كشف لابني";
                    string toFind1 = "اسم الدكتور";
                    string toFind2 = "والمكان";
                    int start = message_rev.IndexOf(toFind1) + toFind1.Length + 1;
                    int end = message_rev.IndexOf(toFind2, start);
                    name = message_rev.Substring(start, end - start);


                    toFind1 = "والمكان ";
                    toFind2 = "والموضوع ";
                    start = message_rev.IndexOf(toFind1) + toFind1.Length;
                    end = message_rev.IndexOf(toFind2, start);
                    place = message_rev.Substring(start, end - start);

                    toFind1 = "والموضوع ";
                    toFind2 = "";
                    start = message_rev.IndexOf(toFind1) + toFind1.Length;
                    end = message_rev.IndexOf(toFind2, start);
                    sub = message_rev.Substring(start, message_rev.Length - start);
                    Console.WriteLine(name + place + sub);
                    Label2.Text = name + place + sub;



                    name = String.Join(" ", name.Split(' ').Reverse().ToArray());
                    place = String.Join(" ", place.Split(' ').Reverse().ToArray());
                    sub = String.Join(" ", sub.Split(' ').Reverse().ToArray());
                }
                catch { }
                pictureBox2.Image = Resources.add_record;

            }
        }

        private void bunifuUserControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
