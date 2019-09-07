using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.InterFaces;
using Wistham.ViewModel;

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
        public IActionResult Get()
        {
            try
            {
                var Camerainfo = _unitOfWork.CameraInfoRepository.Get().ToList();
                return new ObjectResult(Camerainfo);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET: api/GetInfo/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GetInfo
        [HttpPost]
        public IActionResult Post([FromBody] GetCameraInfo cameraInfo)
        {
            try
            {
                var user = _unitOfWork.UserRepository.Get(a => a.UserName == cameraInfo.UserName & a.Password == cameraInfo.Password);
                if (user.Any())
                {
                    var Camerainfo = _unitOfWork.CameraInfoRepository.Get(a => a.CameraId == Convert.ToInt32(cameraInfo.CameraId)).ToList();
                    return new ObjectResult(Camerainfo);
                }
                else
                {
                    return StatusCode((int)HttpStatusCode.Unauthorized, "Login Faild");
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

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
