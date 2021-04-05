// ========================================================
// ReceiveHdrController.cs, 210316
// Author: Russell Fisher
// ========================================================
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Areas.Receive.Models;

namespace SHTWIMS02.Areas.Receive.Controllers
{
    [Area ("Receive")]
    public class ReceiveHdrController : Controller // ------------------------------------------------
    {
        private IReceiveHdrRepository repository;

        public ReceiveHdrController(IReceiveHdrRepository repoService) // ----------
        {
            repository = repoService;
           
        } // eo constructor with dependency injection ---------------------------------------------

        public IActionResult Index() // -----------------------------------------------------------
        {
            return View();
        } // eo Index action method ---------------------------------------------------------------

    } // eo ReceiveController ---------------------------------------------------------------------
} // eo namespace
