using System;
using System.Collections.Generic;

#nullable disable

namespace QLBTC.Models
{
    public partial class Permission
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public string PermissionRole { get; set; }
    }
}
