using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;

namespace DAL
{
    //יצירת משתנה מסוג הDB
    public class DetailsShoppingDAL : IDetailsShoppingDAL
    {
        DiscShopDBContext _DB;
        public DetailsShoppingDAL(DiscShopDBContext DB)
        {
            _DB = DB;
        }
        //הוספה לטבלה
        public List<DetailsShoppingTbl> AddDetailsShopping(DetailsShoppingTbl ds)
        {
            _DB.DetailsShoppingTbls.Add(ds);
            _DB.SaveChanges();
            return _DB.DetailsShoppingTbls.ToList();
        }
        //מחיקה מהטבלה
        public List<DetailsShoppingTbl> DeleateDetailsShopping(int id)
        {
            _DB.DetailsShoppingTbls.Remove(_DB.DetailsShoppingTbls.FirstOrDefault(p => p.IdDetails == id));
            _DB.SaveChanges();
            return _DB.DetailsShoppingTbls.ToList();
        }
        //קבלת כל הטבלה
        public List<DetailsShoppingTbl> GetAllDetailsShopping()
        {
            return _DB.DetailsShoppingTbls.ToList();
        }
        //קבלת רשומה לפי מספר מטבלה
        public DetailsShoppingTbl GetDetailsShoppingById(int id)
        {
            var ds = _DB.DetailsShoppingTbls.FirstOrDefault(p => p.IdDetails == id);
            if (ds != null)
                return ds;
            return null;
        }
        //עדכון רשומה בטבלה
        public List<DetailsShoppingTbl> UpdateDetailsShopping(DetailsShoppingTbl ds)
        {
            var dsToEdit = _DB.DetailsShoppingTbls.FirstOrDefault(p => p.IdDetails == ds.IdDetails);
            if (dsToEdit != null)
            {
                dsToEdit.IdDetails = ds.IdDisc;
                dsToEdit.IdShopping = ds.IdShopping;
                dsToEdit.IdDisc = ds.IdDisc;
                dsToEdit.Count = ds.Count;
                
                _DB.SaveChanges();
            }
            return _DB.DetailsShoppingTbls.ToList();
        }
    }
}
