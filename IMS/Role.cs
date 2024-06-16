using System.Text.Json.Serialization;

namespace IMS
{
    public record class Role
    {
        [property: JsonPropertyName("roleId")] string Id { get; set; }
        [property: JsonPropertyName("RoleName")] string RoleName { get; set; }
        [property: JsonPropertyName("Description")] string Description { get; set; }
    }
}
