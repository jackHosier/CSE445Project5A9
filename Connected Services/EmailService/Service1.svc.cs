using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.Net.Mail;
using GSF.Net.Smtp;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace EmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string sendEmail(string email, string recipient)
        {

            //this is used to send the message 
            SmtpClient smtpClient = new SmtpClient()
            {
                Port = 25,
                Host = "172.22.0.20",
                DeliveryMethod = SmtpDeliveryMethod.Network,
                //Credentials = new NetworkCredential("username", "password"),
                UseDefaultCredentials = true,
                EnableSsl = false,
            };

            //the message to be sent 
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(email),
                Subject = "You're Hired",
                Body = "We have reviewed your resume and have decided to accept your application! Welcome to the team!",
                //IsBodyHtml = true,
            };


            //check if email is valid with this regular expression
            string emailRegEX = "^[^@\\s]+@[^@\\s]+\\.(com|net|org|gov)$";

            //if either email addr's are invalid, throw error message. 
            if (!(Regex.IsMatch(email, emailRegEX, RegexOptions.IgnoreCase)))
            {
                return string.Format("ERROR: sender email address invalid");
            } else if (!(Regex.IsMatch(recipient, emailRegEX, RegexOptions.IgnoreCase)))
            {
                return string.Format("ERROR: recipient email address invalid"); 
            }
            
            else { 
                //send the message 
                try
                {
                    mailMessage.To.Add(recipient);

                    smtpClient.Send(mailMessage);

                    mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;

                    return string.Format("message sent");

                }
                catch(SmtpException ex)
                {
                    mailMessage.DeliveryNotificationOptions=DeliveryNotificationOptions.OnFailure;  

                    return string.Format("message failed to send: "+ ex.ToString());
                }
            } 
            
        }

        
        
        
        
      
        
    }
}
