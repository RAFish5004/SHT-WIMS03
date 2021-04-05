using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SHTWIMS02.Areas.Count
{
    public class CountHdrController : Controller // -----------------------------------------------
    {

        public IActionResult Index() // -----------------------------------------------------------
        {
            return View();
        } // eo Index action method ---------------------------------------------------------------
    } // eo CountHdrController ------------------------------------------------------------------------ 
} // eo namespace