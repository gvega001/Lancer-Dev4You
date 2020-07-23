using System;

namespace Lancer.Models
{
    public class ContactViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    }
}
