using System;

namespace EK_Collection_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colorOptions = { "Red", "Green", "Blue" };

            foreach(var color in colorOptions)
            {
                Console.WriteLine(color.ToUpper());
            }

            Console.ReadKey();
        }
    }
}
