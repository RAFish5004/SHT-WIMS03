// ========================================================
// EFPullHdrRepository.cs, 201111
// Author: Russell Fisher
// 
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SHTWIMS02.Models;

namespace SHTWIMS02.Areas.Pull.Models
{
    public class EFPullHdrRepository : IPullHdrRepository // --------------------------------------
    {
        private ApplicationDbContext context;

        public EFPullHdrRepository(ApplicationDbContext ctx) // -----------------------------------
        {
            context = ctx;
        } // eo EFPullHdrRepository constructor ---------------------------------------------------

        public IQueryable<PullHdr> PullHdrs => context.PullHdrs
            .Include(ph => ph.PullItems);
        public Dictionary<int, string> PullOrders => MakePullOrders(); 

        Dictionary<int, string> MakePullOrders() // -----------------------------------------------
        {
            Dictionary<int, string> phDict = new Dictionary<int, string>();

            foreach (PullHdr ph in PullHdrs)
            {
                string phSummary = new string( $"Id: {ph.PullHdrId} Date: { ph.PullDate.ToShortDateString()}, Pull from {ph.LocationId}, Ship to {ph.Destination} By {ph.Requester} {ph.Status}");
                phDict.Add(ph.PullHdrId, phSummary);
            }

            return phDict;
        } // eo MakePullOrders --------------------------------------------------------------------
        
        
        public void SavePullHdr(PullHdr pullHdr) // -----------------------------------------------
        {
            context.AttachRange(pullHdr.PullItems);
            if (pullHdr.PullHdrId == 0)
            {
                context.PullHdrs.Add(pullHdr);
            }
            context.SaveChanges();
        } // eo SavePullHdr method ----------------------------------------------------------------

    } // eo EFPullHdrRepository class -------------------------------------------------------------
} // eo namespace
