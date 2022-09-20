using System;
namespace qsn1
{
    public class Qsn
    {
        static void Main(string[] args)
        {
            string myString = "sudip";
            string rev="";
            char[] arr=new char[10];
            int j=myString.Length-1;
            for (int i = 0; i < myString.Length; i++)
            {
                arr[i]=myString[j];
                j--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                rev+= arr[i];
            }
            Console.WriteLine(rev);
        }
    }
}