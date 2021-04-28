using NAudio.Wave;
using System;
using System.Collections.Generic;
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
        string phrase = "";
        public bool haveNet = true;

        public string SpeakRecognition(string file = "test.wav")
        {
            try
            {
                Console.WriteLine(file);
                WebRequest request = WebRequest.Create("https://www.google.com/speech-api/v2/recognize?output=json&lang=AR-eg&key=AIzaSyBOti4mM-6x9WDnZIjIeyEU21OpBXqWBgw");
                //
                request.Method = "POST";
                byte[] byteArray = File.ReadAllBytes(file);
                request.ContentType = "audio/l16; rate=16000"; //"16000";
                request.ContentLength = byteArray.Length;
                request.GetRequestStream().Write(byteArray, 0, byteArray.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadToEnd();
                string[] strs = ParseJson(str);


                if (strs.Length > 0) phrase = strs[0].ToLower();

                //Console.WriteLine(phrase);
            }
            catch
            { }
            return phrase;
        }

        public WaveOutEvent MixAudioFiles(string speechMp3)
        {
            WaveOutEvent waveOut = new WaveOutEvent();
            if (haveNet)
            {
                Mp3FileReader reader = new Mp3FileReader(speechMp3);
                waveOut.Init(reader);
                waveOut.Play();
            }

            else
            {
                Mp3FileReader reader = new Mp3FileReader("Sounds\\NoInternetArabic.mp3");
                waveOut.Init(reader);
                waveOut.Play();
            }
            return waveOut;


        }
        public class MyWebClient : WebClient
        {
            //time in milliseconds
            private int timeout;
            public int Timeout
            {
                get
                {
                    return timeout;
                }
                set
                {
                    timeout = value;
                }
            }

            public MyWebClient()
            {
                this.timeout = 2000;
            }

            public MyWebClient(int timeout)
            {
                this.timeout = timeout;
            }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var result = base.GetWebRequest(address);
                result.Timeout = this.timeout;
                return result;
            }
        }


        public class  CloudTextToSpeech2
        {
            //time in milliseconds
            private string text, gender;

            private WaveOutEvent waveOut;

            public string Text
            {
                get
                {
                    return text;
                }
                set
                {
                    text = value;
                }
            }

            public string Gender
            {
                get
                {
                    return gender;
                }
                set
                {
                    gender = value;
                }
            }

            public WaveOutEvent WaveOut
            {
                get
                {
                    return waveOut;
                }
                set
                {
                    //waveOut = value;
                }
            }
            public CloudTextToSpeech2()
            {
                this.text = "";
                this.gender = "";
            }

            public CloudTextToSpeech2(string text, string gender)
            {
                this.waveOut = new WaveOutEvent();

                this.text = text;
                this.gender = gender;
                bool haveNet = true;



                string lang = "ar";
                double pitch = 0.6;
                double rate = 0.5;
                double speed = 0.5;
                double maxresults = 1;
                double xjerr = 5;
                //Console.WriteLine($"\tprocessing phrase: \"{text}\" ");
                var timestamp = (DateTime.Now.ToFileTime()).ToString();


                const string key = "AIzaSyBOti4mM-6x9WDnZIjIeyEU21OpBXqWBgw";
                //    int txtLen = text.Length;
                text = "%" + BitConverter.ToString(Encoding.UTF8.GetBytes(text)).Replace("-", "%");
                string url = $"https://www.google.com/speech-api/v2/synthesize?ie=UTF-8enc=mpeg&client=chromium&key={key}&text={text}&xjerr={xjerr}&lang={lang}&gender={gender}&speed={speed}&pitch={pitch}&maxresults={maxresults}";


                MyWebClient wClient = new MyWebClient(2000);
                wClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows)");
                try
                {
                    wClient.DownloadFile(url, timestamp);
                }
                catch
                {
                    haveNet = false;
                }

                if (haveNet)
                {
                    Mp3FileReader reader = new Mp3FileReader(timestamp);
                    waveOut.Init(reader);
                    waveOut.Play();
                }

                else
                {
                    Mp3FileReader reader = new Mp3FileReader("Sounds\\NoInternetArabic.mp3");
                    waveOut.Init(reader);
                    waveOut.Play();
                }
            }

        }


        public void cloudTextToSpeech(string outFileName, string text, string lang, string gender, double speed = 0.5, double pitch = 0.5, double rate = 0.5, double maxresults = 1, double xjerr = 1)
        {
            const string key = "AIzaSyBOti4mM-6x9WDnZIjIeyEU21OpBXqWBgw";
            //    int txtLen = text.Length;
            text = "%" + BitConverter.ToString(Encoding.UTF8.GetBytes(text)).Replace("-", "%");
            string url = $"https://www.google.com/speech-api/v2/synthesize?ie=UTF-8enc=mpeg&client=chromium&key={key}&text={text}&xjerr={xjerr}&lang={lang}&gender={gender}&speed={speed}&pitch={pitch}&maxresults={maxresults}";


            MyWebClient wClient = new MyWebClient(2000);
            wClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows)");
            try
            {
                wClient.DownloadFile(url, outFileName);
            }
            catch
            {
                haveNet = false;
            }
            //using (WebClient client = new WebClient())
            //{

            //    client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows)");
            //    int txtLen = text.Length;
            //    text = "%" + BitConverter.ToString(Encoding.UTF8.GetBytes(text)).Replace("-", "%");
            //    string url = $"https://www.google.com/speech-api/v2/synthesize?ie=UTF-8enc=mpeg&client=chromium&key={key}&text={text}&xjerr={xjerr}&lang={lang}&gender={gender}&speed={speed}&pitch={pitch}&maxresults={maxresults}";
            //    //client.DownloadFile(url, outFileName);
            //    var taskDownload = client.DownloadFileTaskAsync(new Uri(url), outFileName);
            //    taskDownload.Wait(TimeSpan.FromSeconds(5));


            //}
        }
        string[] ParseJson(string json)
        {
            List<string> list = new List<string>();
            try
            {
                string[] lines = json.Split(new[] { "\"transcript\":\"" }, StringSplitOptions.RemoveEmptyEntries);


                for (int i = 1; i < lines.Length; i++)
                    list.Add(lines[i].Substring(0, lines[i].IndexOf("\"", StringComparison.Ordinal)));
            }
            catch
            {

            }

            return list.ToArray();
        }

        public WaveOutEvent CloudTextToSpeech(string text, string gender)
        {
            //string lang = "ar";
            //double pitch = 0.6;
            //double rate = 0.5;
            //double speed = 0.5;
            //double maxresults = 1;
            //double xjerr = 5;
            ////string text = textBox1.Text;
            //Console.WriteLine($"\tprocessing phrase: \"{text}\" ");
            //var timestamp = (DateTime.Now.ToFileTime()).ToString();
            ////Console.WriteLine(timestamp);
            ////Thread thread = new Thread(() => cloudTextToSpeech(timestamp, text, lang, gender, speed, pitch, rate, maxresults, xjerr))
            ////{
            ////    IsBackground = true
            ////};
            ////thread.Start();
            ////Thread.Sleep(10000);


            //cloudTextToSpeech(timestamp, text, lang, gender, speed, pitch, rate, maxresults, xjerr);
            //return MixAudioFiles(timestamp);


            return new CloudTextToSpeech2(text, gender).WaveOut;

        }


    }
}
