using NAudio.Wave;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace MedicalAssistant
{
    class recognitionArabic
    {
        //private static int lineCount = 0;
        private static StringBuilder output = new StringBuilder();

        //public string recognition_voice;
        private Process process;

        public string MyrecoHex;
        static void MixAudioFiles(string speechMp3)
        {
            var reader = new Mp3FileReader(speechMp3);
            var waveOut = new WaveOut(); // or WaveOutEvent()
            waveOut.Init(reader);
            waveOut.Play();
        }


        static void CloudTextToSpeech(string outFileName, string text, string lang, double speed = 0.5, double pitch = 0.5, double rate = 0.5, double maxresults = 1, double xjerr = 1)
        {
            const string key = "AIzaSyBOti4mM-6x9WDnZIjIeyEU21OpBXqWBgw";
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows)");
                int txtLen = text.Length;
                text = "%" + BitConverter.ToString(Encoding.UTF8.GetBytes(text)).Replace("-", "%");
                string url = $"https://www.google.com/speech-api/v2/synthesize?ie=UTF-8enc=mpeg&client=chromium&key={key}&text={text}&xjerr={xjerr}&lang={lang}&speed={speed}&pitch={pitch}&maxresults={maxresults}";
                client.DownloadFile(url, outFileName);
            }
        }
        public void CloudTextToSpeech(string text)
        {
            string lang = "ar";
            double pitch = 0.6;
            double rate = 0.5;
            double speed = 0.5;
            double maxresults = 1;
            double xjerr = 5;
            //string text = textBox1.Text;
            Console.WriteLine($"\tprocessing phrase: \"{text}\" ");
            var timestamp = (DateTime.Now.ToFileTime()).ToString();
            //Console.WriteLine(timestamp);

            CloudTextToSpeech(timestamp, text, lang, speed, pitch, rate, maxresults, xjerr);
            MixAudioFiles(timestamp);

        }
        public void Recognition()
        {
            while (true)
            {
                try
                {
                    using (FileStream MsiFile = new FileStream("recognition.exe", FileMode.Create))
                    {
                        MsiFile.Write(Properties.Resources.recognition, 0, Properties.Resources.recognition.Length);
                    }
                    process = new Process();
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = @"recognition.exe";
                    process.StartInfo.Arguments = "-p fb.com/3bdo.Mostafa30-abdulrahman-Mostafa";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                    {
                        // Prepend line numbers to each line of the output.
                        if (!String.IsNullOrEmpty(e.Data))
                        {
                            byte[] dBytes = StringToByteArray(e.Data);
                            string text = Encoding.UTF8.GetString(dBytes);
                            //lineCount++;
                            output.Append(text + " ");
                        }
                    });

                    //process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                    //process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();
                    break;
                }
                catch (Exception)
                {
                    try { Process.GetProcesses().Where(x => x.ProcessName.ToLower().StartsWith("recognition")).ToList().ForEach(x => x.Kill()); } catch (Exception) { }
                    //MessageBox.Show(ex.ToString());
                }
            }
        }
        public void OutputHandler(object sender, DataReceivedEventArgs e)
        {

            MyrecoHex = e.Data;

            if (MyrecoHex != null)
            {
                Console.WriteLine(e.Data);
                //string text = e.Data;
                //textBox1.Text = text;
                try
                {
                    byte[] dBytes = StringToByteArray(MyrecoHex);
                    string text = Encoding.UTF8.GetString(dBytes);
                    //recognition_voice = recognition_voice + text + " hsh ";
                    //Console.WriteLine(recognition_voice);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new StringReader(hex))
            {
                for (int i = 0; i < NumberChars; i++)
                    bytes[i] =
                      Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
            }
            return bytes;
        }

        public class WaveProviderToWaveStream : WaveStream
        {
            private readonly IWaveProvider source;
            private long position;

            public WaveProviderToWaveStream(IWaveProvider source)
            {
                this.source = source;
            }

            public override WaveFormat WaveFormat => source.WaveFormat;

            /// <summary>
            /// Don't know the real length of the source, just return a big number
            /// </summary>
            public override long Length => int.MaxValue;

            public override long Position
            {
                get
                {
                    // we'll just return the number of bytes read so far
                    return position;
                }
                set
                {
                    // can't set position on the source
                    // n.b. could alternatively ignore this
                    throw new NotImplementedException();
                }
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                int read = source.Read(buffer, offset, count);
                position += read;
                return read;
            }
        }
        public enum Leftorright { left, right }
        private Leftorright _LeftToRight = Leftorright.left;
        public Leftorright LeftToRight
        {
            get { return _LeftToRight; }
            set { _LeftToRight = value; }
        }

        public string Louding(bool start = false, bool end = false)
        {
            if (start == true)
            {
                Thread thread1 = new Thread(Recognition);
                thread1.IsBackground = true;
                thread1.Start();
            }
            if (end == true)
            {
                Process[] prs = Process.GetProcesses();


                foreach (Process pr in prs)
                {
                    if (pr.ProcessName == "recognition")
                    {

                        pr.Kill();

                    }

                }

                string messge = output.ToString();
                Console.WriteLine("Done " + messge);

                output.Length = 0;

                return messge;
            }
            //Console.WriteLine(recognition_voice);
            return output.ToString();
        }
    }
}
