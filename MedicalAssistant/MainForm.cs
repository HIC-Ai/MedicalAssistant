﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.IO;
using Telerik.WinControls;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Media;
using System.Drawing.Drawing2D;
using MedicalAssistant.Properties;
using System.Text;
using System.Collections.Generic;

namespace MedicalAssistant
{
    public partial class MainForm : RadForm
    {
        //public StringBuilder CommendsWords = new StringBuilder("Hello World!");
        List<string> CommendsWords = new List<string>();

        public MainForm()
        {
            CommendsWords.Add("المهام");
            CommendsWords.Add("الاخبار");

            InitializeComponent();




            //radButton1.TabStop = false;
            //radButton1.FlatStyle = FlatStyle.Flat;
            //radButton1.FlatAppearance.BorderSize = 0;


            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
            this.SetCurrentPageViewPage(this.radPageViewPageDashboard);
            //panel1.HorizontalScroll.Maximum = 0;
            //panel1.HorizontalScroll.Visible = false;
            //panel1.Scroll.Maximum = 0;


            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(0, 500);
            //panel1.Paint += panel1_Paint;
            //this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            panel5.BackgroundImage = Gradient2D(panel5.ClientRectangle, Color.LightPink, Color.LightPink, Color.LightPink, Color.LightPink);



            //this.radProgressBar1.Text = "Loading";
            //this.progressBarAdv1.TextStyle = ProgressBarTextStyles.Custom;


            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            //this.SetToggleButtonsStateImages();
            //this.radChat1.Author = new Author(Properties.Resources.icons8_Chat_32, "Nancy");
            string startupPath = Directory.GetCurrentDirectory();
            //ThemeResolutionService.LoadPackageFile(startupPath.Replace("bin\\Debug", "").ToString() + @"dll\"+ "MedicalAppTheme.tssp");
            ThemeResolutionService.LoadPackageResource("MedicalAssistant.Themes.MedicalAppTheme.tssp");

            RadMessageBox.Instance.ThemeName = "MedicalAppTheme";
            DataSources.PatientsDataSet = this.patientsDataSet;
            DataSources.PatientsDataSet.Appointments.AppointmentsRowChanged += Appointments_AppointmentsRowChanged;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(panel1.AutoScrollPosition.X, panel1.AutoScrollPosition.Y);
            e.Graphics.DrawLine(Pens.Red, 100, 0, 100, 100);
            e.Graphics.DrawLine(Pens.Red, 100, 0, 0, 100);

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
        public string message_send = "مرحبا";
        public string message_rev = "السلام عليكم";
        public bool voice = true;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        string tip = "";
        int i = 0;
        string txt;
        int len = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                i = i + 1;
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(2000);
                    //tip = new database().Tips_database();
                    worker.ReportProgress(i * 1);

                    //label1.Text = tip;
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tip = new database().Tips_database();
            //label1.Text = (e.ProgressPercentage.ToString());

            txt = label1.Text;
            len = txt.Length;
            label1.Text = tip;
            timer1.Start();

        }

        public int page = 1;
        public DateTime CurrentDate
        {
            get { return DateTime.Now; }
        }
        private void main5_Load(object sender, EventArgs e)
        {
            AddIncomming("مرحبا");
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
                backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
                backgroundWorker1.RunWorkerAsync();
            }

            this.appointmentsTableAdapter.Fill(this.patientsDataSet.Appointments);
            //this.patientsTableAdapter.Fill(this.patientsDataSet.Patients);

            //this.SetPageViewPageVisualStyles(this.radPageViewPageDashboard);
            //this.SetPageViewPageVisualStyles(this.radPageViewPageSchedule);
            //this.SetCurrentPageViewPage(this.radPageViewPageDashboard);
            this.UpdateSelectedPageData();

            // Main panel
            //this.FormElement.TitleBar.MaximizeButton.Enabled = false;
            //this.FormElement.ImageBorder.BorderTMedicalAssistantkness = new Padding(0);
            //this.mainPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            //this.radPanelButtonsContainer.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            //this.radSplitButton1.DropDownButtonElement.DropDownMenu.PopupElement.Alignment = ContentAlignment.MiddleRight;

            // Dashboard
            //this.dashboardClockCalendarPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.radCalendarDashboard.FocusedDate = CurrentDate;

            // Schedule
            this.radCalendarSchedule.FocusedDate = CurrentDate;
            this.CustomizeCurrentSchedulerView();
            this.radSchedulerNavigator1.TimelineViewButton.Visibility = ElementVisibility.Hidden;
            //this.radScheduler1.SchedulerElement.ViewElement.AppointmentMargin = new Padding(0, 0, 0, 1);
            this.AddSchedulerAppointmentBackgrounds();
            this.BindScheduler();

            //CalendarNavigationElement navigationElement = this.radCalendarSchedule.CalendarElement.CalendarNavigationElement;
            //navigationElement.PreviousButton.Visibility = ElementVisibility.Visible;
            //navigationElement.NextButton.Visibility = ElementVisibility.Visible;
            //navigationElement.BackColor = Color.FromArgb(242, 242, 243);
            //navigationElement.MinSize = new Size(0, 32);
            //navigationElement.Padding = new Padding(3, 6, 3, 6);
        }





        //private void AddMessageProgrammatically()
        //{
        //    this.radChat1.AutoAddUserMessages = false;
        //    this.radChat1.SendMessage += radChat1_SendMessage;
        //}
        private void radChat1_SendMessage(object sender, SendMessageEventArgs e)
        {
            ChatTextMessage textMessage = e.Message as ChatTextMessage;

            //ChatTextMessage message1 = new ChatTextMessage("Hello", author2, DateTime.Now.AddHours(1));
            //this.radChat1.AddMessage(message1);


            //textMessage.Message = textMessage.Message;
            if (textMessage.Message == "السلام عليكم")
            {
                Author author2 = new Author(Properties.Resources.icons8_Email_Send_32, "Andrew");

                ChatTextMessage message3 = new ChatTextMessage("عليكم السلام", author2, DateTime.Now);
                //this.radChat1.AddMessage(message3);

            }
            //this.radChat1.AddMessage(textMessage);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            if (page != 4)
            {
                page = 4;
            }
        }




        //private void bunifuButton3_Click(object sender, EventArgs e)
        //{
        //    if (page != 3)
        //    {
        //        page = 3;
        //        panalMain.Controls.Clear();
        //    }
        //    //panalMain.Controls.Add(new dashboardMain());
        //}

        //private void scheduleToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        //{
        //    if (page != 2)
        //    {
        //        page = 2;
        //        panalMain.Controls.Clear();
        //    }
        //    //panalMain.Controls.Add(new dashboardMain());
        //}

        private void bunifuButton1_Click(object sender, EventArgs e)
        {


            //panalMain.Controls.Clear();
            //panalMain.Controls.Add(new dashboardMain());
        }

        private void dashboardMain1_Load(object sender, EventArgs e)
        {

        }






        int ticks = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            ticks++;
            radProgressBar1.Value1 = ticks;
            if (ticks == 100)
            {
                timer1.Enabled = false;
                ticks = 0;
            }
        }

        //private void guna2CircleButton1_Click(object sender, EventArgs e)
        //{
        //    timer2.Enabled = true;
        //    new recognitionArabic().Louding(true, false);
        //    guna2CircleButton1.Enabled = false;
        //    guna2Button1.Enabled = true;
        //    guna2Button1.FillColor = Color.Red;

        //}
        void AddIncomming(string message)
        {
            chat.Incomming bubble = new chat.Incomming();
            panel1.Controls.Add(value: bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            bubble.Focus();
        }
        void AddOutgoing(string message)
        {
            var bubble = new chat.Outgoing();
            panel1.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            bubble.Focus();
        }
        private void send(string message_rev)
        {
            AddOutgoing(message_rev);
            timer1.Start();
        }
        //private void guna2Button1_Click(object sender, EventArgs e)
        //{
        //    ticks = 0;
        //    timer2.Enabled = false;
        //    message_rev = new recognitionArabic().Louding(false, true);
        //    if (message_rev != "")
        //    {
        //        guna2CircleButton1.Enabled = true;
        //        guna2Button1.Enabled = false;
        //        SoundPlayer Send = new SoundPlayer("Sounds\\SOUND1.wav");
        //        SoundPlayer Rcv = new SoundPlayer("Sounds\\SOUND2.wav");
        //        send(message_rev);
        //        Send.Play();

        //        var t = new System.Windows.Forms.Timer();
        //        t.Interval = 1000 + (message_rev.Length * 100);
        //        txtTyping.Show();

        //        t.Tick += (s, d) =>
        //        {
        //            txtTyping.Hide();
        //            message_send = new database().Database(message_send, message_rev);
        //            new recognitionArabic().CloudTextToSpeech(message_send);
        //            Debug.WriteLine("message_send " + message_send);
        //            AddIncomming(message_send);
        //            Rcv.Play();
        //            t.Stop();
        //        };
        //        t.Start(); // Start Timer


        //    }

        //    guna2CircleButton1.Enabled = true;
        //    guna2Button1.Enabled = false;
        //}

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Appointments_AppointmentsRowChanged(object sender, PatientsDataSet.AppointmentsRowChangeEvent e)
        {
            this.UpdateTodayAndTomorrowLabels();
        }

        private void dashboardToggleButton_Click(object sender, EventArgs e)
        {
            //this.ResetToggleButtons(this.dashboardToggleButton);
            this.SetCurrentPageViewPage(this.radPageViewPageDashboard);
        }

        private void scheduleToggleButton_Click(object sender, EventArgs e)
        {
            //this.ResetToggleButtons(this.scheduleToggleButton);
            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
        }

        private void radSplitButton1_DropDownOpening(object sender, EventArgs e)
        {
            RadPopupOpeningEventArgs args = e as RadPopupOpeningEventArgs;
            //args.CustomLocation = new Point(args.CustomLocation.X + this.radSplitButton1.Width - 20, args.CustomLocation.Y);
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            this.UpdateSelectedPageData();
        }

        private void UpdateSelectedPageData()
        {
            //if (this.radPageView1.SelectedPage != null && this.radPageView1.Pages.IndexOf(this.radPageView1.SelectedPage) < 3)
            //{
            //    //(this.radPageView1.ViewElement as RadPageViewStripElement).ContentArea.BackColor = Color.White;
            //}
            //else
            //{
            //    (this.radPageView1.ViewElement as RadPageViewStripElement).ContentArea.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
            //}

            if (this.radPageView1.SelectedPage == this.radPageViewPageDashboard)
            {
                this.UpdateTodayAndTomorrowLabels();
            }
        }

        private void SetPageViewPageVisualStyles(RadPageViewPage page)
        {
            //(page.Item as RadPageViewStripItem).ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            //page.Item.Padding = new Padding(14, 10, 14, 10);
            //page.Item.BackColor = Color.FromArgb(36, 24, 58);
            //page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.White, "");
            //page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "Selected");
            //page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "MouseOver");
            //page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "MouseDown");
        }

        private void SetCurrentPageViewPage(RadPageViewPage page)
        {
            //this.radPageViewPageDashboard.Item.Visibility = ElementVisibility.Collapsed;
            //this.radPageViewPageSchedule.Item.Visibility = ElementVisibility.Collapsed;
            page.Item.Visibility = ElementVisibility.Visible;
            this.radPageView1.SelectedPage = page;
        }


        #region Dashboard

        private void radListViewNextPatients_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            e.VisualItem = new PatientsListViewVisualItem();
        }



        private void newAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm addAppointmentForm = new AppointmentForm();
            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
            addAppointmentForm.ShowDialog(this);

            this.SetSchedulerAppointmentsBackground();
        }

        private void radPanelTodaysAppointments_Click(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(CurrentDate);
        }

        private void radPanelTomorrowAppointments_Click(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(CurrentDate.AddDays(1));
        }

        private void radCalendarDashboard_SelectionChanged(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(this.radCalendarDashboard.SelectedDate);
        }

        private void SetSchedulerPageActive(DateTime date)
        {
            //this.scheduleToggleButton.ToggleState = ToggleState.On;
            this.scheduleToggleButton_Click(null, null);
            this.radScheduler1.ActiveViewType = SchedulerViewType.MultiDay;
            this.radScheduler1.FocusedDate = date;
        }


        private void UpdateTodayAndTomorrowLabels()
        {
            DataRow[] todaysAndTomorrowsAppointments = this.patientsDataSet.Appointments
                .Select("Start > #" + CurrentDate.ToString("d", CultureInfo.InvariantCulture) + "# AND Start < #" + CurrentDate.AddDays(2).ToString("d", CultureInfo.InvariantCulture) + "#");
            int todayAppointmentsCount = 0;
            int tomorrowAppointmentsCount = 0;
            DateTime lastAppointmentTodayDateTime = DateTime.MinValue;
            DateTime firstAppointmentTodayDateTime = DateTime.MaxValue;
            foreach (PatientsDataSet.AppointmentsRow appointment in todaysAndTomorrowsAppointments)
            {
                if (appointment.Start.Day == CurrentDate.Day)
                {
                    todayAppointmentsCount++;
                    if (lastAppointmentTodayDateTime < appointment.Start)
                    {
                        lastAppointmentTodayDateTime = appointment.Start;
                    }
                }
                else if (appointment.Start.Day == CurrentDate.AddDays(1).Day)
                {
                    tomorrowAppointmentsCount++;
                    if (firstAppointmentTodayDateTime > appointment.Start)
                    {
                        firstAppointmentTodayDateTime = appointment.Start;
                    }
                }
            }

            this.radLabelTodayAppointmentsCount.Text = todayAppointmentsCount.ToString();
            this.radLabelLastAppointmentToday.Text = "last one at " + lastAppointmentTodayDateTime.ToString("H:mm");

            this.radLabelTomorrowAppointmentsCount.Text = tomorrowAppointmentsCount.ToString();
            this.radLabelFirstAppointmentTomorrow.Text = "first one at " + firstAppointmentTodayDateTime.ToString("H:mm");
        }

        #endregion

        #region Scheduler

        private void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            this.CustomizeCurrentSchedulerView();
        }

        private void radScheduler1_DataBindingComplete(object sender, EventArgs e)
        {
            this.SetSchedulerAppointmentsBackground();
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

        private void DayViewButton_Click(object sender, EventArgs e)
        {
            this.radScheduler1.ActiveViewType = SchedulerViewType.MultiDay;
        }

        private void radCalendarSchedule_SelectionChanged(object sender, EventArgs e)
        {
            this.radScheduler1.FocusedDate = this.radCalendarSchedule.SelectedDate;
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

        private void CustomizeCurrentSchedulerView()
        {
            this.radScheduler1.FocusedDate = CurrentDate;
            SchedulerDayViewBase dayViewBase = null;
            if (this.radScheduler1.ActiveViewType == SchedulerViewType.Day)
            {
                dayViewBase = this.radScheduler1.GetDayView();
            }
            else if (this.radScheduler1.ActiveViewType == SchedulerViewType.MultiDay)
            {
                dayViewBase = this.radScheduler1.GetMultiDayView();
            }
            else if (this.radScheduler1.ActiveViewType == SchedulerViewType.Week)
            {
                dayViewBase = this.radScheduler1.GetWeekView();
            }

            if (dayViewBase != null)
            {
                dayViewBase.RulerFormatStrings.HoursFormatString = "HH";
                dayViewBase.RulerFormatStrings.MinutesFormatString = ":mm";
                dayViewBase.RulerStartScale = 7;
                dayViewBase.RulerEndScale = 20;
                dayViewBase.RulerWidth = 55;
                dayViewBase.RangeFactor = ScaleRange.QuarterHour;
            }
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
            backInfo.DateTimeColor = this.radScheduler1.SchedulerElement.DefaultDateTimeTitleColor;
            backInfo.DateTimeFont = this.radScheduler1.SchedulerElement.DefaultDateTimeTitleFont;
            this.radScheduler1.Backgrounds.Add(backInfo);
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


        #endregion
        private void radScheduler1_ContextMenuOpening(object sender, SchedulerContextMenuOpeningEventArgs e)
        {
            e.Menu.Items.RemoveAt(2);
        }

        private void radLabelTomorrowAppointmentsCount_Click(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(CurrentDate.AddDays(1));

        }

        private void radLabelTodayAppointmentsCount_Click(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(CurrentDate);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public bool rec_text()
        {
            ticks = 0;
            timer2.Enabled = false;
            
            if (message_rev != "")
            {
                SoundPlayer Send = new SoundPlayer("Sounds\\SOUND1.wav");
                SoundPlayer Rcv = new SoundPlayer("Sounds\\SOUND2.wav");
                send(message_rev);
                Send.Play();

                var t = new System.Windows.Forms.Timer();
                t.Interval = 1000 + (message_rev.Length * 100);
                txtTyping.Show();

                t.Tick += (s, d) =>
                {
                    txtTyping.Hide();
                    if (CommendsWords.Contains(message_rev) == true)
                    {
                        Debug.WriteLine("Yes");
                        if (message_rev == CommendsWords[0])
                        {

                            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
                            AddIncomming("حسنا");
                        }

                        if (message_rev == CommendsWords[1])
                        {

                            this.SetCurrentPageViewPage(this.radPageViewPageCharts);

                        }
                        new recognitionArabic().CloudTextToSpeech("حسنا");

                    }
                    else
                    {
                        message_send = new database().Database(message_send, message_rev);
                        new recognitionArabic().CloudTextToSpeech(message_send);
                        Debug.WriteLine("message_send " + message_send);
                        AddIncomming(message_send);
                    }
                    Rcv.Play();
                    t.Stop();
                };
                t.Start(); // Start Timer
                


            }
            return true;
        }
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {


        }

        //private void bunifuPictureBox2_Click(object sender, EventArgs e)
        //{
        //    ticks = 0;
        //    timer2.Enabled = false;
        //    message_rev = new recognitionArabic().Louding(false, true);
        //    if (message_rev != "")
        //    {
        //        bunifuPictureBox1.Enabled = true;
        //        bunifuPictureBox2.Enabled = false;
        //        SoundPlayer Send = new SoundPlayer("Sounds\\SOUND1.wav");
        //        SoundPlayer Rcv = new SoundPlayer("Sounds\\SOUND2.wav");
        //        send(message_rev);
        //        Send.Play();

        //        var t = new System.Windows.Forms.Timer();
        //        t.Interval = 1000 + (message_rev.Length * 100);
        //        txtTyping.Show();

        //        t.Tick += (s, d) =>
        //        {
        //            txtTyping.Hide();
        //            message_send = new database().Database(message_send, message_rev);
        //            new recognitionArabic().CloudTextToSpeech(message_send);
        //            Debug.WriteLine("message_send " + message_send);
        //            AddIncomming(message_send);
        //            Rcv.Play();
        //            t.Stop();
        //        };
        //        t.Start(); // Start Timer


        //    }

        //    bunifuPictureBox1.Enabled = true;
        //    bunifuPictureBox2.Enabled = false;
        //}

        private void txtTyping_Click(object sender, EventArgs e)
        {

        }
        bool talk = false;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {


        }

        private void InputTxt_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void InputTxt_MouseLeave(object sender, EventArgs e)
        {
            //InputTxt.HintText = "";

            //InputTxt.Enabled = false;
            if (talk == false)
            {
                if (InputTxt.Text == "" || InputTxt.Text == null)
                {
                    InputTxt.HintText = "اكتب رسالتك هنا";
                }
            }
        }

       

        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                talk = true;

                InputTxt.Enabled = false;
                message_rev = InputTxt.Text;


                rec_text();
                InputTxt.Enabled = true;
                InputTxt.Text = string.Empty;
                e.SuppressKeyPress = true; // Disable windows error sound
                InputTxt.HintText = "اكتب رسالتك هنا";

            }
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void radButtonNewAppointment_Click(object sender, EventArgs e)
        {

        }

        private void radListView1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (radListView1.SelectedItem != null)
            {
                message_rev = radListView1.SelectedItem.Text;


                InputTxt.Enabled = false;
                rec_text();
                talk = false;
                InputTxt.Enabled = true;
                InputTxt.HintText = "اكتب رسالتك هنا";

            }

        }

        private void radButton1_MouseDown(object sender, MouseEventArgs e)
        {
            //radButton1.BackColor = Color.DodgerBlue;
        }

        private void radButton1_MouseHover(object sender, EventArgs e)
        {
            radButton1.BackColor = Color.FromArgb(105, 181, 255);
            radButton1.ForeColor = Color.White;
            //radButton1.BorderColor = Color.Red;
            //this.radButton1.ButtonElement.BorderElement.PaintUsingParentShape = false;
            //this.radButton1.ButtonElement.ShowBorder = true;
            //this.radButton1.ButtonElement.BorderElement.BoxStyle = BorderBoxStyle.FourBorders;
            //this.radButton1.ButtonElement.BorderElement.TopColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.BottomColor = Color.Transparent;

            //this.radButton1.ButtonElement.BorderElement.LeftShadowColor = Color.Transparent;

            //this.radButton1.ButtonElement.BorderElement.TopShadowColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.RightShadowColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.BottomShadowColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.ForeColor4 = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.ForeColor2 = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.ForeColor3 = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.InnerColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.InnerColor2 = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.RightColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.InnerColor4 = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.LeftColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.InnerColor3 = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.TopColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.TopColor = Color.Transparent;
            //this.radButton1.ButtonElement.BorderElement.TopColor = Color.Transparent;

            //this.radButton1.ButtonElement.BorderElement.TopWidth = 1;
            //this.radButton1.ButtonElement.BorderElement.BottomColor = Color.FromArgb(105, 181, 255);
            //this.radButton1.ButtonElement.BorderElement.BottomWidth = 1;
            //this.radButton1.ButtonElement.BorderElement.LeftColor = Color.FromArgb(105, 181, 255);
            //this.radButton1.ButtonElement.BorderElement.LeftWidth = 1;
            //this.radButton1.ButtonElement.BorderElement.RightColor = Color.FromArgb(105, 181, 255);
            //this.radButton1.ButtonElement.BorderElement.RightWidth = 1;
        }

        private void radButton1_MouseLeave(object sender, EventArgs e)
        {
            //this.radButton1.ButtonElement.ShowBorder = true;

            radButton1.BackColor = Color.Transparent;
            radButton1.ForeColor = Color.FromArgb(105, 181, 255);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //button1.BackColor = Color.FromArgb(105, 181, 255);
            //button1.ForeColor = Color.White;




        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            radButton1.BackColor = Color.Transparent;
            radButton1.ForeColor = Color.FromArgb(105, 181, 255);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            talk = true;

            InputTxt.Enabled = false;
            message_rev = InputTxt.Text;


            rec_text();
            talk = false;
            InputTxt.Enabled = true;
            InputTxt.Text = string.Empty;
            InputTxt.HintText = "اكتب رسالتك هنا";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (voice == true)
            {
                InputTxt.HintText = "";
                pictureBox1.Enabled = false;
                radProgressBar1.Visible = true;
                InputTxt.Enabled = false;
                voice = false;
                timer2.Enabled = true;
                new recognitionArabic().Louding(true, false);
                //bunifuPictureBox1.Enabled = false;
                //bunifuPictureBox2.Enabled = true;
                pictureBox2.Image = Resources.block_microphone;

                //bunifuPictureBox2.FillColor = Color.Red;
            }
            else
            {

                voice = true;
                message_rev = new recognitionArabic().Louding(false, true);
                rec_text();
                pictureBox2.Image = Resources.add_record;
                InputTxt.Enabled = true;
                radProgressBar1.Visible = false;
                pictureBox1.Enabled = true;
                InputTxt.HintText = "اكتب رسالتك هنا";


            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }

    public class MyFormBehavior : RadFormBehavior
    {
        public MyFormBehavior(IComponentTreeHandler treeHandler, bool shouldCreateChildren) :
            base(treeHandler, shouldCreateChildren)
        {
        }

        public override Padding BorderWidth
        {
            get
            {
                return new Padding(1);
            }
        }
    }

    public class PatientsListViewVisualItem : SimpleListViewVisualItem
    {
        LightVisualElement topRightElement;

        public LightVisualElement TopRightElement
        {
            get
            {
                return this.topRightElement;
            }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(SimpleListViewVisualItem);
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            //this.topRightElement = new LightVisualElement();
            //this.topRightElement.StretchHorizontally = false;
            //this.topRightElement.StretchVertically = false;
            //this.topRightElement.DrawFill = true;
            //this.topRightElement.NumberOfColors = 1;
            //this.topRightElement.BackColor = Color.FromArgb(27, 4, 69);
            //this.topRightElement.ForeColor = Color.White;
            //this.topRightElement.Font = new Font("Segoe UI Semibold", 11f);
            //this.topRightElement.Alignment = ContentAlignment.TopRight;
            //this.topRightElement.Padding = new Padding(2);

            //this.Children.Add(this.topRightElement);
        }
    }

}
