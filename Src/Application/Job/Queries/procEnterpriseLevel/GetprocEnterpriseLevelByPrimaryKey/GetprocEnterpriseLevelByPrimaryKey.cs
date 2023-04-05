using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEnterpriseLevel.GetprocEnterpriseLevelLoadAll;

namespace Application.Job.Quiries.procEnterpriseLevel.GetprocEnterpriseLevelByPrimaryKey
{
    /// @author  Shimels Alem proc_Enterprise_LevelLoadByPrimaryKey stored procedure.

    public class GetprocEnterpriseLevelByPrimaryKey : IRequest<GetprocEnterpriseLevelLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
