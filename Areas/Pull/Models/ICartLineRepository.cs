// ========================================================
// IPullItemRepository.cs, interface, p 201
// Author: Russell Fisher, 201111
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS02.Models;

namespace SHTWIMS02.Areas.Pull.Models
{
    public interface ICartLineRepository // -----------------------------------------------------------
    {
        IQueryable<CartLine> CartLines { get; }


    } // eo IPullItemRepository interface ---------------------------------------------------------
} // eo namespace
