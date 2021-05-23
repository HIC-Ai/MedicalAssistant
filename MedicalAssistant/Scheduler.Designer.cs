namespace MedicalAssistant
{
    partial class Scheduler
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.patientsDataSet = new MedicalAssistant.PatientsDataSet();
            this.appointmentsTableAdapter = new MedicalAssistant.PatientsDataSetTableAdapters.AppointmentsTableAdapter();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radButtonNewAppointmentScheduler = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointmentScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radScheduler1
            // 
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Week;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("ar-EG");
            this.radScheduler1.Location = new System.Drawing.Point(31, 119);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Tahoma", 8F);
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2021, 5, 19, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(1047, 361);
            this.radScheduler1.TabIndex = 0;
            this.radScheduler1.ThemeName = "Fluent";
            this.radScheduler1.AppointmentDeleted += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.radScheduler1_AppointmentDeleted);
            this.radScheduler1.DataBindingComplete += new System.EventHandler(this.radScheduler1_DataBindingComplete);
            this.radScheduler1.AppointmentEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs>(this.radScheduler1_AppointmentEditDialogShowing);
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(31, 36);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStep = 7;
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1047, 78);
            this.radSchedulerNavigator1.TabIndex = 1;
            this.radSchedulerNavigator1.ThemeName = "Fluent";
            this.radSchedulerNavigator1.Click += new System.EventHandler(this.radSchedulerNavigator1_Click);
            // 
            // patientsDataSet
            // 
            this.patientsDataSet.DataSetName = "PatientsDataSet";
            this.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.patientsDataSet;
            // 
            // radButtonNewAppointmentScheduler
            // 
            this.radButtonNewAppointmentScheduler.Location = new System.Drawing.Point(875, -3);
            this.radButtonNewAppointmentScheduler.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.radButtonNewAppointmentScheduler.Name = "radButtonNewAppointmentScheduler";
            this.radButtonNewAppointmentScheduler.Size = new System.Drawing.Size(133, 33);
            this.radButtonNewAppointmentScheduler.TabIndex = 6;
            this.radButtonNewAppointmentScheduler.Text = "اضافه موعد";
            this.radButtonNewAppointmentScheduler.Click += new System.EventHandler(this.radButtonNewAppointmentScheduler_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButtonNewAppointmentScheduler.GetChildAt(0))).Text = "اضافه موعد";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonNewAppointmentScheduler.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonNewAppointmentScheduler.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonNewAppointmentScheduler.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonNewAppointmentScheduler.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 525);
            this.Controls.Add(this.radButtonNewAppointmentScheduler);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Controls.Add(this.radScheduler1);
            this.Name = "Scheduler";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Scheduler";
            this.ThemeName = "Fluent";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointmentScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private PatientsDataSet patientsDataSet;
        private PatientsDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private Telerik.WinControls.UI.RadButton radButtonNewAppointmentScheduler;
    }
}
