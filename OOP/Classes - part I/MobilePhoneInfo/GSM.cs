using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneInfo
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static readonly GSM iPhone4S = new GSM("IPhone 4S", "Apple", 1000.0, "me", new Battery("apple battery", 24, 24, BatteryType.LiIon), new Display(4, 4000000));

        private bool CheckPrice(double? value)
        {
            if (price <= 0)
            {
                return false;
            }
            return true;
        }

        public static GSM PIPhone
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory { get; private set; }

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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (!CheckPrice(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
        {
            CallHistory = new List<Call>();
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, null, null) { }

        public override string ToString()
        {
            string result = "The GSM model is " + this.Model + ". The manufacturer is " + this.Manufacturer + ". ";
            if (this.Price != null)
            {
                result += "The price is: " + this.Price + ". ";
            }
            if (this.Owner != null)
            {
                result += "The owner is: " + this.Owner + ". ";
            }
            if (this.Battery != null)
            {
                result += this.Battery.ToString();
            }
            if (this.Display != null)
            {
                result += this.Display.ToString();
            }
            return result;
        }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            if (!CallHistory.Contains(call))
            {
                throw new Exception("There is no such call in Call History!");
            }
            CallHistory.Remove(call);
        }

        public List<Call> ClearHistory()
        {
            List<Call> result = new List<Call>();
            result.AddRange(this.CallHistory);
            CallHistory.Clear();
            return result;
        }

        public double CalculatePrice(double price, double maxPrice = double.MaxValue)
        {
            if (price < 0 || price > maxPrice)
            {
                throw new ArgumentOutOfRangeException("The price must be >= 0 and < "+ maxPrice + "!");
            }
            double totalPrice = 0.0;
            foreach (Call call in CallHistory)
            {
                int minutes = call.Duration / 60;
                if (call.Duration % 60 != 0)
                {
                    minutes++;
                }
                totalPrice += price * minutes;
            }
            return totalPrice;
        }
    }
}
