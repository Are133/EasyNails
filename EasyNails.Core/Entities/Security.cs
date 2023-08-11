using EasyNails.Core.Enumerations;

namespace EasyNails.Core.Entities
{
    public class Security : EntityBase
    {
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public RoleType Role { get; set; }
    }
}
