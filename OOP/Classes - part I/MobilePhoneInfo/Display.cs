using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneInfo
{
    // display characteristics (size and number of colors).
    class Display
    {
        private double? size;
        private int? colorsNumber;



        public Display(double? size, int? colorsNumber)
        {
            this.Size = size;
            this.ColorsNumber = colorsNumber;
        }

        public Display()
            : this(null, null)
        {
        }

        public Display(double? size)
            : this(size, null)
        {
        }

        public Display(int? colors)
            : this(null, colors)
        {
        }

        private bool CheckColorData(int? value)
        {
            if (value <= 0)
            {
                return false;
            }
            return true;
        }
        private bool CheckSizeData(double? value)
        {
            if (value <= 0)
            {
                return false;
            }
            return true;
        }

        public int? ColorsNumber
        {
            get
            {
                return this.colorsNumber;
            }
            private set
            {
                if (!CheckColorData(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.colorsNumber = value;
            }
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (!CheckSizeData(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.size = value;
            }
        }

        public override string ToString()
        {
            string result = "";
            if (this.Size != null)
            {
                result = result + "The display size is " + this.Size + ". ";
            }
            if (this.ColorsNumber != null)
            {
                result = result + "The number of the colors of the display is " + this.ColorsNumber + ". ";
            }
            return result;
        }
    }
}
