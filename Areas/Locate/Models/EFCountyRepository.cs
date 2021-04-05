﻿// ========================================================
// EFCountyRepository.cs, 210318
// Author: Russell Fisher
// 
// ========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Models;
using SHTWIMS02.Areas.Locate.Models;

namespace SHTWIMS02.Areas.Locate.Models
{
    public class EFCountyRepository : ICountyRepository // ----------------------------------------
    {
        private ApplicationDbContext context;

        // constructor
        public EFCountyRepository(ApplicationDbContext ctx) // -------------------------------
        {
            context = ctx;

        } // eo EFCountyRepository constructor -----------------------------------------------

        // satisfy rqmt for ICountyRepository, Counties is referenced in ApplicationDbContext
        public IQueryable<County> Counties => context.Counties;


    } // eo EFCountyRepository --------------------------------------------------------------------
} // eo namespace
