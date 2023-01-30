using System;

namespace OOP
{
    public class Engine
    {
        public int Power;
        public int Capacity;
        public string Type;
        public string SerialNumber;

        public Engine(int power, int capacity, string type, string serialNumber)
        {
            this.Power = power;
            this.Capacity = capacity;
            this.Type = type;
            this.SerialNumber = serialNumber;
        }

        public void ShowEngine()
        {
            Console.WriteLine(
                $"Power: {Power} H.P., \nCapacity: {Capacity} liters, \nType: {Type}, \nSerial number: {SerialNumber}");
        }
    }
}