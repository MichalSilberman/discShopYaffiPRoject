using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class Singer : ControllerBase
    {
        ISingerBLL _SingerBLL;

        public Singer(ISingerBLL SingerBLL)
        {
            _SingerBLL = SingerBLL;
        }

        // GET: api/<controller>
        [HttpGet("GetAllSingers")]
        public IActionResult GetAllSingers()
        {
            return Ok(_SingerBLL.GetAllSingers());
        }

        // GET api/<controller>/5
        [HttpGet("GetSingerById/{id}")]
        public IActionResult GetSingerById(int id)
        {
            return Ok(_SingerBLL.GetSingerById(id));
        }

        // POST api/<controller>
        [HttpPost("AddSinger")]
        public IActionResult AddSinger([FromBody] SingerDTO s)
        {
            return Ok(_SingerBLL.AddSinger(s));
        }

        // PUT api/<controller>/5
        [HttpPut("UpdateSinger")]
        public IActionResult UpdateSinger([FromBody] SingerDTO s)
        {
            return Ok(_SingerBLL.UpdateSinger(s));
        }

        // DELETE api/<controller>/5
        [HttpDelete("DeleateSinger/{id}")]
        public IActionResult DeleateSinger(int id)
        {
            return Ok(_SingerBLL.DeleateSinger(id));
        }
    }
}
