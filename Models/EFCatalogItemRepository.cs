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
        public List<string> Categories => this.ItemCategories();
        public Dictionary<string, string> CatItemKVP => this.MakeDictionary();       

        public Dictionary<string, string> MakeDictionary()
        {
            Dictionary<string, string> ciDict = new Dictionary<string, string>();

            foreach (CatalogItem ci in context.CatalogItems.ToArray())
            {
                ciDict.Add(ci.ItemId, ci.Description);
            }

            return ciDict;
        }// eo MakeDictionary method -------------------------------------------------------------

        // create a list of Categories to populate dropdown lists
        public List<string> ItemCategories() // -----------------------------------------------------
        {
            // url path = /CatalogItem/ItemCatagories

            List<string> itemCat = new List<string>();

            foreach (CatalogItem ci in context.CatalogItems)
            {
                string[] c = ci.Category.Split(" ");

                foreach (string cat in c)
                {

                    itemCat.Add(cat);
                }
            }

            //IEnumerable<string> categ = itemCat.Distinct();
            IEnumerable<string> categ = itemCat.Distinct().OrderBy(cat => cat);

            return categ.ToList();

        } // eo ItemCategories action method ---------------------------------------------------------



    } // eo EFCatalogItemRepository ---------------------------------------------------------------
} //eo namespace
