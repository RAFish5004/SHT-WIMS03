using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SHTWIMS02.Areas.Receive.Models
{
    public class IReceiveItemRepository // --------------------------------------------------------
    {
        IQueryable<ReceiveItem> ReceiveItems { get; }

    } // eo IReceiveItemRepository class ----------------------------------------------------------
} // eo namespace
