


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procAttendance.procAttendanceInsert.procAttendanceInsertCommand
{

    /// @author  Shimels Alem  proc_AttendanceInsert stored procedure.


    public class procAttendanceInsertCommand : IRequest<IList<Attendance_ID>>
    {
        public System.Guid ID { get; set; }
        public System.Guid? Schedule_id { get; set; }
        public System.DateTime? Date { get; set; }
        public bool? Is_Present { get; set; }
        public System.Guid? Student_ID { get; set; }

    }



}
 
 