using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAssistant
{
    public partial class Tips : Form
    {
        public Tips()
        {
            InitializeComponent();
        }
        ArrayList TipsWords = new ArrayList();
        string tip;
        int i = 0;
        int time1 = 0;
        int len = 0;
        private void Tips_Load(object sender, EventArgs e)
        {
            Tips_call.WorkerReportsProgress = true;
            Tips_call.WorkerSupportsCancellation = true;
            if (Tips_call.IsBusy != true)
            {
                Tips_call.RunWorkerAsync();
            }
        }

        private void Tips_call_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(6000); // انتظار 6 ثواني لحين فتج النصائج

            BackgroundWorker worker = sender as BackgroundWorker;

            while (true) // حلقه تكراريه علي النصائج غير منتهية
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

        private void Tips_call_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // اذا كانت النصيحه فارغه ام لا
            if (tip != "")
            {
                Console.WriteLine(tip);
                // اذا كان اي صوت يقال في الخليفيه ينهي قول النصيحه
                {
                    len = tip.Length / 4;
                    timer1.Enabled = true;
                    new recognitionArabic().CloudTextToSpeech("نصيحة : " + tip, "male");    // قول النصيحه بصوت رجل

                }


            }

        }

        private void timer1_Tick(object sender, EventArgs e)
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
                    timer1.Stop(); // ايقاف تايمر الاينمي لبدا نصيحه اخري
                }
            }
        }
    }
}
