using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Models;


namespace SHTWIMS02.Areas.Receive.Models
{
    public class EFReceiveItemRepository : IReceiveItemRepository
    {
        private ApplicationDbContext context;

        // constructor
        public EFReceiveItemRepository(ApplicationDbContext ctx) // -------------------------------
        {
            context = ctx;
        } // eo EFReceiveItemRepository constructor -----------------------------------------------

        // satisfy rqmt for ReceiveIitemRepository, ReceiveItems is referenced in ApplicationDbContext
        public IQueryable<ReceiveItem> ReceiveItems => context.ReceiveItems;

    } // eo EFReceiveItemRepository class ---------------------------------------------------------
} // eo namespace
