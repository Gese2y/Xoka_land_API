using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceLoadAll;

namespace Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceByparentKey
{
    /// @author  Shimels Alem proc_Work_SpaceLoadByPrimaryKey stored procedure.

    public class GetprocWorkSpaceByParentKey : IRequest<GetprocWorkSpaceLoadAllListVm>
    {
        public System.Guid Work_Space_ID { get; set; }
    }
}
