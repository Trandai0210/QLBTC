using System;
using System.Collections.Generic;

#nullable disable

namespace QLBTC.Models
{
    public partial class UserPermission
    {
        public int? UserId { get; set; }
        public int? PermissionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual User User { get; set; }
    }
}
