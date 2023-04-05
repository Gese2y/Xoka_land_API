


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEducation.procEducationInsert.procEducationInsertCommand
{

	/// @author  Shimels Alem  proc_EducationInsert stored procedure.


	public class procEducationInsertCommand : IRequest<IList<Education_ID>>
    {
        public System.Guid ID { get; set; }
        public string EMP_TIN { get; set; }
        public string Level { get; set; }
        public string Instiutution { get; set; }
        public System.DateTime? Graduate_Date { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public System.Guid? Created_By { get; set; }
        public System.Guid? Updated_By { get; set; }
        public System.Byte[]? Date_log { get; set; }
        public string Eduction_Types { get; set; }
    }
		
		
		 
}
 
 