


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procMSEwarning.procMSEwarningInsert.procMSEwarningInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procMSEwarningInsertCommand : IRequest<IList<MSEwarning_ID>>
    {
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public string Warning_Code { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }

		public byte[] Warning_Letter_Doc { get; set; }
	}
		
		
		 
}
 
 