// ========================================================
// PullItem.cs, 200526
// class derives from ItemBase base
// Author: Russell Fisher
// ========================================================
// Entity Framework Reverse Engineering - db first approach
// https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli
// Entity Framework Tools - Package Manager
// https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell
// ComponentModel.DataAnnotations 
// https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations?redirectedfrom=MSDN

using System;
using System.Data;  
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SHTWIMS02.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SHTWIMS02.Areas.Pull.Models
{
    public class PullItem : CountBase
    {
        public PullItem() : base() // -------------------------------------------------------------
        {
            // base class also needs a default, zero parameter constructor
            // this constructor empty for now

        } // eo constructor -----------------------------------------------------------------------       

        public PullItem(CartLine cl) // -----------------------------------------------------------
        {
            // ** constructor to translate from CartLine object 
            // PullitemId set by db
            // PullHdrId set by db
            this.ItemId = cl.ItemId;
            this.UoM = cl.UoM;
            this.QtyRequested = (int)cl.Qty;
            this.Comment = cl.Comment;
            this.DateNeeded = cl.DateNeeded;

        } // eo one parameter constructor ---------------------------------------------------------


        //[BindNever]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int PullItemId { get; set; }
        //[BindNever]
        [ForeignKey("PullHdrId")]
        public int PullHdrId { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 5000, ErrorMessage = "Please enter a quantity greater than 1")]
        public int QtyRequested { get; set; }
        public int QtyShipped { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNeeded { get; set; }

        // inherited from CountBase
        // string ItemId (15 char)
        // string UoM
        // int Qty is used for QtyShipped
        // string Comment        

        // Navigation property, this is required as link to header type
        public virtual PullHdr PullHdr { get; set; }

    } // eo PullItem class ------------------------------------------------------------------------
} // eo namespace
