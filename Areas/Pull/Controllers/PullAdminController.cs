﻿//===================================================
// PullAdminController.cs, 210504
// Author: Russell Fisher
// - enable editing of PullHdr order objects
// HttpRequest class: https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.httprequest?view=aspnetcore-5.0
// ==================================================

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS03.Models;
using SHTWIMS03.Pull.Models;
using SHTWIMS03.Areas.Pull.Models;



namespace SHTWIMS03.Areas.Pull.Controllers
{
    [Area("Pull")]
    public class PullAdminController : Controller // ----------------------------------------------
    {
        private IPullHdrRepository pullRepo;
        private ICatalogItemRepository ciRepo;
        private Dictionary<string, string> cikvp;
        private IPullItemRepository pitemRepo;
        private Cart cart;
        private PullHdrListViewModel phlvm;

        public Dictionary<string, string> CIKVP // ------------
        {
            //set { cikvp = value; }  
            get { return cikvp; }

        } // eo CIKVP dictionary property ----------------------

        public PullAdminController(IPullHdrRepository pulls, ICatalogItemRepository ci,  IPullItemRepository pi) // -----------------------------------------------------------
        {
            pitemRepo = pi;
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
            // the Dictionary PullOrders is a property of of IPullHdrRepository
            return View("PullSelect", pullRepo.PullOrders);

        } // eo PullEdit action method // ---------------------------------------------------------

        //[HttpPost]  * preserve a working version  
        //public ViewResult PullDisplay(int pullHdrId) // ----------------------------------------------
        //{
        //    // created a PullDisplayViewModel to send in a PullHdr and CIKVP dictionary
        //    // https://docs.microsoft.com/en-us/dotnet/api/system.web.httprequest.form?view=netframework-4.8

        //    PullHdr localPull = pullRepo.PullHdrs.FirstOrDefault(p => p.PullHdrId == pullHdrId);
        //    //var req = Request.Form["PullHdrId"];

        //    var ssn = Request.HttpContext.Session.Id;

        //    PullDisplayViewModel PDVM = new PullDisplayViewModel(localPull, CIKVP); 
        //    return View(PDVM); 

        //} //  eo PullDisplay action method -----------------------------------------------------------

        [HttpPost]
        public ViewResult PullDisplay(int pullHdrId) // ----------------------------------------------
        {
            // created a PullDisplayViewModel to send in a PullHdr and CIKVP dictionary
            // https://docs.microsoft.com/en-us/dotnet/api/system.web.httprequest.form?view=netframework-4.8

            PullHdr localPull = pullRepo.PullHdrs.FirstOrDefault(p => p.PullHdrId == pullHdrId);
            //var req = Request.Form["PullHdrId"];

            var ssn = Request.HttpContext.Session.Id;

            PullDisplayViewModel PDVM = new PullDisplayViewModel(localPull, CIKVP);
            return View(PDVM);


        } //  eo PullDisplay action method -----------------------------------------------------------


        [HttpGet]
        public ViewResult PullItemDisplay(int pullItemId) // --------------------------------------
        {

            PullItem pi = pitemRepo.PullItems.FirstOrDefault(pid => pid.PullItemId == pullItemId);

            ViewBag.Description = cikvp[pi.ItemId];
            return View(pi);

        }// eo PullItemDisplay action method ------------------------------------------------------


        [HttpPost]
        public IActionResult PullHdrChanged(PullHdr phdr) // ------------------------------------
        {
            var stat = Request.Form["phdr.Status"];
            var ssn = Request.HttpContext.Session.Id;
            
            if(phdr!=null) 
            { 
                // SavePullHdr method is member of EFPullHdrRepository.cs
                pullRepo.SavePullHdr(phdr); 
            }

            //return RedirectToAction(nameof(Pull.Controllers.PullHdrController.PullMenu));
            //RedirectToAction(string actionName, string controllerName);
            return RedirectToAction("PullMenu", "PullHdr" );

        } // eo PullHdrChanged action -------------------------------------------------------------


    } // eo PullAdminController class -------------------------------------------------------------

} // eo namespace 
