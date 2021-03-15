using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS02.Models
{
    public interface ICatalogItemRepository // ----------------------------------------------------
    {
        IQueryable<CatalogItem> CatalogItems { get; }

    } // eo ICatalogItemRepository interface ------------------------------------------------------
} // eo namespace
