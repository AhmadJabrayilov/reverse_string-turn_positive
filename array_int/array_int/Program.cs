using System;

namespace array_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, -2, 10, -5, 15 };
            turn_positive(nums);
           

        }

        #region array_int
        static int[] turn_positive(int[] numbers)
        {
             for(int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    numbers[i] *= -1;
                }
            Console.Write(numbers[i]+" ");
            }
            return numbers;
        }


        #endregion
    }
}
