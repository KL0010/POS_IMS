using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace POS_IMS.Models
{
    public class EmailHelper
    {
        public async Task <bool>  SendEmail(string email, string confirmLink)
        {
            var apiKey = "[Your SendGrid API key]"; // change apiKey to your SendGrid api key
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("[email address]", "Example User"); // change email address linked to account
            var subject = "Confirm Email";
            var to = new EmailAddress(email, "Email Validation");
            var plainTextContent = "Message from POS_IMS";
            var htmlContent = "<strong>Please confirm email</strong>: " + confirmLink;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                return true;
            }
            return false;
        }
    }
}
