using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CustomerTbl
    {
        public CustomerTbl()
        {
            ShoppingTbls = new HashSet<ShoppingTbl>();
        }

        public short IdCust { get; set; }
        public string NameCust { get; set; }
        public string PassCust { get; set; }
        public string NumOfVisaCust { get; set; }

        public virtual ICollection<ShoppingTbl> ShoppingTbls { get; set; }
    }
}
