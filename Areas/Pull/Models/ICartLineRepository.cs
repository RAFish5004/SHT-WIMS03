// ========================================================
// IPullItemRepository.cs, interface, p 201
// Author: Russell Fisher, 201111
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHTWIMS03.Models;

namespace SHTWIMS03.Areas.Pull.Models
{
    public interface ICartLineRepository // -----------------------------------------------------------
    {
        IQueryable<CartLine> CartLines { get; }

    } // eo IPullItemRepository interface ---------------------------------------------------------
} // eo namespace
