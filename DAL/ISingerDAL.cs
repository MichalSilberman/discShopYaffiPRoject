using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface ISingerDAL
    {
        List<SingerTbl> GetAllSingers();

        SingerTbl GetSingerById(int id);

        List<SingerTbl> UpdateSinger(SingerTbl s);

        List<SingerTbl> AddSinger(SingerTbl s);

        List<SingerTbl> DeleateSinger(int id);
    }
}
