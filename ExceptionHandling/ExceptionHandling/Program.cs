
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader streamReader = null;  //if we dont intialize it here, it will be out of scope in the finally block
           
            try
            {
                //streamReader = new StreamReader(@"c:\file.zip");
                //var content = streamReader.ReadToEnd();

                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");

                //DivideByZeroException
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //here ex is throwing the custom exception message or the hihger level exception message
                                               //if we want to see the inner exception message, we can use ex.InnerException.Message



                //Console.WriteLine("An unexpected error occurred.");
            }

            finally //finally block is used to clean up the resources
                    // it is used to cleanup the resources that are not managed by the CLR
                    //like file, database, network connections
            {
                //streamReader.Dispose();
            }
        }
    }
}


/*
We can eleminate the need of finally block by using using statement inside try block

using statement is a syntactic sugar for try-finally block
 
using (var streamReader = new StreamReader(@"c:\file.zip"))
{
        var content = streamReader.ReadToEnd();
 }

this will automatically call Dispose() method on the streamReader object
*/