using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кр_2варіант_
{
    public abstract class BusRoute
    {
        // Приватні поля
        private int routeNumber;             // Номер рейсу
        private string destination;          // Кінцевий пункт
        private string[] stops;              // Проміжні пункти
        private DateTime departureTime;      // Час відправлення
        private int seatsAvailable;          // Кількість вільних місць

        // Властивості
        public int RouteNumber
        {
            get => routeNumber;
            set => routeNumber = value;
        }

        public string Destination
        {
            get => destination;
            set => destination = value;
        }

        public string[] Stops
        {
            get => stops;
            set => stops = value;
        }

        public DateTime DepartureTime
        {
            get => departureTime;
            set => departureTime = value;
        }

        public int SeatsAvailable
        {
            get => seatsAvailable;
            set => seatsAvailable = value;
        }

        // Конструктор без аргументів
        public BusRoute() : this(0, "Unknown", new string[0], DateTime.Now, 0) { }

        // Конструктор з аргументами
        public BusRoute(int routeNumber, string destination, string[] stops, DateTime departureTime, int seatsAvailable)
        {
            RouteNumber = routeNumber;
            Destination = destination;
            Stops = stops;
            DepartureTime = departureTime;
            SeatsAvailable = seatsAvailable;
        }

        // Віртуальний метод для обчислення відстані
        public virtual double CalculateDistance()
        {
            return 0.0; // За замовчуванням відстань 0
        }

        // Перевизначення ToString
        public override string ToString()
        {
            return $"Route {RouteNumber} to {Destination}, Departure: {DepartureTime}, Seats Available: {SeatsAvailable}";
        }
    }
    public class ExpressRoute : BusRoute
    {
        private double averageSpeed; // Середня швидкість (км/год)

        public double AverageSpeed
        {
            get => averageSpeed;
            set => averageSpeed = value;
        }

        public ExpressRoute(int routeNumber, string destination, string[] stops, DateTime departureTime, int seatsAvailable, double averageSpeed)
            : base(routeNumber, destination, stops, departureTime, seatsAvailable)
        {
            AverageSpeed = averageSpeed;
        }

        public override double CalculateDistance()
        {
            // Умовно вважаємо відстань залежною від середньої швидкості та фіксованого часу
            return AverageSpeed * 3; // 3 години
        }

        public override string ToString()
        {
            return base.ToString() + $", Avg Speed: {AverageSpeed} km/h";
        }
    }

    public class LocalRoute : BusRoute
    {
        private int stopTime; // Час стоянки на кожній зупинці (хвилини)

        public int StopTime
        {
            get => stopTime;
            set => stopTime = value;
        }

        public LocalRoute(int routeNumber, string destination, string[] stops, DateTime departureTime, int seatsAvailable, int stopTime)
            : base(routeNumber, destination, stops, departureTime, seatsAvailable)
        {
            StopTime = stopTime;
        }

        public override double CalculateDistance()
        {
            // Вважаємо відстань залежною від кількості зупинок та фіксованої відстані між ними
            return Stops.Length * 50; // 50 км між кожною зупинкою
        }

        public override string ToString()
        {
            return base.ToString() + $", Stop Time: {StopTime} mins";
        }
    }

}
