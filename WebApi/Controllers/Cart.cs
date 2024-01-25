using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL;
using DAL.Models;
using DTO;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class Cart : ControllerBase
    {
        ICartBLL _CartBLL;
        public Cart(ICartBLL CartBLL)
        {
            _CartBLL = CartBLL;
        }

        // POST api/<controller>
        [HttpPost("AddToCart/{id}")]
        public IActionResult AddCuotomer(short id,[FromBody] List<CartDTO> c)
        {
            
            return Ok(_CartBLL.AddCart(id, c));
        }


    }
}
