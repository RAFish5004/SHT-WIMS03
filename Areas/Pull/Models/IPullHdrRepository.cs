using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS02.Areas.Pull.Models
{
   public interface IPullHdrRepository // --------------------------------------------------------------
    {
        public IQueryable<PullHdr> PullHdrs { get; }

        List<string> PullSummaryList { get; }

        //Dictionary<string, string> PullHdrKVP { get; }

        // required method signature
        void SavePullHdr(PullHdr pullHdr);

    } // eo IPullHdrsRepository -------------------------------------------------------------------
} // eo namespace
