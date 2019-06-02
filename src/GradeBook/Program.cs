using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradebook = new Book("The great book");
            gradebook.AddGrade(95.2);
            gradebook.AddGrade(91.2);
            gradebook.AddGrade(77.2);
            gradebook.ShowStatictics();

            var stats = gradebook.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.LowGrade}");
            Console.WriteLine($"The highest grade is {stats.HighGrade}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
