using Dapper;
using SchoolManagement.Model.Model;
using SchoolManagement.Service.IService;
using SchoolManagement.Service.Repositry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Service.Service
{
    public class SMasterCommon : IMasterCommon
    {
        private readonly IDapperConnection _dapper;
        Response response;
        public SMasterCommon(IDapperConnection connection)
        {
            _dapper = connection;
        }

        public Response GetBankBranch()
        {
            using (response = new Response())
            {
                try
                {
                    List<MBankBranch> backCranchList = new List<MBankBranch>();
                    var dbparams = new DynamicParameters();

                    backCranchList = _dapper.GetAll<MBankBranch>("sp_get_BankBranchName", dbparams, commandType: CommandType.StoredProcedure);

                    if (backCranchList.Count > 0)
                    {
                        response.success = true;
                        response.message = "Success";
                        response.responseData = backCranchList;
                        response.RecordsTotal = backCranchList.Count;

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

        public Response GetCast()
        {
            using (response = new Response())
            {
                try
                {
                    List<MCast> castList = new List<MCast>();
                    var dbparams = new DynamicParameters();

                    castList = _dapper.GetAll<MCast>("sp_get_CastName", dbparams, commandType: CommandType.StoredProcedure);

                    if (castList.Count > 0)
                    {
                        response.success = true;
                        response.message = "Success";
                        response.responseData = castList;
                        response.RecordsTotal = castList.Count;

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

        public Response GetTotal()
        {
            throw new NotImplementedException();
        }

        public Response StramName()
        {
            using (response = new Response())
            {
                try
                {
                    List<MStreamName> streamList = new List<MStreamName>();
                    var dbparams = new DynamicParameters();

                    streamList = _dapper.GetAll<MStreamName>("sp_get_StreamName", dbparams, commandType: CommandType.StoredProcedure);

                    if (streamList.Count > 0)
                    {
                        response.success = true;
                        response.message = "Success";
                        response.responseData = streamList;
                        response.RecordsTotal = streamList.Count;

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
