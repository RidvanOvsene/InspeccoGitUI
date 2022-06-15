using System.ComponentModel.DataAnnotations;

namespace Inspecco_UI.Models.Dtos
{
    public class PersonDto
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string Contact { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
