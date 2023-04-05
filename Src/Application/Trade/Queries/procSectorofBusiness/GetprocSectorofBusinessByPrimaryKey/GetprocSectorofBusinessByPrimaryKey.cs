using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procSectorofBusiness.GetprocSectorofBusinessLoadAll;

namespace Application.Trade.Quiries.procSectorofBusiness.GetprocSectorofBusinessByPrimaryKey
{
    /// @author  Shimels Alem proc_Sector_of_BusinessLoadByPrimaryKey stored procedure.

    public class GetprocSectorofBusinessByPrimaryKey : IRequest<GetprocSectorofBusinessLoadAllListVm>
    {
        public string TIN { get; set; }
        public string Code { get; set; }
    }
}
