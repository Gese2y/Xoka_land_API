using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procCompanyDetailAM.GetprocCompanyDetailAMLoadAll;

namespace Application.Trade.Quiries.procCompanyDetailAM.GetprocCompanyDetailAMByPrimaryKey
{
    /// @author  Shimels Alem proc_Company_Detail_AMLoadByPrimaryKey stored procedure.

    public class GetprocCompanyDetailAMByPrimaryKey : IRequest<GetprocCompanyDetailAMLoadAllListVm>
    {
        public Guid ID { get; set; }
    }
}
