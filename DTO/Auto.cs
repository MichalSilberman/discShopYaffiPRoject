using System;
using DAL.Models;

namespace DTO
{
    public class Auto: AutoMapper.Profile
    {
        public Auto()
        {
            CreateMap<SingerTbl, SingerDTO>();
            CreateMap<SingerDTO, SingerTbl>();

            CreateMap<ShoppingTbl, ShoppingDTO>();
            CreateMap<ShoppingDTO, ShoppingTbl>();

            CreateMap<CustomerTbl, CustomerDTO>();
            CreateMap<CustomerDTO, CustomerTbl>();

            CreateMap<DetailsShoppingTbl, DetailsShoppingDTO>();
            CreateMap<DetailsShoppingDTO, DetailsShoppingTbl>();

            CreateMap<DiscTbl, DiscDTO>();
            CreateMap<DiscDTO, DiscTbl>();
        }
    }
}
