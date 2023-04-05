using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.GetprocEnterpriseApplicationForWorkspaceLoadAll;

namespace Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.GetprocEnterpriseApplicationForWorkspaceByPrimaryKey
{
    /// @author  Shimels Alem proc_Enterprise_Application_For_WorkspaceLoadByPrimaryKey stored procedure.

    public class GetprocEnterpriseApplicationForWorkspaceByPrimaryKey : IRequest<GetprocEnterpriseApplicationForWorkspaceLoadAllListVm>
    {
        public System.Guid EAFW_ID { get; set; }
    }
}
