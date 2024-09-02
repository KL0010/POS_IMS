using Microsoft.AspNetCore.Mvc.RazorPages;

namespace POS_IMS.Models
{
    public class Repository : PageModel
    {
        public Repository() { }

        public bool IsImage(IFormFile file)
        {
            return file.ContentType.StartsWith("image/");
        }

        public bool IsAllowedExtension(string fileName)
        {
            string[] allowedExtensions = { ".jpeg", ".jpg", ".png", ".gif" };
            string fileExtension = System.IO.Path.GetExtension(fileName).ToLowerInvariant();
            return allowedExtensions.Contains(fileExtension);
        }
    }
}
