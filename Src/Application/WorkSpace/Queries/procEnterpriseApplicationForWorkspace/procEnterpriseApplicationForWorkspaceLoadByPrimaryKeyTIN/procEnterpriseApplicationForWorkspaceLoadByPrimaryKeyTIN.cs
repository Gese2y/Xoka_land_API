using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.GetprocEnterpriseApplicationForWorkspaceLoadAll;

namespace Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceLoadByPrimaryKeyTIN
{
    /// @author  Shimels Alem proc_Enterprise_Application_For_WorkspaceLoadByPrimaryKey_TIN stored procedure.

    public class procEnterpriseApplicationForWorkspaceLoadByPrimaryKeyTIN : IRequest<GetprocEnterpriseApplicationForWorkspaceLoadAllListVm>
    {
        public string TIN { get; set; }
    }
}
