using System;

namespace MobilePhoneInfo
{
    //battery characteristics (model, hours idle and hours talk) 
    class Battery
    {
        private BatteryType? type;
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;

        private bool CheckHoursData(int? value)
        {
            if (value <= 0)
            {
                return false;
            }
            return true;
        }

        public BatteryType? Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (!CheckHoursData(value))
                {
                    throw new ArgumentOutOfRangeException("Invalid input!");
                }
                this.hoursIdle = value;
            }
        }
        
        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (!CheckHoursData(value))
                {
                    throw new ArgumentOutOfRangeException("Invalid input!");
                }
                this.hoursTalk = value;
            }
        }
       
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        public Battery()
        {
            this.Model = null;
            this.HoursIdle = null;
            this.HoursTalk = null;
            this.Type = null;
        }
        
        public override string ToString()
        {
            string result = "";
            if (this.Model != null)
            {
                result = result + "The battery model is " + this.Model + ". ";
            }
            if (this.HoursIdle != null)
            {
                result = result + "Hours idle: " + this.HoursIdle+ ". ";
            }
            if (this.HoursTalk != null)
            {
                result = result + "Hours talk: " + this.HoursTalk+ ". ";
            }
            if (this.Type != null)
            {
                result = result + "The battery type is: " + this.Type + ". ";
            }
            return result;
        }
    }
}
