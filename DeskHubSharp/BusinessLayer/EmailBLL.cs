using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace DeskHubSharp
{
    class EmailBLL
    {
        private string _name;
        private string _message;
        private string _emailText;

        public EmailBLL(string name, string message, string emailText)
        {
            _name = name;
            _message = message;
            _emailText = emailText;
        }

        /// <summary>
        /// Checks to see if Email is valid to send
        /// </summary>
        /// <returns></returns>
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
            if (_emailText == "")
            {
                ErrorWindow err = new ErrorWindow();
                err.lbl_title.Content = "Oops.";
                err.txtblk_error.Text = "Please fill in your email.";
                err.ShowDialog();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Creates message for user to send
        /// </summary>
        public void CreateMessage()
        {
            if (IsValidated())
            {
                try
                {
                    var email = new Email();
                    var err = new ErrorWindow();
                    var message = new MimeMessage();

                    message.From.Add(new MailboxAddress($"{_name}", email.FromEmail));
                    message.To.Add(new MailboxAddress("Wyatt J. Miller", email.ToEmail));
                    message.Subject = $"{_name} requires your attention!";
                    message.Body = new TextPart("plain")
                    {
                        Text = _message + " " + _emailText
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                        client.Authenticate(email.FromEmail, email.Password);
                        client.Send(message);
                        client.Disconnect(true);
                    }

                    err.lbl_title.Content = "Thank you!";
                    err.txtblk_error.Text = "Thank you for sending your email! We have it and will reply shortly.";
                    err.ShowDialog();
                }
                catch (Exception e)
                {
                    ErrorWindow err = new ErrorWindow();
                    Console.WriteLine("Exception caught in sending message: {0}",
                            e.ToString());
                    err.ShowDialog();
                }
            }
        }

    }
}
