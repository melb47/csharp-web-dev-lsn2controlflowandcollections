using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] practiceArray = {1, 1, 2, 3, 5, 8};
            foreach (int i in practiceArray)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
