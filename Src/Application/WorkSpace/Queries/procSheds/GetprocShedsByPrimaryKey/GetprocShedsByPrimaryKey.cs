using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procSheds.GetprocShedsLoadAll;

namespace Application.WorkSpace.Quiries.procSheds.GetprocShedsByPrimaryKey
{
    /// @author  Shimels Alem proc_ShedsLoadByPrimaryKey stored procedure.

    public class GetprocShedsByPrimaryKey : IRequest<GetprocShedsLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
