using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
    public interface IDiscBLL
    {
        List<DiscDTO> GetAllDisc();

        DiscDTO GetDiscById(int id);

        List<DiscDTO> GetDiscByIdSinger(int id);

        List<DiscDTO> UpdateDisc(DiscDTO d);

        List<DiscDTO> AddDisc(DiscDTO d);

        List<DiscDTO> DeleateDisc(int id);
    }
}
