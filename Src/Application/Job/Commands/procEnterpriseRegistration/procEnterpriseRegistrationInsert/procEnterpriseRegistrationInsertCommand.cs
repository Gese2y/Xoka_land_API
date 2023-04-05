


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterpriseRegistration.procEnterpriseRegistrationInsert.procEnterpriseRegistrationInsertCommand
{

	/// @author  Shimels Alem  proc_Enterprise_RegistrationInsert stored procedure.


	public class procEnterpriseRegistrationInsertCommand : IRequest<IList<EnterpriseRegistration_TIN>>
    {
		public string TIN { get; set; }
		public string MSE_Code { get; set; }
		public string Name { get; set; }
		public System.Guid? BUS_OPP_Loc_Code { get; set; }
		public string ENT_Type { get; set; }
		public System.Double? Capital_In_Birr { get; set; }
		public string Ent_Level { get; set; }
		public System.Int32? Number_of_Emplyee_Need { get; set; }
		public long? VAT { get; set; }
		public string Sector_ID { get; set; }
		public System.Guid? Region { get; set; }
		public System.Guid? Zone { get; set; }
		public System.Guid? Woreda { get; set; }
		public string Hous_No { get; set; }
		public string GM_Name { get; set; }
		public string Phone1 { get; set; }
		public string Phone2 { get; set; }
		public string Email { get; set; }
		public string Website { get; set; }
		public System.Guid? Licence_ID { get; set; }
		public string Location_x { get; set; }
		public string Location_y { get; set; }
		public string Enterprises_grading_levels { get; set; }
		public string Model_Status { get; set; }
		public string Ownership_Type { get; set; }
		public string Sub_Sector { get; set; }
	}
		
		
		 
}
 
 