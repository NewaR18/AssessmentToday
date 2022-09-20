using System;
namespace count
{
    public class COunting
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 22, 64, 3, 49, 59 };
            int lar = 0;
            int small=arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > lar)
                {
                    lar = arr[i];
                }
                if(arr[i] < small)
                {
                    small = arr[i];
                }
            }
            Console.WriteLine(lar);
            Console.WriteLine(small);
        }
    }
}