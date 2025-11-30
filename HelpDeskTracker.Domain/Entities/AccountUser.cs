using HelpDeskTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskTracker.Domain.Entities
{
    public class AccountUser : AuditableEntity
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
