
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
using SHTWIMS03.Models; // enable ICatalogItemRepository
using SHTWIMS03.Areas.Pull.Controllers;
using SHTWIMS03.Areas.Pull.Models;



namespace SHTWIMS03.Pull.Models

{
    public class PullHdrListViewModel // ----------------------------------------------------------
    {

        private IPullHdrRepository phRepo;
        private ICatalogItemRepository ciRepo;
        static Dictionary<string, string> catItemKVP;


        public ICatalogItemRepository CatItems
        {
            get { return ciRepo; }
           
        }


        public IPullHdrRepository PullHdrs
        {

            get { return phRepo; }
        }

        public Dictionary<string, string> CIKVP
        {
            get { return catItemKVP; }
        }

        public PullHdrListViewModel(IPullHdrRepository repo, ICatalogItemRepository repo2) // -----
        {
            phRepo = repo;
            ciRepo = repo2;
            catItemKVP = repo2.CatItemKVP;

        } // eo constructor -----------------------------------------------------------------------


    } //eo PullHdrListViewModel class -------------------------------------------------------------
} // eo namespace

