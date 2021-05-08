using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Areas.Pull.Controllers;

namespace SHTWIMS02.Areas.Pull.Models
{
   public interface IPullHdrRepository // --------------------------------------------------------------
    {
        public IQueryable<PullHdr> PullHdrs { get; }
        
        public Dictionary<int, string> PullOrders { get; }

        // use the work PullOrder starting here
        void SavePullHdr(PullHdr pullHdr);
       
    } // eo IPullHdrsRepository -------------------------------------------------------------------
} // eo namespace
