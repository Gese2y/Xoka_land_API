using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procJob_Match.GetprocJob_MatchLoadAll;

namespace Application.Job.Quiries.procJob_Match.GetprocJob_MatchByTransactionID
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByTransactionIDstored procedure.

    public class GetprocJob_MatchByTransactionID: IRequest<GetprocJob_MatchLoadAllListVm>
    {
        public System.Guid Transaction_ID { get; set; }
    }
}
