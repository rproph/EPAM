using System;

namespace Development_and_Build_Tools
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Word: ");

            String word = Console.ReadLine()?.ToLower();
            char[] arr = new char[1];
            arr[0] = word[0];

            int counter;

            for (int i = 0; i < word.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (word[i] != arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter == arr.Length)
                {
                    char[] newArr = new char[arr.Length + 1];

                    for (int k = 0; k < arr.Length; k++)
                    {
                        newArr[k] = arr[k];
                    }

                    newArr[newArr.Length - 1] = word[i];
                    arr = newArr;
                }
            }

            Console.WriteLine(arr.Length);
        }
    }
}