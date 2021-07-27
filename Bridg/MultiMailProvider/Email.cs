namespace Design_Pattern.Bridg.MultiMailProvider
{
    /// The Abstraction class 
    public abstract class Email
    {
        public Email(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
        protected IEmailSender _emailSender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void SetEmailSender(IEmailSender sender) => _emailSender = sender;
        //Bussiness method
        public abstract void Send();
    }
}