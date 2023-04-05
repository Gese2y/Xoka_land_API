using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procPayment.GetprocPaymentLoadAll;

namespace Application.Job.Quiries.procPayment.GetprocPaymentByPrimaryKey
{
    /// @author  Shimels Alem proc_AssetsLoadByPrimaryKey stored procedure.

    public class GetprocPaymentByPrimaryKey : IRequest<GetprocPaymentLoadAllListVm>
    {
        public System.Guid PID { get; set; }
    }
}
