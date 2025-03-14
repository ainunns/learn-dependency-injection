using System;

namespace Dependency_Injection
{
    public class CustomerService
    {
        private IMessageService _messageService;
        public CustomerService(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void NotifyCustomer()
        {
            _messageService.SendMessage("Tiket Anda telah kami terima.");
        }
    }
}
