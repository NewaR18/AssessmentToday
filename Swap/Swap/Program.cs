using System;
namespace swap
{
    public class swapping
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The value of a is " + a);
            Console.WriteLine("The value of b is "+ b);
        }
    }
}