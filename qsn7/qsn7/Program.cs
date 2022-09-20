using System;
namespace count
{
    public class COunting
    {
        public string str = "";
        public bool doublex(string s)
        {
            if (s.Contains("xx")){
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            COunting si=new COunting();
            bool sa = si.doublex("xxxxxx");
            Console.WriteLine(sa);
        }
    }
}