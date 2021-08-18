// ========================================================
// PullHdrController.cs, 200909
// Author: Russell Fisher
// completes the Cart implementation
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SHTWIMS03.Models;
using SHTWIMS03.Areas.Pull.Models;
using SHTWIMS03.Pull.Models;


namespace SHTWIMS03.Areas.Pull.Controllers
{
    [Area("Pull")]
    public class PullHdrController : Controller // ------------------------------------------------
    {
        private ICatalogItemRepository ciRepo;
        private IPullHdrRepository repository;
        private Cart cart;
        public Dictionary<string, string> itemKVP;
        public Dictionary<int, string> PullOrders;
        public PullHdrListViewModel phlvm;


        public PullHdrController(IPullHdrRepository repoService, Cart cartService, ICatalogItemRepository itemService) // ----------
        {
            repository = repoService;
            cart = cartService;
            ciRepo = itemService;
            PullOrders = repoService.PullOrders;
            phlvm = new PullHdrListViewModel(repoService, itemService);

        } // eo constructor with dependency injection ---------------------------------------------

        // method call from CartIndex.cshtml Checkout button, selects [Post] version
        public ViewResult Checkout() => View("PullHdrForm", new PullHdr());

        public ViewResult PullIndex() => View(); // -----------------------------------------------
        //{
        //  return View();
        //} // eo PullIndex action method ---------------------------------------------------------


        public ViewResult PullMenu() => View();// first landing point for Pull --------------------
        //{
        //    return View();

        //} // eo PullMenu action method ------------------------------------------------------------


        [HttpGet]
        public ViewResult PullHdrForm() // -----------------------------------------------------
        {
            return View();
        } // eo PullHdrForm action method ---------------------------------------------------------

       [HttpPost]
        public IActionResult PullHdrForm(PullHdr pull) // --------------------------------------------
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, the cart is empty");
            }
            if (ModelState.IsValid)
            {
                foreach (CartLine line in cart.Lines)
                {
                    // convert CartLine to PullItem in PullItem constructor
                    pull.PullItems.Add(new PullItem(line));
                }
                repository.SavePullHdr(pull);
                // **TempData required to pass value to another action after Redirection, p 541
                TempData["phid"] = pull.PullHdrId.ToString();
                return RedirectToAction(nameof(CartCompleted));                
            }
            else
            {
                // need to decide where to go ?
                return View();
            }

        } // eo PullHdrForm post version ----------------------------------------------------------

        public ViewResult CartCompleted() // ----------------------------------------------------------
        {
            string pullId = TempData["phid"] as string;
            cart.Clear();
            return View("CartCompleted",(string)pullId);
        } // eo Completed action method -----------------------------------------------------------

        public ViewResult PullHdrList() // --------------------------------------------------------
        {
            /* PullHdrList shows list of PullHdr and PullItems arranged in a table */

            return View(phlvm);
        } // eo PullHdrList method ----------------------------------------------------------------


    } // eo PullHdrController ---------------------------------------------------------------------
} // eo namespac