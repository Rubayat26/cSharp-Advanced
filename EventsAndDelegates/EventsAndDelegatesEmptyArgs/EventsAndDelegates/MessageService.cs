// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace EventsAndDelegates
{
    public class MessageService  //subscriber
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message...");
        }
    }
}