using System;
//is folder name
namespace GradeBook{

    public class Book{
    string name;
    decimal year;
    List<double> grades = new List<double>();
       public Book(string name,decimal year){
        this.name = name;
        this.year = year;

       }

       public void addGrade(double grade){
        grades.Add(grade);
       }

       public List<double> viewAllGrades(){
        return grades;
       }

       public double calculateAverage(){
        var result = 0.0;

        foreach(var number in grades){
            result+=number;
        }
        return result;
       }
    }

}