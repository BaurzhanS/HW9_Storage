using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW9_Inheritance.classes
{
    public enum Type { oneSided=4700,twoSided=9000}
    public class DVD : Storage
    {
        public double ReadSpeed { set; get; }
        public double WriteSpeed { set; get; }
        public Type type;
        public double UsedMemory { set; get; }

        public DVD(): this("","",0) { }
        public DVD(string name, string model, Type type, double ReadSpeed=3000, double WriteSpeed=4000) : base(name, model)
        {
            this.type = type;
            this.ReadSpeed = ReadSpeed;
            this.WriteSpeed = WriteSpeed;
            this.UsedMemory = 0;
        }

        public override double GetMemoryVolume()
        {
            return (double)this.type;
        }
        public override double CopyDataToDevice(double DataVolume)
        {
            if (DataVolume > ((double)this.type - UsedMemory))
            {
                Console.WriteLine("Памяти в устройстве не хватает!");
                return UsedMemory;
            }
            else
            {
                Console.WriteLine("Копирование займет {0} секунд: ", (this.ReadSpeed * DataVolume / WriteSpeed));
                Thread.Sleep((int)(this.ReadSpeed * DataVolume / WriteSpeed));
                UsedMemory = UsedMemory + DataVolume;
                Console.WriteLine("Данные скопированы на устройство DVD");
                return UsedMemory;
            }
        }
        public override double GetInfoforDeviceFreeSpace()
        {
            Console.WriteLine("Объем свободного места: {0}", ((double)this.type - this.UsedMemory));
            return (double)this.type - this.UsedMemory;
        }
        public override void GetDeviceFullInfo()
        {
            Console.WriteLine("Наименование: {0}\nМодель: {1}\nСкорость чтения: {2}\nСкорость записи: {3}" +
                "\nПамять: {4}\nСвободная память: {5}",
                this.Name, this.Model, this.ReadSpeed, this.WriteSpeed, this.type, ((double)type - UsedMemory));
        }


    }

}
