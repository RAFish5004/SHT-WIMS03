// ========================================================
// ReceiveItemController.cs, 210316
// Author: Russell Fisher
//
// ========================================================

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS03.Areas.Receive.Controllers
{
    [Area("Receive")]
    public class ReceiveItemController : Controller // --------------------------------------------
    {
        public IActionResult Index() // -----------------------------------------------------------
        {
            return View();

        } // eo Index action method ---------------------------------------------------------------

    } // eo ReceiveItemController class -----------------------------------------------------------
} // eo namespace
