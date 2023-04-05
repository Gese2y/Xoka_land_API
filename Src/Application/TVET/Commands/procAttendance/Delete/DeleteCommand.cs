 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procAttendance.procAttendanceDelete.procAttendanceDeleteCommand
{

    // @author  Shimels Alem  proc_AttendanceDelete stored procedure.

    public class procAttendanceDeleteCommand : IRequest<IList<Attendance_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 