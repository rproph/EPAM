using System;

namespace OOP
{
    public class Chassis
    {
        public int NumberOfWheels;
        public int Number;
        public int PermissibleLoad;

        public Chassis(int numberOfWheels, int number, int permissibleLoad)
        {
            this.NumberOfWheels = numberOfWheels;
            this.Number = number;
            this.PermissibleLoad = permissibleLoad;
        }

        public void ShowChassis()
        {
            Console.WriteLine(
                $"Number of wheels: {NumberOfWheels}, \nNumber: {Number}, \nPermissible load: {PermissibleLoad} tons");
        }
    }
}