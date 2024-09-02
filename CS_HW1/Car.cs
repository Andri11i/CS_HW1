using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW1
{
    public class Car
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        private double mileage;


        public int Age
        {
            get
            {
                return DateTime.Now.Year - Year;
            }
        }

        public double Mileage
        {
            get
            {
                return mileage;
            }
            private set
            {
                mileage = value;
            }
        }


        public Car(string brand, string model, int year, double initialMileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = initialMileage;
        }


        ~Car()
        {
            Console.WriteLine("Об'єкт Car видалено.");
        }


        public virtual void Drive(double distance)
        {
            if (distance < 0)
            {
                throw new ArgumentException("Відстань не може бути від'ємною");
            }
            Mileage += distance;
        }


        public virtual void Drive(double distance, double time)
        {
            if (distance < 0 || time <= 0)
            {
                throw new ArgumentException("Відстань не може бути від'ємною і час повинен бути більше нуля");
            }
            double averageSpeed = distance / time;
            Console.WriteLine($"Середня швидкість: {averageSpeed} км/год");
            Drive(distance);
        }
    }
}
