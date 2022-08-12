 using System;

namespace Generics
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable, new()  // here we have two
                                                           //constraints seperated by
                                                           //comma 
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }


        public T Max(T a, T b)    // here if T is not declared as IComparable
                                  //compiler would not understand and consider a and b
                                  //as object, and object cannot be compared 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }


        /*
        public void Whatever()
        {
            var k = 2;           // we can create variables inside a method
        }
        */




        public void DoSomething(T value)
        {
            var obj = new T();   // we have to initialize new() to get the default
                                 //constructor for T
        }

        
    }
}


// where T : IComparable

   //applying contraint to an interface


// where T : Product

   //appliying contraint to a class, here T is  a product or any of its children
   //
   

// where T : struct

   // where T would be a value type 
   

// where T : class

   // where T is a class, It has to be a refernce type 
   

// where T : new()
 
   // where T is an object where it has a default constuctor