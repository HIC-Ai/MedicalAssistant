
namespace MedicalAssistant
{
    partial class DemoSchandeler
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.endDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.startDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuUserControl2 = new Bunifu.UI.WinForms.BunifuUserControl();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuUserControl1 = new Bunifu.UI.WinForms.BunifuUserControl();
            this.Label2 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuUserControl3 = new Bunifu.UI.WinForms.BunifuUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.endDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 10);
            this.panel3.TabIndex = 42;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd-MMMM-yyyy HH:mm";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(56, 281);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(325, 20);
            this.endDateTimePicker.TabIndex = 50;
            this.endDateTimePicker.TabStop = false;
            this.endDateTimePicker.Text = "17-يونيو-2015 12:30";
            this.endDateTimePicker.Value = new System.DateTime(2015, 6, 17, 12, 30, 0, 0);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "dd-MMMM-yyyy HH:mm";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(56, 231);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(325, 20);
            this.startDateTimePicker.TabIndex = 49;
            this.startDateTimePicker.TabStop = false;
            this.startDateTimePicker.Text = "17-يونيو-2015 12:00";
            this.startDateTimePicker.Value = new System.DateTime(2015, 6, 17, 12, 0, 0, 0);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(346, 257);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(33, 18);
            this.radLabel3.TabIndex = 47;
            this.radLabel3.Text = "ينتهي";
            this.radLabel3.ThemeName = "MedicalAppTheme";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(360, 207);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(22, 18);
            this.radLabel2.TabIndex = 48;
            this.radLabel2.Text = "يبدا";
            this.radLabel2.ThemeName = "MedicalAppTheme";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cancelButton.Location = new System.Drawing.Point(138, 375);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 21);
            this.cancelButton.TabIndex = 52;
            this.cancelButton.Text = "الغاء";
            this.cancelButton.ThemeName = "MedicalAppTheme";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.saveButton.Location = new System.Drawing.Point(214, 375);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 21);
            this.saveButton.TabIndex = 51;
            this.saveButton.Text = "حفظ";
            this.saveButton.ThemeName = "MedicalAppTheme";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MedicalAssistant.Properties.Resources.add_record;
            this.pictureBox2.Location = new System.Drawing.Point(195, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(14, 106);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel3.Size = new System.Drawing.Size(401, 44);
            this.gunaLabel3.TabIndex = 60;
            this.gunaLabel3.Text = "مثال : اليمعاد مع الدكتور احمد والمكان في شارع المحطه والموضوع عن كشف لابني احمد";
            this.gunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // bunifuUserControl2
            // 
            this.bunifuUserControl2.AllowAnimations = false;
            this.bunifuUserControl2.AllowBorderColorChanges = false;
            this.bunifuUserControl2.AllowMouseEffects = false;
            this.bunifuUserControl2.AnimationSpeed = 200;
            this.bunifuUserControl2.AutoSize = true;
            this.bunifuUserControl2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuUserControl2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuUserControl2.BorderRadius = 20;
            this.bunifuUserControl2.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.bunifuUserControl2.BorderThickness = 1;
            this.bunifuUserControl2.ColorContrastOnClick = 30;
            this.bunifuUserControl2.ColorContrastOnHover = 30;
            this.bunifuUserControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuUserControl2.Image = null;
            this.bunifuUserControl2.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuUserControl2.Location = new System.Drawing.Point(4, 91);
            this.bunifuUserControl2.Name = "bunifuUserControl2";
            this.bunifuUserControl2.ShowBorders = true;
            this.bunifuUserControl2.Size = new System.Drawing.Size(421, 71);
            this.bunifuUserControl2.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.bunifuUserControl2.TabIndex = 58;
            this.bunifuUserControl2.Click += new System.EventHandler(this.bunifuUserControl2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(14, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel1.Size = new System.Drawing.Size(404, 32);
            this.gunaLabel1.TabIndex = 61;
            this.gunaLabel1.Text = " قم بقول اسم الدكتور ثم الموعد ثم الموضوع  ";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // bunifuUserControl1
            // 
            this.bunifuUserControl1.AllowAnimations = false;
            this.bunifuUserControl1.AllowBorderColorChanges = false;
            this.bunifuUserControl1.AllowMouseEffects = false;
            this.bunifuUserControl1.AnimationSpeed = 200;
            this.bunifuUserControl1.AutoSize = true;
            this.bunifuUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuUserControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuUserControl1.BorderRadius = 20;
            this.bunifuUserControl1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.bunifuUserControl1.BorderThickness = 1;
            this.bunifuUserControl1.ColorContrastOnClick = 30;
            this.bunifuUserControl1.ColorContrastOnHover = 30;
            this.bunifuUserControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuUserControl1.Image = null;
            this.bunifuUserControl1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuUserControl1.Location = new System.Drawing.Point(4, 20);
            this.bunifuUserControl1.Name = "bunifuUserControl1";
            this.bunifuUserControl1.ShowBorders = true;
            this.bunifuUserControl1.Size = new System.Drawing.Size(424, 59);
            this.bunifuUserControl1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.bunifuUserControl1.TabIndex = 59;
            this.bunifuUserControl1.Click += new System.EventHandler(this.bunifuUserControl1_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label2.Location = new System.Drawing.Point(29, 336);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(372, 16);
            this.Label2.TabIndex = 63;
            this.Label2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // bunifuUserControl3
            // 
            this.bunifuUserControl3.AllowAnimations = false;
            this.bunifuUserControl3.AllowBorderColorChanges = false;
            this.bunifuUserControl3.AllowMouseEffects = false;
            this.bunifuUserControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuUserControl3.AnimationSpeed = 200;
            this.bunifuUserControl3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuUserControl3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl3.BorderRadius = 20;
            this.bunifuUserControl3.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.bunifuUserControl3.BorderThickness = 3;
            this.bunifuUserControl3.ColorContrastOnClick = 30;
            this.bunifuUserControl3.ColorContrastOnHover = 30;
            this.bunifuUserControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuUserControl3.Image = null;
            this.bunifuUserControl3.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuUserControl3.Location = new System.Drawing.Point(4, 307);
            this.bunifuUserControl3.Name = "bunifuUserControl3";
            this.bunifuUserControl3.ShowBorders = true;
            this.bunifuUserControl3.Size = new System.Drawing.Size(421, 62);
            this.bunifuUserControl3.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.bunifuUserControl3.TabIndex = 62;
            // 
            // DemoSchandeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 415);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.bunifuUserControl3);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.bunifuUserControl2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.bunifuUserControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DemoSchandeler";
            this.RightToLeftLayout = true;
            this.Text = "DemoSchandeler";
            ((System.ComponentModel.ISupportInitialize)(this.endDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadDateTimePicker endDateTimePicker;
        private Telerik.WinControls.UI.RadDateTimePicker startDateTimePicker;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton cancelButton;
        private Telerik.WinControls.UI.RadButton saveButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Bunifu.UI.WinForms.BunifuUserControl bunifuUserControl2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Bunifu.UI.WinForms.BunifuUserControl bunifuUserControl1;
        private Guna.UI.WinForms.GunaLabel Label2;
        private Bunifu.UI.WinForms.BunifuUserControl bunifuUserControl3;
    }
}