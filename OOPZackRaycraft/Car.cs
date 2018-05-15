using System;
namespace OOPZackRaycraft
{
    public class Car
    {
        public Car() { }

            private int Speed;
        private string Make;
        private string Model;
        private int Year;
        
        public Car(string make, string model, int year, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Speed = speed;
        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            Speed = 0;
        }

        public int SpeedUp()
        {
            Speed++;
            return Speed;
        }

        public int SlowDown()
        {
            if (Speed > 0)
            {
                Speed--;
            }
            return Speed;
        }

        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
        }
    }
}

