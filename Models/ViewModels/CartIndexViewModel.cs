// ========================================================
// CartIndexViewModel.cs, 201005 p 267
// Author: Russell Fisher
// 
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SHTWIMS02.Models.ViewModels
{
    public class CartIndexViewModel // ------------------------------------------------------------
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    } // eo CartIndexViewModel class --------------------------------------------------------------
} // eo namespace
