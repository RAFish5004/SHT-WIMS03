// ========================================================
// PullHdr.cs, 200905
// Author: Russell Fisher
// modelled after ASPMVC p 257
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations; //required to use validation attributes
using System.ComponentModel.DataAnnotations.Schema; // reqd for DatabaseGenerated attribute
using SHTWIMS02.Models;
//using SHTWIMS02.Areas.Locate.Models;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Runtime.CompilerServices;

namespace SHTWIMS02.Areas.Pull.Models
{
    public partial class PullHdr  // ----------------------------------------------------------------------
    {
        //private List<Pullitem> pullitems => PullItems;

        public PullHdr() // -----------------------------------------------------------------------
        {
            this.PullDate = DateTime.Today;
            this.PullItems = new List<PullItem>();
            
        }// default constructor -------------------------------------------------------------------

        // ensure that PullHdrId is null by default
        // private int? pullHdrId = null;

        // ** Notes:
        // Change Shipped property to Status
        // Add Phone for requester
        // Add an email address for requester, see RegExp on p 40

        [BindNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PullHdrId { get; set; }
        
        [BindNever] // p 295
        public string Status { get; set; }

        [ForeignKey("LocationId")]
        [Required(ErrorMessage = "Please select a Location")]
        public string LocationId { get; set; }
        [Required(ErrorMessage = "Please enter today's date")]
        public DateTime PullDate { get; set; }

        [Required(ErrorMessage = "Where is this Pull order going?")]
        public string Destination { get; set; }
     
        [Required(ErrorMessage = "Who requested this Pull order? ")]
        public string Requester { get; set; }
        public string ReqPhone { get; set; }
        public string ReqEmail { get; set; }
        public string Comment { get; set; }


        //public ICollection<PullItem> PullItems { get; set; }

        // this virtual navigation property is critical to relationship
        //public virtual ICollection<CartLine> CartLines { get; set; }
        
        public virtual ICollection<PullItem> PullItems { get; set; }

    } //eo PullHdr class --------------------------------------------------------------------------
} // eo namespace
