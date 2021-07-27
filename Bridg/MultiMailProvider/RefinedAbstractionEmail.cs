namespace Design_Pattern.Bridg.MultiMailProvider
{
    /// The RefinedAbstraction class 
    public class SystemEmail : Email
    {
        public SystemEmail(string subject, string body) : base(subject, body)
        {

        }

        public override void Send()
        {
            string emailSubject = string.Format("Subject: {0} from System", Subject);

            string emailBody = string.Format("Email Body:\n{0}", Body);

            _emailSender.SendMail(emailSubject, emailBody);
        }
    }
    public class UserEmail : Email
    {
        public UserEmail(string subject, string body) : base(subject, body) { }

        public override void Send()
        {
            string emailSubject = string.Format("Subject:\n{0} from User", Subject);

            string emailBody = string.Format("Email Body:\n{0}", Body);

            _emailSender.SendMail(emailSubject, emailBody);
        }
    }
}