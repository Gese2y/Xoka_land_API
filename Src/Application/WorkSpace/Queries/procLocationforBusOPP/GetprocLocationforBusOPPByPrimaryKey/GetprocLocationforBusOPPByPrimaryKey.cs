using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procLocationforBusOPP.GetprocLocationforBusOPPLoadAll;

namespace Application.WorkSpace.Quiries.procLocationforBusOPP.GetprocLocationforBusOPPByPrimaryKey
{
    /// @author  Shimels Alem proc_Location_for_Bus_OPPLoadByPrimaryKey stored procedure.

    public class GetprocLocationforBusOPPByPrimaryKey : IRequest<GetprocLocationforBusOPPLoadAllListVm>
    {
        public System.Guid BUS_OPP_Loc_Code { get; set; }
    }
}
