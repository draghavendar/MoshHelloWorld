using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public String FirstName;
        public String LastName;

        public void Introduction()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }
}
