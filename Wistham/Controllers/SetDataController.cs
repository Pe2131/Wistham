using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.InterFaces;
using Wistham.ViewModel;

namespace Wistham.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetDataController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SetDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/SetData
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // POST: api/SetData
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SetData Data)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                CameraInfo cameraInfo = new CameraInfo {
                    CameraId = Data.CameraId,
                    Description = Data.Description,
                    ImageDataArray = Data.ImageDataArray,
                    ImageDatatype = Data.ImageDatatype,
                    ImageDateTime=Data.ImageDateTime,
                    ImageName=Data.ImageName,
                    ImageUnicId=Data.ImageUnicId,
                    ImageUrl=Data.ImageUrl
                };
                _unitOfWork.CameraInfoRepository.Insert(cameraInfo);
                await _unitOfWork.CameraInfoRepository.Save();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT: api/SetData/5
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
