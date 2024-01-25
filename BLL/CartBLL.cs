using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL.Models;
using DAL;

namespace BLL
{
    public class CartBLL : ICartBLL
    {
        //משתנים מסוג מחלקות שונות
        IDetailsShoppingDAL _IDetailsShoppingDAL;
        IShoppingDAL _IShoppingDAL;
        IDiscDAL _IDiscDAL;
        //אתחול בקונסטרקטור
        public CartBLL(IDetailsShoppingDAL DetailsShoppingDAL, IShoppingDAL ShoppingDAL, IDiscDAL DiscDAL)
        {
            _IDetailsShoppingDAL = DetailsShoppingDAL;
            _IShoppingDAL = ShoppingDAL;
            _IDiscDAL = DiscDAL;

        }
        //פונקציה שמקבלת רשימת של עגלת קניות וקוד לקוח ומיצר עבור כל מוצר שורה בטבלת מוצרים וכן שורה עבור כל הקנייה
        //מחזיר עבור כל מוצר האם אפשר לקנות אותו או אזל במלאי
        public List<bool> AddCart(short id, List<CartDTO> c)
        {
            List<bool> listReturn = new List<bool>();
            try
            {
                decimal sum = 0;
                ShoppingTbl sp = new ShoppingTbl();
                foreach (var item in c)
                {
                        sum += item.sunPrice;
                }
                sp.DateShopping = new DateTime();
                sp.IdCust = id;
                sp.SumShoping = sum;
                _IShoppingDAL.AddShopping(sp);
                foreach(var item in c)
                {
                    if (Check(item.idDisc, item.amount) == true)
                    {
                        DetailsShoppingTbl s = new DetailsShoppingTbl();
                        listReturn.Add(true);
                        s.IdDisc = item.idDisc;
                        s.Count = item.amount;
                        s.IdShopping = sp.IdShopping;
                        _IDetailsShoppingDAL.AddDetailsShopping(s);
                    }
                    else
                        listReturn.Add(false);
                }
                
                return listReturn;
            }
            catch
            {
                return listReturn;
            }
        }
        //פונקציה המקבלת קוד מוצר וכמות ובודקת האם יש מספיק במלאי 
        public bool Check(short id, int amount)
        {
            var disc = _IDiscDAL.GetDiscById(id);
            if (disc.UnitInStock >= amount)
            {
                disc.UnitInStock = disc.UnitInStock - amount;
                _IDiscDAL.UpdateDisc(disc);
                return true;
            }
            else
                return false;
        }


    }
}
