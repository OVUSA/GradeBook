using System;

namespace GradeBook{
    class Program{
        static void Main(string [] args){
            var book = new Book("teachers");
            book.addGrade(95.6);
            book.addGrade(10.6);
            book.addGrade(60.6);
            book.addGrade(90.0);
            book.addGrade(75.2);
            Console.Write($"Average grade is: {book.calculateAverage()}");

            Console.WriteLine($"The lowest value is : {book.GetStatistics().Low}");
            Console.WriteLine($"The highest value is : {book.GetStatistics().High}");
            Console.WriteLine($"The average value is : {book.GetStatistics().Average}");

    


        }
    }
}