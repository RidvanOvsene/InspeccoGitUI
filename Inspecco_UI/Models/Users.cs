using System.ComponentModel.DataAnnotations;

namespace Inspecco_UI.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? RolId { get; set; }
        public string NameSurname { get; set; }
        public string Contact { get; set; }
        public int? CompanyId { get; set; }
    }
}
