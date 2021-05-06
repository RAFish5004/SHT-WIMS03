//===================================================
// PullAdminController.cs, 210504
// Author: Russell Fisher
// - enable editing of PullHdr order objects
// ==================================================

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Models;
using SHTWIMS02.Pull.Models;
using SHTWIMS02.Areas.Pull.Models;


namespace SHTWIMS02.Areas.Pull.Controllers
{
    [Area("Pull")]
    public class PullAdminController : Controller // ----------------------------------------------
    {
        private IPullHdrRepository pullRepo;
        private ICatalogItemRepository ciRepo;
        private Dictionary<string, string> cikvp;
        private Cart cart;
        private PullHdrListViewModel phlvm;

        public PullAdminController(IPullHdrRepository pulls, ICatalogItemRepository ci) // -----------------------------------------------------------
        {
            pullRepo = pulls;
            ciRepo = ci;
            cikvp = ci.CatItemKVP;
            phlvm = new PullHdrListViewModel(pulls,ci);

        } // eo PullAdminContnroller class --------------------------------------------------------


        public ViewResult Index() // -----------------------------------------------------------
        {
            return View();

        } // eo default view ----------------------------------------------------------------------

        public ViewResult PullHdrList()
        {
            return View(phlvm);
        }

    } // eo PullAdminController class -------------------------------------------------------------
} // eo namespace 
