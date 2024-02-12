
using System;

namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)  // here the string[] args is the command line arguments
                                         //and is not used in this program
        {

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor; //lambda expression

            Console.WriteLine(multiplier(10));


            var books = new BookRepository().GetBooks(); // here in hte same line we are initializing
                                                         //and populating the list

            var cheapBooks = books.FindAll(b => b.Price < 10); //lambda expressions
                                                                     //is used to make IsCheaperThan10Dollars
                                                                     //more easy and readable

            
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }




            var cheaperBooks = books.FindAll(IsCheaperThan7Dollars); //normal
                                                                     //expression

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine(book.Title);
            }

        }



        static bool IsCheaperThan7Dollars(Book book) //is a predicate function
        {
            return book.Price < 7;
        }

    }
}


//Lambda  expressions are used for making the code shorter and making it easy to read