using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
    public interface ISingerBLL
    {
        List<SingerDTO> GetAllSingers();

        SingerDTO GetSingerById(int id);

        List<SingerDTO> UpdateSinger(SingerDTO s);

        List<SingerDTO> AddSinger(SingerDTO s);

        List<SingerDTO> DeleateSinger(int id);
    }
}
