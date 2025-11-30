using HelpDeskTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskTracker.Domain.Entities
{
    public class Ticket : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int EngineerId { get; set; }
        public Engineer Engineer { get; set; }
    }
}
