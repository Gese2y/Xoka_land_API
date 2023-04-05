using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procJob_Assignment_Transaction.GetprocJob_Assignment_TransactionLoadAll;

namespace Application.Job.Quiries.procJob_Assignment_Transaction.GetprocJob_Assignment_TransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocJob_Assignment_TransactionByPrimaryKey : IRequest<GetprocJob_Assignment_TransactionLoadAllListVm>
    {
        public System.Guid Transaction_ID { get; set; }
      
    }
}
