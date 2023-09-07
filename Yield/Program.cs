using System;

namespace Yield
{
    internal class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
            {
                Console.WriteLine(element);
            }

            foreach (string element in UserCollection.NoPower())
            {
                Console.WriteLine(element);
            }

            foreach (int element in UserCollection.InragerIenum())
            {
                Console.WriteLine(element);
            }

            foreach (object element in UserCollection.Objejcts())
            {
                Console.WriteLine(element);
            }


            Console.ReadLine();
        }
    }
}