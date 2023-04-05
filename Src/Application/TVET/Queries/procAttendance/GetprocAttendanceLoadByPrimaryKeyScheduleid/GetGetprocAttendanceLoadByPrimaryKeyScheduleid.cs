using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procAttendance.GetprocAttendanceLoadAll;

namespace Application.TVET.Quiries.procAttendance.GetprocAttendanceLoadByPrimaryKeyScheduleid
{
    /// @author  Shimels Alem proc_AttendanceLoadByPrimaryKey_Schedule_id stored procedure.

    public class GetprocAttendanceLoadByPrimaryKeyScheduleid : IRequest<GetprocAttendanceLoadAllListVm>
    {
        public System.Guid Schedule_id { get; set; }
    }
}
