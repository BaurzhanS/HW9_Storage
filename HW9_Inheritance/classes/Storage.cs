using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW9_Inheritance.classes
{
    public abstract class Storage
    {
        public string Name { set; get; }
        public string Model { set; get; }
        public Storage(string name, string model)
        {
            this.Name = name;
            this.Model = model;
        }
        public abstract double GetMemoryVolume();
        public abstract double CopyDataToDevice(double DataVolume);
        public abstract double GetInfoforDeviceFreeSpace();
        public abstract void GetDeviceFullInfo();
    }
}
