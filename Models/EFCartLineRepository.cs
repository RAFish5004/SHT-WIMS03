// ========================================================
// EFCartLineRepository.cs, 201111
// Author: Russell Fisher
// Enable saving CartLine objects to SQL db - no reason to do that
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SHTWIMS03.Models
{
    //public class EFCartLineRepository : ICartLineRepository // ------------------------------------
    //{
    //    private ApplicationDbContext context;

    //    // constructor
    //    public EFCartLineRepository(ApplicationDbContext ctx) // -------------------------------
    //    {
    //        context = ctx;
    //    } // eo EFCartLineRepository constructor -----------------------------------------------


    //    // satisfy rqmt for CartLIneRepository, CartLines is referenced in ApplicationDbContext
    //    public IQueryable<CartLine> CartLines => context.CartLines;

    //} // eo EFCartLineRepository class // ---------------------------------------------------------
}// eo namespace
