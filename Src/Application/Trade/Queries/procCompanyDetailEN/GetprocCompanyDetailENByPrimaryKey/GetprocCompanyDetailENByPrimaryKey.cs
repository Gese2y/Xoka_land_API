using MediatR;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENLoadAll;

namespace Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENByPrimaryKey
{
    /// @author  Shimels Alem proc_Company_Detail_ENLoadByPrimaryKey stored procedure.

    public class GetprocCompanyDetailENByPrimaryKey : IRequest<GetprocCompanyDetailENLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
