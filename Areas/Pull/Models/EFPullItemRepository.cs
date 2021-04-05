// ========================================================
// EFPullItemRepository.cs, 200924
// Author: Russell Fisher
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Models;

namespace SHTWIMS02.Areas.Pull.Models
{
    public class EFPullItemRepository: IPullItemRepository // -------------------------------------
    {
        private ApplicationDbContext context;

        // constructor
        public EFPullItemRepository(ApplicationDbContext ctx) // -------------------------------
        {
            context = ctx;
        } // eo EFPullItemRepository constructor -----------------------------------------------


        // satisfy rqmt for PullIitemRepository, PullItems is referenced in ApplicationDbContext
        public IQueryable<PullItem> PullItems => context.PullItems;

    } // eo EFPullItemRepository Class ------------------------------------------------------------
} // eo namespace
