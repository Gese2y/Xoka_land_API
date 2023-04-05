using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procInstalments.GetprocInstalmentsLoadAll;

namespace Application.SaveCredit.Quiries.procInstalments.GetprocInstalmentsByPrimaryKey
{
    /// @author  Shimels Alem proc_InstalmentsLoadByPrimaryKey stored procedure.

    public class GetprocInstalmentsByPrimaryKey : IRequest<GetprocInstalmentsLoadAllListVm>
    {
        public System.Guid contract_id { get; set; }
        public System.Int32 number { get; set; }
    }
}
