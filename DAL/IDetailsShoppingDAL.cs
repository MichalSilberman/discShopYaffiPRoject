using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

 namespace DAL
{
    public interface IDetailsShoppingDAL
    {
        List<DetailsShoppingTbl> GetAllDetailsShopping();

        DetailsShoppingTbl GetDetailsShoppingById(int id);



        List<DetailsShoppingTbl> UpdateDetailsShopping(DetailsShoppingTbl ds);

        List<DetailsShoppingTbl> AddDetailsShopping(DetailsShoppingTbl ds);

        List<DetailsShoppingTbl> DeleateDetailsShopping(int id);
    }
}
