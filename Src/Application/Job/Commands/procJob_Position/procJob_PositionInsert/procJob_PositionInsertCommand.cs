


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJob_Position.procJob_PositionInsert.procJob_PositionInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procJob_PositionInsertCommand : IRequest<IList<Job_Position_Id>>
    {
        public string Job_Position_ID { get; set; }
        public string Position_Name { get; set; }
        public string Parent_ID { get; set; }
    }
		
		
		 
}
 
 