// ========================================================
// PullHdrSeedData.cs, 200905
// Author: Russell Fisher
// Modeled after p 
// =======================================================
using Microsoft.AspNetCore.Builder; // reqd for this class
using Microsoft.EntityFrameworkCore; // reqd for this class
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Models;

namespace SHTWIMS02.Areas.Pull.Models
{
    public class PullHdrSeedData // ---------------------------------------------------------------
    {
        public static void PopulatedPullHdr(IApplicationBuilder app)  //---------------------------        
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.PullHdrs.Any())
            {
                context.PullHdrs.AddRange(

                new PullHdr { LocationId = "HOUHQ", Status = "Shipped", PullDate = DateTime.Parse("05/31/20"), Destination = "SHTO", Requester = "R Fisher", Comment = "Normal restock" },
                new PullHdr { LocationId = "SHTO", Status = "Shipped", PullDate = DateTime.Parse("05/31/20"), Destination = "CldSpgVFD", Requester = "E Fowler", Comment = "Flood Preparedness" },
                new PullHdr { LocationId = "HOUHQ", Status = "Partial", PullDate = DateTime.Parse("05/31/20"), Destination = "SHTO", Requester = "M Lucey", Comment = "DR350-20" }
                );
                context.SaveChanges();
            }
        }// eo PopulatePullHdr method -------------------------------------------------------------

    } // eo PullHdrSeedData class -----------------------------------------------------------------
} // eo namespace
