


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procExamCentor.procExamCentorInsert.procExamCentorInsertCommand
{

    /// @author  Shimels Alem  proc_Exam_CentorInsert stored procedure.


    public class procExamCentorInsertCommand : IRequest<IList<ExamCentor_CentorCode>>
    {
        public string Centor_Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public System.Guid Org_Code { get; set; }
    }
		
		
		 
}
 
 