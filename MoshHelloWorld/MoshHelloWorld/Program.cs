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
            #region premetive types and conversions examples
            //byte number = 255;
            //int count = 2;
            //float totalPrice = 20.95f;
            //char charecter = 'A';
            //string firstName = "Raghu";
            //bool isWorking = true;

            /* 
            var number = 255;
            var count = 2;
            var totalPrice = 20.95f;
            var charecter = 'A';
            var firstName = "Raghu";
            var isWorking = true;

            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            int i = 1;
            byte b = (byte) i;
            Console.WriteLine(i);

            int j = 1000;
            byte c = (byte)j;
            Console.WriteLine(c);

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
            */
            #endregion

            #region Compatable conversions example
            //string number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);
            #endregion

            #region Non Compatable conversion example
            //string number = "1234";
            //byte b = Convert.ToByte(number);
            //Console.WriteLine(b);

            ///<summery> Error Message you get 
            /// 
            /// Unhandled Exception: System.OverflowException: Value was either too large or too small for an unsigned byte.
            ///    at System.Byte.Parse(String s, NumberStyles style, NumberFormatInfo info)
            ///    at System.Convert.ToByte(String value)
            ///    at MoshHelloWorld.Program.Main(String[] args) in C:\Development\CSharp\Udemy\MoshHamedani C# Training\CSharpBasicsforBeginners\MoshHelloWorld\MoshHelloWorld\MoshHelloWorld\Program.cs:line 62
            ///    
            /// </summery>
            ///
            #endregion

            #region Non compatable conversion example with error handling
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("Cannot convert string value to byte");
            }
            #endregion

            #region compatable conversion example 2 with error handling
            try
            {
                var str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("Cannot convert string value to byte");
            }
            #endregion

        }
    }
}
