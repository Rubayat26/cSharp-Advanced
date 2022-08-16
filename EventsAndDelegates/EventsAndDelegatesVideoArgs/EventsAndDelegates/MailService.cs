// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoArgs args)
        {
            Console.WriteLine("MailService: Sending an email..." + args.Video.Title); //here
                                                                             //we are getting
                                                                             //the title from
                                                                    //the video, that was passed on to
                                                                    //the OnVideoEncoded Method 
        }
    }
}



//this is a way to pass the data about the events that happend