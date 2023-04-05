using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procBussRelationInput.GetprocBussRelationInputLoadAll;

namespace Application.Job.Quiries.procBussRelationInput.GetprocBussRelationInputByPrimaryKey
{
    /// @author  Shimels Alem proc_Buss_Relation_InputLoadByPrimaryKey stored procedure.

    public class GetprocBussRelationInputByPrimaryKey : IRequest<GetprocBussRelationInputLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
