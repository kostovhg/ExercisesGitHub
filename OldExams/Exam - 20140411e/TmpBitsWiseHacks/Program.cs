using System;

namespace TmpBitsWiseHacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose operation: ");
            Console.WriteLine("1. Check if the integer is even or odd" );
            Console.WriteLine("2. Test if the n-th bit is set");

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1: EvenOrOdd(); break;
                case 2: NthBitSet(); break;
                case 3: SetTheNthBit(); break;
                default:
                    break;
            }
        }

        static void EvenOrOdd()
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("x = {0} -> ", x);
            Console.WriteLine(Convert.ToString(x, 2).PadLeft(8,'0'));
            Console.Write("1 = {0} -> ", 1);
            Console.WriteLine(Convert.ToString(1, 2).PadLeft(8, '0'));
            Console.WriteLine("        ---------");
            Console.Write("x & 1 -> ");
            Console.WriteLine(Convert.ToString((x & 1), 2).PadLeft(8, '0'));

            if ((x & 1) == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        static void NthBitSet()
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter possition n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x  =  {0}  -> ", x);
            Console.WriteLine(Convert.ToString(x, 2).PadLeft(8, '0'));
            Console.Write("(1 << n) -> ", (1 << n));
            Console.WriteLine(Convert.ToString((1 << n), 2).PadLeft(8, '0'));
            Console.WriteLine("           ---------");
            Console.Write("x&(1<<n) -> ");
            Console.WriteLine(Convert.ToString(x & (1 << n), 2).PadLeft(8, '0'));

            if ((x & (1 << n)) > 0)
            {
                Console.WriteLine($"Bit {n} is set");
            }
            else
            {
                Console.WriteLine($"Bit {n} is not set");
            }

        }

        static void SetTheNthBit()
        {

        }
    }
}
