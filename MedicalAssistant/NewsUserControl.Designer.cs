
namespace MedicalAssistant
{
    partial class NewsUserControl
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Column 0");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Column 1");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Column 2");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Column 3");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 1");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 2");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 3");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 4");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem5 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 5");
            this.radCardView1 = new Telerik.WinControls.UI.RadCardView();
            this.cardViewGroupItem1 = new Telerik.WinControls.UI.CardViewGroupItem();
            this.cardViewItem1 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem2 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem3 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem4 = new Telerik.WinControls.UI.CardViewItem();
            ((System.ComponentModel.ISupportInitialize)(this.radCardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCardView1.CardTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radCardView1
            // 
            // 
            // 
            // 
            this.radCardView1.CardTemplate.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewGroupItem1});
            this.radCardView1.CardTemplate.Location = new System.Drawing.Point(334, 91);
            this.radCardView1.CardTemplate.Name = "radCardView2Template";
            this.radCardView1.CardTemplate.Size = new System.Drawing.Size(200, 250);
            this.radCardView1.CardTemplate.TabIndex = 0;
            listViewDetailColumn1.HeaderText = "Column 0";
            listViewDetailColumn2.HeaderText = "Column 1";
            listViewDetailColumn3.HeaderText = "Column 2";
            listViewDetailColumn4.HeaderText = "Column 3";
            this.radCardView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radCardView1.GroupItemSize = new System.Drawing.Size(200, 28);
            listViewDataItem1.Text = "ListViewItem 1";
            listViewDataItem2.Text = "ListViewItem 2";
            listViewDataItem3.Text = "ListViewItem 3";
            listViewDataItem4.Text = "ListViewItem 4";
            listViewDataItem5.Text = "ListViewItem 5";
            this.radCardView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1,
            listViewDataItem2,
            listViewDataItem3,
            listViewDataItem4,
            listViewDataItem5});
            this.radCardView1.Location = new System.Drawing.Point(26, 12);
            this.radCardView1.Name = "radCardView1";
            this.radCardView1.Size = new System.Drawing.Size(869, 452);
            this.radCardView1.TabIndex = 2;
            this.radCardView1.ThemeName = "Fluent";
            this.radCardView1.CardViewItemFormatting += new Telerik.WinControls.UI.CardViewItemFormattingEventHandler(this.radCardView1_CardViewItemFormatting);
            // 
            // cardViewGroupItem1
            // 
            this.cardViewGroupItem1.Bounds = new System.Drawing.Rectangle(0, 0, 200, 250);
            this.cardViewGroupItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewItem1,
            this.cardViewItem2,
            this.cardViewItem3,
            this.cardViewItem4});
            this.cardViewGroupItem1.Name = "cardViewGroupItem1";
            // 
            // cardViewItem1
            // 
            this.cardViewItem1.Bounds = new System.Drawing.Rectangle(0, 0, 192, 49);
            this.cardViewItem1.FieldName = "Column 0";
            this.cardViewItem1.Name = "cardViewItem1";
            this.cardViewItem1.Text = "Column 0";
            // 
            // cardViewItem2
            // 
            this.cardViewItem2.Bounds = new System.Drawing.Rectangle(0, 49, 192, 49);
            this.cardViewItem2.FieldName = "Column 1";
            this.cardViewItem2.Name = "cardViewItem2";
            this.cardViewItem2.Text = "Column 1";
            // 
            // cardViewItem3
            // 
            this.cardViewItem3.Bounds = new System.Drawing.Rectangle(0, 98, 192, 49);
            this.cardViewItem3.FieldName = "Column 2";
            this.cardViewItem3.Name = "cardViewItem3";
            this.cardViewItem3.Text = "Column 2";
            // 
            // cardViewItem4
            // 
            this.cardViewItem4.Bounds = new System.Drawing.Rectangle(0, 147, 192, 75);
            this.cardViewItem4.FieldName = "Column 3";
            this.cardViewItem4.Name = "cardViewItem4";
            this.cardViewItem4.Text = "Column 3";
            // 
            // NewsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 476);
            this.Controls.Add(this.radCardView1);
            this.Name = "NewsUserControl";
            this.Load += new System.EventHandler(this.NewsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCardView1.CardTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCardView radCardView1;
        private Telerik.WinControls.UI.CardViewGroupItem cardViewGroupItem1;
        private Telerik.WinControls.UI.CardViewItem cardViewItem1;
        private Telerik.WinControls.UI.CardViewItem cardViewItem2;
        private Telerik.WinControls.UI.CardViewItem cardViewItem3;
        private Telerik.WinControls.UI.CardViewItem cardViewItem4;
    }
}
