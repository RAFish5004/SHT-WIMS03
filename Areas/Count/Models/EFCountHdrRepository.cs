// ========================================================
// EFCountHdrRepository.cs, 210316
// Author: Russell Fisher
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SHTWIMS02.Models;

namespace SHTWIMS02.Areas.Count.Models
{
    public class EFCountHdrRepository // ----------------------------------------------------------
    {
        private ApplicationDbContext context;

        public EFCountHdrRepository(ApplicationDbContext ctx) // -----------------------------------
        {
            context = ctx;
        } // eo EFPullHdrRepository constructor ---------------------------------------------------

        public IQueryable<CountHdr> CountHdrs => context.CountHdrs
            .Include(ph => ph.CountItems);

        public void SaveCountHdr(CountHdr countHdr) // ----------------------------------------------
        {
            context.AttachRange(countHdr.CountItems);
            if (countHdr.CountHdrId == 0)
            {
                context.CountHdrs.Add(countHdr);
            }
            context.SaveChanges();
        } // eo SavePullHdr method ----------------------------------------------------------------


    }// eo EFCouontHdrRepository ------------------------------------------------------------------
} // eo namespace
