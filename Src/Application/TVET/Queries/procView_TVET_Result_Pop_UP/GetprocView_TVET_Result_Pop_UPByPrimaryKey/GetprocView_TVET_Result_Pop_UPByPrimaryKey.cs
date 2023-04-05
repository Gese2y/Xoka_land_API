using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procView_TVET_Result_Pop_UP.GetprocView_TVET_Result_Pop_UPLoadAll;

namespace Application.TVET.Quiries.procView_TVET_Result_Pop_UP.GetprocView_TVET_Result_Pop_UPByPrimaryKey
{
    /// @author  Shimels Alem proc_View_TVET_Result_Pop_UPLoadByPrimaryKey stored procedure.

    public class GetprocView_TVET_Result_Pop_UPByPrimaryKey : IRequest<GetprocView_TVET_Result_Pop_UPLoadAllListVm>
    {
        public Guid EID { get; set; }
    }
}
