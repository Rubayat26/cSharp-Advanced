
using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10); //lambda expressions

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


        
        static bool IsCheaperThan7Dollars(Book book)
        {
            return book.Price < 7;
        }
    }
}


//Lambda  expressions are used for making the code shorter and making it easy to read