using System;

namespace OOP
{
    public class Transmission
    {
        public string Type;
        public int Gears;
        public string Producer;

        public Transmission(string type, int gears, string producer)
        {
            this.Type = type;
            this.Gears = gears;
            this.Producer = producer;
        }

        public void ShowTransmission()
        {
            Console.WriteLine($"Transmission type: {Type}, \nNumber of gears: {Gears}, \nProducer: {Producer}");
        }
    }
}