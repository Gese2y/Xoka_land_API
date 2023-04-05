using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procBazarAndExhibition.GetprocBazarAndExhibitionLoadAll;

namespace Application.Job.Quiries.procBazarAndExhibition.GetprocBazarAndExhibitionByPrimaryKey
{
    /// @author  Shimels Alem proc_Bazar&ExhibitionLoadByPrimaryKey stored procedure.

    public class GetprocBazarAndExhibitionByPrimaryKey : IRequest<GetprocBazarAndExhibitionLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
