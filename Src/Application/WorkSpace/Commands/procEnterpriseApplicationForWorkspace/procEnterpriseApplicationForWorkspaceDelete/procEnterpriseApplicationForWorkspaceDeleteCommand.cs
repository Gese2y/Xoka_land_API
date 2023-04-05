 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceDelete.procEnterpriseApplicationForWorkspaceDeleteCommand
{

    // @author  Shimels Alem  proc_Enterprise_Application_For_WorkspaceDelete stored procedure.

    public class procEnterpriseApplicationForWorkspaceDeleteCommand : IRequest<IList<EnterpriseApplicationForWorkspace_EAFWID>>
    {
        public System.Guid EAFW_ID { get; set; }
    }
		
     
		
		 
}
 
 