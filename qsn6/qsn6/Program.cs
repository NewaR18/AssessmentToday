using System;
namespace summ
{
    public class summing
    {
        static void Main(string[] args)
        {
            int n = 4237;
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}