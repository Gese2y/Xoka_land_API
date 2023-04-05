using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procCapital.GetprocCapitalLoadAll;

namespace Application.Trade.Quiries.procCapital.GetprocCapitalByPrimaryKey
{
    /// @author  Shimels Alem proc_CapitalLoadByPrimaryKey stored procedure.

    public class GetprocCapitalByPrimaryKey : IRequest<GetprocCapitalLoadAllListVm>
    {
        public System.Guid Capital_ID { get; set; }
    }
}
