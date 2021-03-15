// ========================================================
// ItemBase.cs class, 200824
// Author: Russell Fisher
// A base class to minimize the code duplication for 
// Receipt, Pull and Count objects
// ========================================================

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SHTWIMS02.Models
{
    public class ItemBase // --------------------------------------------------
    {
       // private fields
        private string itemId = null;
        private string descr = null;
        private string uom = null;

        // public properties
        [Key]
        public string ItemId { get; set; }
        public string Description { get; set; }
        public string UoM { get; set; }

        public ItemBase() //default constructor ---------------------------------------------------
        { 
            // default constructor, empty at this time
        } // eo default constructor ---------------------------------------------------------------

        public ItemBase(string ItemId, string Description, string UoM) // -----------------------
        {
            itemId = ItemId;
            descr = Description;
            uom = UoM;         

        } // eo three parameter constructor -------------------------------------------------------

        public override string ToString() // ------------------------------------------------------
        {
            return this.itemId + " - " + this.descr;

        } // eo ToString override ----------------------------------------------------------------

    }// eo ItemBase class -------------------------------------------------------------------------
} // eo namespace
