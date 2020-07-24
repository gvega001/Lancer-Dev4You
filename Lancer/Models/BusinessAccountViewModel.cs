using System;

namespace Lancer.Models
{
    public class BusinessAccountViewModel
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public bool ShowRequestId => Id!=null;
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
}
