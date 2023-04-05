using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procIncomeTax.GetprocIncomeTaxLoadAll;

namespace Application.Tax.Quiries.procIncomeTax.GetprocIncomeTaxByPrimaryKey
{
    /// @author  Shimels Alem proc_Income_TaxLoadByPrimaryKey stored procedure.

    public class GetprocIncomeTaxByPrimaryKey : IRequest<GetprocIncomeTaxLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
