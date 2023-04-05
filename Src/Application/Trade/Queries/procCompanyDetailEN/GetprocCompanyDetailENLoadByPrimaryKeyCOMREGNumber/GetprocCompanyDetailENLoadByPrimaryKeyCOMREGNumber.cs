using MediatR;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENLoadAll;

namespace Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENLoadByPrimaryKeyCOMREGNumber
{
    /// @author  Shimels Alem proc_Company_Detail_ENLoadByPrimaryKey_COM_REG_Number stored procedure.

    public class GetprocCompanyDetailENLoadByPrimaryKeyCOMREGNumber : IRequest<GetprocCompanyDetailENLoadAllListVm>
    {
        public string COM_REG_Number { get; set; }
    }
}
