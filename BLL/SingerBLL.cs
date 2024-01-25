using System;
using System.Collections.Generic;
using DTO;
using AutoMapper;
using DAL;
using DAL.Models;

namespace BLL
{
    public class SingerBLL : ISingerBLL

    {

        ISingerDAL _SingerDAL;
        IMapper _imapper;
        public SingerBLL(ISingerDAL SingerDAL)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();

            });
            _imapper = config.CreateMapper();
            _SingerDAL = SingerDAL;
        }
        
        public List<SingerDTO> AddSinger(SingerDTO s)
            
        {
            SingerTbl singer = _imapper.Map<SingerDTO, SingerTbl>(s);
            List<SingerTbl> listsinger = _SingerDAL.AddSinger(singer);
            try
            {
                return _imapper.Map<List<SingerTbl>, List<SingerDTO>>(listsinger);
            }
            catch
            {
                throw new Exception("not succeed AddSinger!!");
            }
             
        }

        public List<SingerDTO> DeleateSinger(int id)
        {
            
            List<SingerTbl> listsinger = _SingerDAL.DeleateSinger(id);

            try
            {
                return _imapper.Map<List<SingerTbl>, List<SingerDTO>>(listsinger);
            }
            catch
            {
                throw new Exception("not succeed DeleateSinger!!");
            }
        }

        public List<SingerDTO> GetAllSingers()
        {
            
            List<SingerTbl> listsinger = _SingerDAL.GetAllSingers();
            try
            {
                return _imapper.Map<List<SingerTbl>, List<SingerDTO>>(listsinger);
            }
            catch
            {
                throw new Exception("not succeed GetAllSingers!!");
            }
        }

        public SingerDTO GetSingerById(int id)
        {
            SingerTbl Singer = _SingerDAL.GetSingerById(id);
            try
            {
                return _imapper.Map<SingerTbl, SingerDTO>(Singer);
            }
            catch
            {
                throw new Exception("not succeed GetSingerById!!");
            }
        }

        public List<SingerDTO> UpdateSinger(SingerDTO s)
        {
            SingerTbl singer = _imapper.Map<SingerDTO, SingerTbl>(s);
            List<SingerTbl> listsinger = _SingerDAL.UpdateSinger(singer);
            try
            {
                return _imapper.Map<List<SingerTbl>, List<SingerDTO>>(listsinger);
            }
            catch
            {
                throw new Exception("not succeed UpdateSinger!!");
            }
        }
    }
}
