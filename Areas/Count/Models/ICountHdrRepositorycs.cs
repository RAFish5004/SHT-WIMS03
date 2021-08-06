using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS03.Areas.Count.Models
{
    public interface ICountHdrRepository // --------------------------------------------------------------
    {
        public IQueryable<CountHdr> CountHdrs { get; }

        // 
        void SaveCountHdr(CountHdr countHdr);

    } // eo ICountHdrsRepository -------------------------------------------------------------------
} // eo namespace

