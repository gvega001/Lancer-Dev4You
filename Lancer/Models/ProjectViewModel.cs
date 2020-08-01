using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace Lancer.Models
{
 
    public class ProjectViewModel
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

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
    
    }
}
