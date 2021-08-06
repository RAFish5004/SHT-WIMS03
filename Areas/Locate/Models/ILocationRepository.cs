using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS03.Areas.Locate.Models
{
    public class ILocationRepository // -----------------------------------------------------------
    {
        IQueryable<Location> Locations { get; }

        List<string> LocationNames { get; }

        Dictionary<string, string> LocationsKVP { get; }

    } // eo ILocationRepository interface ---------------------------------------------------------
} // eo namespace
