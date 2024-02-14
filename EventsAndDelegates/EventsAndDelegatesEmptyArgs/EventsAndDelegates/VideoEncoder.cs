// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace EventsAndDelegates
{
    public class VideoEncoder  // publisher 
    {
        //To give any class the ability to publish an event, we need to do the following:
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        // #1
        public delegate void VideoEncodedEventHandler(object source, EventArgs args); // the delegate would define the signature of the method
                                                                                      //that would be used in the subscribers
                                                                                      // and when the publisher publishes any event,
                                                                                      //it would call the method in the subscribers
       
        // #2
        public event VideoEncodedEventHandler VideoEncoded; // the tense is past implying that the event should be fired upon
                                                            //the completion of the video encoding
                                                            
       
        public void Encode(Video video)
        { 
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);


            // #3
            OnVideoEncoded();         // on plus the event name 
                                      // its job is to notify the subscribers
        }


        //the method should be protected, virtual and void (.Net event naming convention)
        protected virtual void OnVideoEncoded()   //On plus the event (naming convention)
        {
            if (VideoEncoded != null)       // we start by checking if there are
                                            //any subscribers
            {
                VideoEncoded(this, EventArgs.Empty);  // here this refers to the current class 
                                                      //which is VideoEncoder
                                                      // the VideoEncoded method follows the delegate signature
                                                      //we defined earlier 
                                                      // Whenever we dont want to send any data with the event,
                                                      //we use EventArgs.Empty
            }
        }
    }
} 

// here delegate would define how the method would be written in the subcribers 
