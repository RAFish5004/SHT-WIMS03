// ========================================================
// SHT-WIMS02.HomeController, 210309
// Author: Russell Fisher
// ========================================================

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS03.Controllers
{
    // minor change to test GitHub commit
    public class HomeController : Controller // ---------------------------------------------------
    {
        public IActionResult Index() // -----------------------------------------------------------
        {
            return View();
        } // eo Index action method --------------------------------------------------------------

    } // eo HomeController class ------------------------------------------------------------------
} // eo namespace
