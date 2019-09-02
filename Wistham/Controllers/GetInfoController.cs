using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.InterFaces;

namespace Wistham.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetInfoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/GetInfo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GetInfo/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GetInfo
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GetInfo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
