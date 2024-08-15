namespace POS_IMS.Models
{
    public class Config
    {
        public string SuperAdminRoleId {get;} = Guid.NewGuid().ToString();
        public string AiRoleId { get;} = Guid.NewGuid().ToString();
        public string SuperAdminIdentityId {get;} = Guid.NewGuid().ToString();
        public string AiIdentityId { get;} = Guid.NewGuid().ToString();
        public string superAdminEmail { get; } = "Email of super admin";
        public string AiEmail { get; } = "Email for AI";
    }
}
