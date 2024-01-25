using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;

namespace DAL
{
    public class DiscDAL : IDiscDAL
    {
        //יצירת משתנה מסוג הDB
        DiscShopDBContext _DB;
        public DiscDAL(DiscShopDBContext DB)
        {
            _DB = DB;
        }
        //הוספה לטבלה
        public List<DiscTbl> AddDisc(DiscTbl d)
        {
            _DB.DiscTbls.Add(d);
            _DB.SaveChanges();
            return _DB.DiscTbls.ToList();
        }
        //מחיקה מהטבלה
        public List<DiscTbl> DeleateDisc(int id)
        {
            _DB.DiscTbls.Remove(_DB.DiscTbls.FirstOrDefault(p=> p.IdDisc==id));
            _DB.SaveChanges();
            return _DB.DiscTbls.ToList();
        }
        //קבלת כל הטבלה
        public List<DiscTbl> GetAllDisc()
        {
           return _DB.DiscTbls.ToList();
        }
        //קבלת רשומה לפי מספר מטבלה
        public DiscTbl GetDiscById(int id)
        {
            var d = _DB.DiscTbls.FirstOrDefault(p => p.IdDisc == id);
            if (d != null)
                return d;
            return null;
        }
        //קבלת רשומה לפי מספר קטגוריה מטבלה
        public List<DiscTbl> GetDiscByIdSinger(int id)
        {
            var d = _DB.DiscTbls.Where(p => p.IdSinger == id);
            if (d != null)
                return d.ToList();
            return null;
        }

        //עדכון רשומה בטבלה

        public List<DiscTbl> UpdateDisc(DiscTbl d)
        {
            var dToEdit= _DB.DiscTbls.FirstOrDefault(p => p.IdDisc == d.IdDisc);
            if(dToEdit!=null)
            {
                dToEdit.IdDisc = d.IdDisc;
                dToEdit.IdSinger = d.IdSinger;
                dToEdit.ImgDisc = d.ImgDisc;
                dToEdit.NameDisc = d.NameDisc;
                dToEdit.PricePerUnit = d.PricePerUnit;
                dToEdit.UnitInStock = d.UnitInStock;
                _DB.SaveChanges();
            }
            return _DB.DiscTbls.ToList();
        }
    }
}
