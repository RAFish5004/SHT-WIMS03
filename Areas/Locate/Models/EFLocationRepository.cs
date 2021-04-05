using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Models;

namespace SHTWIMS02.Areas.Locate.Models
{
    public class EFLocationRepository : ILocationRepository
    {
        private ApplicationDbContext context;

        // constructor
        public EFLocationRepository(ApplicationDbContext ctx) // -------------------------------
        {
            context = ctx;

        } // eo EFLocationRepository constructor -----------------------------------------------

        // satisfy rqmt for ILocationRepository, Locations is referenced in ApplicationDbContext
        public IQueryable<Location> Locations => context.Locations;

    } // eo EFLocationRepository class ------------------------------------------------------------
} // eo namespapce
