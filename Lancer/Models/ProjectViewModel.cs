using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lancer.Models
{
    public class ProjectViewModel
    {
        [Required]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        [Required]
        [DataType(DataType.Currency)]
        public Decimal Amount { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DaysToDelivery { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Descriptions { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Summary { get; set; }
        public FreeLancerViewModel FreeLancer { get; set; }
        public MilestonesViewModel Milestones { get; set; }
       
    }
}
