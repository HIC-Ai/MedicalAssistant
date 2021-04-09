namespace MedicalAssistant
{
    public class CloudTextToSpeech2Base
    {
        //time in milliseconds
        private string text;
        //time in milliseconds
        private string gender;
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

        //public WaveOutEvent CloudTextToSpeech2(string text, string gender)
        //{
        //    this.text = text;
        //    this.gender = gender;
        //    return text;

        //}
    }
}