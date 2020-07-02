using System;
using System.Collections.Generic;
using System.Text;

namespace TechTestMerkle
{
    public class Time
    {   
        private int Seconds { get; set; }

        private int Minutes { get; set; }

        private int Hours { get; set; }

        public Time(int hours, int minutes, int seconds)
        {
            this.Seconds = seconds;
            this.Minutes = minutes;
            this.Hours = hours; 
        }

        public string TimeString()
        {
            if (this.Hours > 24 || this.Hours < 0 || this.Minutes < 0 || this.Hours < 0)
                throw new Exception("Invalid input");

            return new TimeSpan(this.Hours, this.Minutes, this.Seconds).ToString();
        }

        public void Scale(int seconds)
        {
            TimeSpan timeSpan;

            timeSpan = TimeSpan.FromSeconds(seconds);
            this.Seconds += timeSpan.Seconds;
            this.Minutes += timeSpan.Minutes;
            this.Hours += timeSpan.Hours;
        }

    }
}
