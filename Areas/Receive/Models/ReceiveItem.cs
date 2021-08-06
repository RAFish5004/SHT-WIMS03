// ========================================================
// ReceiveItem.cs class, 210316
// Author: Russell Fisher
// 
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SHTWIMS03.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace SHTWIMS03.Areas.Receive.Models
{
    public class ReceiveItem : CountBase // -------------------------------------------------------
    {
        public ReceiveItem() : base() // ----------------------------------------------------------
        { 
            // empty for now

        } // eo constructor -----------------------------------------------------------------------


        [Key]
        [BindNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceiveItemId { get; set; }
        [BindNever]
        [ForeignKey("ReceiveHdrId")]
        public int ReceiveHdrId { get; set; }            

        // inherited from CountBase
        // string ItemId (15 char)
        // string UoM
        // int Qty is used for QtyReceived
        // string Comment        


        // Navigation property, this is required as link to header type
        public virtual ReceiveHdr ReceiveHdr { get; set; }



    }// eo ReceiveItem class ----------------------------------------------------------------------
} // eo namespace
