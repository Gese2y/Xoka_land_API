


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.UnEmployment;

namespace Application.UnEmployment.Commands.procunEmployeeRequest.procunEmployeeRequestInsert.procunEmployeeRequestInsertCommand
{

	/// @author  Shimels Alem  proc_unEmployeeRequestInsert stored procedure.


	public class procunEmployeeRequestInsertCommand : IRequest<IList<unEmployeeRequest_Id>>
    {
		public System.Guid Id { get; set; }
		public string TIN { get; set; }
		public string Vital_ID { get; set; }
		public string Full_Name { get; set; }
		public string Type { get; set; }
		public byte[] Photo { get; set; }
		public string Region { get; set; }
		public string Zone { get; set; }
		public string Woreda { get; set; }
		public string kebele { get; set; }
		public string House_Number { get; set; }
		public string Mobile_No { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public byte[] Date_log { get; set; }
		public System.Guid? Licence_Service_Id { get; set; }
	}
		
		
		 
}
 
 