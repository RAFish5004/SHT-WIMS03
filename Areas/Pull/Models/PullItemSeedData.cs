// ========================================================
// PullItemSeedData.cs, 200924
// Author: Russell Fisher
//
// ========================================================
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS03.Models;

namespace SHTWIMS03.Areas.Pull.Models
{
    public class PullItemSeedData // --------------------------------------------------------------
    {
     
        public static void EnsurePopulated(IApplicationBuilder app)  //---------------------------        
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.PullItems.Any()) {
                context.PullItems.AddRange(
new PullItem { ItemId = "OS-P950", UoM = "PKG", PullHdrId = 2, QtyRequested = 18, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment="None" },
new PullItem { ItemId = "OS-D283", PullHdrId = 2, QtyRequested = 25, Qty = 15, DateNeeded = DateTime.Parse("06/01/20") },
new PullItem { ItemId = "KF-D46",  UoM = "PKG",PullHdrId = 1, QtyRequested = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "BD-D275", UoM = "Bx",  PullHdrId = 1, QtyRequested = 2, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "BD-D274", UoM = "Cs", PullHdrId = 1, QtyRequested = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "BD-D324", UoM = "Box", PullHdrId = 2, QtyRequested = 8, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "BD-D273", UoM = "Box",  PullHdrId = 2, QtyRequested = 4, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "Trl-005", UoM = "ea", PullHdrId = 1, QtyRequested = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "OS-D275", UoM = "Ea",  PullHdrId = 2, QtyRequested = 36, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "BD-262AA8", UoM = "ea", PullHdrId = 1, QtyRequested = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "BD-D262D", UoM = "ea", PullHdrId = 1, QtyRequested = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "Trl-020", UoM = "ea",  PullHdrId = 1, QtyRequested = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "SS-D37", UoM = "Ea",  PullHdrId = 2, QtyRequested = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" },
new PullItem { ItemId = "Trl-050", UoM = "ea", PullHdrId = 1, QtyRequested = 20, Qty = 15, DateNeeded = DateTime.Parse("06/01/20"), Comment = "None" }

                    );
                context.SaveChanges();
            }
        
        
        } // eo EnsurePopulatedMethod ------------------------------------------------------------


    } // eo PullItemSeedData class ----------------------------------------------------------------
} // eo namespace
