
using System;
namespace DeviceMonitor
{
    class TemperatureModule
    {
        public static void Main(string[] args)
        {
            //Your Code here
            Console.WriteLine("runnning temperaturemodule");
            VibrationModule.Vibration();
        }
    }
    class VibrationModule
    {
        public static void Vibration()
        {
            //Your code here
            Console.WriteLine("running vibrationmodule");
        }
    }
}
