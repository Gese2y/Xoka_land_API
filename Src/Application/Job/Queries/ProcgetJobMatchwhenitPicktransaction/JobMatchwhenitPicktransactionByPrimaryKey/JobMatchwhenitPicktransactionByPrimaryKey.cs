using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.ProcgetJobMatchwhenitPicktransaction.JobMatchwhenitPicktransactionLoadAll;

namespace Application.Job.Quiries.ProcgetJobMatchwhenitPicktransaction.JobMatchwhenitPicktransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_AssetsLoadByPrimaryKey stored procedure.

    public class JobMatchwhenitPicktransactionByPrimaryKey : IRequest<JobMatchwhenitPicktransactionLoadAllListVm>
    {
        public System.Guid? Transaction_ID { get; set; }
    }
}
