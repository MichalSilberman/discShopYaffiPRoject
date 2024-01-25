using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public partial class ShoppingDTO
    {
        public short IdShopping { get; set; }
        public short IdCust { get; set; }
        public DateTime DateShopping { get; set; }
        public decimal SumShoping { get; set; }
    }
}
