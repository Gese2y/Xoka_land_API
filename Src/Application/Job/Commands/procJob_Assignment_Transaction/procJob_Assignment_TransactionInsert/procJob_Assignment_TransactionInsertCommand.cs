


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJob_Assignment_Transaction.procJob_Assignment_TransactionInsert.procJob_Assignment_TransactionInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procJob_Assignment_TransactionInsertCommand : IRequest<IList<Job_Assignment_Transaction_ID>>
    {
        public System.Guid Transaction_ID { get; set; }
        public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
        public Nullable<System.Guid> Woreda { get; set; }
        public Nullable<double> Number_Of_Person { get; set; }
        public string Approval_Justification_Doc { get; set; }
    }
		
		
		 
}
 
 