using System;
using System.Collections.Generic;

namespace ICETASK2_PROG7312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 1 - DICTIONARY");
            Dictionary();

            Console.WriteLine("\nTASK 3 - HashSets");
            HashSet();

            Console.WriteLine("\nTASK 4 - SetOperations");
            SetOperations();



        }

        static void Dictionary()
        {
            //creating the dictionary
            Dictionary<int, string> students = new Dictionary<int, string>();

            //adding the students to this dictionary object
            students.Add(1, "Nia Diale");
            students.Add(2, "Josh Blue");
            students.Add(3, "Leon Brown");
            students.Add(4, "Briana Lopez");
            students.Add(5, "Eve Flora");

            //displaying the list of students
            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Full Name: {student.Value}");
            }
        }


        static void HashSet()
        {
            //creating a hashSet
            HashSet<string> courseCodes = new HashSet<string>();

            //adding the course code 
            courseCodes.Add("CompSci5121");
            courseCodes.Add("Engineering5112");
            courseCodes.Add("Maths7315");
            courseCodes.Add("SCNCE7123");

            //displayng the course codes
            Console.WriteLine("Course Codes:");
            foreach (string course in courseCodes)
            {
                Console.WriteLine(course);
            }

           
        }

        static void SetOperations()
        {
            //Set for Math class
            HashSet<string> mathClass = new HashSet<string>
            {
            "Nia", "Josh", "Leon", "Briana", "Eve"
             };

            //Set for Science class
            HashSet<string> scienceClass = new HashSet<string>
            {
            "Josh", "Briana", "Rihanna", "Eve", "Drake"
            };

            //displaying the Math class students
            Console.WriteLine("Math Class Students:");
            foreach (string student in mathClass)
                Console.WriteLine($" {student}");

            //displaying the Science class students
            Console.WriteLine("\nScience Class Students:");
            foreach (string student in scienceClass)
                Console.WriteLine($" {student}");

            // Intersection
            HashSet<string> bothClasses = new HashSet<string>(mathClass);
            bothClasses.IntersectWith(scienceClass);

            Console.WriteLine("\nIntersection");
            foreach (string student in bothClasses)
                Console.WriteLine($"{student}");

            // Difference
            HashSet<string> onlyMath = new HashSet<string>(mathClass);
            onlyMath.ExceptWith(scienceClass);

            Console.WriteLine("\nDifference");
            foreach (string student in onlyMath)
                Console.WriteLine($"{student}");

            // Union
            HashSet<string> allStudents = new HashSet<string>(mathClass);
            allStudents.UnionWith(scienceClass);

            Console.WriteLine("\nUnion");
            foreach (string student in allStudents)
                Console.WriteLine($"{student}");
        }
    
    }
}
