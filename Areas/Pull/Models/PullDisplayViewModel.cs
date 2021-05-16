// =================================================
// PullDisplayViewModel.cs, 210516
// Author: Russell Fisher
// - the purpose of this VM is to send in a PullHdr object  
//    along with a CatalogItem Dictionary(ItemId, Description)
//    to enable Descriptions in a user view.
// =================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Areas.Pull.Models;
using SHTWIMS02.Pull.Models;

namespace SHTWIMS02.Areas.Pull.Models
{
    public class PullDisplayViewModel // ----------------------------------------------------------
    {
        private PullHdr phdr;
        private Dictionary<string, string> cikvp;
      


        public PullHdr PHdr { get; set; }
        public Dictionary<string, string> CIKVP { get; set; }

        public PullDisplayViewModel (PullHdr ph, Dictionary<string, string> keyValuePairs)
        {

            PHdr = ph;
            CIKVP = keyValuePairs;

        }
    } // eo PullDisplayViewModel ------------------------------------------------------------------
} // eo namespace
