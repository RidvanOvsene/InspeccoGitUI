using System;

namespace Inspecco_UI.Models.Dtos
{
    public class LoginDto
    {
        
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public int? RolId { get; set; }
        public string Token { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
