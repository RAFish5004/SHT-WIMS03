// ========================================================
// Location.cs data type, 210316
// Author: Russell Fisher

// ========================================================
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS03.Areas.Locate.Models
{
    public class Location // ----------------------------------------------------------------------
    {
        public Location() // Controller -----------------------------------------------------------
        { 
            // empty for now
        } // eo constructor -----------------------------------------------------------------------

        // Validation attributes
        // https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-5.0

        [Key]
        [Required(ErrorMessage = "Please create an easy to remember location code, 10 characters or less")]
        public string LocationId { get; set; } // max 12 char location code. unique, arbitrary
        [Required(ErrorMessage ="Please enter the name of the location")]                                               
        public string LocationName { get; set; } // mad 31 char
        [ForeignKey("CntyFIPS")]
        [Required(ErrorMessage = "Select from dropdown box")]
        public string LocationCounty { get; set; } // 3 character FIPS County Code
        public string Type { get; set; } // ARC designation 
        public string Affiliation { get; set; } // name of owner organization
        public string PhoneMain { get; set; }          
        public string Address1{ get; set; } 
        public string Address2{ get; set; }
        public string City{ get; set; }
        public string State{ get; set; } // two character USPS 
        public string PostalCode{ get; set; }
        public bool Climate { get; set; } // Climate controlled?
        public bool Secure { get; set; } // Is the location secure?
        public bool Agreement { get; set; }  // is there an agreement in place?
        public int Area { get; set; }  // how many squqre feet?
        public double Lat { get; set; }
        public double Lon { get; set; }
        public int Elev { get; set; }
        public string Comment { get; set; }

    } // eo Location class ------------------------------------------------------------------------
} // eo namespace
