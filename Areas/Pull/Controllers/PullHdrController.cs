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
using SHTWIMS02.Models;
using SHTWIMS02.Areas.Pull.Models;


namespace SHTWIMS02.Areas.Pull.Controllers
{
    [Area("Pull")]
    public class PullHdrController : Controller // ------------------------------------------------
    {
        private IPullHdrRepository repository;
        private Cart cart;

        public PullHdrController(IPullHdrRepository repoService, Cart cartService) // ----------
        {
            repository = repoService;
            cart = cartService;
        
        } // eo constructor with dependency injection ---------------------------------------------

        // method call from CartIndex.cshtml Checkout button
        public ViewResult Checkout() => View("PullHdrForm", new PullHdr());

        public ViewResult PullIndex() // -------------------------------------------------------
        {
            return View();

        } // eo Index method ----------------------------------------------------------------------

        
        public ViewResult PullMenu() // first landing point for Pull ---------------------------
        {
            return View();

        } // eo PullMenu action method ------------------------------------------------------------


        [HttpGet]
        public ViewResult 
            PullHdrForm() // -----------------------------------------------------
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
                    // convert CartLine to PullItem
                    pull.PullItems.Add(new PullItem(line));
                }
                repository.SavePullHdr(pull);
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
            cart.Clear();
            return View();
        } // eo Completed action method -----------------------------------------------------------

    } // eo PullHdrController ---------------------------------------------------------------------
} // eo namespac