using NAudio.Wave;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MedicalAssistant
{
    public partial class AppointmentForm : RadForm
    {
        private int appointmentId = -1;
        private bool editing = false;
        private ErrorProvider errorProvider;
        public WaveOutEvent spt = new WaveOutEvent(); // or WaveOutEvent()

        public AppointmentForm()
        {
            InitializeComponent();
 //Color.FromArgb(36, 24, 58)
            panel3.BackgroundImage = Gradient2D(panel3.ClientRectangle, Color.LightPink, Color.LightPink, Color.LightPink, Color.LightPink);


            this.errorProvider = new ErrorProvider();
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
            //this.startDateTimePicker.ThemeName = "MedicalAppTheme";
            //this.endDateTimePicker.ThemeName = "MedicalAppTheme";
            PatientsDataSet.AppointmentsRow appointmentsRow = this.Tag as PatientsDataSet.AppointmentsRow;
            if (appointmentsRow != null)
            {
                this.appointmentId = appointmentsRow.Id;
                this.editing = true;
                this.Text = "Edit Appointment";
                this.startDateTimePicker.Value = appointmentsRow.Start;
                this.endDateTimePicker.Value = appointmentsRow.End;
                //selectedPatientId = appointmentsRow.PersonId;
                if (appointmentsRow["Location"] != DBNull.Value)
                {
                    this.locationTextBoxControl.Text = appointmentsRow.Location;
                }
                if (appointmentsRow["Description"] != DBNull.Value)
                {
                    this.descriptionTextBoxControl.Text = appointmentsRow.Description;
                }
                if (appointmentsRow["NameDoc"] != DBNull.Value)
                {
                    this.nameTextBoxControl.Text = appointmentsRow.NameDoc;
                }
            }

            Appointment appointment = this.Tag as Appointment;
            if (appointment != null)
            {
                this.startDateTimePicker.Value = appointment.Start;
                this.endDateTimePicker.Value = appointment.End;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.AreRequiredFieldsValid())
            {
                return;
            }

            if (this.editing)
            {
                this.EditAppointment();
            }
            else
            {
                this.AddAppointment();
            }
            spt = new recognitionArabic().CloudTextToSpeech("تم اضافة المَوعِد", "male");

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAppointment()
        {
            PatientsDataSet.AppointmentsRow appointment = (PatientsDataSet.AppointmentsRow)DataSources.PatientsDataSet.Appointments.Rows.Add();
            appointment.NameDoc = nameTextBoxControl.Text;
            appointment.Start = this.startDateTimePicker.Value;
            appointment.End = this.endDateTimePicker.Value;
            appointment.Location = this.locationTextBoxControl.Text;
            appointment.Description = this.descriptionTextBoxControl.Text;

            this.appointmentsTableAdapter1.Update(DataSources.PatientsDataSet.Appointments);
            this.appointmentsTableAdapter1.Fill(DataSources.PatientsDataSet.Appointments);
            RadMessageBox.Show(this, "Appointment added.");
            //this.Close();
        }

        private void EditAppointment()
        {
            PatientsDataSet.AppointmentsRow appointment = DataSources.PatientsDataSet.Appointments.FindById(this.appointmentId);
            appointment.NameDoc = this.nameTextBoxControl.Text;
            appointment.Start = this.startDateTimePicker.Value;
            appointment.End = this.endDateTimePicker.Value;
            appointment.Location = this.locationTextBoxControl.Text;
            appointment.Description = this.descriptionTextBoxControl.Text;

            this.appointmentsTableAdapter1.Update(DataSources.PatientsDataSet.Appointments);
            this.appointmentsTableAdapter1.Fill(DataSources.PatientsDataSet.Appointments);




            RadMessageBox.Show(this, "Appointment changed.");

        }

        private bool AreRequiredFieldsValid()
        {
            if (this.nameTextBoxControl == null)
            {
                this.errorProvider.SetError(this.nameTextBoxControl, "Doctor is required");
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

        private void radButton3_Click(object sender, EventArgs e)
        {
            if (!this.AreRequiredFieldsValid())
            {
                return;
            }

            if (this.editing)
            {
                PatientsDataSet.AppointmentsRow appointment2 = DataSources.PatientsDataSet.Appointments.FindById(this.appointmentId);

                if (appointment2 != null)
                {
                    appointment2.Delete();
                    this.appointmentsTableAdapter1.Update(DataSources.PatientsDataSet.Appointments);
                    this.appointmentsTableAdapter1.Fill(DataSources.PatientsDataSet.Appointments);
                    RadMessageBox.Show(this, "Appointment Deleted.");
                    this.Close();

                }
            }

        }
    }
}
