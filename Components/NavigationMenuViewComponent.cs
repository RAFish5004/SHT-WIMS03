// ========================================================
// NavigationMenuViewComponent.cs, 200907
// Author: Russell Fisher
// insert into Views.Shared._Layout for general use
//  May not be necessary because the NavButtons view is not used
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // enable ViewComponent base class
using SHTWIMS03.Models;


namespace SHTWIMS03.Components
{
    public class NavigationMenuViewComponent : ViewComponent // ----------------------------------- 
    {
        // Create a List of button contents
        private List<string> NavButtons = new List<string>(new string[] {
            "Locations", 
            "Item Catalog", 
            "Pull Inventory",
            "Receipt", 
            "Counts", 
            "Reports"});
        
        // Views/Shared/Components/NavigationMenu/Default.cshtml
        public IViewComponentResult Invoke() // ---------------------------------------------------
        {
            return View(NavButtons);
        } // eo Invoke method ---------------------------------------------------------------------

    } // eo NavigationMenuViewComponent class -----------------------------------------------------
} // eo namespace
