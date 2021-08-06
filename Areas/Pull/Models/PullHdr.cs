// ========================================================
// PullHdr.cs, 200905
// Author: Russell Fisher
// modelled after ASPMVC p 257
// see: DisplayFormatAttribute Class for date formatting help
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations; //required to use validation attributes
using System.ComponentModel.DataAnnotations.Schema; // reqd for DatabaseGenerated attribute
using SHTWIMS03.Models;
//using SHTWIMS03.Areas.Locate.Models;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Runtime.CompilerServices;

namespace SHTWIMS03.Areas.Pull.Models
{
    public partial class PullHdr  // ----------------------------------------------------------------------
    {
        //private List<Pullitem> pullitems => PullItems;
        private string pullDate;
      

        public PullHdr() // -----------------------------------------------------------------------
        {
            this.PullDate = DateTime.Today;
            //pullDate = DateTime.Today.ToShortDateString();
            pullDate = DateTime.Today.ToString();
            this.PullItems = new List<PullItem>();
            this.Status = "Open";  // default to Open
        }// default constructor -------------------------------------------------------------------

        // ensure that PullHdrId is null by default
        // private int? pullHdrId = null;

        // ** Notes:
        // Change Shipped property to Status
        // Add Phone for requester
        // Add an email address for requester, see RegExp on p 40


        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[BindNever]
        public int PullHdrId { get; set; }
        
        public string Status { get; set; }

        [ForeignKey("LocationId")]
        [Required(ErrorMessage = "Please select a Location")]
        public string LocationId { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a valid date")]
        public DateTime PullDate { get; set; }
                    
        [Required(ErrorMessage = "Where is this Pull order going?")]
        public string Destination { get; set; }
     
        [Required(ErrorMessage = "Who requested this Pull order? ")]
        public string Requester { get; set; }

        public string ReqPhone { get; set; }

        public string ReqEmail { get; set; }

        public string Comment { get; set; }

        public virtual ICollection<PullItem> PullItems { get; set; }

    } //eo PullHdr class --------------------------------------------------------------------------
} // eo namespace
