﻿using SchoolManagement.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Service.IService
{
    public interface IMasterCommon
    {
        public Response StramName();
        public Response GetBankBranch();
        public Response GetCast();
        public Response GetTotal();

    }
}
