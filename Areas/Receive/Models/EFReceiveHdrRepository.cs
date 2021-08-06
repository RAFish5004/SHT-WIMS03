using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SHTWIMS03.Models;

namespace SHTWIMS03.Areas.Receive.Models
{
    public class EFReceiveHdrRepository : IReceiveHdrRepository
    {
        private ApplicationDbContext context;

        public EFReceiveHdrRepository(ApplicationDbContext ctx) // -----------------------------------
        {
            context = ctx;
        } // eo EFReceiveHdrRepository constructor ---------------------------------------------------

        public IQueryable<ReceiveHdr> ReceiveHdrs => context.ReceiveHdrs
             .Include(ph => ph.ReceiveItems);

        public void SavePullHdr(ReceiveHdr receiveHdr) // ----------------------------------------------
        {
            context.AttachRange(receiveHdr.ReceiveItems);
            if (receiveHdr.ReceiveHdrId == 0)
            {
                context.ReceiveHdrs.Add(receiveHdr);
            }
            context.SaveChanges();
        } // eo SavePullHdr method ----------------------------------------------------------------

    } // eo EFReceiveItemRepository ---------------------------------------------------------------
} // eo namespace
