using System;
using System.Collections.Generic;


//is folder name
namespace GradeBook{

    public class Book{
    string name;
    decimal year;
    List<double> grades = new List<double>();
       public Book(string name){
        this.name = name;
        this.year = year;

       }

       public void addGrade(double grade){
        grades.Add(grade);
       }

       public List<double> viewAllGrades(){
        return grades;
       }

       public Statistics GetStatistics(){

        var statistic_value = new Statistics();
        statistic_value.Average = 0.0;
        statistic_value.Low = grades[0];
        statistic_value.High= grades[0];

        foreach(double grade in grades){
            statistic_value.Average+=grade;
            statistic_value.Low = Math.Min(statistic_value.Low,grade);
            statistic_value.High = Math.Max(statistic_value.High,grade);
        }
        statistic_value.Average/=grades.Count;

        return statistic_value;
       }
    }

}