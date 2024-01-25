using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using AutoMapper;
using DAL;
using DAL.Models;
using System.Linq;

namespace BLL
{
    public class DiscBLL : IDiscBLL
    {
        IDiscDAL _DiscDAL;
        IMapper _imapper;
        public DiscBLL(IDiscDAL SingerDAL)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();

            });
            _imapper = config.CreateMapper();
            _DiscDAL = SingerDAL;
        }
        public List<DiscDTO> AddDisc(DiscDTO d)
        {
            DiscTbl disc = _imapper.Map<DiscDTO, DiscTbl>(d);
            List<DiscTbl> listdisc = _DiscDAL.AddDisc(disc);
            try
            {
                return _imapper.Map<List<DiscTbl>, List<DiscDTO>>(listdisc);
            }
            catch
            {
                throw new Exception("not succeed AddDisc!!");
            }
        }

        public List<DiscDTO> DeleateDisc(int id)
        {
            List<DiscTbl> listdisc = _DiscDAL.DeleateDisc(id);
            try
            {

                return  _imapper.Map<List<DiscTbl>, List<DiscDTO>>(listdisc);
            }
            catch
            {
                throw new Exception("not succeed DeleateDisc!!");
            }
        }

        public List<DiscDTO> GetAllDisc()
        {
            List<DiscTbl> listdisc = _DiscDAL.GetAllDisc();
            try
            {

                return _imapper.Map<List<DiscTbl>, List<DiscDTO>>(listdisc);
            }
            catch
            {
                throw new Exception("not succeed GetAllDisc!!");
            }
        }

        public DiscDTO GetDiscById(int id)
        {
            DiscTbl d = _DiscDAL.GetDiscById(id);
            try
            {
                return _imapper.Map<DiscTbl, DiscDTO>(d);
            }
            catch
            {
                throw new Exception("not succeed GetDiscById!!");
            }
        }

        public List<DiscDTO>  GetDiscByIdSinger(int id)
        {
            List<DiscTbl> discList = _DiscDAL.GetDiscByIdSinger(id);
            try
            {
                return _imapper.Map<List<DiscTbl>, List<DiscDTO>>(discList);
            }
            catch
            {
                throw new Exception("not succeed GetDiscByIdSinger!!");
            }
        }

        public List<DiscDTO> UpdateDisc(DiscDTO d)
        {
            DiscTbl disc = _imapper.Map<DiscDTO, DiscTbl>(d);
            List<DiscTbl> discList= _DiscDAL.UpdateDisc(disc);
            try
            {
                return _imapper.Map<List<DiscTbl>,List<DiscDTO>>(discList);
            }
            catch
            {
                throw new Exception("not succeed UpdateDisc!!");
            }
        }
    }
}
