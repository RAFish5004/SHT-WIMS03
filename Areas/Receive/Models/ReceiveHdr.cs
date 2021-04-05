// ========================================================
// ReceiveHdr.cs, 210316
// Author: Russell Fisher
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //required to use validation attributes
using System.ComponentModel.DataAnnotations.Schema; // reqd for DatabaseGenerated attribute
using SHTWIMS02.Models;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc.ModelBinding;



namespace SHTWIMS02.Areas.Receive.Models
{
    public class ReceiveHdr // --------------------------------------------------------------------
    {

        public ReceiveHdr()
        {
            this.ReceiveDate = DateTime.Today;// set default date to current date
            this.ReceiveItems = new List<ReceiveItem>();

        }

        [Key]
        [BindNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceiveHdrId { get; set; }

        [ForeignKey("LocationId")]
        [Required(ErrorMessage = "Please select a Location")]
        public string LocationId { get; set; }
        
        [Required(ErrorMessage = "Please enter today's date")]
        public DateTime ReceiveDate { get; set; }

        [Required(ErrorMessage = "Where did this Receipt originate?")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "Who received this order? ")]
        public string Receiver { get; set; }
        

        public string Comment { get; set; }

        public virtual ICollection<ReceiveItem> ReceiveItems { get; set; }

    }// eo ReceiveHdr class -----------------------------------------------------------------------
} // eo namespace 
