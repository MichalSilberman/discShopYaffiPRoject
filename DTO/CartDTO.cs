using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CartDTO
    {
        public short idCust { get; set; }
        public short idDisc { get; set; }
        public string nameDisc { get; set; }
        public decimal pricePerUnut { get; set; }
        public decimal sunPrice { get; set; }
        public int amount { get; set; }
        public string img { get; set; }
    }
}
