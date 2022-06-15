using System.ComponentModel.DataAnnotations;

namespace Inspecco_UI.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
    }
}
