using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // enable ViewComponent base class

namespace SHTWIMS03.Components
{
    public class SideNavViewComponent : ViewComponent // 
    {
        public IViewComponentResult Invoke() // ---------------------------------------------------
        {
            return View("SideNav");
        } // eo Invoke method ---------------------------------------------------------------------

    } // eo SideNavViewComponent class ------------------------------------------------------------
} // eo namespace 
