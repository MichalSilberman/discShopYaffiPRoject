using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        //יצירת משתנה מסוג הDB
        DiscShopDBContext _DB;
        public CustomerDAL(DiscShopDBContext DB)
        {
            _DB = DB;
        }
        //הוספה לטבלה
        public List<CustomerTbl> AddCuotomer(CustomerTbl c)
        {
            _DB.CustomerTbls.Add(c);
            _DB.SaveChanges();
            return _DB.CustomerTbls.ToList();
        }
        //מחיקה מהטבלה
        public List<CustomerTbl> DeleateCuotomer(int id)
        {
            _DB.CustomerTbls.Remove(_DB.CustomerTbls.FirstOrDefault(p => p.IdCust == id));
            _DB.SaveChanges();
            return _DB.CustomerTbls.ToList();
        }
        //קבלת כל הטבלה
        public List<CustomerTbl> GetAllCuotomers()
        {
            return _DB.CustomerTbls.ToList();
        }
        //קבלת רשומה לפי מספר מטבלה
        public CustomerTbl GetCustomerById(int id)
        {
            var c = _DB.CustomerTbls.FirstOrDefault(p => p.IdCust == id);
            if (c != null)
                return c;
            return null;
        }
        //קבלת רשומה לפי סיסמה מטבלה
        public CustomerTbl GetCuotomerByPass(string pass)
        {
            var c = _DB.CustomerTbls.FirstOrDefault(p => p.PassCust == pass);
            if (c != null)
                return c;
            return null;
        }
        //עדכון רשומה בטבלה
        public List<CustomerTbl> UpdateCuotomer(CustomerTbl c)
        {
            var cToEdit = _DB.CustomerTbls.FirstOrDefault(p => p.IdCust == c.IdCust);
            if (cToEdit != null)
            {
                cToEdit.IdCust = c.IdCust;
                cToEdit.NameCust = c.NameCust;
                cToEdit.NumOfVisaCust = c.NumOfVisaCust;
                cToEdit.PassCust = c.PassCust;
                
                _DB.SaveChanges();
            }
            return _DB.CustomerTbls.ToList();
        }
    }
}
