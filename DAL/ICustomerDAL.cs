using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface ICustomerDAL
    {

        List<CustomerTbl> GetAllCuotomers();

        CustomerTbl GetCuotomerByPass(string pass);
        CustomerTbl GetCustomerById(int id);

        List<CustomerTbl> UpdateCuotomer(CustomerTbl c);

        List<CustomerTbl> AddCuotomer(CustomerTbl c);

        List<CustomerTbl> DeleateCuotomer(int id);
        

        

        

        
    }
}
