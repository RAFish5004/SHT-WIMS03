// ========================================================
// CountyController.cs, 210318
// Author: Russell Fisher
// may not be necessary as County has relatively little range
//  
// ========================================================

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS03.Areas.Locate.Models;

namespace SHTWIMS03.Areas.Locate.Controllers
{
    [Area("Locate")]
    public class CountyController : Controller // -------------------------------------------------
    {
        public static Dictionary<string, string> CountyKVP;
         ICountyRepository repository;

        public CountyController(ICountyRepository repo) // ------------------------------
        {
            repository = repo;
            MakeDictionary(); // create 

        } // eo constructor -----------------------------------------------------------------------


        public IActionResult Index() // -----------------------------------------------------------
        {
            return View();
        } // --------------------------------------------------------------------------------------

        // make a dictionary just in case
        Dictionary<string, string> MakeDictionary() // ---------------------------------------
        {
            CountyKVP = new Dictionary<string, string>();

            foreach (County cnty in repository.Counties)
            {
                CountyKVP.Add(cnty.CntyFIPS, cnty.CntyName.ToString()) ;
            }

            return CountyKVP;
        } // eo MakeDictionary method -------------------------------------------------------------

    } // eo CountyController class ----------------------------------------------------------------
} // eo namespace
