using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index] //book.[0] will give the 0 index value of the BookList
        {
            get { throw new NotImplementedException(); }
        }
    }
}


// ** Whenever create a list we have to initilize it first 
// and after that we can add the items to it. Otherwise it
// will give an error due to empty list