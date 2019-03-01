using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW9_Inheritance.classes;

namespace HW9_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flash s = new Flash("Fleshcard", "HP", 4000);
            //s.CopyDataToDevice(2000);
            //s.CopyDataToDevice(2002);
            //s.GetDeviceFullInfo();
            //s.GetInfoforDeviceFreeSpace();
            //DVD d = new DVD("DVD", "HP", classes.Type.oneSided);
            //Console.WriteLine(d.Name);
            //d.CopyDataToDevice(3000);
            //d.CopyDataToDevice(3000);
            //d.GetInfoforDeviceFreeSpace();
            //d.GetDeviceFullInfo();
            //HDD h = new HDD("HDD", "HP", 6, 100);
            //h.GetDeviceFullInfo();
            //h.CopyDataToDevice(700);
            //h.GetDeviceFullInfo();
            List<Storage> devices = new List<Storage>();
            Flash s = new Flash("Fleshcard", "HP", 4000);
            DVD d = new DVD("DVD", "HP", classes.Type.oneSided);
            DVD d1 = new DVD("DVD-R", "Samsung", classes.Type.twoSided);
            HDD h = new HDD("HDD", "HP", 6, 200);
            devices.Add(s);
            devices.Add(d);
            devices.Add(d1);
            devices.Add(h);
            foreach(Storage item in devices)
            {
                item.GetDeviceFullInfo();
                Console.WriteLine();
                item.CopyDataToDevice(3000);
                Console.WriteLine();
                item.GetDeviceFullInfo();
                Console.WriteLine();
            }
        }
    }
}
