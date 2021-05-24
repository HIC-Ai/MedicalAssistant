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
using System.Linq;
using MedicalAssistant;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Device.Location;
using System.Net;
using Newtonsoft.Json.Linq;

namespace MedicalAssistant
{

    public partial class MainForm : RadForm
    {
        bool tip_call = true;
        int slc;
        bool talk = false;
        public int page = 1;
        int time1 = 0;
        public DateTime CurrentDate
        {
            get { return DateTime.Now; }
        }
        List<string> CommendsWords = new List<string>();
        string genderVoice = "female";
        ArrayList TipsWords = new ArrayList();
        int one = 0;
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

        WaveIn waveIn;
        WaveFileWriter writer;

        WaveIn waveIn2;
        WaveFileWriter writer2;

        string tip = "";
        int i = 0;
        int len = 0;
        public class ObjectList
        {
            public int ID { get; set; }
            public string QS { get; set; }
            public string ANS { get; set; }
        }

        public WaveOutEvent spt = new WaveOutEvent();


        public List<ObjectList> RootObjects;


        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();


        private double LatInicial;
        private double LngInicial;

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
        public MainForm()
        {
            CommendsWords.Add("المهام");
            CommendsWords.Add("الصفحه الرئيسيه");
            CommendsWords.Add("اخبار الصحه");
            CommendsWords.Add("الاعدادات");
            CommendsWords.Add("اضافه موعد");
            CommendsWords.Add("خروج");
            CommendsWords.Add("ما هي مواعيد اليوم");


            RootObjects = JsonConvert.DeserializeObject<List<ObjectList>>(JsonConvert.SerializeObject(new Database.database().Questions()));

            InitializeComponent();



            //جلب الاسئله والاجوبه من الداتا بيز ووضعها في صدنوق الاقتراحات

            foreach (var rootObject in RootObjects)
            {
                if (rootObject.QS != null)
                {
                    Console.WriteLine(rootObject.QS);
                    this.radListView1.Items.AddRange(rootObject.QS);

                    CommendsWords.Add(rootObject.QS);

                }
            }
            //جعل الصفحه الرئسيه هي البدايه في الداش بورد

            this.SetCurrentPageViewPage(this.radPageViewPageDashboard);




            panel1.VerticalScroll.Enabled = true;
            panel1.VerticalScroll.Visible = true;

            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(0, 500);
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            panel5.BackgroundImage = Gradient2D(panel5.ClientRectangle, Color.LightPink, Color.LightPink, Color.LightPink, Color.LightPink);





            //وضع ثيم لبعض التصميم جاهز
            //ThemeResolutionService.LoadPackageFile(Directory.GetCurrentDirectory() + @"\Themes\MedicalAppTheme.tssp");
            //RadMessageBox.Instance.ThemeName = "MedicalAppTheme";
            DataSources.PatientsDataSet = this.patientsDataSet;
            DataSources.PatientsDataSet.Appointments.AppointmentsRowChanged += Appointments_AppointmentsRowChanged;





            //بدا الصنائح في الخليفه
            Tips_call_in_pack.WorkerReportsProgress = true;
            Tips_call_in_pack.WorkerSupportsCancellation = true;



        }
        private void main5_Load(object sender, EventArgs e)
        {

            watcher = new GeoCoordinateWatcher();
            // Catch the StatusChanged event.  
            watcher.StatusChanged += Watcher_StatusChanged;
            // Start the watcher.  
            watcher.Start();

            //panelChatMain.Visible = false;
            this.Size = new Size(1322, 572);
            AddIncomming("ماذا لديك");


            this.appointmentsTableAdapter.Fill(this.patientsDataSet.Appointments);

            this.UpdateSelectedPageData();


            this.radCalendarDashboard.FocusedDate = CurrentDate;

            // Schedule
            //this.radCalendarSchedule.FocusedDate = CurrentDate;
            this.CustomizeCurrentSchedulerView();
            this.radSchedulerNavigator2.TimelineViewButton.Visibility = ElementVisibility.Hidden;
            this.AddSchedulerAppointmentBackgrounds();
            this.BindScheduler();



            if (Tips_call_in_pack.IsBusy != true)
            {
                Tips_call_in_pack.RunWorkerAsync();
            }
            var t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += (s, d) =>
            {
                if (radLabelTodayAppointmentsCount.Text != "0".ToString())
                {
                    spt = new recognitionArabic().CloudTextToSpeech("لديك اليوم " + radLabelTodayAppointmentsCount.Text + "مواعيد", "male");
                }
                else
                {
                    spt = new recognitionArabic().CloudTextToSpeech("ليس لديك مواعيد اليوم", "male");

                }
                t.Stop();
            };
            t.Start();

            recognizer.LoadGrammarAsync(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.RecognizeAsync();

            timer4_realTime_recognizer.Start();



        }

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e) // Find GeoLocation of Device  
        {
            try
            {
                if (e.Status == GeoPositionStatus.Ready)
                {
                    // Display the latitude and longitude.  
                    if (watcher.Position.Location.IsUnknown)
                    {
                        LatInicial = 0;
                        LngInicial = 0;
                    }
                    else
                    {
                        LatInicial = watcher.Position.Location.Latitude;
                        LngInicial = watcher.Position.Location.Longitude;


                        JArray array = new JArray();


                        WebRequest request = WebRequest.Create(string.Format("https://api.geoapify.com/v2/places?categories=healthcare.hospital&filter=circle:{0},{1},10000&limit=20&apiKey=1b48259b810e48ddb151889f9ea58db0", LngInicial, LatInicial));
                        //
                        request.Method = "GET";
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        string str = reader.ReadToEnd();
                        //Console.WriteLine(str);
                        dynamic stuff = JsonConvert.DeserializeObject(str);
;
                        //JObject joResponse = JObject.Parse(str);
                        //JObject result = (JObject)joResponse["features"];
                        //array = (JArray)result["Detail"];
                        //string statu = array[0]["dlrStat"].ToString();
                        //RootObjects = JsonConvert.DeserializeObject<List<ObjectList>>(JsonConvert.SerializeObject(str));




                        foreach (var rootObject in stuff["features"])
                        {
                            {
                                double LngInicial_ = (rootObject["properties"]["lon"]);
                                double LatInicial_ = (rootObject["properties"]["lat"]);
                                string name = (rootObject["properties"]["name"]);


                                //gMapControl1.DragButton = MouseButtons.Left;
                                //gMapControl1.CanDragMap = true;
                                //gMapControl1.MapProvider = GMapProviders.GoogleMap;
                                gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);

                                markerOverlay = new GMapOverlay("موقعك");
                                marker = new GMarkerGoogle(new PointLatLng(LatInicial_, LngInicial_), GMarkerGoogleType.blue);
                                markerOverlay.Markers.Add(marker);
                                marker.ToolTipMode = MarkerTooltipMode.Always;
                                marker.ToolTipText = name;
                                //marker.ToolTip.Foreground = Brushes.Fuchsia;

                                gMapControl1.Overlays.Add(markerOverlay);

                            }
                        }

                        gMapControl1.DragButton = MouseButtons.Left;
                        gMapControl1.CanDragMap = true;
                        gMapControl1.MapProvider = GMapProviders.GoogleMap;
                        gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
                        gMapControl1.MinZoom = 0;
                        gMapControl1.MaxZoom = 24;
                        gMapControl1.Zoom = 18;
                        gMapControl1.AutoScroll = true;

                        markerOverlay = new GMapOverlay("موقعك");
                        marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue);
                        markerOverlay.Markers.Add(marker);
                        marker.ToolTipMode = MarkerTooltipMode.Always;
                        //marker.ToolTipText = string.Format("موقعك الان:\n Latitud:{0}\n Longitud:{1}", LatInicial, LngInicial);
                        marker.ToolTipText = string.Format("موقعك الان");
                        gMapControl1.Overlays.Add(markerOverlay);





                    }
                }
                else
                {
                    LatInicial = 0;
                    LngInicial = 0;
                }
            }
            catch (Exception)
            {
                LatInicial = 0;
                LngInicial = 0;
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
            timer1_tips_enim.Start();
        }

        public void rec_text()
        {
            ticks = 0;
            timer2_radProgressBar.Enabled = false;

            this.radListView1.Enabled = false;

            SoundPlayer Send = new SoundPlayer("Sounds\\SOUND1.wav");
            SoundPlayer Rcv = new SoundPlayer("Sounds\\SOUND2.wav");
            send(message_rev);
            Send.Play();

            var t = new System.Windows.Forms.Timer();
            t.Interval = 1000 + (message_rev.Length * 100);
            txtTyping.Show();
            bool sm = false;
            t.Tick += (s, d) =>
            {
                txtTyping.Hide();
                if (message_rev != string.Empty)
                {
                    foreach (var rootObject in RootObjects)
                    {
                        if (rootObject.QS != null)
                        {
                            if (message_rev == rootObject.QS)
                            {
                                sm = true;
                                message_send = rootObject.ANS;
                                InputTxt.Enabled = false;
                                InputTxt.HintText = "اكتب رسالتك هنا";
                                AddIncomming(message_send);

                                spt = new recognitionArabic().CloudTextToSpeech(message_send, genderVoice);
                                timer3_wait_spech.Start();
                                Debug.WriteLine("message_send " + message_send);
                                talk = false;


                            }

                        }
                    }
                    if (sm == false)
                    {
                        if (CommendsWords.Contains(message_rev) == true)
                        {
                            if (message_rev == CommendsWords[0])
                            {
                                spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
                                timer3_wait_spech.Start();
                                //sp_txt_ok();
                                this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
                            }
                            if (message_rev == CommendsWords[1])
                            {
                                spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
                                timer3_wait_spech.Start();
                                sp_txt_ok();
                                this.SetCurrentPageViewPage(this.radPageViewPageDashboard);
                            }
                            if (message_rev == CommendsWords[2])
                            {
                                spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
                                timer3_wait_spech.Start();
                                sp_txt_ok();
                                this.SetCurrentPageViewPage(this.radPageViewPageCharts);
                            }
                            if (message_rev == CommendsWords[3])
                            {
                                spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
                                timer3_wait_spech.Start();
                                //sp_txt_ok();
                                this.SetCurrentPageViewPage(this.radPageViewPageSettings);
                            }
                            if (message_rev == CommendsWords[4])
                            {
                                sp_txt_ok();

                                Console.WriteLine("addAppointmentForm");
                                start_record_stop.Enabled = false;
                                InputTxt.Enabled = false;
                                voice = false;
                                timer2_radProgressBar.Enabled = true;
                                send_message.Enabled = false;
                                start_record_stop.Enabled = false;


                                timer4_realTime_recognizer.Enabled = false;
                                tip_call = false;
                                message_rev = string.Empty;
                                DemoSchandeler2 addAppointmentForm = new DemoSchandeler2();
                                addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
                                addAppointmentForm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                                addAppointmentForm.ShowDialog();




                            }
                            if (message_rev == CommendsWords[5])
                            {
                                spt = new recognitionArabic().CloudTextToSpeech("يتم الخروج الان و نتمني لك صحة وهناء", genderVoice);
                                timer3_wait_spech.Start();
                                timer5_exit.Start();
                                radButton1.Enabled = false;

                            }
                            if (message_rev == CommendsWords[6])
                            {
                                sp_txt_ok();

                                Console.WriteLine(message_rev);
                                DataRow[] todaysAndTomorrowsAppointments = this.patientsDataSet.Appointments.Select("Start > #" + CurrentDate.ToString("d", CultureInfo.InvariantCulture) + "# AND Start < #" + CurrentDate.AddDays(2).ToString("d", CultureInfo.InvariantCulture) + "#");
                                int todayAppointmentsCount = 0;
                                DateTime lastAppointmentTodayDateTime = DateTime.MinValue;
                                DateTime firstAppointmentTodayDateTime = DateTime.MaxValue;
                                foreach (PatientsDataSet.AppointmentsRow appointment in todaysAndTomorrowsAppointments)
                                {
                                    if (appointment.Start.Day == CurrentDate.Day)
                                    {
                                        todayAppointmentsCount++;
                                        if (lastAppointmentTodayDateTime < appointment.Start)
                                        {

                                            string name, place;
                                            name = String.Join(" ", appointment.NameDoc.Split(' ').Reverse().ToArray());
                                            place = String.Join(" ", appointment.Description.Split(' ').Reverse().ToArray());

                                            spt = new recognitionArabic().CloudTextToSpeech("لديك ميعاد مع الدكتور " + name + "والموضوع عن " + place + "الساعة  " + appointment.Start.Hour, gender: "male");
                                            break;
                                        }
                                    }
                                }
                            }
                        }


                        else
                        {
                            message_send = "خسنا سوف اتذكر ذالك";
                            new recognitionArabic().CloudTextToSpeech(message_send, genderVoice);
                            Debug.WriteLine("message_send " + message_send);
                            AddIncomming(message_send);
                            timer3_wait_spech.Start();
                        }

                    }
                    Rcv.Play();
                }

                t.Stop();
            };
            t.Start();




        }


        int ticks = 0;
        private void timer2_Tick_radProgressBar(object sender, EventArgs e)
        {
            ticks++;
            radProgressBar1.Value1 = ticks;
            if (ticks == 100)
            {
                timer1_tips_enim.Enabled = false;
                ticks = 0;
            }
        }

        public void sp_txt_ok()
        {
            AddIncomming("حسنا");

            spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
            timer3_wait_spech.Start();

        }


        private void radButton1_Click(object sender, EventArgs e)
        {
            radButton1.Enabled = false;
            tip_call = false;
            if (spt.PlaybackState == PlaybackState.Playing)
            {
                spt.Stop();
            }

            spt = new recognitionArabic().CloudTextToSpeech("يتم الخروج الان و نتمني لك صحة وهناء", genderVoice);
            timer3_wait_spech.Start();
            timer5_exit.Start();

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
        void waveIn2_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                writer2.WriteData(e.Buffer, 0, e.BytesRecorded);

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
                writer.Close();
            }
            catch
            {

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (voice == true)
            {
                timer4_realTime_recognizer.Enabled = false;
                recognizer.RecognizeAsyncStop();
                recognizer.RecognizeAsyncCancel();


                start_record_stop.Enabled = false;

                InputTxt.HintText = "";
                radProgressBar1.Visible = true;
                InputTxt.Enabled = false;
                voice = false;
                timer2_radProgressBar.Enabled = true;



                waveIn = new WaveIn();
                waveIn.DeviceNumber = 0;
                waveIn.DataAvailable += waveIn_DataAvailable;
                waveIn.WaveFormat = new WaveFormat(16000, 1);
                writer = new WaveFileWriter("testRecordButton.wav", waveIn.WaveFormat);
                waveIn.StartRecording();


                send_message.Image = Resources.block_microphone;




            }
            else
            {
                if (waveIn != null)
                {
                    if (writer != null)
                    {
                        waveIn.StopRecording();
                        waveIn.Dispose();
                        writer.Close();
                        writer.Dispose();


                        voice = true;
                        message_rev = new recognitionArabic().SpeakRecognition(file: "testRecordButton.wav");




                        rec_text();
                        send_message.Image = Resources.add_record;
                        InputTxt.Enabled = true;
                        radProgressBar1.Visible = false;
                        start_record_stop.Enabled = true;
                        InputTxt.HintText = "اكتب رسالتك هنا";
                    }
                }
                recognizer.RecognizeAsync();
                timer4_realTime_recognizer.Enabled = true;


            }
        }



        private void timer1_Tick__tips_enim(object sender, EventArgs e)
        {

            time1 = time1 + 1; // عمل حاويه لتامير اذا تم انتهاء من مدي الصنيجه
            if (tip != "")
            {
                if (time1 < len)  // اذا كان النيحه فارغه لا يكمل
                {
                    label1.Text = tip.Substring(0, time1 * 4); // قطع النصيحه لكل 4 احرف وعمل اينيمشن بها
                    if (label1.ForeColor == Color.Black) // اذا كان االون اسود بعد القطع الاول يتم تحويله ازرق
                    {
                        label1.ForeColor = Color.FromArgb(15, 82, 186);
                    }
                    else
                    {
                        label1.ForeColor = Color.Black; // اذا كان االون ازرق بعد القطع الاول يتم تحويله اسود
                    }
                    Thread.Sleep(100); // وضع فتره زمنيه لحين الانتهائ من قول النصيحه حتي لا يحدث مشاكل
                }
                else
                {
                    label1.ForeColor = Color.Black; // جعل اخر لون للتصيحه اسود
                    time1 = 0; // جعل الحاويه فارغه حتي يبدا نصيحه اخري
                    timer1_tips_enim.Stop(); // ايقاف تايمر الاينمي لبدا نصيحه اخري
                }
            }


        }

        private void radListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (slc != radListView1.SelectedIndex)
            {
                if (spt.PlaybackState == PlaybackState.Stopped)
                {
                    {
                        this.send_message.Enabled = false;
                        this.start_record_stop.Enabled = false;

                        Console.WriteLine(slc);



                        message_rev = radListView1.SelectedItem.Text;

                        rec_text();


                        slc = radListView1.SelectedIndex;
                    }

                }


            }



        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (spt != null)
            {
                if (spt.PlaybackState != PlaybackState.Playing) // اذا كان الصوت انتهي ام لا
                {

                    this.radListView1.Enabled = true; // اعاده تفعيل صندوف اقتراحات في الشات
                    this.send_message.Enabled = true; // اعاده تفعيل ارسال رساله في الشات
                    InputTxt.Enabled = true; // اعاده تفعيل كتابه رساله في الشات
                    start_record_stop.Enabled = true; // اعاده تفعيل كتابه تسحجيل صوت في الشات
                    talk = false;

                    InputTxt.HintText = "اكتب رسالتك هنا";
                    timer3_wait_spech.Stop(); // اياف تايمر النصيحه
                }
            }
            else
            {
                timer3_wait_spech.Stop(); // اياف تايمر النصيحه اذا واجهه اي خطا في النصيحه

            }

        }
        string message_rev_real = "";
        private void timer4_Tick_realTime_recognizer(object sender, EventArgs e)
        {
            if (recognizer != null)
            {
                if (recognizer.AudioState.ToString() == "Speech")
                {
                    try
                    {
                        if (one == 0)
                        {
                            waveIn2 = new WaveIn();
                            waveIn2.DeviceNumber = 0;
                            waveIn2.DataAvailable += waveIn2_DataAvailable;
                            waveIn2.WaveFormat = new WaveFormat(16000, 1);
                            writer2 = new WaveFileWriter(@"testReail.wav", waveIn2.WaveFormat);
                            Console.WriteLine("now StartRecording");

                            waveIn2.StartRecording();

                        }
                        one = 1;
                    }
                    catch { }

                }

                if (recognizer.AudioState.ToString() == "Stopped")
                {

                    if (waveIn2 != null)
                    {

                        waveIn2.StopRecording();
                        waveIn2.Dispose();


                        writer2.Close();
                        writer2.Dispose();


                        voice = true;
                        string message_rev_real2 = new recognitionArabic().SpeakRecognition("testReail.wav");
                        if (message_rev_real != message_rev_real2)
                        {
                            //Console.WriteLine(message_rev);

                            if (message_rev_real2.Contains("الاستماع"))
                            {
                                message_rev = message_rev_real2.Replace("الاستماع ", "");
                                Console.WriteLine(message_rev);
                                if (message_rev == CommendsWords[0])
                                {
                                    spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
                                    timer3_wait_spech.Start();
                                    this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
                                }
                                if (message_rev == CommendsWords[1])
                                {
                                    spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
                                    timer3_wait_spech.Start();
                                    this.SetCurrentPageViewPage(this.radPageViewPageDashboard);
                                }
                                if (message_rev == CommendsWords[2])
                                {
                                    spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
                                    timer3_wait_spech.Start();
                                    this.SetCurrentPageViewPage(this.radPageViewPageCharts);
                                }
                                if (message_rev == CommendsWords[3])
                                {
                                    spt = new recognitionArabic().CloudTextToSpeech("حسنا", genderVoice);
                                    timer3_wait_spech.Start();
                                    this.SetCurrentPageViewPage(this.radPageViewPageSettings);
                                }
                                if (message_rev == CommendsWords[4])
                                {

                                    start_record_stop.Enabled = false;
                                    InputTxt.Enabled = false;
                                    voice = false;
                                    timer2_radProgressBar.Enabled = true;
                                    send_message.Enabled = false;
                                    start_record_stop.Enabled = false;


                                    timer4_realTime_recognizer.Enabled = false;
                                    if (spt.PlaybackState == PlaybackState.Playing)
                                    {
                                        spt.Stop();
                                    }

                                    tip_call = false;




                                    DemoSchandeler2 addAppointmentForm = new DemoSchandeler2();
                                    addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
                                    addAppointmentForm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                                    addAppointmentForm.ShowDialog();


                                }
                                if (message_rev == CommendsWords[5])
                                {
                                    spt = new recognitionArabic().CloudTextToSpeech("يتم الخروج الان و نتمني لك صحة وهناء", genderVoice);
                                    timer3_wait_spech.Start();
                                    timer5_exit.Start();
                                    radButton1.Enabled = false;

                                }
                                if (message_rev == CommendsWords[6])
                                {
                                    Console.WriteLine(message_rev);
                                    DataRow[] todaysAndTomorrowsAppointments = this.patientsDataSet.Appointments.Select("Start > #" + CurrentDate.ToString("d", CultureInfo.InvariantCulture) + "# AND Start < #" + CurrentDate.AddDays(2).ToString("d", CultureInfo.InvariantCulture) + "#");
                                    int todayAppointmentsCount = 0;
                                    DateTime lastAppointmentTodayDateTime = DateTime.MinValue;
                                    DateTime firstAppointmentTodayDateTime = DateTime.MaxValue;
                                    foreach (PatientsDataSet.AppointmentsRow appointment in todaysAndTomorrowsAppointments)
                                    {
                                        if (appointment.Start.Day == CurrentDate.Day)
                                        {
                                            todayAppointmentsCount++;
                                            if (lastAppointmentTodayDateTime < appointment.Start)
                                            {

                                                string name, place;
                                                name = String.Join(" ", appointment.NameDoc.Split(' ').Reverse().ToArray());
                                                place = String.Join(" ", appointment.Description.Split(' ').Reverse().ToArray());
                                                spt = new recognitionArabic().CloudTextToSpeech("لديك ميعاد مع الدكتور " + name + "والموضوع عن " + place + "الساعة  " + appointment.Start.Hour, gender: "male");
                                                break;
                                            }
                                        }
                                    }



                                }
                                message_rev_real = message_rev_real2;
                            }



                        }
                        Console.WriteLine(recognizer.AudioState);

                        if (recognizer.AudioState.ToString() != "Silence" & recognizer.AudioState.ToString() != "Speech")
                        {
                            recognizer.RecognizeAsync();
                        }


                        Thread.Sleep(100);
                        one = 0;
                    }


                }

            }




        }

        private void timer5_Tick_exit(object sender, EventArgs e)
        {
            if (timer3_wait_spech.Enabled == false)
            {
                recognizer.RecognizeAsyncCancel();
                this.Hide();
                Application.Exit();
                timer5_exit.Stop(); ;

            }
        }

        private void timer_recognizer_Tick(object sender, EventArgs e)
        {
            if (spt.PlaybackState == PlaybackState.Stopped)
            {
                recognizer.RequestRecognizerUpdate();
                timer_recognizer_stop.Enabled = false;
            }
        }

        private void backgroundWorker1_ProgressChanged_1_Tips_call_in_pack(object sender, ProgressChangedEventArgs e)
        {
            // اذا كانت النصيحه فارغه ام لا
            if (tip != "")
            {
                Console.WriteLine(tip);
                // اذا كان اي صوت يقال في الخليفيه ينهي قول النصيحه
                if (spt.PlaybackState == PlaybackState.Stopped)
                {

                    // ثبل قول النصيحه
                    this.radListView1.Enabled = false;      // قفل صندوق اقتراحات الشات
                    this.send_message.Enabled = false;      // قفل ارسال رساله الي الشات
                    this.start_record_stop.Enabled = false; InputTxt.Enabled = false;  // قفل ارسال تسجيل الي الشات
                    this.InputTxt.Enabled = false; // قفل كتابه رساله الي الشات
                    talk = true;

                    recognizer.RecognizeAsyncCancel(); // قفل الاستماع في الخليفه 
                    recognizer.RecognizeAsyncStop();   // قفل الاستماع في الخليفه 

                    spt = new recognitionArabic().CloudTextToSpeech("نصيحة : " + tip, "male");    // قول النصيحه بصوت رجل
                    len = tip.Length / 4; // حساب مدي كلمه النصيحه لعمل اينيميشن للنصيحه
                    //label1.Text = "";
                    timer1_tips_enim.Interval = len; // اعطاء المدي ل للاينينمشن

                    timer_recognizer_stop.Enabled = true; // بدا تايمر التعرف علي موعد اانتهاء النصيحه
                    timer1_tips_enim.Start(); // بدا تايمر اعطاء النصيحه في الشاشه
                    timer3_wait_spech.Start(); // بدا تايمر لتفعيل اي خيارات تم الغائها مثل ارسال رساله وتسجيل صوت حين ينهي النصيحه

                }


            }

        }

        private void backgroundWorker1_DoWork_1_Tips_call_in_pack(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(6000); // انتظار 6 ثواني لحين فتج النصائج

            BackgroundWorker worker = sender as BackgroundWorker;

            while (true) // حلقه تكراريه علي النصائج غير منتهية
            {
                if (tip_call == true) // هل يسمج بمناداه النصيحه ام لا
                {

                    TipsWords = new Database.database().Tips_database(); // اخد النصائج من االداتا بيز


                    i = i + 1;
                    if (worker.CancellationPending == true) // اذا تم الغاء النصيحه
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {

                        foreach (string fg in TipsWords) // حلقه تكراريه علي النصائح وعمل فتره زمنيه بين كل نصيحه 5 دقائق
                        {
                            tip = fg;
                            worker.ReportProgress(i * 1); // الدخول الي حدث النصائح والعطاء النصيحه في التصميم
                            Thread.Sleep(100000);
                        }


                    }
                }
            }
        }

        // /////////////////////////////////////////



        private void Appointments_AppointmentsRowChanged(object sender, PatientsDataSet.AppointmentsRowChangeEvent e)
        {
            this.UpdateTodayAndTomorrowLabels();
        }

        private void scheduleToggleButton_Click(object sender, EventArgs e)
        {
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

        private void newAppointment_Click(object sender, EventArgs e)
        {

            start_record_stop.Enabled = false;
            InputTxt.Enabled = false;
            voice = false;
            timer2_radProgressBar.Enabled = true;
            send_message.Enabled = false;
            start_record_stop.Enabled = false;


            recognizer.RecognizeAsyncCancel();
            timer4_realTime_recognizer.Enabled = false;
            if (spt.PlaybackState == PlaybackState.Playing)
            {
                spt.Stop();
            }


            tip_call = false;
            AppointmentForm addAppointmentForm = new AppointmentForm();
            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
            addAppointmentForm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
            addAppointmentForm.ShowDialog(this);
            tip_call = true;

        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("lol");
            timer4_realTime_recognizer.Enabled = true;
            start_record_stop.Enabled = true;
            InputTxt.Enabled = true;
            voice = true;
            timer2_radProgressBar.Enabled = false;

            send_message.Enabled = true;
            start_record_stop.Enabled = true;
            tip_call = true;

            this.SetSchedulerAppointmentsBackground();


        }

        private void radCalendarDashboard_SelectionChanged(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(this.radCalendarDashboard.SelectedDate);
        }

        private void SetSchedulerPageActive(DateTime date)
        {
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
            //this.radScheduler1.FocusedDate = this.radCalendarSchedule.SelectedDate;
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

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radSchedulerNavigator2_Click(object sender, EventArgs e)
        {

        }
        bool Chat_ = false;
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (panelChatMain.Visible == false)
            {
                panelChatMain.Visible = true;
                this.Size = new Size(1310, 569);
            }
            else
            {
                panelChatMain.Visible = false;
                this.Size = new Size(1009, 569);

            }


        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radPageViewPageMaps_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
