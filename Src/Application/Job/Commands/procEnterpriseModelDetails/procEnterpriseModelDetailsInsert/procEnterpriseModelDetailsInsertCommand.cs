


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterpriseModelDetails.procEnterpriseModelDetailsInsert.procEnterpriseModelDetailsInsertCommand
{

	/// @author  Shimels Alem  proc_Enterprise_RegistrationInsert stored procedure.


	public class procEnterpriseModelDetailsInsertCommand : IRequest<IList<Enterprise_Model_Details_ID>>
    {
        public System.Guid Ent_Model_Detail_ID { get; set; }
        public string TIN { get; set; }
        public byte[] Model_Evaluation_Letter { get; set; }
        public Nullable<System.DateTime> Date_Of_Model_Selection { get; set; }
        public Nullable<double> Point_Earned { get; set; }
        public string Remarks { get; set; }
    }
		
		
		 
}
 
 