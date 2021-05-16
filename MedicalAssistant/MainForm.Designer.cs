
using MedicalAssistant;

namespace MedicalAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("المهام");
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Age");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Gender");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "EncounterTime");
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.start_record_stop = new System.Windows.Forms.PictureBox();
            this.txtTyping = new System.Windows.Forms.Label();
            this.send_message = new System.Windows.Forms.PictureBox();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.InputTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.object_ed72cbad_facf_4a15_8078_4f0e9b98e184 = new Telerik.WinControls.RootRadElement();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPageDashboard = new Telerik.WinControls.UI.RadPageViewPage();
            this.radButtonNewAppointment = new Telerik.WinControls.UI.RadButton();
            this.dashboardClockCalendarPanel = new Telerik.WinControls.UI.RadPanel();
            this.radCalendarDashboard = new Telerik.WinControls.UI.RadCalendar();
            this.radClock1 = new Telerik.WinControls.UI.RadClock();
            this.radPanelTodaysAppointments = new Telerik.WinControls.UI.RadPanel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelLastAppointmentToday = new Telerik.WinControls.UI.RadLabel();
            this.radLabelTodayAppointmentsCount = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPanelTomorrowAppointments = new Telerik.WinControls.UI.RadPanel();
            this.radLabelFirstAppointmentTomorrow = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelTomorrowAppointmentsCount = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radPageViewPageSchedule = new Telerik.WinControls.UI.RadPageViewPage();
            this.radCalendarSchedule = new Telerik.WinControls.UI.RadCalendar();
            this.radButtonNewAppointmentScheduler = new Telerik.WinControls.UI.RadButton();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radPageViewPageCharts = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPageSettings = new Telerik.WinControls.UI.RadPageViewPage();
            this.radListViewNextPatients = new Telerik.WinControls.UI.RadListView();
            this.Tips_call_in_pack = new System.ComponentModel.BackgroundWorker();
            this.timer1_tips_enim = new System.Windows.Forms.Timer(this.components);
            this.timer2_radProgressBar = new System.Windows.Forms.Timer(this.components);
            this.panelChatMain = new System.Windows.Forms.Panel();
            this.object_e3bdc5d3_c56d_48bf_bc43_aa607a6c2b99 = new Telerik.WinControls.RootRadElement();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.patientsDataSet = new MedicalAssistant.PatientsDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new MedicalAssistant.PatientsDataSetTableAdapters.AppointmentsTableAdapter();
            this.timer3_wait_spech = new System.Windows.Forms.Timer(this.components);
            this.timer5_exit = new System.Windows.Forms.Timer(this.components);
            this.timer_recognizer_stop = new System.Windows.Forms.Timer(this.components);
            this.timer4_realTime_recognizer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start_record_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPageDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardClockCalendarPanel)).BeginInit();
            this.dashboardClockCalendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendarDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTodaysAppointments)).BeginInit();
            this.radPanelTodaysAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelLastAppointmentToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTodayAppointmentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTomorrowAppointments)).BeginInit();
            this.radPanelTomorrowAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFirstAppointmentTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTomorrowAppointmentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.radPageViewPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendarSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointmentScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewNextPatients)).BeginInit();
            this.panelChatMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.radPanel2.Controls.Add(this.start_record_stop);
            this.radPanel2.Controls.Add(this.txtTyping);
            this.radPanel2.Controls.Add(this.send_message);
            this.radPanel2.Controls.Add(this.radProgressBar1);
            this.radPanel2.Controls.Add(this.InputTxt);
            resources.ApplyResources(this.radPanel2, "radPanel2");
            this.radPanel2.Name = "radPanel2";
            // 
            // start_record_stop
            // 
            this.start_record_stop.Image = global::MedicalAssistant.Properties.Resources.filled_sent;
            resources.ApplyResources(this.start_record_stop, "start_record_stop");
            this.start_record_stop.Name = "start_record_stop";
            this.start_record_stop.TabStop = false;
            this.start_record_stop.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtTyping
            // 
            resources.ApplyResources(this.txtTyping, "txtTyping");
            this.txtTyping.BackColor = System.Drawing.SystemColors.Control;
            this.txtTyping.Name = "txtTyping";
            // 
            // send_message
            // 
            this.send_message.Image = global::MedicalAssistant.Properties.Resources.add_record;
            resources.ApplyResources(this.send_message, "send_message");
            this.send_message.Name = "send_message";
            this.send_message.TabStop = false;
            this.send_message.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // radProgressBar1
            // 
            resources.ApplyResources(this.radProgressBar1, "radProgressBar1");
            this.radProgressBar1.Name = "radProgressBar1";
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.radProgressBar1.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(164)))), ((int)(((byte)(177)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(93)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(93)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.ProgressBarTextElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(3))).ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(212)))));
            ((Telerik.WinControls.UI.ProgressBarTextElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(3))).Text = resources.GetString("resource.Text1");
            // 
            // InputTxt
            // 
            resources.ApplyResources(this.InputTxt, "InputTxt");
            this.InputTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.InputTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.InputTxt.BackColor = System.Drawing.SystemColors.Control;
            this.InputTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.InputTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTxt.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.InputTxt.HintForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InputTxt.HintText = "اكتب رسالتك هنا";
            this.InputTxt.isPassword = false;
            this.InputTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InputTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.InputTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InputTxt.LineThickness = 3;
            this.InputTxt.MaxLength = 32767;
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyDown);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radListView1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // radListView1
            // 
            this.radListView1.AllowArbitraryItemHeight = true;
            this.radListView1.AllowEdit = false;
            this.radListView1.CheckBoxesPosition = Telerik.WinControls.UI.CheckBoxesPosition.Top;
            resources.ApplyResources(this.radListView1, "radListView1");
            this.radListView1.FullRowSelect = false;
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 28);
            listViewDataItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            listViewDataItem1.Text = "المهام";
            listViewDataItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1});
            this.radListView1.ItemSize = new System.Drawing.Size(50, 50);
            this.radListView1.ItemSpacing = 4;
            this.radListView1.Name = "radListView1";
            this.radListView1.ThemeName = "Fluent";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.radListView1.SelectedIndexChanged += new System.EventHandler(this.radListView1_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadListViewElement)(this.radListView1.GetChildAt(0))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment")));
            ((Telerik.WinControls.UI.RadListViewElement)(this.radListView1.GetChildAt(0))).RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft")));
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.guna2CirclePictureBox2);
            resources.ApplyResources(this.guna2GradientPanel1, "guna2GradientPanel1");
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(93)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.label1.UseMnemonic = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2CirclePictureBox2, "guna2CirclePictureBox2");
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.Black;
            this.guna2CirclePictureBox2.Image = global::MedicalAssistant.Properties.Resources.received_264768345150339;
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.guna2GradientPanel1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // object_ed72cbad_facf_4a15_8078_4f0e9b98e184
            // 
            this.object_ed72cbad_facf_4a15_8078_4f0e9b98e184.Name = "object_ed72cbad_facf_4a15_8078_4f0e9b98e184";
            this.object_ed72cbad_facf_4a15_8078_4f0e9b98e184.StretchHorizontally = true;
            this.object_ed72cbad_facf_4a15_8078_4f0e9b98e184.StretchVertically = true;
            // 
            // radPageView1
            // 
            this.radPageView1.BackColor = System.Drawing.Color.Transparent;
            this.radPageView1.Controls.Add(this.radPageViewPageDashboard);
            this.radPageView1.Controls.Add(this.radPageViewPageSchedule);
            this.radPageView1.Controls.Add(this.radPageViewPageCharts);
            this.radPageView1.Controls.Add(this.radPageViewPageSettings);
            resources.ApplyResources(this.radPageView1, "radPageView1");
            this.radPageView1.Name = "radPageView1";
            // 
            // 
            // 
            this.radPageView1.RootElement.BorderHighlightColor = System.Drawing.Color.Transparent;
            this.radPageView1.RootElement.FocusBorderColor = System.Drawing.Color.Transparent;
            this.radPageView1.RootElement.HighlightColor = System.Drawing.Color.Transparent;
            this.radPageView1.RootElement.RippleAnimationColor = System.Drawing.Color.Transparent;
            this.radPageView1.SelectedPage = this.radPageViewPageDashboard;
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.radPageView1.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.radPageView1.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Shrink;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.radPageView1.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Right;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.radPageView1.GetChildAt(0))).ItemDragMode = Telerik.WinControls.UI.PageViewItemDragMode.Preview;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.radPageView1.GetChildAt(0))).ItemSpacing = 40;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.radPageView1.GetChildAt(0))).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.radPageView1.GetChildAt(0))).BackColor4 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.radPageView1.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderInnerColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderInnerColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderLeftColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderRightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderBottomShadowColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).ImageTransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).MinSize = new System.Drawing.Size(25, 0);
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderRightColor = System.Drawing.Color.DodgerBlue;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderRightShadowColor = System.Drawing.Color.DodgerBlue;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).ImageTransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BorderHighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageTransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).ToolTipText = resources.GetString("resource.ToolTipText");
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).ImageTransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).ToolTipText = resources.GetString("resource.ToolTipText1");
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(2))).ImageTransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(2))).ToolTipText = resources.GetString("resource.ToolTipText2");
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).ImageTransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).ToolTipText = resources.GetString("resource.ToolTipText3");
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderInnerColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderInnerColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderInnerColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderTopColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderRightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderBottomColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderBottomShadowColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderHighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).Text = resources.GetString("resource.Text5");
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radPageViewPageDashboard
            // 
            this.radPageViewPageDashboard.BackColor = System.Drawing.Color.Transparent;
            this.radPageViewPageDashboard.Controls.Add(this.radButtonNewAppointment);
            this.radPageViewPageDashboard.Controls.Add(this.dashboardClockCalendarPanel);
            this.radPageViewPageDashboard.Controls.Add(this.radPanelTodaysAppointments);
            this.radPageViewPageDashboard.Controls.Add(this.radLabel2);
            this.radPageViewPageDashboard.Controls.Add(this.radPanelTomorrowAppointments);
            this.radPageViewPageDashboard.Image = global::MedicalAssistant.Properties.Resources.home__2_;
            this.radPageViewPageDashboard.ItemSize = new System.Drawing.SizeF(125F, 45F);
            resources.ApplyResources(this.radPageViewPageDashboard, "radPageViewPageDashboard");
            this.radPageViewPageDashboard.Name = "radPageViewPageDashboard";
            this.radPageViewPageDashboard.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radButtonNewAppointment
            // 
            resources.ApplyResources(this.radButtonNewAppointment, "radButtonNewAppointment");
            this.radButtonNewAppointment.Name = "radButtonNewAppointment";
            this.radButtonNewAppointment.Click += new System.EventHandler(this.newAppointment_Click);
            // 
            // dashboardClockCalendarPanel
            // 
            this.dashboardClockCalendarPanel.BackColor = System.Drawing.Color.Transparent;
            this.dashboardClockCalendarPanel.Controls.Add(this.radCalendarDashboard);
            this.dashboardClockCalendarPanel.Controls.Add(this.radClock1);
            resources.ApplyResources(this.dashboardClockCalendarPanel, "dashboardClockCalendarPanel");
            this.dashboardClockCalendarPanel.Name = "dashboardClockCalendarPanel";
            // 
            // radCalendarDashboard
            // 
            this.radCalendarDashboard.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            resources.ApplyResources(this.radCalendarDashboard, "radCalendarDashboard");
            this.radCalendarDashboard.Name = "radCalendarDashboard";
            this.radCalendarDashboard.ShowFastNavigationButtons = false;
            this.radCalendarDashboard.ShowNavigationButtons = false;
            this.radCalendarDashboard.ShowRowHeaders = true;
            this.radCalendarDashboard.SelectionChanged += new System.EventHandler(this.radCalendarDashboard_SelectionChanged);
            // 
            // radClock1
            // 
            resources.ApplyResources(this.radClock1, "radClock1");
            this.radClock1.Name = "radClock1";
            // 
            // radPanelTodaysAppointments
            // 
            this.radPanelTodaysAppointments.Controls.Add(this.radLabel6);
            this.radPanelTodaysAppointments.Controls.Add(this.radLabelLastAppointmentToday);
            this.radPanelTodaysAppointments.Controls.Add(this.radLabelTodayAppointmentsCount);
            this.radPanelTodaysAppointments.Controls.Add(this.radLabel3);
            resources.ApplyResources(this.radPanelTodaysAppointments, "radPanelTodaysAppointments");
            this.radPanelTodaysAppointments.Name = "radPanelTodaysAppointments";
            // 
            // radLabel6
            // 
            this.radLabel6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabel6, "radLabel6");
            this.radLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabel6.Name = "radLabel6";
            // 
            // radLabelLastAppointmentToday
            // 
            this.radLabelLastAppointmentToday.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabelLastAppointmentToday, "radLabelLastAppointmentToday");
            this.radLabelLastAppointmentToday.Name = "radLabelLastAppointmentToday";
            // 
            // radLabelTodayAppointmentsCount
            // 
            this.radLabelTodayAppointmentsCount.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabelTodayAppointmentsCount, "radLabelTodayAppointmentsCount");
            this.radLabelTodayAppointmentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabelTodayAppointmentsCount.Name = "radLabelTodayAppointmentsCount";
            this.radLabelTodayAppointmentsCount.UseCompatibleTextRendering = false;
            this.radLabelTodayAppointmentsCount.Click += new System.EventHandler(this.radLabelTodayAppointmentsCount_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabel3, "radLabel3");
            this.radLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(79)))));
            this.radLabel3.Name = "radLabel3";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabel2, "radLabel2");
            this.radLabel2.Name = "radLabel2";
            // 
            // radPanelTomorrowAppointments
            // 
            this.radPanelTomorrowAppointments.Controls.Add(this.radLabelFirstAppointmentTomorrow);
            this.radPanelTomorrowAppointments.Controls.Add(this.radLabel9);
            this.radPanelTomorrowAppointments.Controls.Add(this.radLabelTomorrowAppointmentsCount);
            this.radPanelTomorrowAppointments.Controls.Add(this.radLabel4);
            resources.ApplyResources(this.radPanelTomorrowAppointments, "radPanelTomorrowAppointments");
            this.radPanelTomorrowAppointments.Name = "radPanelTomorrowAppointments";
            // 
            // radLabelFirstAppointmentTomorrow
            // 
            this.radLabelFirstAppointmentTomorrow.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabelFirstAppointmentTomorrow, "radLabelFirstAppointmentTomorrow");
            this.radLabelFirstAppointmentTomorrow.Name = "radLabelFirstAppointmentTomorrow";
            // 
            // radLabel9
            // 
            this.radLabel9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabel9, "radLabel9");
            this.radLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabel9.Name = "radLabel9";
            // 
            // radLabelTomorrowAppointmentsCount
            // 
            this.radLabelTomorrowAppointmentsCount.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabelTomorrowAppointmentsCount, "radLabelTomorrowAppointmentsCount");
            this.radLabelTomorrowAppointmentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabelTomorrowAppointmentsCount.Name = "radLabelTomorrowAppointmentsCount";
            this.radLabelTomorrowAppointmentsCount.UseCompatibleTextRendering = false;
            this.radLabelTomorrowAppointmentsCount.Click += new System.EventHandler(this.radLabelTomorrowAppointmentsCount_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabel4, "radLabel4");
            this.radLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(79)))));
            this.radLabel4.Name = "radLabel4";
            // 
            // radPageViewPageSchedule
            // 
            this.radPageViewPageSchedule.BackColor = System.Drawing.SystemColors.Control;
            this.radPageViewPageSchedule.Controls.Add(this.radCalendarSchedule);
            this.radPageViewPageSchedule.Controls.Add(this.radButtonNewAppointmentScheduler);
            this.radPageViewPageSchedule.Controls.Add(this.radSchedulerNavigator1);
            this.radPageViewPageSchedule.Controls.Add(this.radScheduler1);
            this.radPageViewPageSchedule.ForeColor = System.Drawing.Color.Transparent;
            this.radPageViewPageSchedule.Image = global::MedicalAssistant.Properties.Resources.schedule__3_;
            this.radPageViewPageSchedule.ItemSize = new System.Drawing.SizeF(125F, 45F);
            resources.ApplyResources(this.radPageViewPageSchedule, "radPageViewPageSchedule");
            this.radPageViewPageSchedule.Name = "radPageViewPageSchedule";
            this.radPageViewPageSchedule.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radCalendarSchedule
            // 
            this.radCalendarSchedule.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            resources.ApplyResources(this.radCalendarSchedule, "radCalendarSchedule");
            this.radCalendarSchedule.Name = "radCalendarSchedule";
            this.radCalendarSchedule.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(1900, 1, 1, 0, 0, 0, 0)});
            this.radCalendarSchedule.ShowRowHeaders = true;
            this.radCalendarSchedule.SelectionChanged += new System.EventHandler(this.radCalendarSchedule_SelectionChanged);
            // 
            // radButtonNewAppointmentScheduler
            // 
            resources.ApplyResources(this.radButtonNewAppointmentScheduler, "radButtonNewAppointmentScheduler");
            this.radButtonNewAppointmentScheduler.Name = "radButtonNewAppointmentScheduler";
            this.radButtonNewAppointmentScheduler.Click += new System.EventHandler(this.newAppointment_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButtonNewAppointmentScheduler.GetChildAt(0))).Text = resources.GetString("resource.Text2");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonNewAppointmentScheduler.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonNewAppointmentScheduler.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonNewAppointmentScheduler.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonNewAppointmentScheduler.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "MMMM d, yyyy";
            this.radSchedulerNavigator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            resources.ApplyResources(this.radSchedulerNavigator1, "radSchedulerNavigator1");
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            ((Telerik.WinControls.UI.SchedulerNavigatorElement)(this.radSchedulerNavigator1.GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.RadItem)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).TopColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BottomColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2))).InnerColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(1))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).InnerColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).InnerColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(3))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(3).GetChildAt(2))).InnerColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(3).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(4))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(4).GetChildAt(2))).InnerColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(4).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.LightVisualElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(5))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(5).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(5).GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0))).Text = resources.GetString("resource.Text3");
            ((Telerik.WinControls.UI.RadLabelElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0).GetChildAt(2).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0).GetChildAt(2).GetChildAt(0))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment1")));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(0).GetChildAt(2).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(1).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(1).GetChildAt(2))).ImageTransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(1).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.SchedulerNavigatorSearchTextbox)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(2))).MaxSize = new System.Drawing.Size(-13, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(6).GetChildAt(2).GetChildAt(1))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.RadItem)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).LeftColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).TopColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).RightColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BottomColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment2")));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(2))).InnerColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0).GetChildAt(3))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0))).TransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment3")));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(2))).InnerColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(1).GetChildAt(3))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.UI.RadLabelElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).TextAlignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlignment")));
            ((Telerik.WinControls.UI.RadLabelElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Text = resources.GetString("resource.Text4");
            ((Telerik.WinControls.UI.RadLabelElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).TransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment4")));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).TextAlignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlignment1")));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.UI.LightVisualElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3))).ForeColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0).GetChildAt(1).GetChildAt(0))).TransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0).GetChildAt(1).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment5")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(3).GetChildAt(0).GetChildAt(3))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            // 
            // radScheduler1
            // 
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.MultiDay;
            this.radScheduler1.AllowAppointmentCreateInline = false;
            this.radScheduler1.AllowAppointmentMove = false;
            this.radScheduler1.AllowAppointmentResize = false;
            this.radScheduler1.AllowAppointmentsMultiSelect = true;
            this.radScheduler1.AllowCopyPaste = Telerik.WinControls.UI.CopyPasteMode.Disallow;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("");
            this.radScheduler1.HeaderFormat = "dddd M\\/d";
            resources.ApplyResources(this.radScheduler1, "radScheduler1");
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2015, 8, 22, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2015, 8, 17, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.ThemeName = "MedicalAppTheme";
            this.radScheduler1.AppointmentDeleted += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.radScheduler1_AppointmentDeleted);
            this.radScheduler1.DataBindingComplete += new System.EventHandler(this.radScheduler1_DataBindingComplete);
            this.radScheduler1.ContextMenuOpening += new Telerik.WinControls.UI.SchedulerContextMenuOpeningEventHandler(this.radScheduler1_ContextMenuOpening);
            this.radScheduler1.ActiveViewChanged += new System.EventHandler<Telerik.WinControls.UI.SchedulerViewChangedEventArgs>(this.radScheduler1_ActiveViewChanged);
            this.radScheduler1.AppointmentEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs>(this.radScheduler1_AppointmentEditDialogShowing);
            // 
            // radPageViewPageCharts
            // 
            this.radPageViewPageCharts.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radPageViewPageCharts, "radPageViewPageCharts");
            this.radPageViewPageCharts.Image = global::MedicalAssistant.Properties.Resources.live;
            this.radPageViewPageCharts.ItemSize = new System.Drawing.SizeF(125F, 45F);
            this.radPageViewPageCharts.Name = "radPageViewPageCharts";
            this.radPageViewPageCharts.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPageViewPageSettings
            // 
            this.radPageViewPageSettings.BackColor = System.Drawing.Color.Transparent;
            this.radPageViewPageSettings.Image = global::MedicalAssistant.Properties.Resources.settings;
            this.radPageViewPageSettings.ItemSize = new System.Drawing.SizeF(125F, 45F);
            resources.ApplyResources(this.radPageViewPageSettings, "radPageViewPageSettings");
            this.radPageViewPageSettings.Name = "radPageViewPageSettings";
            this.radPageViewPageSettings.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radListViewNextPatients
            // 
            this.radListViewNextPatients.AllowArbitraryItemHeight = true;
            this.radListViewNextPatients.AllowEdit = false;
            this.radListViewNextPatients.AllowRemove = false;
            listViewDetailColumn1.HeaderText = "Name";
            listViewDetailColumn2.HeaderText = "Age";
            listViewDetailColumn3.HeaderText = "Gender";
            listViewDetailColumn4.HeaderText = "EncounterTime";
            this.radListViewNextPatients.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListViewNextPatients.ItemSize = new System.Drawing.Size(200, 95);
            resources.ApplyResources(this.radListViewNextPatients, "radListViewNextPatients");
            this.radListViewNextPatients.Name = "radListViewNextPatients";
            this.radListViewNextPatients.SelectLastAddedItem = false;
            this.radListViewNextPatients.ThemeName = "MedicalAppTheme";
            this.radListViewNextPatients.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            // 
            // Tips_call_in_pack
            // 
            this.Tips_call_in_pack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1_Tips_call_in_pack);
            this.Tips_call_in_pack.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged_1_Tips_call_in_pack);
            // 
            // timer1_tips_enim
            // 
            this.timer1_tips_enim.Enabled = true;
            this.timer1_tips_enim.Interval = 2000;
            this.timer1_tips_enim.Tick += new System.EventHandler(this.timer1_Tick__tips_enim);
            // 
            // timer2_radProgressBar
            // 
            this.timer2_radProgressBar.Tick += new System.EventHandler(this.timer2_Tick_radProgressBar);
            // 
            // panelChatMain
            // 
            this.panelChatMain.BackColor = System.Drawing.Color.Transparent;
            this.panelChatMain.Controls.Add(this.panel3);
            this.panelChatMain.Controls.Add(this.panel1);
            this.panelChatMain.Controls.Add(this.radPanel2);
            resources.ApplyResources(this.panelChatMain, "panelChatMain");
            this.panelChatMain.Name = "panelChatMain";
            // 
            // object_e3bdc5d3_c56d_48bf_bc43_aa607a6c2b99
            // 
            this.object_e3bdc5d3_c56d_48bf_bc43_aa607a6c2b99.Name = "object_e3bdc5d3_c56d_48bf_bc43_aa607a6c2b99";
            this.object_e3bdc5d3_c56d_48bf_bc43_aa607a6c2b99.StretchHorizontally = true;
            this.object_e3bdc5d3_c56d_48bf_bc43_aa607a6c2b99.StretchVertically = true;
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.radButton2, "radButton2");
            this.radButton2.ForeColor = System.Drawing.Color.SeaGreen;
            this.radButton2.Name = "radButton2";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Transparent;
            this.radButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.radButton1, "radButton1");
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.radButton1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.radButton1.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.radButton1.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.radButton1.RootElement.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.radButton1.RootElement.RippleAnimationColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.radButton1.RootElement.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.radButton1.TextWrap = true;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton1.MouseLeave += new System.EventHandler(this.radButton1_MouseLeave);
            this.radButton1.MouseHover += new System.EventHandler(this.radButton1_MouseHover);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = resources.GetString("resource.Text6");
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).RippleAnimationColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).ForeColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).ForeColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).InnerColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).InnerColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).InnerColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Pink;
            this.panel5.Controls.Add(this.guna2CirclePictureBox1);
            this.panel5.Controls.Add(this.radButton2);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::MedicalAssistant.Properties.Resources.icons8_chat_50;
            resources.ApplyResources(this.guna2CirclePictureBox1, "guna2CirclePictureBox1");
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // patientsDataSet
            // 
            this.patientsDataSet.DataSetName = "PatientsDataSet";
            this.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.patientsDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // timer3_wait_spech
            // 
            this.timer3_wait_spech.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timer5_exit
            // 
            this.timer5_exit.Tick += new System.EventHandler(this.timer5_Tick_exit);
            // 
            // timer_recognizer_stop
            // 
            this.timer_recognizer_stop.Tick += new System.EventHandler(this.timer_recognizer_Tick);
            // 
            // timer4_realTime_recognizer
            // 
            this.timer4_realTime_recognizer.Interval = 1;
            this.timer4_realTime_recognizer.Tick += new System.EventHandler(this.timer4_Tick_realTime_recognizer);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelChatMain);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.main5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start_record_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPageDashboard.ResumeLayout(false);
            this.radPageViewPageDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardClockCalendarPanel)).EndInit();
            this.dashboardClockCalendarPanel.ResumeLayout(false);
            this.dashboardClockCalendarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendarDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTodaysAppointments)).EndInit();
            this.radPanelTodaysAppointments.ResumeLayout(false);
            this.radPanelTodaysAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelLastAppointmentToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTodayAppointmentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTomorrowAppointments)).EndInit();
            this.radPanelTomorrowAppointments.ResumeLayout(false);
            this.radPanelTomorrowAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFirstAppointmentTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTomorrowAppointmentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.radPageViewPageSchedule.ResumeLayout(false);
            this.radPageViewPageSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendarSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointmentScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewNextPatients)).EndInit();
            this.panelChatMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label txtTyping;
        private Telerik.WinControls.RootRadElement object_ed72cbad_facf_4a15_8078_4f0e9b98e184;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPageDashboard;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPageSchedule;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPageCharts;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPageSettings;
        private Telerik.WinControls.UI.RadPanel dashboardClockCalendarPanel;
        private Telerik.WinControls.UI.RadCalendar radCalendarDashboard;
        private Telerik.WinControls.UI.RadClock radClock1;
        private Telerik.WinControls.UI.RadPanel radPanelTodaysAppointments;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabelLastAppointmentToday;
        private Telerik.WinControls.UI.RadLabel radLabelTodayAppointmentsCount;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadPanel radPanelTomorrowAppointments;
        private Telerik.WinControls.UI.RadLabel radLabelFirstAppointmentTomorrow;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabelTomorrowAppointmentsCount;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton radButtonNewAppointmentScheduler;
        private Telerik.WinControls.UI.RadCalendar radCalendarSchedule;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadListView radListViewNextPatients;
        private System.ComponentModel.BackgroundWorker Tips_call_in_pack;
        private System.Windows.Forms.Timer timer1_tips_enim;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private System.Windows.Forms.Timer timer2_radProgressBar;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private PatientsDataSet patientsDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private MedicalAssistant.PatientsDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.Panel panelChatMain;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputTxt;
        private Telerik.WinControls.RootRadElement object_e3bdc5d3_c56d_48bf_bc43_aa607a6c2b99;
        private Telerik.WinControls.UI.RadButton radButtonNewAppointment;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.PictureBox start_record_stop;
        private System.Windows.Forms.PictureBox send_message;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer3_wait_spech;
        private System.Windows.Forms.Timer timer5_exit;
        private System.Windows.Forms.Timer timer_recognizer_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer4_realTime_recognizer;
    }
}