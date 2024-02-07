using System;

namespace Generics
{
    public class List
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}

//Here as we are not initilizing a list so
//it will give a null error if does not used .