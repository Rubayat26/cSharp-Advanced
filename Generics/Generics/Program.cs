 using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List();
//            numbers.Add(10);  //this line will throw an excpetion error
                              //as we have not initilized the list
//            numbers.Add(20);
//            Console.WriteLine(numbers[0]);

            var number = new Nullable<int>();
           
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var number2 = new Nullable<int>(5);
            Console.WriteLine("Has Value ?" + number2.HasValue);    
            Console.WriteLine("Value: " + number2.GetValueOrDefault());

            var utilitiy = new Utilities<float>();
            Console.WriteLine(utilitiy.Max(2, 3));
            Console.WriteLine(utilitiy.Max(2.3f, 3.4f));

            var utilitiy2 = new Utilities<int>();
            utilitiy2.DoSomething(5);

            var utilitiy3 = new Utilities<double>();
            utilitiy3.DoSomething(5.5);


            var book1 = new Book { Isbn = "1111", Title = "C# Advanced" };
            var books = new GenericList<Book>();
            books.Add(book1);
           // books.Add(new Book());
            var firstBookInGenericList = books[0];
            Console.WriteLine(firstBookInGenericList.Title);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());



            var x = Sample.Max(6, 5);

            var y = Sample.Max<int>(9,8);


        }
    }
}
