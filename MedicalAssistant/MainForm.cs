using System;
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
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using NAudio.Wave;
using System.Threading;
//using Microsoft.Speech.Synthesis;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace MedicalAssistant
{

    public partial class MainForm : RadForm
    {
        List<string> CommendsWords = new List<string>();
        string genderVoice = "female";
        ArrayList TipsWords = new ArrayList();

        public class ObjectList
        {
            public int ID { get; set; }
            public string QS { get; set; }
            public string ANS { get; set; }
        }

        public WaveOutEvent spt = new WaveOutEvent(); // or WaveOutEvent()


        public List<ObjectList> RootObjects;


        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();

        // Configure the audio output.   

        // Handle the AudioStateChanged event.  
        void sre_AudioStateChanged(object sender, AudioStateChangedEventArgs e)
        {
            Console.WriteLine(e.AudioState);

            if (e.AudioState.ToString() == "Speech")
            {
                waveIn = new WaveIn();
                waveIn.DeviceNumber = 0;
                waveIn.DataAvailable += waveIn_DataAvailable;
                waveIn.RecordingStopped +=
                    new EventHandler<NAudio.Wave.StoppedEventArgs>(waveIn_RecordingStopped);
                waveIn.WaveFormat = new WaveFormat(16000, 1);
                writer = new WaveFileWriter(@"test.wav", waveIn.WaveFormat);
                Console.WriteLine("now StartRecording");

                waveIn.StartRecording();
                //recognizer.RecognizeAsync();

            }
            if (e.AudioState.ToString() == "Stopped")
            {
                //Thread.Sleep(300);

                waveIn.StopRecording();
                waveIn.Dispose();
                writer.Close();
                writer.Dispose();


                voice = true;
                //message_rev = new recognitionArabic().Louding(false, true);
                message_rev = new recognitionArabic().SpeakRecognition();
                //Console.WriteLine(message_rev);

                if (message_rev.Contains("الاستماع"))
                {
                    Console.WriteLine(message_rev.Replace("الاستماع", ""));

                }
                recognizer.RecognizeAsync();
                Thread.Sleep(100);

                //timer4.Stop();
            }
            // Handle event here.  
        }

        public MainForm()
        {
            CommendsWords.Add("المهام");
            CommendsWords.Add("الصفحه الرئيسيه");
            CommendsWords.Add("اخبار الصحه");
            CommendsWords.Add("الاعدادات");
            CommendsWords.Add("اضافه موعد");

            //CommendsWords.Add("الاخبار");
            //CommendsWords.Add("من انا");
            //CommendsWords.Add("علاج ضيق التنفس عند النوم بالأعشاب");

            //var mySuperDictionary = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(new Database.database().Questions()));

            RootObjects = JsonConvert.DeserializeObject<List<ObjectList>>(JsonConvert.SerializeObject(new Database.database().Questions()));


            //var jObject = JObject.Parse(new Database.database().Questions().ToString());


            //JavaScriptSerializer jss = new JavaScriptSerializer();
            //var obj = jsonObj;


            //Console.WriteLine(jsonObj);


            recognizer.LoadGrammarAsync(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.RecognizeAsync();

            //using (SpeechSynthesizer synth = new SpeechSynthesizer())
            //{

            //    // Configure the audio output.   
            //    synth.SetOutputToWaveFile(@"H:\test.wav");

            //    // Create a SoundPlayer instance to play output audio file.  
            //    System.Media.SoundPlayer m_SoundPlayer =
            //      new System.Media.SoundPlayer(@"H:\test.wav");

            //    // Build a prompt.  
            //    PromptBuilder builder = new PromptBuilder();
            //    builder.AppendText("This is sample output to a WAVE file.");

            //    // Speak the prompt.  
            //    synth.Speak(builder);
            //    m_SoundPlayer.Play();
            //}

            InitializeComponent();
            //recognizer.AudioStateChanged += new EventHandler<AudioStateChangedEventArgs>(sre_AudioStateChanged);




            timer4.Start();
            foreach (var rootObject in RootObjects)
            {
                if (rootObject.QS != null)
                {
                    Console.WriteLine(rootObject.QS);
                    this.radListView1.Items.AddRange(rootObject.QS);

                    CommendsWords.Add(rootObject.QS);

                    //Console.WriteLine("lol "+ rootObject.ANS);
                }
            }
            //this.radListView1.SelectedItem = null;
            //PatientsDataSet.QuestionsRow questionsRow = this.Tag as PatientsDataSet.QuestionsRow;
            //if (questionsRow != null)
            //{
            //    Console.WriteLine("lol");
            //    this.QS = questionsRow.QS;
            //    this.AS = questionsRow.AS;

            //}

            //foreach (PatientsDataSet.QuestionsRow person in DataSources.PatientsDataSet.Questions)
            //{
            //    Console.WriteLine("lol");

            //}
            //BindingSource bs = (BindingSource)dgvTestData.DataSource;
            //var dt = (bs.DataSource as DataSet).Tables[bs.DataMember];


            //foreach (PatientsDataSet.QuestionsRow person in DataSources.PatientsDataSet.Questions)
            //{
            //    Console.WriteLine(person.QS);
            //}
            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
            this.SetCurrentPageViewPage(this.radPageViewPageDashboard);


            panel1.VerticalScroll.Enabled = true;
            panel1.VerticalScroll.Visible = true;

            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(0, 500);
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            panel5.BackgroundImage = Gradient2D(panel5.ClientRectangle, Color.LightPink, Color.LightPink, Color.LightPink, Color.LightPink);






            //this.SetToggleButtonsStateImages();
            //this.radChat1.Author = new Author(Properties.Resources.icons8_Chat_32, "Nancy");
            string startupPath = Directory.GetCurrentDirectory();
            //ThemeResolutionService.LoadPackageFile(startupPath.Replace("bin\\Debug", "").ToString() + @"dll\"+ "MedicalAppTheme.tssp");
            ThemeResolutionService.LoadPackageResource("MedicalAssistant.Themes.MedicalAppTheme.tssp");

            RadMessageBox.Instance.ThemeName = "MedicalAppTheme";
            DataSources.PatientsDataSet = this.patientsDataSet;
            DataSources.PatientsDataSet.Appointments.AppointmentsRowChanged += Appointments_AppointmentsRowChanged;



            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

        }
        public void rec_text()
        {
            //radListView1.Enabled = false;

            ticks = 0;
            timer2.Enabled = false;

            if (message_rev != "")
            {
                this.radListView1.Enabled = false;

                SoundPlayer Send = new SoundPlayer("Sounds\\SOUND1.wav");
                SoundPlayer Rcv = new SoundPlayer("Sounds\\SOUND2.wav");
                send(message_rev);
                Send.Play();

                var t = new System.Windows.Forms.Timer();
                t.Interval = 1000 + (message_rev.Length * 100);
                //t.Interval = 1000 + (1 * 100);
                txtTyping.Show();

                t.Tick += (s, d) =>
                {
                    txtTyping.Hide();
                    if (CommendsWords.Contains(message_rev) == true)
                    {

                        foreach (var rootObject in RootObjects)
                        {
                            if (rootObject.QS != null)
                            {
                                if (message_rev == rootObject.QS)
                                {

                                    message_send = rootObject.ANS;
                                    InputTxt.Enabled = false;
                                    InputTxt.HintText = "اكتب رسالتك هنا";
                                    //message_send = new Database.database().Database(message_send, message_rev);
                                    AddIncomming(message_send);

                                    spt = new recognitionArabic().CloudTextToSpeech(message_send, genderVoice);
                                    timer3.Start();
                                    Debug.WriteLine("message_send " + message_send);
                                    talk = false;


                                    //timer3.Start();

                                }

                            }
                        }



                        if (message_rev == CommendsWords[0])
                        {
                            sp_txt_ok();
                            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
                        }
                        if (message_rev == CommendsWords[4])
                        {
                            sp_txt_ok();
                            AppointmentForm addAppointmentForm = new AppointmentForm();
                            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
                            addAppointmentForm.ShowDialog(this);

                            this.SetSchedulerAppointmentsBackground();
                        }

                        if (message_rev == "لدي صداع")
                        {
                            sp_txt_ok();
                            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
                        }

                        //if (message_rev == CommendsWords[1])
                        //{
                        //    sp_txt_ok();

                        //    this.SetCurrentPageViewPage(this.radPageViewPageCharts);

                        //}

                        //if (message_rev == CommendsWords[3])
                        //{
                        //    message_send = "";
                        //    InputTxt.Enabled = false;
                        //    InputTxt.HintText = "اكتب رسالتك هنا";
                        //    //message_send = new Database.database().Database(message_send, message_rev);
                        //    new recognitionArabic().CloudTextToSpeech(message_send);
                        //    Debug.WriteLine("message_send " + message_send);
                        //    AddIncomming(message_send);
                        //    talk = false;

                        //    InputTxt.Enabled = true;


                        //    //sp_txt_ok();
                        //    //try
                        //    //{
                        //    //    //f();
                        //    //}
                        //    //catch { }
                        //    //message_send = "حسنا اضف كمثال : المعياع مع الدكتور احمد في تاريخ اليوم الساعه الثانيه عشر";
                        //    //new recognitionArabic().CloudTextToSpeech(message_send);
                        //    //AddIncomming(message_send);

                        //    //await DemoSchandeler DemoSchandeler = new DemoSchandeler();
                        //    //DemoSchandeler.ShowDialog();


                        //    //DemoSchandeler modalForm = new DemoSchandeler();
                        //    //BeginInvoke((Action)(() => modalForm.ShowDialog()));

                        //    //DemoSchandeler DemoSchandeler = new DemoSchandeler();

                        //    //// prepare a operation to call it async --> your ShowDialog-call
                        //    //var asyncCall = new Action(() => BeginInvoke(
                        //    //                                 new Action(() => DemoSchandeler.Show())
                        //    //                           ));

                        //    //asyncCall.BeginInvoke(ar => DemoSchandeler = null, null);
                        //    //await new DemoSchandeler().Show();




                        //    //this.SetSchedulerAppointmentsBackground();
                        //    //message_rev = "";
                        //}
                    }
                    else
                    {
                        message_send = new Database.database().Database(message_send, message_rev);
                        new recognitionArabic().CloudTextToSpeech(message_send, genderVoice);
                        Debug.WriteLine("message_send " + message_send);
                        AddIncomming(message_send);
                        timer3.Start();

                    }
                    Rcv.Play();
                    t.Stop();
                };
                t.Start(); // Start Timer


            }

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
        int len = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);

            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {




                TipsWords = new Database.database().Tips_database();

                i = i + 1;
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    foreach (string fg in TipsWords)
                    {
                        tip = fg;

                        //tip = new database().Tips_database();
                        worker.ReportProgress(i * 1);
                        Thread.Sleep(100000);
                    }



                    //label1.Text = tip;
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ArrayList TipsWords = new ArrayList();


            //TipsWords = new Database.database().Tips_database();
            //Debug.WriteLine(TipsWords);


            //label1.Text = (e.ProgressPercentage.ToString());

            //txt = tip;



            //foreach (string fg in TipsWords)
            //{
            //    tip = fg;
            if (tip != "")
            {
                Debug.WriteLine(tip);
                if (spt.PlaybackState == PlaybackState.Stopped)
                {
                    this.radListView1.Enabled = false;
                    this.pictureBox2.Enabled = false;
                    this.pictureBox1.Enabled = false; InputTxt.Enabled = false;
                    this.InputTxt.Enabled = false;
                    talk = true;



                    spt = new recognitionArabic().CloudTextToSpeech("نصيحة : " + tip, "male");
                    len = tip.Length;
                    //label1.Text = "";
                    timer1.Interval = len;

                    timer1.Start();
                    timer3.Start();

                }


                //System.Threading.Thread.Sleep(20000);

            }
            //}
            //if (time1 > len)
            //{
            //    time1 = 0;
            //    timer1.Stop();
            //}
        }

        public int page = 1;
        public DateTime CurrentDate
        {
            get { return DateTime.Now; }
        }
        private void main5_Load(object sender, EventArgs e)
        {
            AddIncomming("ماذا لديك");


            this.appointmentsTableAdapter.Fill(this.patientsDataSet.Appointments);

            this.UpdateSelectedPageData();


            this.radCalendarDashboard.FocusedDate = CurrentDate;

            // Schedule
            this.radCalendarSchedule.FocusedDate = CurrentDate;
            this.CustomizeCurrentSchedulerView();
            this.radSchedulerNavigator1.TimelineViewButton.Visibility = ElementVisibility.Hidden;
            //this.radScheduler1.SchedulerElement.ViewElement.AppointmentMargin = new Padding(0, 0, 0, 1);
            this.AddSchedulerAppointmentBackgrounds();
            this.BindScheduler();



            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
                backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
                backgroundWorker1.RunWorkerAsync();
            }

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


        private void Appointments_AppointmentsRowChanged(object sender, PatientsDataSet.AppointmentsRowChangeEvent e)
        {
            this.UpdateTodayAndTomorrowLabels();
        }

        private void scheduleToggleButton_Click(object sender, EventArgs e)
        {
            //this.ResetToggleButtons(this.scheduleToggleButton);
            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
        }


        private void UpdateSelectedPageData()
        {


            if (this.radPageView1.SelectedPage == this.radPageViewPageDashboard)
            {
                this.UpdateTodayAndTomorrowLabels();
            }
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
            //e.VisualItem = new PatientsListViewVisualItem();
        }



        private void newAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm addAppointmentForm = new AppointmentForm();
            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
            addAppointmentForm.ShowDialog(this);

            this.SetSchedulerAppointmentsBackground();
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


        public void sp_txt_ok()
        {
            AddIncomming("حسنا");

            spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
            timer3.Start();

        }


        bool talk = false;





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

        private void radButton1_MouseHover(object sender, EventArgs e)
        {
            radButton1.BackColor = Color.FromArgb(105, 181, 255);
            radButton1.ForeColor = Color.White;
        }

        private void radButton1_MouseLeave(object sender, EventArgs e)
        {

            radButton1.BackColor = Color.Transparent;
            radButton1.ForeColor = Color.FromArgb(105, 181, 255);

        }


        private void radButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

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
        WaveIn waveIn;
        WaveFileWriter writer;

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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (voice == true)
            {
                recognizer.RecognizeAsyncCancel();

                timer4.Enabled = false;

                InputTxt.HintText = "";
                pictureBox1.Enabled = false;
                radProgressBar1.Visible = true;
                InputTxt.Enabled = false;
                voice = false;
                timer2.Enabled = true;
                //new recognitionArabic().Louding(true, false);
                //var result = new recognitionArabic().SpeakRecognitionRecord();

                //var RecordObjectList = new recognitionArabic().SpeakRecognitionRecord();
                //waveIn = RecordObjectList.waveIn;
                //writer = RecordObjectList.writer;


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
                //message_rev = new recognitionArabic().Louding(false, true);
                message_rev = new recognitionArabic().SpeakRecognition();




                rec_text();
                pictureBox2.Image = Resources.add_record;
                InputTxt.Enabled = true;
                radProgressBar1.Visible = false;
                pictureBox1.Enabled = true;
                InputTxt.HintText = "اكتب رسالتك هنا";
                recognizer.RecognizeAsync();
                timer4.Enabled = true;


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
        int time1 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1 = time1 + 1;
            if (tip != "")
            {
                if (time1 < len)
                {
                    label1.Text = tip.Substring(0, time1);
                    if (label1.ForeColor == Color.Black)
                    {
                        label1.ForeColor = Color.FromArgb(15, 82, 186);
                    }
                    else
                    {
                        label1.ForeColor = Color.Black;
                    }
                    Thread.Sleep(100);

                    //time1 = 0;
                    //timer1.Stop();
                }
                else
                {
                    time1 = 0;
                    timer1.Stop();
                    label1.ForeColor = Color.Black;
                }
            }


        }

        int slc;
        private void radListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (slc != radListView1.SelectedIndex)
            {
                if (spt.PlaybackState == PlaybackState.Stopped)
                {
                    {
                        this.pictureBox2.Enabled = false;
                        this.pictureBox1.Enabled = false;

                        Console.WriteLine(slc);

                        //radListView1.ShowItemToolTips = false;

                        //if (radListView1.SelectedItem != null)

                        message_rev = radListView1.SelectedItem.Text;
                        //radListView1.ShowItemToolTips = false;

                        rec_text();
                        //radListView1.ShowItemToolTips = true;



                        //Thread thread1 = new Thread(waitSpech);
                        //thread1.IsBackground = true;
                        //thread1.Start();




                        //radListView1.SelectedItem.Text = "اختر الموعد";


                        slc = radListView1.SelectedIndex;
                    }
                    //radListView1.Visible = true;
                    //radListView1.Enabled = true;
                    //radListView1.ShowItemToolTips = true;
                    //pictureBox2.Enabled = true;

                    //radListView1.Enabled = true;
                }
                //this.radListView1.Enabled = false;
                //this.pictureBox2.Enabled = false;



            }



        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (spt.PlaybackState != PlaybackState.Playing)
            {

                this.radListView1.Enabled = true;
                this.pictureBox2.Enabled = true;
                InputTxt.Enabled = true;
                pictureBox1.Enabled = true;
                talk = false;

                InputTxt.Enabled = true;
                InputTxt.HintText = "اكتب رسالتك هنا";
                timer3.Stop();
            }

        }
        int one = 0;
        int two = 0;

        [Obsolete]
        private void timer4_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(recognizer.AudioState);

            if (recognizer.AudioState.ToString() == "Speech")
            {
                if (one == 0)
                {
                    waveIn = new WaveIn();
                    waveIn.DeviceNumber = 0;
                    waveIn.DataAvailable += waveIn_DataAvailable;
                    waveIn.RecordingStopped +=
                        new EventHandler<NAudio.Wave.StoppedEventArgs>(waveIn_RecordingStopped);
                    waveIn.WaveFormat = new WaveFormat(16000, 1);
                    writer = new WaveFileWriter(@"test.wav", waveIn.WaveFormat);
                    Console.WriteLine("now StartRecording");

                    waveIn.StartRecording();
                }
                //recognizer.RecognizeAsync();
                one = 1;
            }
            if (recognizer.AudioState.ToString() == "Stopped")
            {
                //Thread.Sleep(300);
                try
                {


                    waveIn.StopRecording();
                    waveIn.Dispose();
                    writer.Close();
                    writer.Dispose();


                voice = true;
                    //message_rev = new recognitionArabic().Louding(false, true);
                    message_rev = new recognitionArabic().SpeakRecognition();
                    //Console.WriteLine(message_rev);

                    if (message_rev.Contains("الاستماع"))
                    {
                        message_rev = message_rev.Replace("الاستماع ", "");
                        Console.WriteLine(message_rev);
                        if (message_rev == CommendsWords[0])
                        {
                            sp_txt_ok();
                            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
                        }
                        if (message_rev == CommendsWords[4])
                        {
                            sp_txt_ok();
                            AppointmentForm addAppointmentForm = new AppointmentForm();
                            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
                            addAppointmentForm.AllowShowFocusCues = true;
                            addAppointmentForm.ShowIcon = true;
                            addAppointmentForm.ShowDialog();


                            this.SetSchedulerAppointmentsBackground();
                        }
                    }
                    recognizer.RecognizeAsync();
                    Thread.Sleep(100);
                    one = 0;
                }
                catch
                {
                    //recognizer.RecognizeAsync();

                }
                //timer4.Stop();
            }
            // Handle event here.  
        
        // Handle event here.  

        //Console.WriteLine(recognizer.AudioState);

    }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }


        //public class MyFormBehavior : RadFormBehavior
        //{
        //    public MyFormBehavior(IComponentTreeHandler treeHandler, bool shouldCreateChildren) :
        //        base(treeHandler, shouldCreateChildren)
        //    {
        //    }

        //    public override Padding BorderWidth
        //    {
        //        get
        //        {
        //            return new Padding(1);
        //        }
        //    }
        //}

        //public class PatientsListViewVisualItem : SimpleListViewVisualItem
        //{
        //    LightVisualElement topRightElement;

        //    public LightVisualElement TopRightElement
        //    {
        //        get
        //        {
        //            return this.topRightElement;
        //        }
        //    }

        //    protected override Type ThemeEffectiveType
        //    {
        //        get
        //        {
        //            return typeof(SimpleListViewVisualItem);
        //        }
        //    }

        //    protected override void CreateChildElements()
        //    {
        //        base.CreateChildElements();
        //    }
        //}


    }
}
    
