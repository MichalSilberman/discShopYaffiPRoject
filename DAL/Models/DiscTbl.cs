using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DiscTbl
    {
        public DiscTbl()
        {
            DetailsShoppingTbls = new HashSet<DetailsShoppingTbl>();
        }

        public short IdDisc { get; set; }
        public string NameDisc { get; set; }
        public short IdSinger { get; set; }
        public decimal PricePerUnit { get; set; }
        public string ImgDisc { get; set; }
        public int UnitInStock { get; set; }

        public virtual SingerTbl IdSingerNavigation { get; set; }
        public virtual ICollection<DetailsShoppingTbl> DetailsShoppingTbls { get; set; }
    }
}
