using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW1
{
    public class ElectricCar : Car
    {

        public double BatteryCapacity { get; set; }
        private double batteryLevel;


        public ElectricCar(string brand, string model, int year, double initialMileage, double batteryCapacity)
            : base(brand, model, year, initialMileage)
        {
            BatteryCapacity = batteryCapacity;
            batteryLevel = batteryCapacity;
        }


        public void Charge(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Кількість заряду не може бути від'ємною");
            }
            batteryLevel += amount;
            if (batteryLevel > BatteryCapacity)
            {
                batteryLevel = BatteryCapacity;
            }
            Console.WriteLine($"Рівень заряду батареї: {batteryLevel}/{BatteryCapacity}");
        }


        public override void Drive(double distance)
        {
            if (distance < 0)
            {
                throw new ArgumentException("Відстань не може бути від'ємною");
            }
            double requiredBattery = distance * 0.2; // Припустимо, 1 км витрачає 0.2 одиниці заряду
            if (requiredBattery > batteryLevel)
            {
                throw new InvalidOperationException("Недостатньо заряду для подолання відстані");
            }
            batteryLevel -= requiredBattery;
            base.Drive(distance);
            Console.WriteLine($"Заряд батареї після поїздки: {batteryLevel}/{BatteryCapacity}");
        }
    }
}
