// ========================================================
// CartController.cs, rev 201106
// Author: Russell Fisher
// 
// ========================================================


using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SHTWIMS02.Models;
using SHTWIMS02.Models.ViewModels;
using SHTWIMS02.Components;

namespace Areas.SHTWIMS02.Controllers
{
    public class CartController : Controller // ---------------------------------------------------
    {
        private ICatalogItemRepository repository;
        private Cart cart;
        
        // constructor with two service parameters
        public CartController(ICatalogItemRepository repo, Cart cartService) // -------------------------------------
        {
            repository = repo;
            cart = cartService; // p 273

        } // eo constructor -----------------------------------------------------------------------


        public IActionResult Index() // -----------------------------------------------------------
        {
            // request filterString for select list
            return View();
        
        } // eo Index action method ---------------------------------------------------------------


        public ViewResult CiListFiltered(string filterString) // ----------------------------------     
        {

            // filler object is a place holder for the first item in the filtered list
            CatalogItem filler = new CatalogItem { ItemId = "filler", Description = "Select an item", UoM = "ea" };
            List<CatalogItem> items = new List<CatalogItem>(); // holds search result

            items.Add(filler);

            foreach (CatalogItem iv in repository.CatalogItems)
            {
                if (!String.IsNullOrEmpty(filterString))
                {
                    // convert both items to lower case before comparison
                    if (iv.Description.ToLower().Contains(filterString.ToLower()))
                    {
                        items.Add(iv);
                    }
                }
            }
            return View(items);

        } // eo IClistFilter method ---------------------------------------------------------------
      

        [HttpGet]
        public ViewResult CartLineForm() // ----------------------------------------------------------
        {
            return View();

        } // eo CartLineForm base method -------------------------------------------------------------

        [HttpPost] // it is critical that the parameter has the same name as the <select> tag.
        public IActionResult CartLineForm(string itmSelect) // ----------------------------------------
        {
            // action method to display info from CiFilteredList.itmSelect <select>tag return 
            // from CartForm 

            if (itmSelect != null)
            {
                CartLine cl;
                CatalogItem c = repository.CatalogItems.FirstOrDefault(ci => ci.ItemId == itmSelect);

                // cast CatalogItem object to CartLine type
                cl = new CartLine(c);

                //  call CartForm view to enable input additional information as CartLine 
                return View(cl);
            }
            else
            {
                return RedirectToAction("/Home/Index");
            }

        } //eo CartLineForm  -----------------------------------------------------------------------------       

        public RedirectToActionResult AddToCart(CartLine cartLine, string returnUrl) // ---------------
        {

            if (cartLine != null)
            {
                //Cart cart = GetCart(); // Cart service defined in constructor
                cart.AddLine(cartLine); // call AddLine method of Cart class
                //SaveCart(cart);  comment out p274
            }

            return RedirectToAction("CartIndex", new { returnUrl });

        } // eo AddToCart method ------------------------------------------------------------------

        public ViewResult CartIndex(string returnUrl) // p 267 ----------------------------------------
        //public ViewResult CartIndex()
        {
            // CartIndexViewModel 
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });

        } // eo CartIndex action method ---------------------------------------------------------------

        public RedirectToActionResult RemoveFromCart(CartLine cartItem, string returnUrl) // ----------
        {

            if (cartItem != null)
            {

                //Cart cart = GetCart();
                cart.RemoveLine(cartItem); // Cart service defined in constructor
                // SaveCart(cart); comment out p274
            }

            return RedirectToAction("CartIndex");
            //return RedirectToAction("CartIndex", new { returnUrl });
        } // eo RemoveFromCart method -------------------------------------------------------------


    } // eo CartController ------------------------------------------------------------------------
} // eo namespace