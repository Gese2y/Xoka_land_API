using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procSub_City_Job_Assignment_Transaction.GetprocSub_City_Job_Assignment_TransactionLoadAll;

namespace Application.Job.Quiries.procSub_City_Job_Assignment_Transaction.Getproc_Sub_City_Job_Assignment_TransactionLoadByPrimaryKeyforsubcity
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class Getproc_Sub_City_Job_Assignment_TransactionLoadByPrimaryKeyforsubcity : IRequest<GetprocSub_City_Job_Assignment_TransactionLoadAllListVm>
    {
        public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
        public Nullable<System.Guid> Sub_City { get; set; }

    }
}
