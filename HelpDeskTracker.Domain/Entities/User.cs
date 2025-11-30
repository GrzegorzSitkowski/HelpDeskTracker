using HelpDeskTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskTracker.Domain.Entities
{
    public class User : AuditableEntity
    {
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public DateTimeOffset RegisterDate { get; set; }
        public ICollection<AccountUser> AccountUsers { get; set; } = new List<AccountUser>();
    }
}
