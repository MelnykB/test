using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class VehicleClass
        {
            public void Construct(CarBuilder carBuilder)
            {
                carBuilder.Body();
                carBuilder.Color();
                carBuilder.Engine();
                carBuilder.Salon();
            }
        }

        abstract class CarBuilder
        {
            protected Vehicle car;

            public Vehicle Car
            {
                get { return car; }
            }

            public abstract void Body();
            public abstract void Color();
            public abstract void Engine();
            public abstract void Salon();
        }

        class luxaryCar : CarBuilder
        {
            public luxaryCar()
            {
                car = new Vehicle("премiум");
            }

            public override void Body()
            {
                car["кузов"] = "купе";
            }

            public override void Color()
            {
                car["колір"] = "золотий";
            }

            public override void Engine()
            {
                car["двигун"] = "V12";
            }

            public override void Salon()
            {
                car["салон"] = "бiля шкiра";
            }
        }

        class MediumCar : CarBuilder
        {
            public MediumCar()
            {
                car = new Vehicle("представницьке");
            }

            public override void Body()
            {
                car["кузов"] = "кросовер";
            }

            public override void Color()
            {
                car["колір"] = "чорний";
            }

            public override void Engine()
            {
                car["двигун"] = "V6";
            }

            public override void Salon()
            {
                car["салон"] = "чорний шкiрзамiнник";
            }
        }

        class LowCar : CarBuilder
        {
            public LowCar()
            {
                car = new Vehicle("бюджетне");
            }

            public override void Body()
            {
                car["кузов"] = "седан";
            }

            public override void Color()
            {
                car["колір"] = "сiрий";
            }

            public override void Engine()
            {
                car["двигун"] = "L4";
            }

            public override void Salon()
            {
                car["салон"] = "сiрий велюр";
            }
        }
        class Vehicle
        {
            private string _carType;
            private Dictionary<string, string> _equipment = new Dictionary<string, string>();

            public Vehicle(string carType)
            {
                this._carType = carType;
            }

            public string this[string key]
            {
                get { return _equipment[key]; }
                set { _equipment[key] = value; }
            }

            public void Show()
            {
                Console.WriteLine("\n---------------------------");
                Console.WriteLine("Авто: {0}", _carType);
                Console.WriteLine(" Тип кузова: {0}", _equipment["кузов"]);
                Console.WriteLine(" Колiр: {0}", _equipment["колір"]);
                Console.WriteLine(" Двигун: {0}", _equipment["двигун"]);
                Console.WriteLine(" Салон: {0}", _equipment["салон"]);
            }
        }
        static void Main(string[] args)
        {
            //CarBuilder carBuilder = new CarBuilder();
            //carBuilder.
            Vehicle vehicle = new Vehicle();
            vehicle.Show();
        }
    }
}
