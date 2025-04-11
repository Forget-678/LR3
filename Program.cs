using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Car
    {
        public string Brand { get; set; }
        public string LicensePlate { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"Автомобиль: марка - {Brand}, номер - {LicensePlate}");
        }
    }

    class PassengerCar : Car
    {
        public int NumberOfSeats { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Легковой автомобиль: марка - {Brand}, \nномер - {LicensePlate}, \nчисло пассажирских мест - {NumberOfSeats}");
            Console.WriteLine();
        }
    }

    
    class Truck : Car
    {
        public decimal LoadCapacity { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Грузовой автомобиль: марка - {Brand}, \nномер - {LicensePlate}, \nгрузоподъемность - {LoadCapacity}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            PassengerCar passengerCar = new PassengerCar
            {
                Brand = "Toyota",
                LicensePlate = "ABC123",
                NumberOfSeats = 5
            };

            Truck truck = new Truck
            {
                Brand = "MAN",
                LicensePlate = "XYZ789",
                LoadCapacity = 15000.5m
            };

            passengerCar.Show();
            truck.Show();
            Console.ReadKey();

        }
    }
}
