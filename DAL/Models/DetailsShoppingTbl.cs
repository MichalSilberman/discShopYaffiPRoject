using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DetailsShoppingTbl
    {
        public short IdDetails { get; set; }
        public short IdShopping { get; set; }
        public short IdDisc { get; set; }
        public int Count { get; set; }

        public virtual DiscTbl IdDiscNavigation { get; set; }
        public virtual ShoppingTbl IdShoppingNavigation { get; set; }
    }
}
