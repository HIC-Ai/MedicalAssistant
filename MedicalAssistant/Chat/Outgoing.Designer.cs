
namespace MedicalAssistant.chat
{
    partial class Outgoing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuUserControl2 = new Bunifu.UI.WinForms.BunifuUserControl();
            this.Label2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // bunifuUserControl2
            // 
            this.bunifuUserControl2.AllowAnimations = false;
            this.bunifuUserControl2.AllowBorderColorChanges = false;
            this.bunifuUserControl2.AllowMouseEffects = false;
            this.bunifuUserControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuUserControl2.AnimationSpeed = 200;
            this.bunifuUserControl2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuUserControl2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl2.BorderRadius = 20;
            this.bunifuUserControl2.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.bunifuUserControl2.BorderThickness = 3;
            this.bunifuUserControl2.ColorContrastOnClick = 30;
            this.bunifuUserControl2.ColorContrastOnHover = 30;
            this.bunifuUserControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuUserControl2.Image = null;
            this.bunifuUserControl2.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuUserControl2.Location = new System.Drawing.Point(0, 3);
            this.bunifuUserControl2.Name = "bunifuUserControl2";
            this.bunifuUserControl2.ShowBorders = true;
            this.bunifuUserControl2.Size = new System.Drawing.Size(275, 43);
            this.bunifuUserControl2.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.bunifuUserControl2.TabIndex = 0;
            this.bunifuUserControl2.Click += new System.EventHandler(this.bunifuUserControl2_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label2.Location = new System.Drawing.Point(25, 13);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(226, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "وعليكم السلام ";
            this.Label2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Outgoing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.bunifuUserControl2);
            this.Name = "Outgoing";
            this.Size = new System.Drawing.Size(276, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuUserControl bunifuUserControl2;
        private Guna.UI.WinForms.GunaLabel Label2;
    }
}
