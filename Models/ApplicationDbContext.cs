// ========================================================
// ApplicationDbContext.cs, 200904
// Author: Russell Fisher
// this class makes the connection between app and SQL db
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using SHTWIMS03.Models;
using SHTWIMS03.Areas.Pull.Models;
using SHTWIMS03.Areas.Locate.Models;
using SHTWIMS03.Areas.Count.Models;
using SHTWIMS03.Areas.Receive.Models;


// see: appsettings.json for,
// Connection String: CSPullItems
// Db Name: PullItems02

namespace SHTWIMS03.Models
{
    public class ApplicationDbContext : DbContext // ----------------------------------------------
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            var ops = options;

        } // eo ApplicationDbContext constructor --------------------------------------------------

        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<PullHdr> PullHdrs { get; set; }
        public DbSet<PullItem> PullItems { get; set; }
        public DbSet<CartLine> CartLines { get; set; } // added 201111
        public DbSet<CountHdr> CountHdrs { get; set; }
        public DbSet<CountItem> CountItems { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ReceiveHdr> ReceiveHdrs { get; set; }
        public DbSet<ReceiveItem> ReceiveItems { get; set; }

    } // eo ApplicationDbContext class ------------------------------------------------------------
} // eo namespace
