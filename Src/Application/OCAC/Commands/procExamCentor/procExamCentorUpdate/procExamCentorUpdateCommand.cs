using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.OCAC;

namespace Application.OCAC.Commands.procExamCentor.procExamCentorUpdate.procExamCentorUpdateCommand
{

    /// @author  Shimels Alem  proc_Exam_CentorUpdate stored procedure.

    public class procExamCentorUpdateCommand : IRequest<IList<ExamCentor_CentorCode>>
   {
        public string Centor_Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public System.Guid Org_Code { get; set; }
    }
		
		
		 
}

