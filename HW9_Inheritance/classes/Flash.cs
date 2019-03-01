using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW9_Inheritance.classes
{
    public class Flash: Storage
    {
        public double Speed { set; get; }
        public double Memory { set; get; }
        public double UsedMemory { set; get; }

        public Flash(): this("","",0) { }
        public Flash(string name, string model, double Memory, double Speed=3000) :base(name,model)
        {
            this.Speed = Speed;
            this.Memory = Memory;
            this.UsedMemory = 0;
        }

        public override double GetMemoryVolume()
        {
            return this.Memory;
        }
        public override double CopyDataToDevice(double DataVolume)
        {
            
            if (DataVolume > (Memory-UsedMemory))
            {
                Console.WriteLine("Памяти в устройстве не хватает!");
                return UsedMemory;
            }
            else
            {
                Console.WriteLine("Копирование займет {0} секунд: ",(this.Speed * DataVolume / Speed));
                Thread.Sleep((int)(this.Speed * DataVolume / Speed));
                UsedMemory=UsedMemory + DataVolume;
                Console.WriteLine("Данные скопированы на устройство Flash");
                return UsedMemory;
            }
        }
        public override double GetInfoforDeviceFreeSpace()
        {
            Console.WriteLine("Объем свободного места: {0}", (this.Memory - this.UsedMemory));
            return this.Memory - this.UsedMemory;
        }
        public override void GetDeviceFullInfo()
        {
            Console.WriteLine("Наименование: {0}\nМодель: {1}\nСкорость: {2}\nПамять: {3}\nСвободная память: {4}",
                this.Name,this.Model,this.Speed,this.Memory,(Memory-UsedMemory));
        }
    }
}
