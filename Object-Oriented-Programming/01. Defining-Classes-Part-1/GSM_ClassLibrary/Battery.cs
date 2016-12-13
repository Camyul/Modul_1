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
        private string hoursIdle;
        private string hoursTalk;
        private BatteryType batteryType = BatteryType.LiPol;

        public Battery()
        {
            this.batModel = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string batModel)
        {
            this.batModel = batModel;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string batModel, string hoursIdle, string hoursTalk)
        {
            this.batModel = batModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
       
        public void PrintBattery()
        {
            Console.WriteLine("Model: {0}\n\rHoursIdle: {1}\n\rHoursTalk: {2}\n\rBatteryType: {3}",
                            this.batModel ?? "n\\a", this.hoursIdle ?? "n\\a", this.hoursTalk ?? "n\\a", batteryType);
        }
    }
}
