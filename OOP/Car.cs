using System;

namespace OOP
{
    public class Car
    {
        public string Name;

        private Engine eng = new Engine(100, 40, "Internal combustion engine", "A21");
        private Chassis chas = new Chassis(4, 4090, 5);
        private Transmission trans = new Transmission("Mechanical", 5, "Nissan");

        public Car(string name)
        {
            this.Name = name;
        }

        public void ShowCar()
        {
            Console.WriteLine(Name);
            eng.ShowEngine();
            chas.ShowChassis();
            trans.ShowTransmission();
        }
    }
}