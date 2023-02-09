using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Model.Model;
using SchoolManagement.Service.IService;

namespace SchoolManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterCommonController : ControllerBase
    {
        private readonly IMasterCommon _master;
        Response response;
        public MasterCommonController(IMasterCommon master)
        {
            _master = master;
        }

        [HttpGet, Route("GetStreamName")]
        public Response GetStreamName()
        {
            var data = _master.StramName();
            return data;
        }
        [HttpGet, Route("GetBankBranch")]
        public Response GetBankBranch()
        {
            var data = _master.GetBankBranch();
            return data;
        }
        [HttpGet, Route("GetCast")]
        public Response GetCast()
        {
            var data = _master.GetCast();
            return data;
        }


    }
}
