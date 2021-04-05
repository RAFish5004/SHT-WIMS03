// ========================================================
// ICountyRepository.cs, 210318
// Author: Russell Fisher
// County primarily used in Location data type 
//  fill dropdown box select items
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS02.Areas.Locate.Models
{
    public class ICountyRepository // -------------------------------------------------------------
    {
         public IQueryable<County> Counties { get; }

    } // eo ICountyRepository interface -----------------------------------------------------------
} // eo namespace
