using System;

namespace Dependency_Injection
{
    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            // build sms message
            // contact sms gateway
            // send message
            Console.WriteLine($"Message sent via SMS: {message}");
        }
    }
}