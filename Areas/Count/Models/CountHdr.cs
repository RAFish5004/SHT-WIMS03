using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations; //required to use validation attributes
using System.ComponentModel.DataAnnotations.Schema; // reqd for DatabaseGenerated attribute
using SHTWIMS02.Models;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Runtime.CompilerServices;

namespace SHTWIMS02.Areas.Count.Models
{
    public class CountHdr // ----------------------------------------------------------------------
    {
        public CountHdr() // ----------------------------------------------------------------------
        {
            this.CountDate = DateTime.Today;
            this.CountItems = new List<CountItem>();

        } // eo default constructor ---------------------------------------------------------------

        [Key]
        [BindNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountHdrId { get; set; }

        [BindNever]
        [ForeignKey("LocationId")]
        public string LocationId { get; set; }


        [Required(ErrorMessage = "Please enter today's date")]
        public DateTime CountDate { get; set; }
        public string CountBy { get; set; }
        public string Comment { get; set; }

        [BindNever] // this virtual navigation property is critical to relationship
        public virtual ICollection<CountItem> CountItems { get; set; }

        

    } // eo CountHdr class ------------------------------------------------------------------------
} //eo namespace
