using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeOef
{
    class Oef3
    {

        //public class InvitationService
        //{
        //    public void SendInvite(string email, string firstName, string lastName)
        //    {
        //        if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
        //        {
        //            throw new Exception("Name is not valid!");
        //        }
        //        if (!email.Contains("@") || !email.Contains("."))
        //        {
        //            throw new Exception("Email is not valid!!");
        //        }

        //        SmtpClient client = new SmtpClient();
        //        MailMessage mm = new MailMessage("mysite@nowhere.com", email);

        //        client.Send(new MailMessage("mysite@nowhere.com", email)
        //        {
        //            Subject = "Please join me at my party!"
        //        });
        //    }

        //} methode heeft twee verantwoordelijkheden
        // Controle op Geldigheid en mailservice



        public class InvitationService
        {
            public void SendInvite(string email, string firstName, string lastName)
            {
                if (IsMailAdressValid(email, firstName, lastName))
                {
                    SmtpClient client = new SmtpClient();
                    MailMessage mm = new MailMessage("mysite@nowhere.com", email);

                    client.Send(new MailMessage("mysite@nowhere.com", email)
                    {
                        Subject = "Please join me at my party!"
                    });
                }
            }


            public bool IsMailAdressValid(string email, string firstName, string lastName)
            {
                if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
                {
                    throw new Exception("Name is not valid!");
                }
                if (!email.Contains("@") || !email.Contains("."))
                {
                    throw new Exception("Email is not valid!!");
                }
                return true;
            }
        }
    }
}
