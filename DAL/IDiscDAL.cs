using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface IDiscDAL
    {
      
        List<DiscTbl> GetAllDisc();
        
        DiscTbl GetDiscById(int id);

        List<DiscTbl> GetDiscByIdSinger(int id);

        List<DiscTbl> UpdateDisc(DiscTbl d);

        List<DiscTbl> AddDisc(DiscTbl d);

        List<DiscTbl> DeleateDisc(int id);


    }
}
