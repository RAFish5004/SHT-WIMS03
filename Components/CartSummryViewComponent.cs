﻿// ========================================================
//  CartSummaryViewComponent.cs, p 277
//  ViewComponent is a class in Microsoft.AspNetCore.Mvc
//  see p246
// ========================================================

using Microsoft.AspNetCore.Mvc;
using SHTWIMS03.Models;



namespace SHTWIMS03.Components
{
    public class CartSummaryViewComponent : ViewComponent // ---------------------------------------
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService) // -------------------------------------
        {
            cart = cartService;
        } // eo constructor -----------------------------------------------------------------------

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }

    } // eo CartSummaryViewComponent class --------------------------------------------------------
} // eo namespace
