// =====================================================
// EFLocationRepository.cs, 210325
// Author: Russell Fisher
//
// =====================================================

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
        public Dictionary<string, string> LocationsKVP => this.MakeDictionary();
        public List<string> LocationNames => this.GetLocations();


        Dictionary<string, string> MakeDictionary()
        {
            Dictionary<string, string> locDict = new Dictionary<string, string>();

            foreach (Location loc in context.Locations.ToArray())
            {
               locDict.Add(loc.LocationId, loc.LocationName);
            }
            
            return locDict ;
        }// eo MakeDictionary method -------------------------------------------------------------

        public List<string> GetLocations() // -----------------------------------------------------
        {
            // url path = /CatalogItem/ItemCatagories

            List<string> locations = new List<string>();
            


            foreach (Location loc in context.Locations)
            {
                
                    locations.Add(loc.LocationId);
                
            }

            IEnumerable<string> lns = locations.Distinct();           

            return lns.ToList<string>();

        } // eo ItemCategories action method ---------------------------------------------------------



    } // eo EFLocationRepository class ------------------------------------------------------------
} // eo namespapce
