using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public partial class DiscDTO
    {
        public short IdDisc { get; set; }
        public string NameDisc { get; set; }
        public short IdSinger { get; set; }
        public decimal PricePerUnit { get; set; }
        public string ImgDisc { get; set; }
        public int UnitInStock { get; set; }
    }
}
