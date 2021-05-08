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
        public IQueryable<PullHdr> PullHdrs => context.PullHdrs
            .Include(ph => ph.PullItems);
        public List<string> PullSummaryList => MakeSummaryList();
       

        public EFPullHdrRepository(ApplicationDbContext ctx) // constructor -----------------------
        {
            context = ctx;
        } // eo EFPullHdrRepository constructor ---------------------------------------------------

        
       
        public void SavePullHdr(PullHdr pullHdr) // ----------------------------------------------
        {
            context.AttachRange(pullHdr.PullItems);
            if (pullHdr.PullHdrId == 0)
            {
                context.PullHdrs.Add(pullHdr);
            }
            context.SaveChanges();
        } // eo SavePullHdr method ----------------------------------------------------------------

        public List<string> MakeSummaryList()
        {
            List<string> hold = new List<string>(); 

            foreach (PullHdr ph in PullHdrs)
            {
                string phsum = new string
                  ($"{ph.PullHdrId} {ph.Status} {ph.PullDate} by {ph.Requester} to {ph.Destination} ");

                hold.Add(phsum);                                          
            }              
            
            return hold;
        }

        
    } // eo EFPullHdrRepository class -------------------------------------------------------------
} // eo namespace
