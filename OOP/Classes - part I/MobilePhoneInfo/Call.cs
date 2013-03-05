using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneInfo
{
    //date, time, dialed phone number and duration (in seconds).
    class Call
    {
        private DateTime date;
        private string dialedPhone;
        private int duration;

        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }

        public string DialedPhone
        {
            get
            {
                return this.dialedPhone;
            }
            private set
            {
                this.dialedPhone = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public Call(DateTime date, string dialedPhone, int duration)
        {
            this.Date = date;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The date is " + this.Date.Date + ". ");
            sb.Append("The time is " + this.Date.TimeOfDay + ". ");
            sb.Append("The dialed phone is " + this.DialedPhone + ". ");
            sb.Append("The duration is " + this.Duration + ". ");
            return sb.ToString();
        }
    }
}
