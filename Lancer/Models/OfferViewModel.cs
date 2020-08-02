using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lancer.Models
{
    [Authorize]
    [BindProperties]
    public class OfferViewModel
    {
       
        public long Id { get; set; }

        
        [Required]
        public LeadContactViewModel Lead { get; set; }
        [Required]
        public ProjectViewModel Project { get; set; }
 
        public virtual ICollection<BidViewModel> Bids { get; set; }
        [Required]
        public FreeLancerViewModel FreeLancers { get; set; }
        [Required]
        public BusinessAccountViewModel Business { get; set; }
        public virtual ICollection<MilestonesViewModel> Milestones { get; set; }
    }
}
