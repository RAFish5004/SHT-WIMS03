using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SHTWIMS02.Models;



namespace SHTWIMS02.Controllers
{
    public class CatalogItemController : Controller // --------------------------------------------
    {     
        private ICatalogItemRepository repository;
        private List<string> catalogCategories;
     
        
        
        // properties
        public List<string> CatalogCategories {

            get{
                return catalogCategories;
            }
        } // eo property -------------------------
        
       


        // Constructor, one parameter
        public CatalogItemController(ICatalogItemRepository repo) // ------------------------------
        {
            repository = repo;            

        } // eo constructor -----------------------------------------------------------------------

        public ViewResult CatalogMenu() // --------------------------------------------------------
        {
            return View();
        
        } // eo CatalogMenu method ----------------------------------------------------------------


        public IActionResult SearchString() // ----------------------------------------------------
        {
            // this is a simple reduced list of items
            return View();

        } // eo SearchString method ---------------------------------------------------------------
    
        
       public ViewResult CiFilteredScrollList(string searchString) // -----------------------------     
        {
            // use ViewData[fltDescr] to capture screen input

            List<CatalogItem> items = new List<CatalogItem>(); // holds search result

            foreach (CatalogItem iv in repository.CatalogItems)
            {
                if (!String.IsNullOrEmpty(searchString))
                {
                    // convert both items to lower case before comparison
                    if (iv.Description.ToLower().Contains(searchString.ToLower()))
                    {
                        items.Add(iv);
                    }
                }
            }
            
            return View(items);

        } // eo CiSelectList method ---------------------------------------------------------------

      

    } // eo CatalogItemController class -----------------------------------------------------------
} // eo namespac