// ========================================================
// IPullItemRepository.cs, interface, p 201
// Author: Russell Fisher, 200905
// ========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHTWIMS03.Areas.Pull.Models
{
    public interface IPullItemRepository // -----------------------------------------------------------
    {
        IQueryable<PullItem> PullItems { get; }

    } // eo IPullItemRepository interface ---------------------------------------------------------
} // eo namespace
