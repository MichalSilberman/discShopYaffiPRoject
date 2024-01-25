using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ShoppingTbl
    {
        public ShoppingTbl()
        {
            DetailsShoppingTbls = new HashSet<DetailsShoppingTbl>();
        }

        public short IdShopping { get; set; }
        public short IdCust { get; set; }
        public DateTime DateShopping { get; set; }
        public decimal SumShoping { get; set; }

        public virtual CustomerTbl IdCustNavigation { get; set; }
        public virtual ICollection<DetailsShoppingTbl> DetailsShoppingTbls { get; set; }
    }
}
