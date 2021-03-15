// ========================================================
// CatalogItem.cs, 200824
// Author: Russell Fisher
// A class derived from ItemBase that enables Category property
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace SHTWIMS02.Models
{
    public class CatalogItem : ItemBase // --------------------------------------------------------
    {
        
        public string Category { get; set; }
        
        public CatalogItem() : base() // default constructor --------------------------------------
        {
            
        } // eo default constructor --------------------------------------------------------------

        public CatalogItem(string ItemId, string Description, string UoM, string Category) :
            base() // -----------------------------------------------------------------------------
        { 
            // empty at this time

        } // eo 4 parameter constructor -----------------------------------------------------------

    } // eo CatalogItem class ---------------------------------------------------------------------
} // eo namespace
