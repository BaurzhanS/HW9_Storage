using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW9_Inheritance.classes
{
    public class HDD: Storage
    {
        public double Speed { set; get; }
        public int Sections { set; get; }
        public double SectionMemory { set; get; }
        public double UsedMemory { set; get; }

        public HDD() : this("", "", 0,0) { }
        public HDD(string name, string model, int sections, double SectionMemory, double Speed = 3000) : base(name, model)
        {
            this.Speed = Speed;
            this.Sections = sections;
            this.SectionMemory = SectionMemory;
            this.UsedMemory = 0;
        }

        public override double GetMemoryVolume()
        {
            return this.SectionMemory*this.Sections;
        }
        public override double CopyDataToDevice(double DataVolume)
        {

            if (DataVolume > ((Sections*SectionMemory) - UsedMemory))
            {
                Console.WriteLine("Памяти в устройстве не хватает!");
                return UsedMemory;
            }
            else
            {
                Console.WriteLine("Копирование займет {0} секунд: ", (this.Speed * DataVolume / Speed));
                Thread.Sleep((int)(this.Speed * DataVolume / Speed));
                UsedMemory = UsedMemory + DataVolume;
                Console.WriteLine("Данные скопированы на устройство Flash");
                return UsedMemory;
            }
        }
        public override double GetInfoforDeviceFreeSpace()
        {
            Console.WriteLine("Объем свободного места: {0}", ((Sections * SectionMemory) - this.UsedMemory));
            return ((Sections * SectionMemory) - this.UsedMemory);
        }
        public override void GetDeviceFullInfo()
        {
            Console.WriteLine("Наименование: {0}\nМодель: {1}\nСкорость: {2}\nПамять: {3}\nСвободная память: {4}",
                this.Name, this.Model, this.Speed, (Sections * SectionMemory), (Sections * SectionMemory)-this.UsedMemory);
        }
    }
}
