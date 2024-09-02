namespace POS_IMS.Models
{
    public class Init
    {
        public string AutoAddressKey { get; } = "[Google API key]";// [Google API key]
        public string TrilioAccount { get; } = "[Twilio SID Account]"; // [Twilio SID Account]
        public string TrilioKey { get; } = "[Twilio token]"; // [Twilio token]
        public string TrilioNumber { get; } = "[SendGrid Number]"; // [SendGrid Number]
        public string SendGridKey { get; } = "[Sendgrid API key]"; // [Sendgrid API key]
        public string Email { get; } = "[Email]"; // [Email]
        public string System { get; } = "[System Name]"; // [System Name]
        public string ScanApi { get; } = "[Cloudmersive API key]";// [Cloudmersive API key]
    }
}
