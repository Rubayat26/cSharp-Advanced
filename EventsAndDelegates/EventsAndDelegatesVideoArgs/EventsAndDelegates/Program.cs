﻿


namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 2" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber



            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;  //we are doing the subscribtion here 
            
            
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //we are adding another subscriber

           
            
            videoEncoder.Encode(video);
        }
    }
}