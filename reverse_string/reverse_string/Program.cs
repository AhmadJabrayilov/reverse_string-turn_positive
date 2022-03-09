using System;

namespace reverse_string
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("enter word: ");
            string new_word =  Console.ReadLine();
            Console.Write("reverse word: ");
            rvs_string(new_word);
        }
        #region rvs_string
        static string rvs_string(string word )
        {
            
            
            for (int i = word.Length-1; i>=0; i--)
            {
                Console.Write(word[i]);
            }
            return word;

        }
        #endregion
    }
}
