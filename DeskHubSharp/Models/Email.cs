namespace DeskHubSharp
{
    public class Email
    {
        private string _toEmail = "wjmiller2016@gmail.com";
        private string _fromEmail = "wjmiller2016@gmail.com";
        private string _passwordEmail = "IhaveanAMDRX580";

        public string Password
        {
            get { return _passwordEmail; }
            set { _passwordEmail = value; }
        }

        public string FromEmail
        {
            get { return _fromEmail; }
            set { _fromEmail = value; }
        }

        public string ToEmail
        {
            get { return _toEmail; }
            set { _toEmail = value; }
        }

        public Email()
        {

        }
        
    }
}