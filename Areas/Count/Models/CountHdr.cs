using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations; //required to use validation attributes
using System.ComponentModel.DataAnnotations.Schema; // reqd for DatabaseGenerated attribute
using SHTWIMS03.Models;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Runtime.CompilerServices;

namespace SHTWIMS03.Areas.Count.Models
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
       
        [ForeignKey("LocationId")]
        public string LocationId { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter the date the count was made")]
        public DateTime CountDate { get; set; }
        public string CountBy { get; set; }
        public string Comment { get; set; }

        [BindNever] // this virtual navigation property is critical to relationship
        public virtual ICollection<CountItem> CountItems { get; set; }

        

    } // eo CountHdr class ------------------------------------------------------------------------
} //eo namespace
