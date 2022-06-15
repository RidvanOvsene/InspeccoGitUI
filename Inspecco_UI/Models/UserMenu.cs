using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspecco_UI.Models
{
    public class UserMenu
    {
        [Key]
        public int UserMenuId { get; set; } 
        public int? MenuId { get; set; }
        public int? UserId { get; set; }
        public string Contact { get; set; }
        public int? CompanyId { get; set; }

    }
}
