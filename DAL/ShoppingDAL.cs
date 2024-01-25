using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;


namespace DAL
{
    public class ShoppingDAL : IShoppingDAL

    {
        //יצירת משתנה מסוג הDB
        DiscShopDBContext _DB;
        public ShoppingDAL(DiscShopDBContext DB)
        {
            _DB = DB;
        }
        //הוספה לטבלה
        public List<ShoppingTbl> AddShopping(ShoppingTbl sp)
        {
            _DB.ShoppingTbls.Add(sp);
            _DB.SaveChanges();
            return _DB.ShoppingTbls.ToList();

        }
        //מחיקה מהטבלה
        public List<ShoppingTbl> DeleateShopping(int id)
        {
            _DB.ShoppingTbls.Remove(_DB.ShoppingTbls.FirstOrDefault(p => p.IdShopping == id));
            _DB.SaveChanges();
            return _DB.ShoppingTbls.ToList();
        }
        //קבלת כל הטבלה
        public List<ShoppingTbl> GetAllShopping()
        {
            return _DB.ShoppingTbls.ToList();
        }
        //קבלת רשומה לפי מספר מטבלה
        public ShoppingTbl GetShoppingById(int id)
        {
            var sp = _DB.ShoppingTbls.FirstOrDefault(p => p.IdShopping == id);
            if (sp != null)
                return sp;
            return null;
        }
        //עדכון רשומה בטבלה
        public List<ShoppingTbl> UpdateShopping(ShoppingTbl sp)
        {
            var spToEdit = _DB.ShoppingTbls.FirstOrDefault(p => p.IdShopping == sp.IdShopping);
            if (spToEdit != null)
            {
                spToEdit.IdShopping = sp.IdShopping;
                spToEdit.IdCust = sp.IdCust;
                spToEdit.DateShopping = sp.DateShopping;
                spToEdit.SumShoping = sp.SumShoping;
                _DB.SaveChanges();
            }

            return _DB.ShoppingTbls.ToList();
        }
    }
}
