namespace POS_IMS.Models
{
    public class Config
    {
        public string SuperAdminRoleId {get;} = Guid.NewGuid().ToString();
        public string AiRoleId { get;} = Guid.NewGuid().ToString();
        public string SuperAdminIdentityId {get;} = Guid.NewGuid().ToString();
        public string AiIdentityId { get;} = Guid.NewGuid().ToString();
        public string SuperAdminEmail { get;} = "kmlam1375@gmail.com";
        public string AiEmail { get; } = "lamkam1375@gmail.com";
    }
}
