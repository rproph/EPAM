using System;

namespace Basic_of_.NET_Framework_and_C
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("number: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.Write("system: ");
            int sysOfNum = Int32.Parse(Console.ReadLine());

            int ost = 0;
            string result = "";

            if (sysOfNum == 2)
            {
                while (true)
                {
                    ost = number % 2;
                    number /= 2;

                    if (ost == 1)
                    {
                        result = "1" + result;
                    }
                    else if (ost == 0)
                    {
                        result = "0" + result;
                    }

                    if (number == 1)
                    {
                        result = "1" + result;
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}