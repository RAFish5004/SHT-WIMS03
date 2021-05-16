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

        public Dictionary<string, string> CIKVP
        {
            set { cikvp = value; }
            get { return cikvp; }

        }

        public PullAdminController(IPullHdrRepository pulls, ICatalogItemRepository ci) // -----------------------------------------------------------
        {

            pullRepo = pulls;
            ciRepo = ci;
            cikvp = ci.CatItemKVP;
            phlvm = new PullHdrListViewModel(pulls, ci);

        } // eo PullAdminContnroller class --------------------------------------------------------


        public ViewResult Index() // --------------------------------------------------------------
        {
            return View();

        } // eo default view ----------------------------------------------------------------------



        public IActionResult PullSelect() // --------------------------------------------------------
        {
            return View("PullSelect", pullRepo.PullOrders);

        } // eo PullEdit action method // ---------------------------------------------------------

        public ViewResult PullDisplay(int pullHdrId) // ----------------------------------------------
        {   
            // created a PullDisplayViewModel to send in a PullHdr and CIKVP dictionary

            PullHdr localPull = pullRepo.PullHdrs.FirstOrDefault(p => p.PullHdrId == pullHdrId);

            PullDisplayViewModel PDVM = new PullDisplayViewModel(localPull, CIKVP); 
            return View(PDVM); 

        } //  eo PullDisplay action method -----------------------------------------------------------

    } // eo PullAdminController class -------------------------------------------------------------
} // eo namespace 
