using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    partial class Program
    {    
        static void Main(string[] args)
        {

            #region Class
            var john = new Person();
            john.FirstName = "Raghu";
            john.LastName = "Devarapalli";

            john.Introduction();

            Calculator calculator = new Calculator();
            var result = calculator.Add(3, 4);
            Console.WriteLine(result);
            #endregion

            #region Arrays
            var number = new int[3];
            number[0] = 1;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "John", "Smith", "Raghu" };
            #endregion

            #region strings
            var firstName = "Raghu";
            var lastName = "Devarapalli";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var namesList = new string[3] { "John", "smith", "Raghu" };
            var listOfNames = string.Join("|", namesList);

            var text = @"Mosh C# course folder is given below
C:\Development\CSharp\Udemy\MoshHamedani C# Training\CSharpBasicsforBeginners\MoshHelloWorld\MoshHelloWorld\CSharpFundamentals\
This is version controlled";
            Console.WriteLine(text);
            #endregion

            #region Reference type & Value type
            var a = 8;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a={0},b={1}",a,b));

            var array1 = new int[3]{ 1,2,3};
            var array2 = array1;
            array2[0] = 8;
            Console.WriteLine("array1[0]: {0}, array2[0]: {1}",array1[0],array2[0]);
            #endregion

            Console.ReadKey();

        }
    }
}
