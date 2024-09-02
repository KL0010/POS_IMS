using POS.Models;
using System.Web;

namespace POS_IMS.Models
{
    public class Sanitizer
    {
        public InitialContact SanitizeContact(InitialContact contact)
        {
            contact.FirstName = HttpUtility.HtmlEncode(contact.FirstName);
            contact.LastName = HttpUtility.HtmlEncode(contact.LastName);
            contact.Address = HttpUtility.HtmlEncode(contact.Address);
            contact.Borough = HttpUtility.HtmlEncode(contact.Borough);
            contact.Postcode = HttpUtility.HtmlEncode(contact.Postcode);
            contact.State = HttpUtility.HtmlEncode(contact.State);
            contact.Country = HttpUtility.HtmlEncode(contact.Country);
            contact.Brands = HttpUtility.HtmlEncode(contact.Brands);
            contact.PhoneNumber = HttpUtility.HtmlEncode(contact.PhoneNumber);
            contact.LegalBusinessName = HttpUtility.HtmlEncode(contact.LegalBusinessName);
            contact.BusinessId = HttpUtility.HtmlEncode(contact.BusinessId);
            contact.Message = HttpUtility.HtmlEncode(contact.Message);

            return contact;
        }

        public Category SanitizeCategoryInputs(Category category)
        {
            category.CategoryName = HttpUtility.HtmlEncode(category.CategoryName);
            category.CategoryDescription = HttpUtility.HtmlEncode(category.CategoryDescription);;

            return category;
        }
    }
}
