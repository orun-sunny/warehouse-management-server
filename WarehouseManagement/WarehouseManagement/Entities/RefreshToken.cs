using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManagement.Domain.Entities
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; }
        public Guid UserId { get; set; }
        public DateTime Expires { get; set; }

        public User User { get; set; }

    }
}
