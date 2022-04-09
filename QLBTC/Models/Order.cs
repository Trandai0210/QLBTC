using System;
using System.Collections.Generic;

#nullable disable

namespace QLBTC.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime? Dos { get; set; }
        public DateTime? Dof { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
