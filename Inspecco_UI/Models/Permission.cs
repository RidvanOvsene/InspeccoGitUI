﻿using System.ComponentModel.DataAnnotations;

namespace Inspecco_UI.Models
{
    public class Permission
    {
        [Key]
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
    }
}
