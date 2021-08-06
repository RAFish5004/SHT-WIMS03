// ========================================================
// ICountItemRepository.cs, 210316
// Author: Russell Fisher
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SHTWIMS03.Areas.Count.Models
{
    public class ICountItemRepository // ----------------------------------------------------------
    {
        IQueryable<CountItem> CountItems { get; }

    } // eo ICountItemRepository class ------------------------------------------------------------
} // eo namespace
