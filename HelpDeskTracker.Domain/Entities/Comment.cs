using HelpDeskTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskTracker.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public string Content { get; set; }
        public DateTimeOffset CommentDate { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
