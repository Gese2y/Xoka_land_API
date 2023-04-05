


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceInsert.procEnterpriseApplicationForWorkspaceInsertCommand
{

    /// @author  Shimels Alem  proc_Enterprise_Application_For_WorkspaceInsert stored procedure.


    public class procEnterpriseApplicationForWorkspaceInsertCommand : IRequest<IList<EnterpriseApplicationForWorkspace_EAFWID>>
    {
        public System.Guid EAFW_ID { get; set; }
        public string TIN { get; set; }
        public System.Double? Size_M2 { get; set; }
        public string Application { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IsSubmited { get; set; }
        public System.DateTime? App_Date { get; set; }
        public System.Guid? Application_code { get; set; }
        public System.Guid? Licence_ID { get; set; }
    }
		
		
		 
}
 
 