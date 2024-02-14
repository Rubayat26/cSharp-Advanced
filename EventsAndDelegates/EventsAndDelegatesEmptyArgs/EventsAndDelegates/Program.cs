// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber



            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;  // we are doing the subscribtion here 
                                                                      // Look we dont have the parenthesis 
                                                                      //we are not calling the method here
                                                                      //we are just passing the reference of the method


                                                     //VideoEncoded event behind the scenes is a list of pointers to methods
            
            
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // we are adding another subscriber

           //Again we need to do the subscription before we call the method, otherwise the event would be null
            
            videoEncoder.Encode(video);
        }
    }
}