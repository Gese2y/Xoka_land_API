using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procBazarAndExhibition.GetprocBazarAndExhibitionLoadAll;

namespace Application.Job.Quiries.procBazarAndExhibition.GetprocBazarAndExhibitionLoadByPrimaryKeyOPPID
{
    /// @author  Shimels Alem proc_Bazar&ExhibitionLoadByPrimaryKey_OPP_ID stored procedure.

    public class GetprocBazarAndExhibitionLoadByPrimaryKeyOPPID : IRequest<GetprocBazarAndExhibitionLoadAllListVm>
    {
        public System.Guid OPP_ID { get; set; }
    }
}
