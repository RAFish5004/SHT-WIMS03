// ========================================================
// PullHdrListViewModel.cs, 210421
// Author: Russell Fisher
// - this view model carries a copy of the PullHdr repo
//  and the CatalogItem Dictionary to enable item.Description
//  to allow user to view items by description rather than item code
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Models; // enable ICatalogItemRepository
using SHTWIMS02.Areas.Pull.Controllers;
using SHTWIMS02.Areas.Pull.Models;


namespace SHTWIMS02.Pull.Models.ViewModels
{
    public class PullHdrListViewModel // ----------------------------------------------------------
    {

        private IPullHdrRepository phRepo;
        private ICatalogItemRepository ciRepo;
        static Dictionary<string, string> catItemKVP;

        public IPullHdrRepository PullHdrs {
            
            get { return phRepo; }
        }

        public Dictionary<string, string> ItemKVP {
            set {
                catItemKVP = ItemKVP;
            }
            
            get {
               
                return catItemKVP;
                }
            }// eo property


        public PullHdrListViewModel(IPullHdrRepository repo, ICatalogItemRepository repo2) // -----
        {
            phRepo = repo;
            ciRepo = repo2;
            MakeDictionary();
        } // eo constructor -----------------------------------------------------------------------


        public Dictionary<string, string> MakeDictionary() // ---------------------------------------
        {
            catItemKVP = new Dictionary<string, string>();

            foreach (CatalogItem ci in ciRepo.CatalogItems.ToArray())
            {
                catItemKVP.Add(ci.ItemId, ci.Description);
            }

            return catItemKVP;
        } // eo MakeDictionary method -------------------------------------------------------------

    } //eo PullHdrListViewModel class -------------------------------------------------------------
} // eo namespace