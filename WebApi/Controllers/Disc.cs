using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DTO;
using BLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class Disc : ControllerBase
    {
        IDiscBLL _DiscBLL;
        public Disc(IDiscBLL DiscBLL)
        {
            _DiscBLL = DiscBLL;
        }
        // GET: api/<controller>
        [HttpGet("GetAllDisc")]
        public IActionResult GetAllDisc()
        {
            return Ok(_DiscBLL.GetAllDisc());
        }

        // GET api/<controller>/5
        [HttpGet("GetDiscById/{id}")]
        public IActionResult GetDiscById(int id)
        {
            return Ok(_DiscBLL.GetDiscById(id));
        }

        // GET api/<controller>/5
        [HttpGet("GetDiscByIdSinger/{id}")]
        public IActionResult GetDiscByIdSinger(int id)
        {
            return Ok(_DiscBLL.GetDiscByIdSinger(id));
        }

        // POST api/<controller>
        [HttpPost("AddDisc")]
        public IActionResult AddDisc([FromBody] DiscDTO d)
        {
            return Ok(_DiscBLL.AddDisc(d));
        }

        // PUT api/<controller>/5
        [HttpPut("UpdateDisc")]
        public IActionResult UpdateDisc([FromBody] DiscDTO d)
        {
            return Ok(_DiscBLL.UpdateDisc(d));
        }

        // DELETE api/<controller>/5
        [HttpDelete("DeleateDisc/{id}")]
        public IActionResult DeleateDisc(int id)
        {
            return Ok(_DiscBLL.DeleateDisc(id));
        }
    }
}
