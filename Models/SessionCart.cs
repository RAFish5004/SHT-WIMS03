// ========================================================
// SessionCart.cs, 201019
// Author: Russell Fisher
// See p 272
// Inherits Cart class, add ISession object with unique session Id 
// SessionCart adds access to Json AddLine and RemoveLine base methods
// located in: Infrastructure/SessionExtensions
// 
// ========================================================
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SHTWIMS03.Infrastructure;
using System;

namespace SHTWIMS03.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services) // ----------------------------------
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;

        } // eo static GetCart method -------------------------------------------------------------

        [JsonIgnore]
        public ISession Session { get; set; }

        // see Infrastructure/SessionExtensions.cs for base methods
        public override void AddLine(CartLine cartLine) // ----------------------------------------
        {
            base.AddLine(cartLine);
            Session.SetJson("Cart", this);
        } // eo AddLine override method -----------------------------------------------------------

        public override void RemoveLine(CartLine cartItem) // -------------------------------------
        {
            base.RemoveLine(cartItem);
            Session.SetJson("Cart", this);

        } // eo RemoveLine override method --------------------------------------------------------

        public override void Clear() // -----------------------------------------------------------
        {
            base.Clear();
            Session.Remove("Cart");
        } // eo Clear override method -------------------------------------------------------------

    } // eo SessionCart class -----------------------------------------------------------------------
} // eo namespace
