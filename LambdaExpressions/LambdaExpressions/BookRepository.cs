using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()  //a list of type Book 
        {
            return new List<Book>  //here we are initilizing the list 
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 17}
            };
        }
    }
}

// So we will use BookRepository.GetBooks() to initialize and populate a booklist here