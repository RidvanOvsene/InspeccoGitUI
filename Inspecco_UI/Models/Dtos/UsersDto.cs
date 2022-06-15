
using System.ComponentModel.DataAnnotations;


namespace Inspecco_UI.Models.Dtos
{
    public class UserDto
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public string Contact { get; set; }
        public int? RolId { get; set; }
        public string RolName { get; set; }

    }
}
