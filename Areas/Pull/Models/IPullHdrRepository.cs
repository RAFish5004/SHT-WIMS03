using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS02.Areas.Pull.Models
{
   public interface IPullHdrRepository // --------------------------------------------------------------
    {
        public IQueryable<PullHdr> PullHdrs { get; }
        
        // use the work PullOrder starting here
        void SavePullHdr(PullHdr pullHdr);
       
    } // eo IPullHdrsRepository -------------------------------------------------------------------
} // eo namespace
