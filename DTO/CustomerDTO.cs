using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public partial class CustomerDTO
    {
        public short IdCust { get; set; }
        public string NameCust { get; set; }
        public string PassCust { get; set; }
        public string NumOfVisaCust { get; set; }

        public static implicit operator List<object>(CustomerDTO v)
        {
            throw new NotImplementedException();
        }
    }
}
