using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Lancer.Models
{
    public class MilestonesViewModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        
        [Required]
        [DataType(DataType.Currency)]
        public Decimal Amount { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Days To Deliver")]
        public DateTime DaysToDelivery { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Descriptions { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Summary { get; set; }
       
    }
}
