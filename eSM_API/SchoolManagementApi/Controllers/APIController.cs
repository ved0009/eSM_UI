using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Model.Model;
using SchoolManagement.Service.Repositry;

namespace SchoolManagementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : ControllerBase
    {

        private readonly IDapperConnection _dapper;
        Response response;

        public APIController(IDapperConnection dapper)
        {
            _dapper = dapper;
        }

      
        [HttpGet]
        [Route("IsApiRunning")]
        public Response IsRunningApi()
        {
            using (response = new Response())
            {
                try
                {
                    var data = "Api is on running mode";
                    //var data = _dapper.GetDbconnection();
                    var date = new DateTime();
                    response.success = true;
                    response.message = "SuccessFully";
                    response.responseData = data;
                    response.responseData2 = date;
                       
                }
                catch (Exception)
                {

                    response.success = false;
                    response.message = "SuccessFully";
                    response.responseData = "Database connection error";
                }
            }
           
            return response;
        }
        //[HttpPost]
        //[Route("PostData")]
        //public JsonResult PostData()
        //{
        //    return new JsonResult( true);
        //}
        //[HttpDelete]
        //[Route("PostDelete")]
        //public JsonResult PostDelete()
        //{
        //    return new JsonResult(true);
        //}
        //[HttpHead]
        //[Route("PostHead")]
        //public JsonResult PostHead()
        //{
        //    return new JsonResult(true);
        //}
        //[HttpPut]
        //[Route("PostPut")]
        //public JsonResult PostUpdate()
        //{
        //    return new JsonResult(true);
        //}
        //[HttpOptions]
        //[Route("PostOption")]
        //public JsonResult PostOption()
        //{
        //    return new JsonResult(true);
        //}
    }
}