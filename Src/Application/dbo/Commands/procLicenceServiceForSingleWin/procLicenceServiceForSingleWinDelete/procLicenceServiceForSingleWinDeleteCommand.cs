 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procLicenceServiceForSingleWin.procLicenceServiceForSingleWinDelete.procLicenceServiceForSingleWinDeleteCommand
{

    // @author  Shimels Alem  proc_Licence_Service_For_Single_WinDelete stored procedure.

    public class procLicenceServiceForSingleWinDeleteCommand : IRequest<IList<LicenceServiceForSingleWin_LicenceId>>
    {
        public System.Guid Licence_Id { get; set; }
    }
		
     
		
		 
}
 
 