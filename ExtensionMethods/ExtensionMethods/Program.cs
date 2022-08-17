
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);  //althgough we are applying extension
                                                  //methods, in the instance of an object 
                                                  //essentialy they are static methods

            Console.WriteLine(shortenedPost);   

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            var max = numbers.Max();

            Console.WriteLine(max);

        }
    }
}


//post. will show the Shorten method as an extension when writing the code,
//the other methods will have purple cube shoiwing the methods of string class  





// in real word you will be using extension methods most of the time
//instead of creating them, and we should avoid creating them if we have other ways 