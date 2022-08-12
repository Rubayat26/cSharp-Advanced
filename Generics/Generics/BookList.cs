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

    public class GenericDictionary<TKey, TValue>    //Creating a generic Dictionary 
    {
        public void Add(TKey key, TValue value)     // the type of TKey and TValue will be 
                                                   //specified when we will create the 
                                                   // instance of GenericDictionary 
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}