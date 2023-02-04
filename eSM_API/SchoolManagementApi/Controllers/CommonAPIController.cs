using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Model.Model;
using SchoolManagement.Service.IService;

namespace SchoolManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonAPIController : ControllerBase
    {
        private readonly ICommonAPI _common;
        public CommonAPIController(ICommonAPI common)
        {
                _common= common;
        }
        [HttpGet]
        [Route("GetMonthList")]
        public Response GetMonthList()
        {
           var data = _common.GetMonthName();
            return data;
        }
    }
}
