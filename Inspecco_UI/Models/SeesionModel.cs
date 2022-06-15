using System.Collections.Generic;

namespace Inspecco_UI.Models
{
    public class SeesionModel
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public UserRole Role { get; set; }
        public string Token { get; set; }
    }
    public class UserRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<RolePermission> Permission { get; set; }
    }
    public class RolePermission
    {
        public int Permissiond { get; set; }
        public string PermissionName { get; set; }
    }
}
