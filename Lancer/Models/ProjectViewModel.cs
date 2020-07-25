using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lancer.Models
{
    public class ProjectViewModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public bool ShowRequestId => Id == 0;
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
        public virtual ICollection<FreeLancerViewModel> FreeLancers { get; set; }
        public virtual ICollection<MilestonesViewModel> Milestones { get; set; }
    }
}
