using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MedicalAssistant
{
    public partial class NewsUserControl : Form
    {
        public NewsUserControl()
        {
            InitializeComponent();

            this.radCardView1.ItemSize = new System.Drawing.Size(500, 250);
            this.radCardView1.CardTemplate.LoadLayout(@"..\..\layout.xml");
            //this.radCardView1.DataSource = this.employeesBindingSource;
        }

        private void NewsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void radCardView1_CardViewItemFormatting(object sender, Telerik.WinControls.UI.CardViewItemFormattingEventArgs e)
        {
            CardViewItem cardViewItem = e.Item as CardViewItem;
            if (cardViewItem != null)
            {
                if (cardViewItem.FieldName == "Notes")
                {
                    cardViewItem.EditorItem.TextWrap = true;
                    cardViewItem.EditorItem.AutoEllipsis = true;
                }
                else
                {
                    cardViewItem.EditorItem.ResetValue(LightVisualElement.TextWrapProperty, Telerik.WinControls.ValueResetFlags.Local);
                }

                if (cardViewItem.FieldName == "TitleOfCourtesy" || cardViewItem.FieldName == "FirstName" || cardViewItem.FieldName == "LastName")
                {
                    cardViewItem.Font = new Font(cardViewItem.Font.FontFamily, 10.5f, FontStyle.Regular);
                }
                else
                {
                    Font itemFont = new Font(cardViewItem.Font.FontFamily, cardViewItem.Font.Size, FontStyle.Bold);
                    Font editorFont = new Font(cardViewItem.Font.FontFamily, cardViewItem.Font.Size, FontStyle.Regular);

                    cardViewItem.Font = itemFont;
                    cardViewItem.EditorItem.Font = editorFont;
                }
            }
        }
    }
}
