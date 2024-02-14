// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace EventsAndDelegates
{
    public class VideoArgs : EventArgs    //Here we want to send a refernce to the video
                                          //which video was encoded 
    {
        public Video Video { get; set; }
    }


    public class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        // #1
        public delegate void VideoEncodedEventHandler(object source, VideoArgs args); //instead of eventArgs
        //we are sending VideoArgs




        // #2
        public event VideoEncodedEventHandler VideoEncoded;
        // public event EventHandler VideoEncoding; //when the video is encoding before the event is raised


        // EventHandler from .net library comes with two versions
        // EventHandler             // if the EventHander is not sending any data
        // EventHandler<TEventArgs> // if the EventHandler is sending any data as well 

        // step 1 and 2 together 
        //public event EventHandler<VideoArgs> VideoEncoded;
         

        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            

            // #3
            OnVideoEncoded(video);         // passing the video object created 
        }


        
        protected virtual void OnVideoEncoded(Video video)   //here passing video so that we can
                                                             //use that for referncing
        {
            if (VideoEncoded != null)       // we start by checking if there are
                                            //any subscribers
            {
                VideoEncoded(this, new VideoArgs() { Video = video}); // here this refers to the current class 
                                                                     //which is VideoEncoder
                                                                    
                                                                    // For getting the video we had to
                                                                    //pass Video on OnVideoEncoded method   
                                                                     
            }
        }
    }
} 

// here delegate would define how the method would be written in the subcribers 




//Now we are passing value data to the VideoEncoded Event