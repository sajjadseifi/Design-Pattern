using System;

namespace Design_Pattern.Bridg.MultiMailProvider
{
    //Concreate for IEmailSender To pass in RefindedEmail Abstraction 
    public class WebServiceEmailSender : IEmailSender
    {
        public void SendMail(string subject, string body)
        {
            Console.WriteLine("Sending Email using WebService:\n{0}\n{1}\n", subject, body);
        }
    }
    public class WCFEmailSender : IEmailSender
    {
        public void SendMail(string subject, string body)
        {
            Console.WriteLine("Sending Email using WCF:\n{0}\n{1}\n", subject, body);
        }
    }
    public class WebAPIEmailSender : IEmailSender

    {
        public void SendMail(string subject, string body)
        {
            Console.WriteLine("Sending Email using Web API:\n{0}\n{1}\n", subject, body);
        }

    }
}