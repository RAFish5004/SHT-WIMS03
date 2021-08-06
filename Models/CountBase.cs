// ========================================================
// CountBase.cs, 200924
// Author: Russell Fisher
// class differs from ItemBase as it has no description field
// no description keeps the data file cleaner
// base class for CountItem, PullItem and ReceiptItem
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SHTWIMS03.Models
{
    public class CountBase // ---------------------------------------------------------------------
    {        
        public string ItemId { get; set; } // item identifier code
        public string UoM { get; set; } // unit of measure
        public int Qty { get; set; } // quantity, shipped, received or counted       
        public string Comment { get; set; } 

        public CountBase() // default constructor -------------------------------------------------
        { 
            // empty for now
        
        } // eo default constructor ---------------------------------------------------------------


    }// eo CountBase class ------------------------------------------------------------------------
}
