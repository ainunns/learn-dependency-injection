using System;

namespace Dependency_Injection
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            // build email message
            // contact email server
            // send message

            Console.WriteLine($"Message sent via email: {message}");
        }
    }
}