using System;
using System.Collections.Generic;

namespace Generics
{
    public class GenericList<T>
    {
        private List<T> items;

        public GenericList()
        {
            items = new List<T>();
        }

        public void Add(T value)
        {
            items.Add(value);
        }

        public T this[int index]
        {
            get { return items[index]; }
        }
    }
}

//Here before we were creating a class for each type of list,
//but now we have created a generic class which can be used for any type of list.
//The type of T will be specified when we will create the instance of the class.