using Dapper;
using SchoolManagement.Model.Model;
using SchoolManagement.Service.IService;
using SchoolManagement.Service.Repositry;
using System.Data;

namespace SchoolManagement.Service.Service
{
    public class SCommonAPI : ICommonAPI
    {
        private readonly IDapperConnection _dapper;
        Response response;
        public SCommonAPI(IDapperConnection dapper)
        {
            _dapper = dapper;
        }
        public Response GetMonthName()
        {
            using (response = new Response())
            {
                try
                {
                    List<MMonthName> monthList = new List<MMonthName>();
                    var dbparams = new DynamicParameters();

                    monthList = _dapper.GetAll<MMonthName>("sp_Get_MonthName", dbparams, commandType: CommandType.StoredProcedure);
                    
                    if (monthList.Count > 0)
                    {
                        response.success = true;
                        response.message = "Success";
                        response.responseData = monthList;
                        response.RecordsTotal= monthList.Count;
                        
                    }
                    else
                    {
                        response.success = false;
                        response.message = "fail";
                        response.responseData = "No record";
                    }
                }
                catch (Exception ex)
                {

                    response.success = false;
                    response.message = "Api error ahead";
                    response.responseData = ex.Message;
                }
            }
            return response;
        }
    }
}
