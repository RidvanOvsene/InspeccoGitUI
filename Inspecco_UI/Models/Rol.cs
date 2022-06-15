using System.ComponentModel.DataAnnotations;

namespace Inspecco_UI.Models
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }
        public string RolName { get; set; }
    }
}
