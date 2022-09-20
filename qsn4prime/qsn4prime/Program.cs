using System;
namespace qsn4
{
    public class Prime
    {
        static void Main(string[] args)
        {
            int n = 79;
            int j=0;
            for(int i = 2; i < n / 2; i++)
            {
                if(n%i == 0)
                {
                    j = 1;
                }
            }
            if(j == 0)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}