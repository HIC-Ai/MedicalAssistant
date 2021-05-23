using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MedicalAssistant
{
    public partial class Scheduler : Telerik.WinControls.UI.RadForm
    {
        public Scheduler()
        {
            InitializeComponent();
            DataSources.PatientsDataSet = this.patientsDataSet;
        }

        private void radSchedulerNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void Scheduler_Load(object sender, EventArgs e)
        {
            this.appointmentsTableAdapter.Fill(this.patientsDataSet.Appointments); // ملي جدول ب البيانات 
            this.AddSchedulerAppointmentBackgrounds(); // تغير كل لون مهام
            this.BindScheduler(); // عرض الجدول في الخليفيه
        }
        private void AddSchedulerAppointmentBackgrounds()
        {
            this.radScheduler1.Backgrounds.Clear();
            this.AddSchedulerAppointmentbacroundInfo(1, "Purple", Color.FromArgb(218, 219, 255));
            this.AddSchedulerAppointmentbacroundInfo(2, "Yellow", Color.FromArgb(255, 252, 223));
            this.AddSchedulerAppointmentbacroundInfo(3, "Red", Color.FromArgb(252, 218, 202));
            this.AddSchedulerAppointmentbacroundInfo(4, "Green", Color.FromArgb(216, 245, 179));
        }
        private void AddSchedulerAppointmentbacroundInfo(int id, string name, Color backColor)
        {
            AppointmentBackgroundInfo backInfo = new AppointmentBackgroundInfo(id, name, backColor, backColor);
            backInfo.ForeColor = Color.Black;
            backInfo.ShadowStyle = ShadowStyles.Solid;
            backInfo.ShadowWidth = 0;
            backInfo.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            backInfo.BorderColor = Color.FromArgb(198, 202, 185);
            backInfo.BorderGradientStyle = GradientStyles.Solid;
            //backInfo.DateTimeColor = this.radScheduler1.SchedulerElement.DefaultDateTimeTitleColor;
            //backInfo.DateTimeFont = this.radScheduler1.SchedulerElement.DefaultDateTimeTitleFont;
            this.radScheduler1.Backgrounds.Add(backInfo);
        }
        private void BindScheduler()
        {
            SchedulerBindingDataSource dataSource = new SchedulerBindingDataSource();
            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.Start = "Start";
            appointmentMappingInfo.End = "End";
            appointmentMappingInfo.Summary = "NameDoc";
            appointmentMappingInfo.Description = "Description";
            appointmentMappingInfo.Location = "Location";

            dataSource.EventProvider.Mapping = appointmentMappingInfo;
            dataSource.EventProvider.DataSource = this.appointmentsBindingSource;
            this.radScheduler1.DataSource = dataSource;

        }
        private void SetSchedulerAppointmentsBackground()
        {
            int colorIndex = 1;
            foreach (IEvent appointment in this.radScheduler1.Appointments)
            {
                appointment.BackgroundId = colorIndex;
                colorIndex++;
                if (this.radScheduler1.Backgrounds.Count < colorIndex)
                {
                    colorIndex = 1;
                }
            }
        }
        private void radScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            e.Cancel = true;

            // if creating new appointment
            AppointmentForm addAppointmentForm = new AppointmentForm();
            if (e.Appointment.DataItem != null)
            {
                DataRowView rowView = e.Appointment.DataItem as DataRowView;
                addAppointmentForm.Tag = rowView.Row;
            }
            else
            {
                addAppointmentForm.Tag = new Appointment(e.Appointment.Start, e.Appointment.End);
            }

            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
            addAppointmentForm.ShowDialog(this);
            this.SetSchedulerAppointmentsBackground();
        }

        private void radScheduler1_AppointmentDeleted(object sender, SchedulerAppointmentEventArgs e)
        {
            this.appointmentsTableAdapter.Update(DataSources.PatientsDataSet.Appointments);

        }

        private void radScheduler1_DataBindingComplete(object sender, EventArgs e)
        {
            this.SetSchedulerAppointmentsBackground();

        }

        private void radButtonNewAppointmentScheduler_Click(object sender, EventArgs e)
        {

            // if creating new appointment
            AppointmentForm addAppointmentForm = new AppointmentForm();


            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
            addAppointmentForm.ShowDialog(this);
            this.SetSchedulerAppointmentsBackground();
        }
    }
}
