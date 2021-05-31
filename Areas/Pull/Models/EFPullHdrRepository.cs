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
       
        public IQueryable<PullHdr> PullHdrs => context.PullHdrs.Include(ph => ph.PullItems);// req'd by interface

        public Dictionary<int, string> PullOrders => MakePullOrders();// req'd by interface

        public EFPullHdrRepository(ApplicationDbContext ctx) // -----------------------------------
        {
            context = ctx;

        } // eo EFPullHdrRepository constructor ---------------------------------------------------


        Dictionary<int, string> MakePullOrders() // -----------------------------------------------
        {
            // this method creates PullOrder string objects to be used in PullSelect select list to enable editing
            Dictionary<int, string> phDict = new Dictionary<int, string>();

            foreach (PullHdr ph in PullHdrs)
            {
                string phSummary = new string( $"Id: {ph.PullHdrId}, < Date: { ph.PullDate.ToShortDateString()}, Pull from {ph.LocationId}, Ship to {ph.Destination}, By {ph.Requester} >  {ph.Status}");
                phDict.Add(ph.PullHdrId, phSummary);
            }

            return phDict;

        } // eo MakePullOrders --------------------------------------------------------------------
        
               
        public void SavePullHdr(PullHdr pullHdr) // ----------------------------------------------
        {
            //SaveChanges is a method of DbContext class inherited by ApplicationDbContext class
            // located in the Models folder of the base program
            // if PullHdrId = 0 then Add a new order, otherwise save changes
            context.AttachRange(pullHdr.PullItems);
            if (pullHdr.PullHdrId == 0)
            {
                context.PullHdrs.Add(pullHdr);
            }
            else
            {
                // see p308 for explanation
                PullHdr dbEntry = context.PullHdrs.FirstOrDefault(ph => ph.PullHdrId == pullHdr.PullHdrId);
                if (dbEntry != null)
                {
                    dbEntry.PullHdrId = pullHdr.PullHdrId;
                    dbEntry.Status = pullHdr.Status;
                    dbEntry.LocationId = pullHdr.LocationId;
                    dbEntry.PullDate = pullHdr.PullDate;
                    dbEntry.Destination = pullHdr.Destination;
                    dbEntry.Requester = pullHdr.Requester;
                    dbEntry.ReqPhone = pullHdr.ReqPhone;
                    dbEntry.ReqEmail = pullHdr.ReqEmail;
                    dbEntry.Comment = pullHdr.Comment;
                }
            }
            context.SaveChanges();
        } // eo SavePullHdr method ----------------------------------------------------------------

        
    } // eo EFPullHdrRepository class -------------------------------------------------------------
} // eo namespace
