// ========================================================
// Cart.cs, 201106 imported from PullCart
// Cartline object also => moved to separate file
// ========================================================
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SHTWIMS02.Models
{
    public class Cart // --------------------------------------------------------------------------
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddLine(CartLine inCartItem) // p 257 ---------------------------------
        {
            CartLine line = lineCollection
                .Where(ci => ci.ItemId == inCartItem.ItemId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(inCartItem);
            }
            else
            {
                // what to do if inCartItem already exists?
            }

        } // eo AddItem virtual method ------------------------------------------------------------

        public virtual void RemoveLine(CartLine cartItem) // --------------------------------------
        {
            // called by CartController
            lineCollection.RemoveAll(l => l.ItemId == cartItem.ItemId);

        } // eo RemoveLine virtual method ---------------------------------------------------------

        public virtual void Clear() => lineCollection.Clear();

        // virtual navigation property required by EntityFramework Core
        public virtual IEnumerable<CartLine> Lines => lineCollection;


    } // eo Cart class ----------------------------------------------------------------------------
    
} // eo namespace
