using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
    public interface ICustomerBLL
    {
        List<CustomerDTO> AddCuotomer(CustomerDTO c);
        CustomerDTO GetCuotomerByPass(string pass);
    }
}
