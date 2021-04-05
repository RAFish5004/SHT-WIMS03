using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS02.Areas.Locate.Models
{
    public class ILocationRepository // -----------------------------------------------------------
    {
        IQueryable<Location> Locations { get; }

    } // eo ILocationRepository interface ---------------------------------------------------------
} // eo namespace
