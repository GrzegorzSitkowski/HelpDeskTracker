using HelpDeskTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskTracker.Domain.Entities
{
    public class Account : AuditableEntity
    {
        public string Name { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public ICollection<AccountUser> {get; set;} = new List<AccountUser>();
    }
}
