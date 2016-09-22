using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp01
{
    class Program
    {

       static void Main()
        {
            A();
            B();
           @C();
        }

        static void A()
        {
            //
            // Create new string from char array.
            //
            char[] charArray = new char[3];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';

            string exampleString = new string(charArray);
            Console.WriteLine(exampleString);
            Console.WriteLine(exampleString == "abc");
        }

        static void B()
        {
            //
            // Create new string of repeated characters.
            //
            string exampleString = new string('a', 10);
            Console.WriteLine(exampleString);
            Console.WriteLine(exampleString == "aaaaaaaaaa");
        }

        static void @C()
        {
            //
            // Create new string from range of characters in array.
            //
            char[] charArray = new char[6];
            charArray[0] = 'a';
            charArray[1] = 'B';
            charArray[2] = 'c';
            charArray[3] = 'D';
            charArray[4] = 'e';
            charArray[5] = 'F';

            string exampleString = new string(charArray, 0, 3);
            Console.WriteLine(exampleString);
            Console.WriteLine(exampleString == "aBc");
        }
    }
}
