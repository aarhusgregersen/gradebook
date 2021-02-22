using System;
using System.Collections.Generic;
using GradeBook;

namespace Gradebook
{
  public class Book
  {
    // What is the behaviour of this class?
    // What is the methods needed to accomplish this?
    // What is the state that will be stored in instances of this class?

    // A constructor takes complete control over the initialization of the class
    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average =  0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;

      foreach(var grade in grades)
      {
          result.Low = Math.Min(grade, result.Low);
          result.High = Math.Max(grade, result.High);
          result.Average += grade;
      }
      result.Average /= grades.Count;

      return result;
    }
    private List<double> grades;
    public string Name;
  }

}