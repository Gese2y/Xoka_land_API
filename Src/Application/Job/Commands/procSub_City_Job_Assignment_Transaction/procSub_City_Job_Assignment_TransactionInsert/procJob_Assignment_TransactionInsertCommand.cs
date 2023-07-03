


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procSub_City_Job_Assignment_Transaction.procSub_City_Job_Assignment_TransactionInsert.procSub_City_Job_Assignment_TransactionInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procSub_City_Job_Assignment_TransactionInsertCommand : IRequest<IList<Sub_City_Job_Assignment_Transaction_ID>>
    {
        public System.Guid Transaction_ID { get; set; }
        public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
        public Nullable<System.Guid> Sub_City { get; set; }
        public Nullable<double> Number_Of_Person { get; set; }
        public string Approval_Justification_Doc { get; set; }
        public string Created_By { get; set; }
    }
		
		
		 
}
 
 