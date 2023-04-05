using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procBusinessOppoForjobCreation.GetprocBusinessOppoForjobCreationLoadAll;

namespace Application.Job.Quiries.procBusinessOppoForjobCreation.GetprocBusinessOppoForjobCreationByPrimaryKey
{
    /// @author  Shimels Alem proc_Business_Oppo_For__job_CreationLoadByPrimaryKey stored procedure.

    public class GetprocBusinessOppoForjobCreationByPrimaryKey : IRequest<GetprocBusinessOppoForjobCreationLoadAllListVm>
    {
        public System.Guid BUS_OPP_ID { get; set; }
    }
}
