
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();



            processor.Process("photo.jpg");
        }


    }
}
