using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace POS_IMS.Models
{
    public class EmailHelper
    {
        public async Task <bool>  SendEmail(string email, string callbackUrl, string subject, string text)
        {
            var apiKey = "[Your SendGrid API key]";  // change apiKey to your SendGrid api key
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("[email address]", "Example User"); // change email address linked to account
            var to = new EmailAddress(email, subject);
            var htmlContent = "<strong>" + text + "</strong>: " + callbackUrl;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, htmlContent);
            var response = await client.SendEmailAsync(msg);

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                return true;
            }
            return false;
        }
    }
}
