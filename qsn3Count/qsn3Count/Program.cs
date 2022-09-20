using System;
namespace count
{
    public class COunting
    {
        static void Main(string[] args)
        {
            int j=0;
            string word = "there are 4 sentences";
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i].Contains(" "))
                {
                    j++;
                }
            }
        }
    }
}