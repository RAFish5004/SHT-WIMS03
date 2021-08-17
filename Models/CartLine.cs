// ========================================================
// CartLine.cs, 210331
// Author: Russell Fisher
// Recast CartLine type for general purpose
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.DependencyInjection; // reqd for GetService method
using SHTWIMS03.Models;
using SHTWIMS03.Areas.Pull.Models;

namespace SHTWIMS03.Models
{

    public partial class CartLine // --------------------------------------------------------
    {
      
        private static IServiceProvider sp;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartLineId { get; set; }
        [BindNever]
        [ForeignKey("PullHdrId")]
        public int PullHdrId { get; set; }       
        public string ItemId { get; set; }
        public string Description { get; set; }
        public string UoM { get; set; }        
        [Required]
        [Range(minimum: 1, maximum: 5000, ErrorMessage = "Please enter a quantity of one or more")]
        public int Qty { get; set; }
        [Required(ErrorMessage = "Please enter a valid date mm/dd/yy")]
        public DateTime DateNeeded { get; set; }
        public string Comment { get; set; }
        
        public CartLine() // default constructor --------------------------------------------------
        {          
            // empty at present

        } // eo default constructor ---------------------------------------------------------------


        public CartLine(CatalogItem ci) // alt 1 constructor, new Cartline-------------------------
        {
            // upgrade a CatalogItem to a CartLine object
            this.ItemId = ci.ItemId;
            this.Description = ci.Description;
            this.UoM = ci.UoM;
            this.Qty = 1;
            this.DateNeeded = DateTime.Today;

        }// eo constructor from CatalogItem--------------------------------------------------------

        public CartLine(PullItem pi)  // alt 2 constructor, update PullItem -----------------------
        {
            // enable Description property
            var ciRepository = sp.GetService<ICatalogItemRepository>();            
            
            // ** convert PullItem to Cartline object
            this.ItemId = pi.ItemId;
            this.Description = ciRepository.CatalogItems.FirstOrDefault(ci => ci.ItemId == pi.ItemId).Description;
            this.UoM = pi.UoM;
            this.Qty = pi.QtyRequested;
            this.DateNeeded = pi.DateNeeded;
            this.Comment = pi.Comment;

        } // eo constructor from PullItem ---------------------------------------------------------

    } //eo CartLine class -------------------------------------------------------------------------

} // eo namespace