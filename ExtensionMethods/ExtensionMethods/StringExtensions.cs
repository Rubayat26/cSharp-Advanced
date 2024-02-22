using System;
using System.Linq;

namespace System  //namespace System is used so that the extension method remains available
                  //to all parts of the program as extension method does not work if
                  //the class that created them is out of scope 
{
    public static class StringExtensions //this has to be declared a static class for
                                         //adding extensions 
    {
        public static string Shorten(this String str, int numberOfWords) //public static string
                                                                         //is the syntax 
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

           

            return (string.Join(" ", words.Take(numberOfWords)) + "..."); //
        }
    }
}


//The extension method cannot work if the class created them is out of scope
//If the class is out of scope , we have to use the using System namespace to use the extension method


// string array is an array which does not have Take method. But later microsoft introduced
//Take method which is an extension method that can be implemented to any class that 
//implements an IEnumerable Interface, in this case the str array. 