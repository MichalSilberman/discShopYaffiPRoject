using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SingerTbl
    {
        public SingerTbl()
        {
            DiscTbls = new HashSet<DiscTbl>();
        }

        public short IdSinger { get; set; }
        public string NameSinger { get; set; }

        public virtual ICollection<DiscTbl> DiscTbls { get; set; }
    }
}
