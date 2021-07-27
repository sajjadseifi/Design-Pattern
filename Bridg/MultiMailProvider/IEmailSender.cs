namespace Design_Pattern.Bridg.MultiMailProvider
{
    //Bridg or Implimentor
    public interface IEmailSender
    {
        void SendMail(string subject, string body);
    }
}