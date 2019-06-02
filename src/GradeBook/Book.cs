using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public void AddGrade(double grade)
        {
            grades.Add(grade);       
        }

        public Book(string name)
        {
              grades  = new List<double>();
              this.name = name;
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.HighGrade = double.MinValue; 
            result.LowGrade = double.MaxValue;
           
            foreach (var grade in grades)
            {
                result.LowGrade = Math.Min(grade,result.LowGrade);
                result.HighGrade = Math.Max(grade,result.HighGrade);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
        public void ShowStatictics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var item in grades)
            {
                lowGrade = Math.Min(item,lowGrade);
                highGrade = Math.Max(item,highGrade);
                result += item;
            }
            result /= grades.Count;

            
        }
    }
}