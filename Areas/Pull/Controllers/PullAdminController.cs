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


        public ViewResult Index() // --------------------------------------------------------------
        {
            return View();

        } // eo default view ----------------------------------------------------------------------

        public ViewResult PullHdrList() // --------------------------------------------------------
        {
            /* PullHdrList shows list of ... */

            return View(phlvm);
        } // eo PullHdrList method ----------------------------------------------------------------

        public IActionResult PullSelect() // --------------------------------------------------------
        {            
            return View("PullSelect",pullRepo.PullOrders);
        
        } // eo PullEdit action method // ---------------------------------------------------------

        public ViewResult PullGet(int pullHdrId) // ----------------------------------------------
        {
            PullHdr Pull = new PullHdr();
            /* This method receives the pullHdrId parameter from the PullSelect.csheml view.  The
              parameter of type int is used to get the PullHdr object that will be edited.             
             */
            foreach (PullHdr ph in pullRepo.PullHdrs)
            {
                if (ph.PullHdrId == pullHdrId) Pull = ph;
            }

            return View("PullDisplay",Pull);  // the PullHdr item is selected now need to display it

        } //  eo PullEdit action method -----------------------------------------------------------

    } // eo PullAdminController class -------------------------------------------------------------
} // eo namespace 
