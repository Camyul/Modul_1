using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_ClassLibrary
{
    public class Battery
    {
        private string batModel;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType = BatteryType.LiPol;

        public Battery()
        {
            this.batModel = null;
            this.hoursIdle = 120;
            this.hoursTalk = 5;
        }
        public Battery(string batModel)
        {
            this.batModel = batModel;
            this.hoursIdle = 120;
            this.hoursTalk = 5;
        }
        public Battery(string batModel, int hoursIdle, int hoursTalk)
        {
            this.batModel = batModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public string BatModel
        {
            get
            {
                return this.batModel;
            }
            set
            {
                this.batModel = value;

            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Value can't be smaller from \"0\"");
                }
                this.hoursIdle = value;

            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0 || value >= this.hoursIdle)
                {
                    throw new IndexOutOfRangeException("Value can't be smaller from \"0\" and biggest \"Hours Idle\"");
                }
                this.hoursTalk = value;

            }
        }
        public override string ToString()
        {
            return String.Format("Model of Battery: {0}\n\rHoursIdle: {1} hours\n\rHoursTalk: {2} hours\n\rBatteryType: {3}",
                        this.batModel ?? "n\\a", this.hoursIdle, this.hoursTalk, batteryType);
        }
    }
}
