


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.UnEmployment.Commands.procEmploymentExperience.procEmploymentExperienceInsert.procEmploymentExperienceInsertCommand
{

	/// @author  Shimels Alem  proc_Employment_ExperienceInsert stored procedure.


	public class procEmploymentExperienceInsertCommand : IRequest<IList<EmploymentExperience_ID>>
    {
		public System.Guid ID { get; set; }
		public string EMP_TIN { get; set; }
		public string EMP_Pension_NO { get; set; }
		public string Types_of_employment { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.Double? basic_Salary { get; set; }
		public string Reference { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.Byte[]? Date_log { get; set; }
		public string Job_Position_ID { get; set; }
	}
		
		
		 
}
 
 