using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        public static int EvenSum(List<int> args)
        {
            int sum = 0;
            foreach (int i in args)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static List<string> WordLength(List<string> words, int wordLength)
        {
            List<string> wordList = new List<string>();
            foreach (string word in words)
            {
                if (word.Length == wordLength)
                {
                    wordList.Add(word);
                }
            }
            return wordList;
        }
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int> { 2, 56, 45, 3, 9, 79, 90, 15, 32, 64 };
            int answer = EvenSum(numbers);
            Console.WriteLine(answer);

            List<string> lotsOfWords = new List<string> { "happy", "sad", "depressed", "love", "hate", "dog", "cat", "animal", "fence", "yard", "beach", "towel", "exercise", "quarantine" };

            Console.WriteLine("How many letters do you want in your word?");
            int wordAnswer = int.Parse(Console.ReadLine());
            List<string> answerList = new List<string>(WordLength(lotsOfWords, wordAnswer));

            answerList.ForEach(Console.WriteLine);
        }
    }
}
