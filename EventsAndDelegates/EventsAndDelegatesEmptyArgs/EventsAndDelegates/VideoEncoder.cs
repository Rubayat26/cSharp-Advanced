// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        // #1
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
       
        // #2
        public event VideoEncodedEventHandler VideoEncoded;
       
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);


            // #3
            OnVideoEncoded();         // on plus the event name 
        }


        
        protected virtual void OnVideoEncoded()   //On plus the event naming convention
        {
            if (VideoEncoded != null)       // we start by checking if there are
                                            //any subscribers
            {
                VideoEncoded(this, EventArgs.Empty);  // here this refers to the current class 
                                                      //which is VideoEncoder              
            }
        }
    }
} 

// here delegate would define how the method would be written in the subcribers 
