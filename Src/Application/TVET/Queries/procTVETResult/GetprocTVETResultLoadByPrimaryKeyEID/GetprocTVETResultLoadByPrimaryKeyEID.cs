using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procTVETResult.GetprocTVETResultLoadAll;

namespace Application.TVET.Quiries.procTVETResult.GetprocTVETResultLoadByPrimaryKeyEID
{
    /// @author  Shimels Alem proc_TVET_ResultLoadByPrimaryKey_EID stored procedure.

    public class GetprocTVETResultLoadByPrimaryKeyEID : IRequest<GetprocTVETResultLoadAllListVm>
    {
        public System.Guid EID { get; set; }
    }
}
