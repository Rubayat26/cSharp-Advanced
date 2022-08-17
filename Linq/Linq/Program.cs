using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Func<int, int, int> add = (a, b) => a + b;
            //Console.WriteLine(add(2, 3));



            var books = new BookRepository().GetBooks();

            var cheapBooks = books.Where(b => b.Price<=10)
                                    .OrderBy(b=>b.Title);

            Console.WriteLine("Chapebooks ordered by title : ");
            
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Price);
            }




            var titleList = books.Where(b => b.Price <= 10)   //Due to select we get a list 
                                    .OrderBy(b => b.Title)    //of strings 
                                    .Select(b=>b.Title);

            Console.WriteLine("here are the titles : ");
            foreach (var book in titleList)
            {
                Console.WriteLine( book);
            }

            

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine("maximum price of the books : "+ maxPrice);



            var book1 = books.SingleOrDefault(b => b.Title== "ASP.NET MVC") ;
            Console.WriteLine(book1.Price);



            var bookCollection = books.Skip(2).Take(3);
            Console.WriteLine("no of books in new collection : "+bookCollection.Count());

        }

        

    
    }
}
