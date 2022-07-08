using System;
using System.Collections.Generic;
namespace GradeBook{
    class Program{
        static void Main(string [] args){
            var book = new Book("teachers", 2000);
            book.addGrade(95.6);
            book.addGrade(10.6);
            book.addGrade(60.6);
            book.addGrade(90.0);
            book.addGrade(75.2);
            Console.Write($"Average grade is: {book.calculateAverage()}");

    


        }
    }
}