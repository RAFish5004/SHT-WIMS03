// ====================================================
// StatusNames.cs, 210518
// Author: Russell Fisher
// - this item provides terms for the dropdown box on the 
//   PullHdr input form, see p772
// ====================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS03.Areas.Pull.Models
{
    public enum StatusTerms // --------------------------------------------------------------------
    {
        Open,
        Approved,
        Partial,
        Completed,
        Cancelled

    } // eo StatusNames enumeration ---------------------------------------------------------------
} // eo namespace
