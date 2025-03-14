// See https://aka.ms/new-console-template for more information

using Dependency_Injection;

var _emailService = new EmailService();
var _smsService = new SmsService();

CustomerService cs = new(_smsService);
cs.NotifyCustomer();