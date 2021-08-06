using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS03.Areas.Pull.Controllers;

namespace SHTWIMS03.Areas.Pull.Models
{
   public interface IPullHdrRepository // --------------------------------------------------------------
    {
        public IQueryable<PullHdr> PullHdrs { get; }
        
        // the origin of PullOrder term
        public Dictionary<int, string> PullOrders { get; }
       
        void SavePullHdr(PullHdr pullHdr);

    } // eo IPullHdrsRepository -------------------------------------------------------------------
} // eo namespace
