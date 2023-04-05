using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceLoadAll;

namespace Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceByPrimaryKey
{
    /// @author  Shimels Alem proc_Work_SpaceLoadByPrimaryKey stored procedure.

    public class GetprocWorkSpaceByPrimaryKey : IRequest<GetprocWorkSpaceLoadAllListVm>
    {
        public System.Guid Work_Space_ID { get; set; }
    }
}
