using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using AutoMapper;
using DAL;
using DAL.Models;

namespace BLL
{
    public class CustomerBLL : ICustomerBLL
    {
        ICustomerDAL _CustomerDAL;
        IMapper _imapper;
        public CustomerBLL(ICustomerDAL CustomerDAL)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();

            });
            _imapper = config.CreateMapper();
            _CustomerDAL = CustomerDAL;
        }

        public List<CustomerDTO> AddCuotomer(CustomerDTO c)
        {
            CustomerTbl cust =_imapper.Map<CustomerDTO, CustomerTbl>(c);
            List<CustomerTbl> listcust = _CustomerDAL.AddCuotomer(cust);
            try
            {

                return _imapper.Map<List<CustomerTbl>, List<CustomerDTO>>(listcust);
            }
            catch
            {
                throw new Exception("not succeed AddCuotomer!!");
            }
        }

        

        public CustomerDTO GetCuotomerByPass(string pass)
        {
            CustomerTbl c = _CustomerDAL .GetCuotomerByPass(pass);
            try
            {
                return _imapper.Map<CustomerTbl,CustomerDTO>(c);
            }
            catch
            {
                throw new Exception("not succeed GetCuotomerByPass!!");
            }
        }
    }
}
