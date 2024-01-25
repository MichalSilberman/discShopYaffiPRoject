using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models; 

namespace DAL
{
    public interface IShoppingDAL
    {
        List<ShoppingTbl> GetAllShopping();

        ShoppingTbl GetShoppingById(int id);

        List<ShoppingTbl> UpdateShopping(ShoppingTbl sp);

        List<ShoppingTbl> AddShopping(ShoppingTbl sp);

        List<ShoppingTbl> DeleateShopping(int id);
    }
}
