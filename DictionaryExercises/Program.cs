using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newId;
            string input;


            Console.WriteLine("Enter your student information (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student ID: ");
                input = Console.ReadLine();

                if (!Equals(input, ""))
                {
                    newId = int.Parse(input);
                    Console.WriteLine("Name: ");
                    string inputName = Console.ReadLine();
                    string newName = inputName;
                    students.Add(newId, newName);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(input, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
            //double sum = 0.0;

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
                //sum += student.Value;
            }

           // double avg = sum / students.Count;
           // Console.WriteLine("Average grade: " + avg);
        }
    }
}
