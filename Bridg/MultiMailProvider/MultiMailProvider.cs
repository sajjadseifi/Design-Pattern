using design_pattern;

namespace Design_Pattern.Bridg.MultiMailProvider
{
    public class MultiMailProvider : IRun
    {
        public void Run()
        {
            //all service for send email
            IEmailSender webService = new WebServiceEmailSender();
            IEmailSender wcf = new WCFEmailSender();
            IEmailSender webApi = new WebAPIEmailSender();

            //system email
            Email sys = new SystemEmail("Test Message", "Hi there, This is a Test Message from System");
            sys.SetEmailSender(webService);
            sys.Send();
            sys.SetEmailSender(wcf);
            sys.Send();
            sys.SetEmailSender(webApi);
            sys.Send();

            //user email
            Email user = new UserEmail("Test Message", "Hi there, This is a Test Message from User");
            user.SetEmailSender(webService);
            user.Send();
            user.SetEmailSender(wcf);
            user.Send();
            user.SetEmailSender(webApi);
            user.Send();

        }
    }
}