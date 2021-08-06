// ========================================================
// CountItem.cs, 200924
// Author: Russell Fisher
// base class for CountItem, no item description
// the idea is to reduce the burden of description field
// base class, inherited by PullItem and ReceiptItem
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SHTWIMS03.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace SHTWIMS03.Areas.Count.Models
{
    public class CountItem : CountBase // ---------------------------------------------------------------------
    {
        public CountItem() // ---------------------------------------------------------------------
        { 
            // empty for now

        } // eo default constructor -----------------------------------------------------------------------
     
        [Key]
        [BindNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountItemId { get; set; }

        [BindNever]
        [ForeignKey("CountHdrId")]
        [Required(ErrorMessage = "Please select a Location")]
        public int CountHdrId { get; set; }        

        // Navigation property, the syntax on this item is not entirely clear
        public virtual CountHdr CountHdr{ get; set; }

    } // eo CountItem class -----------------------------------------------------------------------
} // eo namespace
