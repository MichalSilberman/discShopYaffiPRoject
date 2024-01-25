using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;

namespace DAL
{
    public class SingerDAL : ISingerDAL
    {
        //יצירת משתנה מסוג הDB
        DiscShopDBContext _DB;
        public SingerDAL(DiscShopDBContext DB)
        {
            _DB = DB;  
        }
        //הוספה לטבלה
        public List<SingerTbl> AddSinger(SingerTbl s)
        {
            _DB.SingerTbls.Add(s);
            _DB.SaveChanges();
            return _DB.SingerTbls.ToList();
        }
        //מחיקה מהטבלה
        public List<SingerTbl> DeleateSinger(int id)
        {
            if (id != null) { 
                _DB.SingerTbls.Remove(_DB.SingerTbls.FirstOrDefault(p => p.IdSinger == id));
                _DB.SaveChanges();
            }
            return _DB.SingerTbls.ToList();
        }
        //קבלת כל הטבלה
        public List<SingerTbl> GetAllSingers()
        {
            return _DB.SingerTbls.ToList();
        }
        //קבלת רשומה לפי מספר מטבלה
        public SingerTbl GetSingerById(int id)
        {
            var s=_DB.SingerTbls.FirstOrDefault(p => p.IdSinger == id);
            if(s!=null)
                return s;
            return null;
        }
        //עדכון רשומה בטבלה
        public List<SingerTbl> UpdateSinger(SingerTbl s)
        {
            var sToEdit= _DB.SingerTbls.FirstOrDefault(p => p.IdSinger == s.IdSinger);
            if(sToEdit!=null)
            {
                sToEdit.IdSinger = s.IdSinger;
                sToEdit.NameSinger = s.NameSinger;
                _DB.SaveChanges();
            }
            
            return _DB.SingerTbls.ToList();
        }
    }
}
