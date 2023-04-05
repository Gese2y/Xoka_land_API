using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procSector.GetprocSectorLoadAll;

namespace Application.Trade.Quiries.procSector.GetprocSectorByPrimaryKey
{
    /// @author  Shimels Alem proc_Business_ActivityLoadByPrimaryKey stored procedure.

    public class GetprocSectorByPrimaryKey : IRequest<GetprocSectorLoadAllListVm>
    {
        public string S_Code { get; set; }
       
    }
}
