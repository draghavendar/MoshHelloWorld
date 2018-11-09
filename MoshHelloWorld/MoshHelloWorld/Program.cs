using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 255;
            //int count = 2;
            //float totalPrice = 20.95f;
            //char charecter = 'A';
            //string firstName = "Raghu";
            //bool isWorking = true;

            var number = 255;
            var count = 2;
            var totalPrice = 20.95f;
            var charecter = 'A';
            var firstName = "Raghu";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(charecter);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0},{1}", float.MaxValue, float.MaxValue);
            Console.ReadKey();
        }
    }
}
