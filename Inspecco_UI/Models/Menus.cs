using System.ComponentModel.DataAnnotations;
namespace Inspecco_UI.Models
{
    public class Menus
    {
        [Key]
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }

    }
}
