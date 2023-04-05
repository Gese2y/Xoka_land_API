


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procEnrollment.procEnrollmentInsert.procEnrollmentInsertCommand
{

    /// @author  Shimels Alem  proc_EnrollmentInsert stored procedure.


    public class procEnrollmentInsertCommand : IRequest<IList<Enrollment_EID>>
    {
        public System.Guid EID { get; set; }
        public string Code { get; set; }
        public string Batch_ID { get; set; }
        public System.Guid? Student_ID { get; set; }
        public string Status { get; set; }
    }
		
		
		 
}
 
 