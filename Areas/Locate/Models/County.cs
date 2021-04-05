// ========================================================
// County.cs, 210318
// Author: Russell Fisher
//
// ========================================================
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SHTWIMS02.Areas.Locate.Models
{
    public class County // ------------------------------------------------------------------------
    {
        public County() // -----------------------------------------------------------------------
        { 
            // empty at this time

        } // eo constructor -----------------------------------------------------------------------

        [Key]
        public string CntyFIPS { get; set; }
        public string CntyName { get; set; }
        public string Territory { get; set; }
        public string Seat { get; set; }
        public double SeatLat { get; set; }
        public double SeatLon { get; set; }
        public int Area { get; set; }


    } // eo County class --------------------------------------------------------------------------
} // eo namespace
