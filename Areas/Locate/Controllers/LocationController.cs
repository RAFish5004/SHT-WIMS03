// ========================================================
// LocationController.cs, 210315
// 
// ========================================================

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Areas.Locate.Models;

namespace SHTWIMS02.Areas.Locate.Controllers
{
    [Area("Locate")]
    public class LocationController : Controller // ----------------------------------------------
    {
        private ILocationRepository repository;

        public LocationController(ILocationRepository repo) // ------------------------------------
        {
            repository = repo;
        
        } // eo constructor -----------------------------------------------------------------------


        public IActionResult Index()
        {
            return View();
        }

    } // eo LocationController class --------------------------------------------------------------
} // eo namespace
