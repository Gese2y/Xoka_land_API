using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.procLicenceServiceForSingleWin.GetprocLicenceServiceForSingleWinLoadAll;

namespace Application.dbo.Quiries.procLicenceServiceForSingleWin.GetprocLicenceServiceForSingleWinByPrimaryKey
{
    /// @author  Shimels Alem proc_Licence_Service_For_Single_WinLoadByPrimaryKey stored procedure.

    public class GetprocLicenceServiceForSingleWinByPrimaryKey : IRequest<GetprocLicenceServiceForSingleWinLoadAllListVm>
    {
        public System.Guid Licence_Id { get; set; }
    }
}
