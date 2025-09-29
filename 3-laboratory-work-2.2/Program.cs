using System;

namespace lab02_02
{
    class Vehicle
    {
        private int x;
        private int y;
        private int price;
        private int speed;
        private int year;

        public Vehicle(int x, int y, int price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Координаты: ({x}, {y})");
            Console.WriteLine($"Цена: {price}$");
            Console.WriteLine($"Скорость: {speed} км/ч");
            Console.WriteLine($"Год выпуска: {year} г.");
        }
    }
    class Car : Vehicle
    {
        public Car(int x, int y, int price, int speed, int year) :
            base(x, y, price, speed, year)
        {
        }
        public void PrintInfo()
        {
            base.PrintInfo();
        }
    }
    class Plane : Vehicle
    {
        private int height;
        private int passengers;
        public Plane(int x, int y, int price, int speed, int year, int height, int passengers) :
            base(x, y, price, speed, year)
        {
            this.height = height;
            this.passengers = passengers;
        }
        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Высота полета: {height} м.");
            Console.WriteLine($"Количество пассажиров: {passengers}");
        }
    }
    class Ship : Vehicle
    {
        private int passengers;
        private string port;
        public Ship(int x, int y, int price, int speed, int year, int passengers, string port) :
            base(x, y, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }
        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Количество пассажиров: {passengers}");
            Console.WriteLine($"Порт: {port}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(
                -13, 45, 1200, 180, 2016);
            Plane plane = new Plane(
                0, 45, 4000000, 450, 2020, 3000, 125);
            Ship ship = new Ship(
                1457, -1356, 3500000, 90, 2005, 45, "Севкабель");

            car.PrintInfo();
            Console.WriteLine();
            plane.PrintInfo();
            Console.WriteLine();
            ship.PrintInfo();
        }
    }
}