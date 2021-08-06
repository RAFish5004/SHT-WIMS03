// ========================================================
// EFCountItemReposiitory.cs, 210316
// Author: Russell Fisher
// 
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS03.Models;
using SHTWIMS03.Areas.Count.Models;

namespace SHTWIMS03.Areas.Count.Models
{
    public class EFCountItemRepository : ICountItemRepository // ---------------------------------------------------------
    {
        private ApplicationDbContext context;

        // constructor
        public EFCountItemRepository(ApplicationDbContext ctx) // -------------------------------
        {
            context = ctx;
        } // eo EFCountItemRepository constructor -----------------------------------------------


        // satisfy rqmt for ICountItemRepository, CountItems is referenced in ApplicationDbContext
        public IQueryable<CountItem> CountItems => context.CountItems;

    }// eo EFCountItemRepository class ------------------------------------------------------------
} // eo namespace
