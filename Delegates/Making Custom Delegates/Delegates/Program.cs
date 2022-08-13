
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler1 = filters.ApplyBrightness; //created filterHandler1
                                                                                        //of type
                                                                                        //PhotoFilterHandler 
            
            
            
            filterHandler1 += filters.ApplyContrast; // pointing to PhotoFilters ApplyContrast method 
            filterHandler1 += RedEyeRemove;

            processor.Process("photo.jpg", filterHandler1);
        }


        public static void RedEyeRemove(Photo photo) 
                                                 
        {
            Console.WriteLine("removed red eye");
        }
    }
}

// while writing new method just to keep in mind
//it has to match the format of
//"public delegate void PhotoFilterHandler(Photo photo);"








