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
    public class Customer : ControllerBase
    {
        ICustomerBLL _CustomerBLL;
        public Customer(ICustomerBLL CustomerBLL)
        {
            _CustomerBLL = CustomerBLL;
        }

        // GET api/<Customer>/5
        [HttpGet("GetCuotomerByPass/{pass}")]
        public IActionResult GetCuotomerByPass(string pass)
        {
            return Ok(_CustomerBLL.GetCuotomerByPass(pass));
        }

        // POST api/<controller>
        [HttpPost("AddCuotomer")]
        public IActionResult AddCuotomer([FromBody]CustomerDTO c)
        {
            return Ok(_CustomerBLL.AddCuotomer(c));
        }

        
    }
}
