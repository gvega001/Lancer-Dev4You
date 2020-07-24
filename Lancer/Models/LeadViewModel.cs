using System;
using System.Security.Policy;

namespace Lancer.Models
{
    public class LeadViewModel
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Date {get; set;}
    }
}
