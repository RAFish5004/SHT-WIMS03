// ========================================================
// EFCatalogItemRerpository.cs, 200824
// Author: Russell Fisher
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS02.Models
{
    public class EFCatalogItemRepository : ICatalogItemRepository // ------------------------------  
    {
        private ApplicationDbContext context;

        // constructor
        public EFCatalogItemRepository(ApplicationDbContext ctx) // -------------------------------
        {
            context = ctx;
        } // eo EFCatalogItemRepository constructor -----------------------------------------------

        // satisfy rqmt for CatalogIitemRepository, CatalogItems is referenced in ApplicationDbContext
        public IQueryable<CatalogItem> CatalogItems => context.CatalogItems;

    } // eo EFCatalogItemRepository ---------------------------------------------------------------
} //eo namespace
