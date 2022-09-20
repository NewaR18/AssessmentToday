using System;
namespace qsn8
{
    public class qsn8try
    {
        public bool love6(int a,int b)
        {
            if(a==6 || b == 6)
            {
                return true;
            }
            else if(Math.Abs(a+b)==6 || Math.Abs(a - b) == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            qsn8try si=new qsn8try();
            bool a=si.love6(1, 5);
            Console.WriteLine(a);
        }
    }
}