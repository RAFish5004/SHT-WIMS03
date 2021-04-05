// ========================================================
// LocationController.cs, 210315
// 
// ========================================================

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS02.Areas.Locate.Controllers
{
    public class LocationController : Controller // ----------------------------------------------
    {
        public IActionResult Index()
        {
            return View();
        }

    } // eo LocationController class --------------------------------------------------------------
} // eo namespace
