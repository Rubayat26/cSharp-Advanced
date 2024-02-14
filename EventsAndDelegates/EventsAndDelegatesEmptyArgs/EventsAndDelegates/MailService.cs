// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace EventsAndDelegates
{
    public class MailService    //subscriber
    {
        public void OnVideoEncoded(object source, EventArgs args)  //The method here is the event handler
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}