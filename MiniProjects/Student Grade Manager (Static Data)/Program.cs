using System;
using System.Linq;

namespace StudentGradeManager
{
    class Program
    {
        // Arrays of student data - made static to be accessible by static methods
        static string[] names = { "Ali", "Sara", "Omar" };
        static float[] grades = { 90, 55, 40 };

        // Minimum passing grade
        const float PASS_GRADE = 50;

        static void Main(string[] args)
        {
            // Display all students
            DisplayStudents();

            // Calculate and display average
            CalculateAverage(grades);
        }

        // Function to calculate average of grades
        static void CalculateAverage(params float[] grades)
        {
            Console.WriteLine("Average: " + grades.Average()); // Fixed: added ()
        }

        // Function to display students
        static void DisplayStudents()
        {
            Console.WriteLine("Student Grades:");
            Console.WriteLine("================");

            // Loop through students - Fixed: changed > to <
            for (int x = 0; x < names.Length; x++)
            {
                Console.WriteLine($"Name: {names[x]}, Grade: {grades[x]}");
            }
            Console.WriteLine(); // Empty line for better formatting
        }
    }
}

