using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procbussinessRelationMKT.GetprocbussinessRelationMKTLoadAll;

namespace Application.Job.Quiries.procbussinessRelationMKT.GetprocbussinessRelationMKTByPrimaryKey
{
    /// @author  Shimels Alem proc_bussiness_Relation_MKTLoadByPrimaryKey stored procedure.

    public class GetprocbussinessRelationMKTByPrimaryKey : IRequest<GetprocbussinessRelationMKTLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
