


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterprise_Grade_Points_Details.procEnterprise_Grade_Points_DetailsInsert.procEnterprise_Grade_Points_DetailsInsertCommand
{

	/// @author  Shimels Alem  proc_Enterprise_RegistrationInsert stored procedure.


	public class procEnterprise_Grade_Points_DetailsInsertCommand : IRequest<IList<Enterprise_Grade_Points_Details_ID>>
    {
        public string ID { get; set; }
        public DateTime Date_Graded { get; set; }
        public string Filled_By { get; set; }
        public string JSON_Value { get; set; }
        public string Enterprise_TIN { get; set; }
    }
		
		
		 
}
 
 