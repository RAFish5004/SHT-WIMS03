using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS03.Models
{
    public interface ICatalogItemRepository // ----------------------------------------------------
    {
        IQueryable<CatalogItem> CatalogItems { get; }

        List<string> Categories { get; }

        Dictionary<string, string> CatItemKVP { get; }

    } // eo ICatalogItemRepository interface ------------------------------------------------------
} // eo namespace
