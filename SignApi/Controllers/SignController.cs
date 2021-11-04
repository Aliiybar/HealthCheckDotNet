using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignApi.Entities;
using SignApi.DAL;

namespace SignApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignController : ControllerBase
    {
        private readonly SignContext _signContext;

        public SignController(SignContext signContext)
        {
            _signContext = signContext;
        }
        [HttpGet]
        public IEnumerable<Sign> Get()
        {
            return _signContext.Signs.ToArray();
        }


        [HttpPost]
        public IActionResult Post()
        {
            var sign = new Sign { Id = Guid.NewGuid(), SignName = "S002", Location = "Sale" };
            _signContext.Signs.Add(sign);

            _signContext.SaveChanges();
            return Ok("OK");
        }
    }
}
