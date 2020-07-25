using System;
using Microsoft.AspNetCore.Mvc;
namespace Lancer.Models
{
    public class LeadContactViewModel
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public bool ShowRequestId => Id!=null;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool Notifications { get; set; }
        public BusinessAccountViewModel BusinessAccount { get; set; }

    }
}
