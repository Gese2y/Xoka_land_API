using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procShedStatus.GetprocShedStatusLoadAll;

namespace Application.WorkSpace.Quiries.procShedStatus.GetprocShedStatusByPrimaryKey
{
    /// @author  Shimels Alem proc_Shed_StatusLoadByPrimaryKey stored procedure.

    public class GetprocShedStatusByPrimaryKey : IRequest<GetprocShedStatusLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
