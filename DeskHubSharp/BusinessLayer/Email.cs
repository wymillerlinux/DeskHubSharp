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
    class Email
    {
        // TODO: finish this class
        // TODO: debug feedback form

        private string _to = "wjmiller2016@gmail.com";
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
                try
                {
                    var err = new ErrorWindow();
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress($"{_name}", _from));
                    message.To.Add(new MailboxAddress("Wyatt J. Miller", _to));
                    message.Subject = $"{_name} requires your attention!";
                    message.Body = new TextPart("plain")
                    {
                        Text = _message
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                        // change credentials
                        client.Authenticate(_from, "password");
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
