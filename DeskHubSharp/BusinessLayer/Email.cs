using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DeskHubSharp
{
    class Email
    {
        // TODO: finish this class

        private string _to = "wyatt@wyattjmiller.com";
        private string _from = "wjmiller2016@gmail.com";
        private string _name;
        private string _message;

        public Email(TextBox name, TextBox emailBody)
        {
            _name = name.Text;
            _message = emailBody.Text;
        }

        private bool IsValidated()
        { 
            if (_name == "")
            {
                ErrorWindow err = new ErrorWindow();
                err.lbl_title.Content = "Oops.";
                err.txtblk_error.Text = "Please fill in your name.";
                err.ShowDialog();
                return false;
            }
            if (_message == "")
            {
                ErrorWindow err = new ErrorWindow();
                err.lbl_title.Content = "Oops.";
                err.txtblk_error.Text = "Please fill in your message to the developer.";
                err.ShowDialog();
                return false;
            }

            return true;
        }

        public void CreateMessage()
        {
            if (IsValidated())
            {
                // TODO: get a test email to send
                string subject = $"DeskHubSharp: {_name} requires your attention.";
                string body = $"{_message}";
                MailMessage message = new MailMessage(_from, _to, subject, body);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                //Console.WriteLine("Changing time out from {0} to 100.", client.Timeout);
                client.Timeout = 1000;
                // Credentials are necessary if the server requires the client 
                // to authenticate before it will send e-mail on the client's behalf.
                client.Credentials = CredentialCache.DefaultNetworkCredentials;

                try
                {
                    client.Send(message);
                }
                catch (Exception e)
                {
                    ErrorWindow err = new ErrorWindow();
                    Console.WriteLine("Exception caught in CreateTimeoutTestMessage(): {0}",
                            e.ToString());
                    err.ShowDialog();
                }
            }
        }

    }
}
